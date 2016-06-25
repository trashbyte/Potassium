using LibGC;
using LibGC.Gma;
using LibGC.Tpl;
using System;
using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Potassium {
    public partial class PaneMaterials : DockContent {
        MainWindow mainWindow;
        bool haveUnsavedTplChanges = false;

        public PaneMaterials(MainWindow win) {
            mainWindow = win;
            InitializeComponent();
            Name = TabText = Text = "Materials";
            SwitchLayout(false);
            SwitchLayout(true);
        }

        public void SwitchLayout(bool vertical) {
            if (vertical) {
                mainTable.RowCount = 3;
                mainTable.ColumnCount = 1;
                mainTable.RowStyles.Clear();
                mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 200));
                mainTable.SetCellPosition(treesTable, new TableLayoutPanelCellPosition(0, 0));
                mainTable.SetCellPosition(textureImage, new TableLayoutPanelCellPosition(0, 1));
                mainTable.SetCellPosition(dataTable, new TableLayoutPanelCellPosition(0, 2));
            }
            else {
                mainTable.RowCount = 1;
                mainTable.ColumnCount = 3;
                mainTable.ColumnStyles.Clear();
                mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350));
                mainTable.SetCellPosition(treesTable, new TableLayoutPanelCellPosition(0, 0));
                mainTable.SetCellPosition(textureImage, new TableLayoutPanelCellPosition(1, 0));
                mainTable.SetCellPosition(dataTable, new TableLayoutPanelCellPosition(2, 0));
            }
        }

        public TreeNode SelectedTextureNode { get { return treeTextures.SelectedNode; } }

        public void UpdateTrees() {
            treeTextures.SelectedNode = null; // Workaround for bug 5661 in Mono
            treeTextures.Nodes.Clear();

            if (mainWindow.Tpl != null) {
                for (int i = 0; i < mainWindow.Tpl.Count; i++) {
                    TreeNode textureItem = new TreeNode(string.Format("Texture {0}", i));
                    textureItem.ForeColor = (!mainWindow.Tpl[i].IsEmpty) ? Color.DarkGreen : Color.Red;
                    textureItem.Tag = new TextureReference(i, -1);
                    treeTextures.Nodes.Add(textureItem);

                    // Add subitems for the texture levels
                    if (!mainWindow.Tpl[i].IsEmpty) {
                        for (int j = 0; j < mainWindow.Tpl[i].LevelCount; j++) {
                            TreeNode levelItem = new TreeNode(string.Format("Level {0}", j));
                            levelItem.Tag = new TextureReference(i, j);
                            textureItem.Nodes.Add(levelItem);
                        }
                    }
                }
            }

            treeMaterials.SelectedNode = null; // Workaround for bug 5661 in Mono
            treeMaterials.Nodes.Clear();

            // Make sure that an item is selected in the model list and it corresponds to a non-null model
            int modelIdx = GetSelectedModelIdx();
            if (modelIdx == -1 || mainWindow.Gma[modelIdx] == null) {
                return;
            }

            // Populate the material list from the model
            Gcmf model = mainWindow.Gma[modelIdx].ModelObject;
            for (int i = 0; i < model.Materials.Count; i++) {
                TreeNode materialItem = new TreeNode(string.Format("Material {0}", i));
                materialItem.Tag = new ModelMaterialReference(modelIdx, i);
                treeMaterials.Nodes.Add(materialItem);
            }
        }

        private void treeTextures_AfterSelect(object sender, TreeViewEventArgs e) {
            // If no item is selected in the list, don't show the information panel
            if (SelectedTextureNode == null) {
                textureImage.Image = null;
                textureImage.Visible = false;
                return;
            }

            // Otherwise, extract the TextureReference structure to get the selected texture
            TextureReference textureData = (TextureReference)SelectedTextureNode.Tag;
            TplTexture tex = mainWindow.Tpl[textureData.TextureIdx];

            // If the texture is null, then show a "bogus" information panel
            if (tex.IsEmpty) {
                textureImage.Image = null;
                textureImage.Visible = false;

                textureTable.Visible = true;
                lblTextureDimensions.Text = "-";
                lblTextureFormat.Text = "-";
                //btnExportTextureLevel.Enabled = false;
                //btnImportTextureLevel.Enabled = false;

                return;
            }

            // If selecting the whole texture, then show data about the first level, otherwise from the selected model
            int effTextureLevel = (textureData.TextureLevel != -1) ? textureData.TextureLevel : 0;

            textureImage.Image = tex.DecodeLevelToBitmap(effTextureLevel);
            textureImage.Visible = true;

            textureTable.Visible = true;
            lblTextureDimensions.Text = string.Format("{0} x {1}",
                tex.WidthOfLevel(effTextureLevel), tex.HeightOfLevel(effTextureLevel));
            lblTextureFormat.Text = string.Format("{0} ({1})", tex.Format, EnumUtils.GetEnumDescription(tex.Format));
            //btnExportTextureLevel.Enabled = true;
            //btnImportTextureLevel.Enabled = true;
        }

        private int GetSelectedModelIdx() {
            // If no item is selected in the list, return -1
            if (mainWindow.paneModels.TreeModel.SelectedNode == null)
                return -1;

            // Otherwise, extract the model/mesh reference structure and get the model index from there
            ModelMeshReference itemData = (ModelMeshReference)mainWindow.paneModels.TreeModel.SelectedNode.Tag;
            return ((ModelMeshReference)mainWindow.paneModels.TreeModel.SelectedNode.Tag).ModelIdx;
        }

        public GcmfMaterial GetSelectedMaterial() {
            // If no item is selected in the list, return nullptr
            if (treeMaterials.SelectedNode == null)
                return null;

            // Otherwise, extract the ModelMaterialReference structure to get the selected model/mesh
            ModelMaterialReference itemData = (ModelMaterialReference)treeMaterials.SelectedNode.Tag;
            return mainWindow.Gma[itemData.ModelIdx].ModelObject.Materials[itemData.MaterialIdx];
        }

        private void treeMaterials_AfterSelect(object sender, TreeViewEventArgs e) {
            // If no model or material is selected, make the fields blank
            GcmfMaterial material = mainWindow.paneMaterials.GetSelectedMaterial();
            if (material == null) {
                materialTable.Visible = false;
                return;
            }

            materialTable.Visible = true;
            lblMaterialFlags.Text = string.Format("0x{0:X8}", material.Flags);
            lblMaterialTextureIndex.Text = string.Format("{0}", material.TextureIdx);
            lblMaterialUnk6.Text = string.Format("0x{0:X2}", material.Unk6);
            lblMaterialAnisotropyLevel.Text = string.Format("0x{0:X2}", material.AnisotropyLevel);
            lblMaterialUnkC.Text = string.Format("0x{0:X4}", material.UnkC);
            lblMaterialUnk10.Text = string.Format("0x{0:X8}", material.Unk10);

            if (material.TextureIdx < treeTextures.Nodes.Count) {
                treeTextures.SelectedNode = treeTextures.Nodes[material.TextureIdx];
            }
        }

        private void PaneMaterials_Resize(object sender, System.EventArgs e) {
            if (Width - 100 > Height) SwitchLayout(false);
            else SwitchLayout(true);
        }
    }
}
