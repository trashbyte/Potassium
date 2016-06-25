using LibGC;
using LibGC.Gma;
using LibGC.ModelLoader;
using LibGC.ModelRenderer;
using LibGC.StageLayout;
using LibGC.Tpl;
using Ookii.Dialogs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Potassium {
    public partial class MainWindow : Form {
        public PaneStageViewer paneStageViewer { get; set; }
        public PaneModels paneModels { get; set; }
        public PaneMaterials paneMaterials { get; set; }
        public PaneStageLayout paneStageLayout { get; set; }
        public PaneProject paneProject { get; set; }

        public string ProjectPath { get; set; }
        Project project;

        private ExpanderForm expanderForm;
        private LoadSaveTestForm loadSaveTestForm;

        /// <summary>Path to the currently loaded .GMA file, or null if there isn't any.</summary>
        public string GmaPath { get; set; }
        /// <summary>Instance of the currently loaded .GMA file, or null if there isn't any.</summary>
        public Gma Gma { get; set; }
        /// <summary>true if the .GMA file has been modified and the changes have not yet been saved.</summary>
        public bool HaveUnsavedGmaChanges { get; set; }

        /// <summary>Path to the currently loaded .TPL file, or null if there isn't any.</summary>
        public string TplPath { get; set; }
        /// <summary>Instance of the currently loaded .TPL file, or null if there isn't any.</summary>
        public Tpl Tpl { get; set; }
        /// <summary>true if the .TPL file has been modified and the changes have not yet been saved.</summary>
        public bool HaveUnsavedTplChanges { get; set; }

        /// <summary>Path to the currently loaded stage layout file, or null if there isn't any.</summary>
        public string StageLayoutPath { get; set; }
        /// <summary>Instance of the currently loaded stage layout file, or null if there isn't any.</summary>
        public StageLayout StageLayout { get; set; }

        public MainWindow() {
            InitializeComponent();

            project = new Project();

            paneStageViewer = new PaneStageViewer(this);
            paneStageViewer.Show(mainDockPanel);

            // stack vertically
            //content3.DockHandler.FloatPane.DockTo(mainDockPanel.DockWindows[DockState.DockRight]);

            paneMaterials = new PaneMaterials(this);
            paneMaterials.Show(mainDockPanel, DockState.DockLeft);

            paneModels = new PaneModels(this);
            paneModels.Show(mainDockPanel, DockState.DockLeft);

            paneStageLayout = new PaneStageLayout(this);
            paneStageLayout.Show(mainDockPanel, DockState.DockLeft);

            paneProject = new PaneProject(this);
            paneProject.Show(mainDockPanel, DockState.DockRight);

            // Load empty files
            LoadGmaFile(null);
            LoadTplFile(null);
        }

        public void UpdateMenu() {
            exportGmaToolStripMenuItem.Enabled = (Gma != null);
            exportTplToolStripMenuItem.Enabled = (Tpl != null);
            exportObjMtlToolStripMenuItem.Enabled = (Gma != null);
        }

        /// <summary>
        /// Requests to the user to save unsaved changes in order to advance to the next option.
        /// </summary>
        /// <returns>true if the user has decided to advance (may have saved or not), false if the user wants to cancel the action.</returns>
        private bool CheckSaveUnsavedChanges() {
            if (!CheckSaveUnsavedGmaChanges())
                return false;
            if (!CheckSaveUnsavedTplChanges())
                return false;
            return true;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
            if (!CheckSaveUnsavedChanges()) {
                e.Cancel = true;
                return;
            }

            paneStageViewer.UnloadModel();
        }

        #region GMA

        private void importGmaToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!CheckSaveUnsavedChanges()) return;

            // Suggest the name associated with the loaded .TPL file if one is loaded
            if (TplPath != null && TplPath.EndsWith(".tpl"))
                ofdLoadGma.FileName = TplPath.Substring(0, TplPath.Length - 3) + "gma";

            // Ask the user for a GMA file
            if (ofdLoadGma.ShowDialog() != DialogResult.OK) return;

            LoadGmaFile(ofdLoadGma.FileName);
        }

        private void LoadGmaFile(string newGmaPath) {
            // Try to load the GMA file
            if (newGmaPath != null) {
                try {
                    using (Stream gmaStream = File.OpenRead(newGmaPath)) {
                        Gma = new Gma(gmaStream, GcGame.SuperMonkeyBall1);
                        GmaPath = newGmaPath;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Gma = null;
                    GmaPath = null;
                }
            }
            else {
                Gma = null;
                GmaPath = null;
            }
            HaveUnsavedGmaChanges = false;

            // Update model list
            paneModels.UpdateTree();

            // Update material tab
            paneMaterials.UpdateTrees();

            // Update model viewer
            paneStageViewer.InvalidateGL();
        }

        private void saveGMAToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveGmaFile();
        }

        private void saveGMAAsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (sfdSaveGma.ShowDialog() == DialogResult.OK) {
                GmaPath = sfdSaveGma.FileName;
                SaveGmaFile();
            }
        }

        private bool SaveGmaFile() {
            // If there isn't currently any path set (e.g. we've just imported a model),
            // we have to request one to the user
            if (GmaPath == null) {
                if (sfdSaveGma.ShowDialog() != DialogResult.OK)
                    return false;

                GmaPath = sfdSaveGma.FileName;
            }

            using (Stream gmaStream = File.OpenWrite(GmaPath)) {
                Gma.Save(gmaStream, GcGame.SuperMonkeyBall1);
            }

            HaveUnsavedGmaChanges = false;
            paneModels.UpdateModelButtons();
            return true;
        }

        private bool CheckSaveUnsavedGmaChanges() {
            if (HaveUnsavedGmaChanges) {
                switch (MessageBox.Show("There are unsaved .GMA file changes. Save them now?",
                    "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) {
                    case DialogResult.Yes:
                        return SaveGmaFile();

                    case DialogResult.No:
                        break;

                    case DialogResult.Cancel:
                        return false;

                    default:
                        throw new InvalidOperationException("Internal error.");

                }
            }

            return true;
        }

        #endregion

        #region TPL

        private void loadTPLToolStripMenuItem_Click(object sender, System.EventArgs e) {
            if (!CheckSaveUnsavedChanges())
                return;

            // Suggest the name associated with the loaded .GMA file if one is loaded
            if (GmaPath != null && GmaPath.EndsWith(".gma"))
                ofdLoadTpl.FileName = GmaPath.Substring(0, GmaPath.Length - 3) + "tpl";

            // Ask the user for a TPL file
            if (ofdLoadTpl.ShowDialog() != DialogResult.OK)
                return;

            LoadTplFile(ofdLoadTpl.FileName);
        }

        private void LoadTplFile(string newTplPath) {
            // Try to load the TPL file
            if (newTplPath != null) {
                try {
                    using (Stream tplStream = File.OpenRead(newTplPath)) {
                        Tpl = new Tpl(tplStream, GcGame.SuperMonkeyBall1);
                        TplPath = newTplPath;
                        paneStageViewer.SetDrawTextures(true);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tpl = null;
                    TplPath = null;
                }
            }
            else {
                Tpl = null;
                TplPath = null;
            }
            HaveUnsavedTplChanges = false;

            // Update texture list
            paneMaterials.UpdateTrees();
            //UpdateTextureButtons();

            // Update model viewer
            paneStageViewer.InvalidateGL();
        }

        private void saveTPLToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveTplFile();
        }

        private void saveTPLAsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (sfdSaveTpl.ShowDialog() != DialogResult.OK)
                return;

            TplPath = sfdSaveTpl.FileName;
            SaveTplFile();
        }

        private bool SaveTplFile() {
            // If there isn't currently any path set (e.g. we've just imported a model),
            // we have to request one to the user
            if (TplPath == null) {
                if (sfdSaveTpl.ShowDialog() != DialogResult.OK)
                    return false;

                TplPath = sfdSaveTpl.FileName;
            }

            using (Stream tplStream = File.OpenWrite(TplPath)) {
                Tpl.Save(tplStream, GcGame.SuperMonkeyBall1);
            }

            HaveUnsavedTplChanges = false;
            //UpdateTextureButtons();
            return true;
        }

        private bool CheckSaveUnsavedTplChanges() {
            if (HaveUnsavedTplChanges) {
                switch (MessageBox.Show("There are unsaved .TPL file changes. Save them now?",
                    "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) {
                    case DialogResult.Yes:
                        return SaveTplFile();

                    case DialogResult.No:
                        break;

                    case DialogResult.Cancel:
                        return false;

                    default:
                        throw new InvalidOperationException("Internal error.");
                }
            }

            return true;
        }

        #endregion

        #region Stage Layout

        private void loadStageLayoutToolStripMenuItem_Click(object sender, EventArgs e) {
            // Ask the user for a stage layout file
            if (ofdLoadStageLayout.ShowDialog() != DialogResult.OK)
                return;

            LoadStageLayoutFile(ofdLoadStageLayout.FileName);
        }

        private void LoadStageLayoutFile(string newStageLayoutPath) {
            // Try to load the stage layout file
            if (newStageLayoutPath != null) {
                try {
                    using (Stream stageLayoutStream = File.OpenRead(newStageLayoutPath)) {
                        StageLayout = new StageLayout(stageLayoutStream);
                        StageLayoutPath = newStageLayoutPath;
                        paneStageLayout.UpdateStageLayoutTree();
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    StageLayout = null;
                    StageLayoutPath = null;
                }
            }
            else {
                StageLayout = null;
                StageLayoutPath = null;
            }

            // Update model viewer
            paneStageViewer.InvalidateGL();
        }

        #endregion

        private void exportObjMtlToolStripMenuItem_Click(object sender, EventArgs e) {
            if (fbdModelExportPath.ShowDialog() == DialogResult.OK) {
                // Export OBJ and MTL files
                ObjMtlExporter exporter = new ObjMtlExporter(fbdModelExportPath.SelectedPath);

                // Export textures
                if (Tpl != null) {
                    for (int i = 0; i < Tpl.Count; i++) {
                        exporter.ExportTexture(i, Tpl[i]);
                    }
                }

                // Export model
                if (Gma != null) {
                    exporter.ExportModel(Gma);
                }
            }
        }

        private void importObjMtlToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!CheckSaveUnsavedChanges())
                return;

            if (ofdLoadObj.ShowDialog() != DialogResult.OK)
                return;

            List<string> modelWarningLog;
            ObjMtlModel model;
            try {
                model = new ObjMtlModel(ofdLoadObj.FileName, out modelWarningLog);
                if (modelWarningLog.Count != 0) {
                    ObjMtlWarningLogDialog warningDlg = new ObjMtlWarningLogDialog(modelWarningLog);
                    if (warningDlg.ShowDialog() != DialogResult.Yes)
                        return;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error loading the OBJ file. " + ex.Message, "Error loading the OBJ file.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dictionary<Bitmap, int> textureIndexMapping;
            Tpl = new Tpl(model, out textureIndexMapping);
            Gma = new Gma(model, textureIndexMapping);
            paneStageViewer.SetDrawTextures(true);

            // Set TPL / GMA as changed
            HaveUnsavedGmaChanges = true;
            HaveUnsavedTplChanges = true;

            // Update model list
            paneModels.UpdateTree();
            paneModels.UpdateModelButtons();

            // Update material tab
            paneMaterials.UpdateTrees();
            
            //UpdateTextureButtons();

            // Update stage viewer
            paneStageViewer.InvalidateGL();
        }

        private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e) {
            var ofd = new VistaFolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                var projectFilePath = Path.Combine(ofd.SelectedPath, "project.xml");
                if (File.Exists(projectFilePath)) {
                    ProjectPath = ofd.SelectedPath;
                    project = ProjectParser.Parse(projectFilePath);
                    paneProject.SetItems(project.Stages);
                }
                else MessageBox.Show("The provided folder doesn't appear to be a project folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadSaveTestToolStripMenuItem_Click(object sender, EventArgs e) {
            if (loadSaveTestForm == null) {
                loadSaveTestForm = new LoadSaveTestForm();
                loadSaveTestForm.FormClosed += (a, b) => loadSaveTestForm = null;
                loadSaveTestForm.Show();
            }
        }

        private void gxExpanderToolStripMenuItem_Click(object sender, EventArgs e) {
            if (expanderForm == null) {
                expanderForm = new ExpanderForm();
                expanderForm.FormClosed += (a, b) => expanderForm = null;
                expanderForm.Show();
            }
        }
    }
}
