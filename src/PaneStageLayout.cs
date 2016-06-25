using LibGC.StageLayout;
using OpenTK;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Potassium {
    public partial class PaneStageLayout : DockContent {
        MainWindow mainWindow;

        public PaneStageLayout(MainWindow win) {
            mainWindow = win;
            InitializeComponent();
            Name = TabText = Text = "Stage Layout";
            treeStageLayout_AfterSelect(null, null); // clear tables
        }

        public void UpdateStageLayoutTree() {
            treeStageLayout.BeginUpdate();

            // Collision

            var collisionNode = treeStageLayout.Nodes.Add("Collision");
            foreach (var c in mainWindow.StageLayout.Collision) {
                collisionNode.Nodes.Add(c.Position.ToString());
            }

            var goalsNode = treeStageLayout.Nodes.Add("Goals");
            foreach (var g in mainWindow.StageLayout.Goals) {
                goalsNode.Nodes.Add(g.Color.ToString() + ": " + g.Position.ToString());
            }

            var bananasNode = treeStageLayout.Nodes.Add("Bananas");
            foreach (var b in mainWindow.StageLayout.Bananas) {
                var node = new TreeNode(b.Position.ToString());
                node.Tag = b;
                bananasNode.Nodes.Add(node);
            }

            var bumpersNode = treeStageLayout.Nodes.Add("Bumpers");
            foreach (var b in mainWindow.StageLayout.Bumpers) {
                bumpersNode.Nodes.Add(b.Position.ToString());
            }

            var jamabarsNode = treeStageLayout.Nodes.Add("Jamabars");
            foreach (var j in mainWindow.StageLayout.Jamabars) {
                jamabarsNode.Nodes.Add(j.Position.ToString());
            }

            var unk40Node = treeStageLayout.Nodes.Add("Unk40");
            foreach (var u in mainWindow.StageLayout.Unk40) {
                unk40Node.Nodes.Add(u.Position.ToString());
            }

            var unk48Node = treeStageLayout.Nodes.Add("Unk48");
            foreach (var u in mainWindow.StageLayout.Unk48) {
                unk48Node.Nodes.Add(u.Position.ToString());
            }

            var unk50Node = treeStageLayout.Nodes.Add("Unk50");
            foreach (var u in mainWindow.StageLayout.Unk50) {
                unk50Node.Nodes.Add(u.Position.ToString());
            }

            var unk60Node = treeStageLayout.Nodes.Add("Unk60");
            foreach (var u in mainWindow.StageLayout.Unk60) {
                unk60Node.Nodes.Add(u.Position.ToString());
            }

            var unk70Node = treeStageLayout.Nodes.Add("Unk70");
            foreach (var u in mainWindow.StageLayout.Unk70) {
                unk70Node.Nodes.Add(u.Position.ToString());
            }

            var modelNamesNode = treeStageLayout.Nodes.Add("Model Names");
            foreach (var n in mainWindow.StageLayout.ModelNames) {
                modelNamesNode.Nodes.Add(n.Name);
            }

            treeStageLayout.EndUpdate();
        }

        private void treeStageLayout_AfterSelect(object sender, TreeViewEventArgs e) {
            tableBanana.Visible = false;

            mainTable.RowStyles.Clear();
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            if (treeStageLayout.SelectedNode != null) {
                if (treeStageLayout.SelectedNode.Tag != null) {
                    if (treeStageLayout.SelectedNode.Tag is StageLayoutBanana) {
                        mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 120));
                        mainTable.SetCellPosition(tableBanana, new TableLayoutPanelCellPosition(0, 1));
                        tableBanana.Visible = true;

                        StageLayoutBanana b = (StageLayoutBanana)treeStageLayout.SelectedNode.Tag;
                        textBoxBananaX.Text = b.Position.X.ToString();
                        textBoxBananaY.Text = b.Position.Y.ToString();
                        textBoxBananaZ.Text = b.Position.Z.ToString();
                        if (b.Type == StageLayoutBanana.BananaType.Single) {
                            comboBananaType.SelectedIndex = comboBananaType.Items.IndexOf("Single");
                        }
                        else {
                            comboBananaType.SelectedIndex = comboBananaType.Items.IndexOf("Bunch");
                        }
                    }
                }
            }
        }

        private void textBoxBananaPos_TextChanged(object sender, EventArgs e) {
            if (treeStageLayout.SelectedNode == null
                    || treeStageLayout.SelectedNode.Tag == null
                    || !(treeStageLayout.SelectedNode.Tag is StageLayoutBanana)) {
                return;
            }
            StageLayoutBanana b = (StageLayoutBanana)treeStageLayout.SelectedNode.Tag;
            float val = 0;
            Vector3 pos = b.Position;
            TextBox tb = (TextBox)sender;
            if (float.TryParse(tb.Text, out val)) {
                if (tb == textBoxBananaX) pos.X = val;
                if (tb == textBoxBananaY) pos.Y = val;
                if (tb == textBoxBananaZ) pos.Z = val;
            }
            b.Position = pos;
            treeStageLayout.SelectedNode.Tag = b;
            mainWindow.paneStageViewer.InvalidateGL();
        }

        private void comboBananaType_SelectedValueChanged(object sender, EventArgs e) {
            if (treeStageLayout.SelectedNode == null
                    || treeStageLayout.SelectedNode.Tag == null
                    || !(treeStageLayout.SelectedNode.Tag is StageLayoutBanana)) {
                return;
            }
            StageLayoutBanana b = (StageLayoutBanana)treeStageLayout.SelectedNode.Tag;
            b.Type = comboBananaType.SelectedText == "Single"
                ? StageLayoutBanana.BananaType.Single
                : StageLayoutBanana.BananaType.Bunch;
            treeStageLayout.SelectedNode.Tag = b;
        }
    }
}
