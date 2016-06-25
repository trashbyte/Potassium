namespace Potassium {
    partial class PaneModels {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnModelShowAll = new System.Windows.Forms.Button();
            this.btnModelShowLayer1 = new System.Windows.Forms.Button();
            this.btnModelShowLayer2 = new System.Windows.Forms.Button();
            this.btnModelHideAll = new System.Windows.Forms.Button();
            this.treeModel = new Potassium_WinFormsExt.TreeViewAutoPartialCheckBox();
            this.modelTable = new System.Windows.Forms.TableLayoutPanel();
            this.modelData = new System.Windows.Forms.TableLayoutPanel();
            this.lblModelSectionFlagsText = new System.Windows.Forms.Label();
            this.lblModelCenterText = new System.Windows.Forms.Label();
            this.lblModelRadiusText = new System.Windows.Forms.Label();
            this.lblModelTransformMatrixDefaultReferencesText = new System.Windows.Forms.Label();
            this.lblModelNumTransformMatricesText = new System.Windows.Forms.Label();
            this.lblModelSectionFlags = new System.Windows.Forms.Label();
            this.lblModelCenter = new System.Windows.Forms.Label();
            this.lblModelRadius = new System.Windows.Forms.Label();
            this.lblModelTransformMatrixDefaultReferences = new System.Windows.Forms.Label();
            this.lblModelNumTransformMatrices = new System.Windows.Forms.Label();
            this.modelHeader = new System.Windows.Forms.Label();
            this.meshTable = new System.Windows.Forms.TableLayoutPanel();
            this.meshData = new System.Windows.Forms.TableLayoutPanel();
            this.lblMeshRenderFlagsText = new System.Windows.Forms.Label();
            this.lblMeshUnk4Text = new System.Windows.Forms.Label();
            this.lblMeshUnk8Text = new System.Windows.Forms.Label();
            this.lblMeshUnkCText = new System.Windows.Forms.Label();
            this.lblMeshUnk10Text = new System.Windows.Forms.Label();
            this.lblMeshUnk14Text = new System.Windows.Forms.Label();
            this.lblMeshPrimaryMaterialIdxText = new System.Windows.Forms.Label();
            this.lblMeshSecondaryMaterialIdxText = new System.Windows.Forms.Label();
            this.lblMeshTertiaryMaterialIdxText = new System.Windows.Forms.Label();
            this.lblMeshTransformMatrixSpecificReferencesText = new System.Windows.Forms.Label();
            this.lblMeshCenterText = new System.Windows.Forms.Label();
            this.lblMeshUnk3CText = new System.Windows.Forms.Label();
            this.lblMeshUnk40Text = new System.Windows.Forms.Label();
            this.lblMeshUnk40 = new System.Windows.Forms.Label();
            this.lblMeshUnk3C = new System.Windows.Forms.Label();
            this.lblMeshCenter = new System.Windows.Forms.Label();
            this.lblMeshTransformMatrixSpecificReferences = new System.Windows.Forms.Label();
            this.lblMeshTertiaryMaterialIdx = new System.Windows.Forms.Label();
            this.lblMeshSecondaryMaterialIdx = new System.Windows.Forms.Label();
            this.lblMeshPrimaryMaterialIdx = new System.Windows.Forms.Label();
            this.lblMeshUnk14 = new System.Windows.Forms.Label();
            this.lblMeshUnk10 = new System.Windows.Forms.Label();
            this.lblMeshUnkC = new System.Windows.Forms.Label();
            this.lblMeshUnk8 = new System.Windows.Forms.Label();
            this.lblMeshUnk4 = new System.Windows.Forms.Label();
            this.lblMeshRenderFlags = new System.Windows.Forms.Label();
            this.meshHeader = new System.Windows.Forms.Label();
            this.tableLayout.SuspendLayout();
            this.modelTable.SuspendLayout();
            this.modelData.SuspendLayout();
            this.meshTable.SuspendLayout();
            this.meshData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this.meshTable, 0, 2);
            this.tableLayout.Controls.Add(this.modelTable, 0, 1);
            this.tableLayout.Controls.Add(this.btnModelShowAll, 0, 3);
            this.tableLayout.Controls.Add(this.btnModelShowLayer1, 0, 4);
            this.tableLayout.Controls.Add(this.btnModelShowLayer2, 0, 5);
            this.tableLayout.Controls.Add(this.btnModelHideAll, 0, 6);
            this.tableLayout.Controls.Add(this.treeModel, 0, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 7;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayout.Size = new System.Drawing.Size(379, 579);
            this.tableLayout.TabIndex = 0;
            // 
            // btnModelShowAll
            // 
            this.btnModelShowAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModelShowAll.Location = new System.Drawing.Point(3, 462);
            this.btnModelShowAll.Name = "btnModelShowAll";
            this.btnModelShowAll.Size = new System.Drawing.Size(373, 24);
            this.btnModelShowAll.TabIndex = 0;
            this.btnModelShowAll.Text = "Show All";
            this.btnModelShowAll.UseVisualStyleBackColor = true;
            this.btnModelShowAll.Click += new System.EventHandler(this.btnModelShowAll_Click);
            // 
            // btnModelShowLayer1
            // 
            this.btnModelShowLayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModelShowLayer1.Location = new System.Drawing.Point(3, 492);
            this.btnModelShowLayer1.Name = "btnModelShowLayer1";
            this.btnModelShowLayer1.Size = new System.Drawing.Size(373, 24);
            this.btnModelShowLayer1.TabIndex = 1;
            this.btnModelShowLayer1.Text = "Show Layer 1 (Opaque) Only";
            this.btnModelShowLayer1.UseVisualStyleBackColor = true;
            this.btnModelShowLayer1.Click += new System.EventHandler(this.btnModelShowLayer1_Click);
            // 
            // btnModelShowLayer2
            // 
            this.btnModelShowLayer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModelShowLayer2.Location = new System.Drawing.Point(3, 522);
            this.btnModelShowLayer2.Name = "btnModelShowLayer2";
            this.btnModelShowLayer2.Size = new System.Drawing.Size(373, 24);
            this.btnModelShowLayer2.TabIndex = 2;
            this.btnModelShowLayer2.Text = "Show Layer 2 (Transparent) Only";
            this.btnModelShowLayer2.UseVisualStyleBackColor = true;
            this.btnModelShowLayer2.Click += new System.EventHandler(this.btnModelShowLayer2_Click);
            // 
            // btnModelHideAll
            // 
            this.btnModelHideAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModelHideAll.Location = new System.Drawing.Point(3, 552);
            this.btnModelHideAll.Name = "btnModelHideAll";
            this.btnModelHideAll.Size = new System.Drawing.Size(373, 24);
            this.btnModelHideAll.TabIndex = 3;
            this.btnModelHideAll.Text = "Hide All";
            this.btnModelHideAll.UseVisualStyleBackColor = true;
            this.btnModelHideAll.Click += new System.EventHandler(this.btnModelHideAll_Click);
            // 
            // treeModel
            // 
            this.treeModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeModel.Location = new System.Drawing.Point(3, 3);
            this.treeModel.Name = "treeModel";
            this.treeModel.Size = new System.Drawing.Size(373, 58);
            this.treeModel.TabIndex = 4;
            this.treeModel.AfterCheckState += new System.Windows.Forms.TreeViewEventHandler(this.treeModel_AfterCheckState);
            this.treeModel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeModel_AfterSelect);
            // 
            // modelTable
            // 
            this.modelTable.ColumnCount = 1;
            this.modelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.modelTable.Controls.Add(this.modelData, 0, 1);
            this.modelTable.Controls.Add(this.modelHeader, 0, 0);
            this.modelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelTable.Location = new System.Drawing.Point(0, 64);
            this.modelTable.Margin = new System.Windows.Forms.Padding(0);
            this.modelTable.Name = "modelTable";
            this.modelTable.RowCount = 2;
            this.modelTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.modelTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.modelTable.Size = new System.Drawing.Size(379, 120);
            this.modelTable.TabIndex = 5;
            this.modelTable.Visible = false;
            // 
            // modelData
            // 
            this.modelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelData.ColumnCount = 2;
            this.modelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.modelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.modelData.Controls.Add(this.lblModelSectionFlagsText, 0, 0);
            this.modelData.Controls.Add(this.lblModelCenterText, 0, 1);
            this.modelData.Controls.Add(this.lblModelRadiusText, 0, 2);
            this.modelData.Controls.Add(this.lblModelTransformMatrixDefaultReferencesText, 0, 3);
            this.modelData.Controls.Add(this.lblModelNumTransformMatricesText, 0, 4);
            this.modelData.Controls.Add(this.lblModelSectionFlags, 1, 0);
            this.modelData.Controls.Add(this.lblModelCenter, 1, 1);
            this.modelData.Controls.Add(this.lblModelRadius, 1, 2);
            this.modelData.Controls.Add(this.lblModelTransformMatrixDefaultReferences, 1, 3);
            this.modelData.Controls.Add(this.lblModelNumTransformMatrices, 1, 4);
            this.modelData.Location = new System.Drawing.Point(3, 20);
            this.modelData.Name = "modelData";
            this.modelData.RowCount = 5;
            this.modelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.modelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.modelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.modelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.modelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.modelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.modelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.modelData.Size = new System.Drawing.Size(373, 100);
            this.modelData.TabIndex = 1;
            // 
            // lblModelSectionFlagsText
            // 
            this.lblModelSectionFlagsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelSectionFlagsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelSectionFlagsText.Location = new System.Drawing.Point(3, 0);
            this.lblModelSectionFlagsText.Name = "lblModelSectionFlagsText";
            this.lblModelSectionFlagsText.Size = new System.Drawing.Size(180, 20);
            this.lblModelSectionFlagsText.TabIndex = 0;
            this.lblModelSectionFlagsText.Text = "Section Flags:";
            this.lblModelSectionFlagsText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblModelCenterText
            // 
            this.lblModelCenterText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelCenterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelCenterText.Location = new System.Drawing.Point(3, 20);
            this.lblModelCenterText.Name = "lblModelCenterText";
            this.lblModelCenterText.Size = new System.Drawing.Size(180, 20);
            this.lblModelCenterText.TabIndex = 1;
            this.lblModelCenterText.Text = "Center (X,Y,Z):";
            this.lblModelCenterText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblModelRadiusText
            // 
            this.lblModelRadiusText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelRadiusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelRadiusText.Location = new System.Drawing.Point(3, 40);
            this.lblModelRadiusText.Name = "lblModelRadiusText";
            this.lblModelRadiusText.Size = new System.Drawing.Size(180, 20);
            this.lblModelRadiusText.TabIndex = 2;
            this.lblModelRadiusText.Text = "Radius:";
            this.lblModelRadiusText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblModelTransformMatrixDefaultReferencesText
            // 
            this.lblModelTransformMatrixDefaultReferencesText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelTransformMatrixDefaultReferencesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelTransformMatrixDefaultReferencesText.Location = new System.Drawing.Point(3, 60);
            this.lblModelTransformMatrixDefaultReferencesText.Name = "lblModelTransformMatrixDefaultReferencesText";
            this.lblModelTransformMatrixDefaultReferencesText.Size = new System.Drawing.Size(180, 20);
            this.lblModelTransformMatrixDefaultReferencesText.TabIndex = 3;
            this.lblModelTransformMatrixDefaultReferencesText.Text = "Transform Matrix Default Idxs:";
            this.lblModelTransformMatrixDefaultReferencesText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblModelNumTransformMatricesText
            // 
            this.lblModelNumTransformMatricesText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelNumTransformMatricesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelNumTransformMatricesText.Location = new System.Drawing.Point(3, 80);
            this.lblModelNumTransformMatricesText.Name = "lblModelNumTransformMatricesText";
            this.lblModelNumTransformMatricesText.Size = new System.Drawing.Size(180, 20);
            this.lblModelNumTransformMatricesText.TabIndex = 4;
            this.lblModelNumTransformMatricesText.Text = "Num. Transform Matrix:";
            this.lblModelNumTransformMatricesText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblModelSectionFlags
            // 
            this.lblModelSectionFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelSectionFlags.Location = new System.Drawing.Point(189, 0);
            this.lblModelSectionFlags.Name = "lblModelSectionFlags";
            this.lblModelSectionFlags.Size = new System.Drawing.Size(181, 20);
            this.lblModelSectionFlags.TabIndex = 5;
            this.lblModelSectionFlags.Text = "-";
            // 
            // lblModelCenter
            // 
            this.lblModelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelCenter.Location = new System.Drawing.Point(189, 20);
            this.lblModelCenter.Name = "lblModelCenter";
            this.lblModelCenter.Size = new System.Drawing.Size(181, 20);
            this.lblModelCenter.TabIndex = 6;
            this.lblModelCenter.Text = "-";
            // 
            // lblModelRadius
            // 
            this.lblModelRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelRadius.Location = new System.Drawing.Point(189, 40);
            this.lblModelRadius.Name = "lblModelRadius";
            this.lblModelRadius.Size = new System.Drawing.Size(181, 20);
            this.lblModelRadius.TabIndex = 7;
            this.lblModelRadius.Text = "-";
            // 
            // lblModelTransformMatrixDefaultReferences
            // 
            this.lblModelTransformMatrixDefaultReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelTransformMatrixDefaultReferences.Location = new System.Drawing.Point(189, 60);
            this.lblModelTransformMatrixDefaultReferences.Name = "lblModelTransformMatrixDefaultReferences";
            this.lblModelTransformMatrixDefaultReferences.Size = new System.Drawing.Size(181, 20);
            this.lblModelTransformMatrixDefaultReferences.TabIndex = 8;
            this.lblModelTransformMatrixDefaultReferences.Text = "-";
            // 
            // lblModelNumTransformMatrices
            // 
            this.lblModelNumTransformMatrices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelNumTransformMatrices.Location = new System.Drawing.Point(189, 80);
            this.lblModelNumTransformMatrices.Name = "lblModelNumTransformMatrices";
            this.lblModelNumTransformMatrices.Size = new System.Drawing.Size(181, 20);
            this.lblModelNumTransformMatrices.TabIndex = 9;
            this.lblModelNumTransformMatrices.Text = "-";
            // 
            // modelHeader
            // 
            this.modelHeader.AutoSize = true;
            this.modelHeader.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.modelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelHeader.Location = new System.Drawing.Point(3, 0);
            this.modelHeader.Name = "modelHeader";
            this.modelHeader.Padding = new System.Windows.Forms.Padding(2);
            this.modelHeader.Size = new System.Drawing.Size(373, 17);
            this.modelHeader.TabIndex = 0;
            this.modelHeader.Text = "Model";
            // 
            // meshTable
            // 
            this.meshTable.ColumnCount = 1;
            this.meshTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.meshTable.Controls.Add(this.meshData, 0, 1);
            this.meshTable.Controls.Add(this.meshHeader, 0, 0);
            this.meshTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meshTable.Location = new System.Drawing.Point(0, 184);
            this.meshTable.Margin = new System.Windows.Forms.Padding(0);
            this.meshTable.Name = "meshTable";
            this.meshTable.RowCount = 2;
            this.meshTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.meshTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.meshTable.Size = new System.Drawing.Size(379, 275);
            this.meshTable.TabIndex = 6;
            this.meshTable.Visible = false;
            // 
            // meshData
            // 
            this.meshData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.meshData.ColumnCount = 2;
            this.meshData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.meshData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.meshData.Controls.Add(this.lblMeshRenderFlagsText, 0, 0);
            this.meshData.Controls.Add(this.lblMeshUnk4Text, 0, 1);
            this.meshData.Controls.Add(this.lblMeshUnk8Text, 0, 2);
            this.meshData.Controls.Add(this.lblMeshUnkCText, 0, 3);
            this.meshData.Controls.Add(this.lblMeshUnk10Text, 0, 4);
            this.meshData.Controls.Add(this.lblMeshUnk14Text, 0, 5);
            this.meshData.Controls.Add(this.lblMeshPrimaryMaterialIdxText, 0, 6);
            this.meshData.Controls.Add(this.lblMeshSecondaryMaterialIdxText, 0, 7);
            this.meshData.Controls.Add(this.lblMeshTertiaryMaterialIdxText, 0, 8);
            this.meshData.Controls.Add(this.lblMeshTransformMatrixSpecificReferencesText, 0, 9);
            this.meshData.Controls.Add(this.lblMeshCenterText, 0, 10);
            this.meshData.Controls.Add(this.lblMeshUnk3CText, 0, 11);
            this.meshData.Controls.Add(this.lblMeshUnk40Text, 0, 12);
            this.meshData.Controls.Add(this.lblMeshUnk40, 1, 12);
            this.meshData.Controls.Add(this.lblMeshUnk3C, 1, 11);
            this.meshData.Controls.Add(this.lblMeshCenter, 1, 10);
            this.meshData.Controls.Add(this.lblMeshTransformMatrixSpecificReferences, 1, 9);
            this.meshData.Controls.Add(this.lblMeshTertiaryMaterialIdx, 1, 8);
            this.meshData.Controls.Add(this.lblMeshSecondaryMaterialIdx, 1, 7);
            this.meshData.Controls.Add(this.lblMeshPrimaryMaterialIdx, 1, 6);
            this.meshData.Controls.Add(this.lblMeshUnk14, 1, 5);
            this.meshData.Controls.Add(this.lblMeshUnk10, 1, 4);
            this.meshData.Controls.Add(this.lblMeshUnkC, 1, 3);
            this.meshData.Controls.Add(this.lblMeshUnk8, 1, 2);
            this.meshData.Controls.Add(this.lblMeshUnk4, 1, 1);
            this.meshData.Controls.Add(this.lblMeshRenderFlags, 1, 0);
            this.meshData.Location = new System.Drawing.Point(3, 20);
            this.meshData.Name = "meshData";
            this.meshData.RowCount = 13;
            this.meshData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.meshData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.meshData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.meshData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.meshData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.meshData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.meshData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.meshData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.meshData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.meshData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.meshData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.meshData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.meshData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.meshData.Size = new System.Drawing.Size(373, 268);
            this.meshData.TabIndex = 2;
            // 
            // lblMeshRenderFlagsText
            // 
            this.lblMeshRenderFlagsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshRenderFlagsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshRenderFlagsText.Location = new System.Drawing.Point(3, 0);
            this.lblMeshRenderFlagsText.Name = "lblMeshRenderFlagsText";
            this.lblMeshRenderFlagsText.Size = new System.Drawing.Size(180, 20);
            this.lblMeshRenderFlagsText.TabIndex = 0;
            this.lblMeshRenderFlagsText.Text = "Render Flags:";
            this.lblMeshRenderFlagsText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshUnk4Text
            // 
            this.lblMeshUnk4Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk4Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshUnk4Text.Location = new System.Drawing.Point(3, 20);
            this.lblMeshUnk4Text.Name = "lblMeshUnk4Text";
            this.lblMeshUnk4Text.Size = new System.Drawing.Size(180, 20);
            this.lblMeshUnk4Text.TabIndex = 1;
            this.lblMeshUnk4Text.Text = "Unk4:";
            this.lblMeshUnk4Text.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshUnk8Text
            // 
            this.lblMeshUnk8Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk8Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshUnk8Text.Location = new System.Drawing.Point(3, 40);
            this.lblMeshUnk8Text.Name = "lblMeshUnk8Text";
            this.lblMeshUnk8Text.Size = new System.Drawing.Size(180, 20);
            this.lblMeshUnk8Text.TabIndex = 2;
            this.lblMeshUnk8Text.Text = "Unk8:";
            this.lblMeshUnk8Text.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshUnkCText
            // 
            this.lblMeshUnkCText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnkCText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshUnkCText.Location = new System.Drawing.Point(3, 60);
            this.lblMeshUnkCText.Name = "lblMeshUnkCText";
            this.lblMeshUnkCText.Size = new System.Drawing.Size(180, 20);
            this.lblMeshUnkCText.TabIndex = 3;
            this.lblMeshUnkCText.Text = "UnkC:";
            this.lblMeshUnkCText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshUnk10Text
            // 
            this.lblMeshUnk10Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk10Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshUnk10Text.Location = new System.Drawing.Point(3, 80);
            this.lblMeshUnk10Text.Name = "lblMeshUnk10Text";
            this.lblMeshUnk10Text.Size = new System.Drawing.Size(180, 20);
            this.lblMeshUnk10Text.TabIndex = 4;
            this.lblMeshUnk10Text.Text = "Unk10:";
            this.lblMeshUnk10Text.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshUnk14Text
            // 
            this.lblMeshUnk14Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk14Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshUnk14Text.Location = new System.Drawing.Point(3, 100);
            this.lblMeshUnk14Text.Name = "lblMeshUnk14Text";
            this.lblMeshUnk14Text.Size = new System.Drawing.Size(180, 20);
            this.lblMeshUnk14Text.TabIndex = 5;
            this.lblMeshUnk14Text.Text = "Unk14:";
            this.lblMeshUnk14Text.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshPrimaryMaterialIdxText
            // 
            this.lblMeshPrimaryMaterialIdxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshPrimaryMaterialIdxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshPrimaryMaterialIdxText.Location = new System.Drawing.Point(3, 120);
            this.lblMeshPrimaryMaterialIdxText.Name = "lblMeshPrimaryMaterialIdxText";
            this.lblMeshPrimaryMaterialIdxText.Size = new System.Drawing.Size(180, 20);
            this.lblMeshPrimaryMaterialIdxText.TabIndex = 6;
            this.lblMeshPrimaryMaterialIdxText.Text = "Primary Material Idx:";
            this.lblMeshPrimaryMaterialIdxText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshSecondaryMaterialIdxText
            // 
            this.lblMeshSecondaryMaterialIdxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshSecondaryMaterialIdxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshSecondaryMaterialIdxText.Location = new System.Drawing.Point(3, 140);
            this.lblMeshSecondaryMaterialIdxText.Name = "lblMeshSecondaryMaterialIdxText";
            this.lblMeshSecondaryMaterialIdxText.Size = new System.Drawing.Size(180, 20);
            this.lblMeshSecondaryMaterialIdxText.TabIndex = 7;
            this.lblMeshSecondaryMaterialIdxText.Text = "Secondary Material Idx:";
            this.lblMeshSecondaryMaterialIdxText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshTertiaryMaterialIdxText
            // 
            this.lblMeshTertiaryMaterialIdxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshTertiaryMaterialIdxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshTertiaryMaterialIdxText.Location = new System.Drawing.Point(3, 160);
            this.lblMeshTertiaryMaterialIdxText.Name = "lblMeshTertiaryMaterialIdxText";
            this.lblMeshTertiaryMaterialIdxText.Size = new System.Drawing.Size(180, 20);
            this.lblMeshTertiaryMaterialIdxText.TabIndex = 8;
            this.lblMeshTertiaryMaterialIdxText.Text = "Tertiary Material Idx:";
            this.lblMeshTertiaryMaterialIdxText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshTransformMatrixSpecificReferencesText
            // 
            this.lblMeshTransformMatrixSpecificReferencesText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshTransformMatrixSpecificReferencesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshTransformMatrixSpecificReferencesText.Location = new System.Drawing.Point(3, 180);
            this.lblMeshTransformMatrixSpecificReferencesText.Name = "lblMeshTransformMatrixSpecificReferencesText";
            this.lblMeshTransformMatrixSpecificReferencesText.Size = new System.Drawing.Size(180, 20);
            this.lblMeshTransformMatrixSpecificReferencesText.TabIndex = 10;
            this.lblMeshTransformMatrixSpecificReferencesText.Text = "Transform Matrix Specific Idxs:";
            this.lblMeshTransformMatrixSpecificReferencesText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshCenterText
            // 
            this.lblMeshCenterText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshCenterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshCenterText.Location = new System.Drawing.Point(3, 200);
            this.lblMeshCenterText.Name = "lblMeshCenterText";
            this.lblMeshCenterText.Size = new System.Drawing.Size(180, 20);
            this.lblMeshCenterText.TabIndex = 11;
            this.lblMeshCenterText.Text = "Center (X,Y,Z):";
            this.lblMeshCenterText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshUnk3CText
            // 
            this.lblMeshUnk3CText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk3CText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshUnk3CText.Location = new System.Drawing.Point(3, 220);
            this.lblMeshUnk3CText.Name = "lblMeshUnk3CText";
            this.lblMeshUnk3CText.Size = new System.Drawing.Size(180, 20);
            this.lblMeshUnk3CText.TabIndex = 12;
            this.lblMeshUnk3CText.Text = "Unk3C:";
            this.lblMeshUnk3CText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshUnk40Text
            // 
            this.lblMeshUnk40Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk40Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshUnk40Text.Location = new System.Drawing.Point(3, 240);
            this.lblMeshUnk40Text.Name = "lblMeshUnk40Text";
            this.lblMeshUnk40Text.Size = new System.Drawing.Size(180, 28);
            this.lblMeshUnk40Text.TabIndex = 13;
            this.lblMeshUnk40Text.Text = "Unk40:";
            this.lblMeshUnk40Text.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshUnk40
            // 
            this.lblMeshUnk40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk40.Location = new System.Drawing.Point(189, 240);
            this.lblMeshUnk40.Name = "lblMeshUnk40";
            this.lblMeshUnk40.Size = new System.Drawing.Size(181, 28);
            this.lblMeshUnk40.TabIndex = 14;
            this.lblMeshUnk40.Text = "-";
            // 
            // lblMeshUnk3C
            // 
            this.lblMeshUnk3C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk3C.Location = new System.Drawing.Point(189, 220);
            this.lblMeshUnk3C.Name = "lblMeshUnk3C";
            this.lblMeshUnk3C.Size = new System.Drawing.Size(181, 20);
            this.lblMeshUnk3C.TabIndex = 15;
            this.lblMeshUnk3C.Text = "-";
            // 
            // lblMeshCenter
            // 
            this.lblMeshCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshCenter.Location = new System.Drawing.Point(189, 200);
            this.lblMeshCenter.Name = "lblMeshCenter";
            this.lblMeshCenter.Size = new System.Drawing.Size(181, 20);
            this.lblMeshCenter.TabIndex = 16;
            this.lblMeshCenter.Text = "-";
            // 
            // lblMeshTransformMatrixSpecificReferences
            // 
            this.lblMeshTransformMatrixSpecificReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshTransformMatrixSpecificReferences.Location = new System.Drawing.Point(189, 180);
            this.lblMeshTransformMatrixSpecificReferences.Name = "lblMeshTransformMatrixSpecificReferences";
            this.lblMeshTransformMatrixSpecificReferences.Size = new System.Drawing.Size(181, 20);
            this.lblMeshTransformMatrixSpecificReferences.TabIndex = 17;
            this.lblMeshTransformMatrixSpecificReferences.Text = "-";
            // 
            // lblMeshTertiaryMaterialIdx
            // 
            this.lblMeshTertiaryMaterialIdx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshTertiaryMaterialIdx.Location = new System.Drawing.Point(189, 160);
            this.lblMeshTertiaryMaterialIdx.Name = "lblMeshTertiaryMaterialIdx";
            this.lblMeshTertiaryMaterialIdx.Size = new System.Drawing.Size(181, 20);
            this.lblMeshTertiaryMaterialIdx.TabIndex = 19;
            this.lblMeshTertiaryMaterialIdx.Text = "-";
            // 
            // lblMeshSecondaryMaterialIdx
            // 
            this.lblMeshSecondaryMaterialIdx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshSecondaryMaterialIdx.Location = new System.Drawing.Point(189, 140);
            this.lblMeshSecondaryMaterialIdx.Name = "lblMeshSecondaryMaterialIdx";
            this.lblMeshSecondaryMaterialIdx.Size = new System.Drawing.Size(181, 20);
            this.lblMeshSecondaryMaterialIdx.TabIndex = 20;
            this.lblMeshSecondaryMaterialIdx.Text = "-";
            // 
            // lblMeshPrimaryMaterialIdx
            // 
            this.lblMeshPrimaryMaterialIdx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshPrimaryMaterialIdx.Location = new System.Drawing.Point(189, 120);
            this.lblMeshPrimaryMaterialIdx.Name = "lblMeshPrimaryMaterialIdx";
            this.lblMeshPrimaryMaterialIdx.Size = new System.Drawing.Size(181, 20);
            this.lblMeshPrimaryMaterialIdx.TabIndex = 21;
            this.lblMeshPrimaryMaterialIdx.Text = "-";
            // 
            // lblMeshUnk14
            // 
            this.lblMeshUnk14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk14.Location = new System.Drawing.Point(189, 100);
            this.lblMeshUnk14.Name = "lblMeshUnk14";
            this.lblMeshUnk14.Size = new System.Drawing.Size(181, 20);
            this.lblMeshUnk14.TabIndex = 22;
            this.lblMeshUnk14.Text = "-";
            // 
            // lblMeshUnk10
            // 
            this.lblMeshUnk10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk10.Location = new System.Drawing.Point(189, 80);
            this.lblMeshUnk10.Name = "lblMeshUnk10";
            this.lblMeshUnk10.Size = new System.Drawing.Size(181, 20);
            this.lblMeshUnk10.TabIndex = 23;
            this.lblMeshUnk10.Text = "-";
            // 
            // lblMeshUnkC
            // 
            this.lblMeshUnkC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnkC.Location = new System.Drawing.Point(189, 60);
            this.lblMeshUnkC.Name = "lblMeshUnkC";
            this.lblMeshUnkC.Size = new System.Drawing.Size(181, 20);
            this.lblMeshUnkC.TabIndex = 24;
            this.lblMeshUnkC.Text = "-";
            // 
            // lblMeshUnk8
            // 
            this.lblMeshUnk8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk8.Location = new System.Drawing.Point(189, 40);
            this.lblMeshUnk8.Name = "lblMeshUnk8";
            this.lblMeshUnk8.Size = new System.Drawing.Size(181, 20);
            this.lblMeshUnk8.TabIndex = 25;
            this.lblMeshUnk8.Text = "-";
            // 
            // lblMeshUnk4
            // 
            this.lblMeshUnk4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk4.Location = new System.Drawing.Point(189, 20);
            this.lblMeshUnk4.Name = "lblMeshUnk4";
            this.lblMeshUnk4.Size = new System.Drawing.Size(181, 20);
            this.lblMeshUnk4.TabIndex = 26;
            this.lblMeshUnk4.Text = "-";
            // 
            // lblMeshRenderFlags
            // 
            this.lblMeshRenderFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshRenderFlags.Location = new System.Drawing.Point(189, 0);
            this.lblMeshRenderFlags.Name = "lblMeshRenderFlags";
            this.lblMeshRenderFlags.Size = new System.Drawing.Size(181, 20);
            this.lblMeshRenderFlags.TabIndex = 27;
            this.lblMeshRenderFlags.Text = "-";
            // 
            // meshHeader
            // 
            this.meshHeader.AutoSize = true;
            this.meshHeader.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.meshHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meshHeader.Location = new System.Drawing.Point(3, 0);
            this.meshHeader.Name = "meshHeader";
            this.meshHeader.Padding = new System.Windows.Forms.Padding(2);
            this.meshHeader.Size = new System.Drawing.Size(373, 17);
            this.meshHeader.TabIndex = 1;
            this.meshHeader.Text = "Mesh";
            // 
            // PaneModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 579);
            this.Controls.Add(this.tableLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PaneModels";
            this.Text = "Pane_ModelList";
            this.tableLayout.ResumeLayout(false);
            this.modelTable.ResumeLayout(false);
            this.modelTable.PerformLayout();
            this.modelData.ResumeLayout(false);
            this.meshTable.ResumeLayout(false);
            this.meshTable.PerformLayout();
            this.meshData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Button btnModelShowAll;
        private System.Windows.Forms.Button btnModelShowLayer1;
        private System.Windows.Forms.Button btnModelShowLayer2;
        private System.Windows.Forms.Button btnModelHideAll;
        private Potassium_WinFormsExt.TreeViewAutoPartialCheckBox treeModel;
        private System.Windows.Forms.TableLayoutPanel modelTable;
        private System.Windows.Forms.TableLayoutPanel modelData;
        private System.Windows.Forms.Label lblModelSectionFlagsText;
        private System.Windows.Forms.Label lblModelCenterText;
        private System.Windows.Forms.Label lblModelRadiusText;
        private System.Windows.Forms.Label lblModelTransformMatrixDefaultReferencesText;
        private System.Windows.Forms.Label lblModelNumTransformMatricesText;
        private System.Windows.Forms.Label lblModelSectionFlags;
        private System.Windows.Forms.Label lblModelCenter;
        private System.Windows.Forms.Label lblModelRadius;
        private System.Windows.Forms.Label lblModelTransformMatrixDefaultReferences;
        private System.Windows.Forms.Label lblModelNumTransformMatrices;
        private System.Windows.Forms.Label modelHeader;
        private System.Windows.Forms.TableLayoutPanel meshTable;
        private System.Windows.Forms.TableLayoutPanel meshData;
        private System.Windows.Forms.Label lblMeshRenderFlagsText;
        private System.Windows.Forms.Label lblMeshUnk4Text;
        private System.Windows.Forms.Label lblMeshUnk8Text;
        private System.Windows.Forms.Label lblMeshUnkCText;
        private System.Windows.Forms.Label lblMeshUnk10Text;
        private System.Windows.Forms.Label lblMeshUnk14Text;
        private System.Windows.Forms.Label lblMeshPrimaryMaterialIdxText;
        private System.Windows.Forms.Label lblMeshSecondaryMaterialIdxText;
        private System.Windows.Forms.Label lblMeshTertiaryMaterialIdxText;
        private System.Windows.Forms.Label lblMeshTransformMatrixSpecificReferencesText;
        private System.Windows.Forms.Label lblMeshCenterText;
        private System.Windows.Forms.Label lblMeshUnk3CText;
        private System.Windows.Forms.Label lblMeshUnk40Text;
        private System.Windows.Forms.Label lblMeshUnk40;
        private System.Windows.Forms.Label lblMeshUnk3C;
        private System.Windows.Forms.Label lblMeshCenter;
        private System.Windows.Forms.Label lblMeshTransformMatrixSpecificReferences;
        private System.Windows.Forms.Label lblMeshTertiaryMaterialIdx;
        private System.Windows.Forms.Label lblMeshSecondaryMaterialIdx;
        private System.Windows.Forms.Label lblMeshPrimaryMaterialIdx;
        private System.Windows.Forms.Label lblMeshUnk14;
        private System.Windows.Forms.Label lblMeshUnk10;
        private System.Windows.Forms.Label lblMeshUnkC;
        private System.Windows.Forms.Label lblMeshUnk8;
        private System.Windows.Forms.Label lblMeshUnk4;
        private System.Windows.Forms.Label lblMeshRenderFlags;
        private System.Windows.Forms.Label meshHeader;
    }
}