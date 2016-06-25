using LibGC;
using LibGC.Gma;
using System;
using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Potassium {
    public partial class PaneModels : DockContent {

        public Potassium_WinFormsExt.TreeViewAutoPartialCheckBox TreeModel {
            get { return treeModel; }
        }

        private MainWindow mainWindow;

        public TreeNode SelectedNode {
            get { return treeModel.SelectedNode; }
        }

        public PaneModels(MainWindow win) {
            mainWindow = win;
            InitializeComponent();
            Name = TabText = Text = "Models";
        }

        public void UpdateTree() {
            UpdateModelTree();
            UpdateModelButtons();
        }

        private void UpdateModelTree() {
            //treeMaterials.SelectedNode = null; // Workaround for bug 5661 in Mono
            treeModel.Nodes.Clear();

            if (mainWindow.Gma != null) {
                for (int i = 0; i < mainWindow.Gma.Count; i++) {
                    // Add entry corresponding to the whole model
                    TreeNode modelItem = new TreeNode((mainWindow.Gma[i] != null) ? mainWindow.Gma[i].Name : "Unnamed");
                    modelItem.Tag = new ModelMeshReference(i, -1);
                    modelItem.ForeColor = (mainWindow.Gma[i] != null) ? Color.DarkGreen : Color.Red;
                    treeModel.Nodes.Add(modelItem);

                    // Add display list entries for the meshes within the model
                    if (mainWindow.Gma[i] != null) {
                        Gcmf model = mainWindow.Gma[i].ModelObject;
                        for (int j = 0; j < model.Meshes.Count; j++) {
                            int layerNo = (model.Meshes[j].Layer == GcmfMesh.MeshLayer.Layer1) ? 1 : 2;
                            TreeNode meshItem = new TreeNode(string.Format("[Layer {0}] Mesh {1}", layerNo, j));
                            meshItem.Tag = new ModelMeshReference(i, j);
                            modelItem.Nodes.Add(meshItem);
                        }
                    }

                    treeModel.SetCheckState(modelItem, CheckState.Checked);
                }
            }
        }

        public void UpdateModelButtons() {
            btnModelShowAll.Enabled = (mainWindow.Gma != null);
            btnModelShowLayer1.Enabled = (mainWindow.Gma != null);
            btnModelShowLayer2.Enabled = (mainWindow.Gma != null);
            btnModelHideAll.Enabled = (mainWindow.Gma != null);

            mainWindow.UpdateMenu();
        }

        private void SetVisibleModelMeshes(bool showLayer1, bool showLayer2) {
            foreach (TreeNode modelItem in treeModel.Nodes) {
                if (modelItem.Nodes.Count > 0) {
                    // Set model meshes check state
                    foreach (TreeNode meshItem in modelItem.Nodes) {
                        ModelMeshReference meshData = (ModelMeshReference)meshItem.Tag;
                        GcmfMesh mesh = mainWindow.Gma[meshData.ModelIdx].ModelObject.Meshes[meshData.MeshIdx];
                        if (mesh.Layer == GcmfMesh.MeshLayer.Layer1) {
                            treeModel.SetCheckState(meshItem, showLayer1 ? CheckState.Checked : CheckState.Unchecked);
                        }
                        else if (mesh.Layer == GcmfMesh.MeshLayer.Layer2) {
                            treeModel.SetCheckState(meshItem, showLayer2 ? CheckState.Checked : CheckState.Unchecked);
                        }
                    }
                }
                else {
                    // For the orphan nodes (models with no meshes, mostly GMA null entries),
                    // unselect them unless we're choosing to show both types of layers
                    treeModel.SetCheckState(modelItem, (showLayer1 && showLayer2) ? CheckState.Checked : CheckState.Unchecked);
                }
            }

            // The model will be updated due to the AfterCheckState event on treeModel
        }

        private void btnModelShowAll_Click(object sender, EventArgs e) {
            SetVisibleModelMeshes(true, true);
        }

        private void btnModelShowLayer1_Click(object sender, EventArgs e) {
            SetVisibleModelMeshes(true, false);
        }

        private void btnModelShowLayer2_Click(object sender, EventArgs e) {
            SetVisibleModelMeshes(false, true);
        }

        private void btnModelHideAll_Click(object sender, EventArgs e) {
            SetVisibleModelMeshes(false, false);
        }

        private void treeModel_AfterCheckState(object sender, TreeViewEventArgs e) {
            mainWindow.paneStageViewer.InvalidateGL();
        }

        private void treeModel_AfterSelect(object sender, TreeViewEventArgs e) {
            mainWindow.paneMaterials.UpdateTrees();

            // If no item is selected in the list, hide the display completely
            if (mainWindow.paneModels.SelectedNode == null) {
                modelTable.Visible = false;
                meshTable.Visible = false;
                return;
            }

            // Otherwise, extract the ModelTreeItem structure to get the selected model/mesh
            ModelMeshReference modelMeshReference = (ModelMeshReference)mainWindow.paneModels.SelectedNode.Tag;
            if (mainWindow.Gma[modelMeshReference.ModelIdx] == null) {
                modelTable.Visible = false;
                meshTable.Visible = false;
                return;
            }

            Gcmf model = mainWindow.Gma[modelMeshReference.ModelIdx].ModelObject;

            // Show information about the selected model / mesh
            if (modelMeshReference.MeshIdx == -1) {
                modelTable.Visible = true;
                meshTable.Visible = false;

                lblModelSectionFlags.Text = string.Format("0x{0:X8}", model.SectionFlags);
                lblModelCenter.Text = model.BoundingSphereCenter.ToString();
                lblModelRadius.Text = model.BoundingSphereRadius.ToString();
                lblModelTransformMatrixDefaultReferences.Text = string.Join(",",
                    Array.ConvertAll(model.TransformMatrixDefaultIdxs, b => string.Format("0x{0:X2}", b)));
                lblModelNumTransformMatrices.Text = model.TransformMatrices.Count.ToString();
            }
            else {
                GcmfMesh mesh = model.Meshes[modelMeshReference.MeshIdx];

                modelTable.Visible = true;
                meshTable.Visible = true;

                lblMeshRenderFlags.Text = string.Format("0x{0:X8} ({1})", (uint)mesh.RenderFlags, EnumUtils.GetEnumFlagsString(mesh.RenderFlags));
                lblMeshUnk4.Text = string.Format("0x{0:X8}", mesh.Unk4);
                lblMeshUnk8.Text = string.Format("0x{0:X8}", mesh.Unk8);
                lblMeshUnkC.Text = string.Format("0x{0:X8}", mesh.UnkC);
                lblMeshUnk10.Text = string.Format("0x{0:X4}", mesh.Unk10);
                lblMeshUnk14.Text = string.Format("0x{0:X4}", mesh.Unk14);
                lblMeshPrimaryMaterialIdx.Text = mesh.PrimaryMaterialIdx.ToString();
                lblMeshSecondaryMaterialIdx.Text = mesh.SecondaryMaterialIdx.ToString();
                lblMeshTertiaryMaterialIdx.Text = mesh.TertiaryMaterialIdx.ToString();
                lblMeshTransformMatrixSpecificReferences.Text = string.Join(",",
                    Array.ConvertAll(mesh.TransformMatrixSpecificIdxsObj1, b => string.Format("0x{0:X2}", b)));
                lblMeshCenter.Text = mesh.BoundingSphereCenter.ToString();
                lblMeshUnk3C.Text = mesh.Unk3C.ToString();
                lblMeshUnk40.Text = string.Format("0x{0:X8}", mesh.Unk40);
            }
        }
    }
}
