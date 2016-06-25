using LibGC;
using LibGC.Gma;
using LibGC.StageLayout;
using LibGC.Tpl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Potassium {
    public partial class PaneProject : DockContent {
        MainWindow mainWindow;
        BindingSource source;

        public PaneProject(MainWindow win) {
            mainWindow = win;
            InitializeComponent();
            Name = TabText = Text = "Project";
            
            source = new BindingSource();
            stageList.DataSource = source;
        }

        public void SetItems(List<ProjectStage> stages) {
            source.DataSource = stages;
            stageList.DataSource = source;
        }

        private void stageList_MouseDoubleClick(object sender, MouseEventArgs e) {
            ProjectStage stage = (ProjectStage)stageList.SelectedItem;

            // Try to load the GMA file
            try {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\projects\\test\\" + stage.Name + "\\stage.gma");
                using (Stream gmaStream = File.OpenRead(path)) {
                    mainWindow.Gma = new Gma(gmaStream, GcGame.SuperMonkeyBall1);
                    mainWindow.GmaPath = path;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mainWindow.Gma = null;
                mainWindow.GmaPath = null;
            }
            mainWindow.HaveUnsavedGmaChanges = false;

            // Try to load the TPL file
            try {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\projects\\test\\" + stage.Name + "\\stage.tpl");
                using (Stream tplStream = File.OpenRead(path)) {
                    mainWindow.Tpl = new Tpl(tplStream, GcGame.SuperMonkeyBall1);
                    mainWindow.TplPath = path;
                    mainWindow.paneStageViewer.SetDrawTextures(true);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mainWindow.Tpl = null;
                mainWindow.TplPath = null;
            }
            mainWindow.HaveUnsavedTplChanges = false;

            // Try to load the stage layout file
            try {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\projects\\test\\" + stage.Name + "\\stage.layout");
                using (Stream stageLayoutStream = File.OpenRead(path)) {
                    mainWindow.StageLayout = new StageLayout(stageLayoutStream);
                    mainWindow.StageLayoutPath = path;
                    mainWindow.paneStageLayout.UpdateStageLayoutTree();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mainWindow.StageLayout = null;
                mainWindow.StageLayoutPath = null;
            }

            // Update model viewer
            mainWindow.paneStageViewer.InvalidateGL();

            // Update model list
            mainWindow.paneModels.UpdateTree();

            // Update material tab
            mainWindow.paneMaterials.UpdateTrees();
            //UpdateTextureButtons();

            // Update model viewer
            mainWindow.paneStageViewer.InvalidateGL();
        }
    }
}
