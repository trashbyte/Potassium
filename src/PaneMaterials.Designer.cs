namespace Potassium {
    partial class PaneMaterials {
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
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.treesTable = new System.Windows.Forms.TableLayoutPanel();
            this.dataTable = new System.Windows.Forms.TableLayoutPanel();
            this.materialTable = new System.Windows.Forms.TableLayoutPanel();
            this.materialHeader = new System.Windows.Forms.Label();
            this.materialData = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaterialFlagsText = new System.Windows.Forms.Label();
            this.lblMaterialTextureIndexText = new System.Windows.Forms.Label();
            this.lblMaterialUnk6Text = new System.Windows.Forms.Label();
            this.lblMaterialAnisotropyLevelText = new System.Windows.Forms.Label();
            this.lblMaterialUnkCText = new System.Windows.Forms.Label();
            this.lblMaterialUnk10Text = new System.Windows.Forms.Label();
            this.lblMaterialFlags = new System.Windows.Forms.Label();
            this.lblMaterialTextureIndex = new System.Windows.Forms.Label();
            this.lblMaterialUnk6 = new System.Windows.Forms.Label();
            this.lblMaterialAnisotropyLevel = new System.Windows.Forms.Label();
            this.lblMaterialUnkC = new System.Windows.Forms.Label();
            this.lblMaterialUnk10 = new System.Windows.Forms.Label();
            this.textureTable = new System.Windows.Forms.TableLayoutPanel();
            this.textureData = new System.Windows.Forms.TableLayoutPanel();
            this.lblTextureDimensionsText = new System.Windows.Forms.Label();
            this.lblTextureDimensions = new System.Windows.Forms.Label();
            this.lblTextureFormatText = new System.Windows.Forms.Label();
            this.lblTextureFormat = new System.Windows.Forms.Label();
            this.textureHeader = new System.Windows.Forms.Label();
            this.treeTextures = new Potassium_WinFormsExt.TreeViewAutoPartialCheckBox();
            this.treeMaterials = new Potassium_WinFormsExt.TreeViewAutoPartialCheckBox();
            this.textureImage = new Potassium_WinFormsExt.PictureBoxDownsizeIfNecessary();
            this.mainTable.SuspendLayout();
            this.treesTable.SuspendLayout();
            this.dataTable.SuspendLayout();
            this.materialTable.SuspendLayout();
            this.materialData.SuspendLayout();
            this.textureTable.SuspendLayout();
            this.textureData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textureImage)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTable
            // 
            this.mainTable.ColumnCount = 1;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTable.Controls.Add(this.dataTable, 0, 2);
            this.mainTable.Controls.Add(this.treesTable, 0, 0);
            this.mainTable.Controls.Add(this.textureImage, 0, 1);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 3;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTable.Size = new System.Drawing.Size(284, 567);
            this.mainTable.TabIndex = 1;
            // 
            // treesTable
            // 
            this.treesTable.ColumnCount = 2;
            this.treesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.treesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.treesTable.Controls.Add(this.treeTextures, 0, 0);
            this.treesTable.Controls.Add(this.treeMaterials, 1, 0);
            this.treesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treesTable.Location = new System.Drawing.Point(3, 3);
            this.treesTable.Name = "treesTable";
            this.treesTable.RowCount = 1;
            this.treesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.treesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.treesTable.Size = new System.Drawing.Size(278, 177);
            this.treesTable.TabIndex = 2;
            // 
            // dataTable
            // 
            this.dataTable.ColumnCount = 1;
            this.dataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dataTable.Controls.Add(this.materialTable, 0, 1);
            this.dataTable.Controls.Add(this.textureTable, 0, 0);
            this.dataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTable.Location = new System.Drawing.Point(3, 369);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowCount = 2;
            this.dataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.dataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.dataTable.Size = new System.Drawing.Size(278, 195);
            this.dataTable.TabIndex = 8;
            // 
            // materialTable
            // 
            this.materialTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTable.ColumnCount = 1;
            this.materialTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.materialTable.Controls.Add(this.materialHeader, 0, 0);
            this.materialTable.Controls.Add(this.materialData, 0, 1);
            this.materialTable.Location = new System.Drawing.Point(3, 58);
            this.materialTable.Name = "materialTable";
            this.materialTable.RowCount = 1;
            this.materialTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.materialTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.materialTable.Size = new System.Drawing.Size(272, 139);
            this.materialTable.TabIndex = 8;
            this.materialTable.Visible = false;
            // 
            // materialHeader
            // 
            this.materialHeader.AutoSize = true;
            this.materialHeader.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.materialHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialHeader.Location = new System.Drawing.Point(3, 0);
            this.materialHeader.Name = "materialHeader";
            this.materialHeader.Padding = new System.Windows.Forms.Padding(2);
            this.materialHeader.Size = new System.Drawing.Size(347, 17);
            this.materialHeader.TabIndex = 2;
            this.materialHeader.Text = "Material";
            // 
            // materialData
            // 
            this.materialData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialData.ColumnCount = 2;
            this.materialData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.materialData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.materialData.Controls.Add(this.lblMaterialFlagsText, 0, 0);
            this.materialData.Controls.Add(this.lblMaterialTextureIndexText, 0, 1);
            this.materialData.Controls.Add(this.lblMaterialUnk6Text, 0, 2);
            this.materialData.Controls.Add(this.lblMaterialAnisotropyLevelText, 0, 3);
            this.materialData.Controls.Add(this.lblMaterialUnkCText, 0, 4);
            this.materialData.Controls.Add(this.lblMaterialUnk10Text, 0, 5);
            this.materialData.Controls.Add(this.lblMaterialFlags, 1, 0);
            this.materialData.Controls.Add(this.lblMaterialTextureIndex, 1, 1);
            this.materialData.Controls.Add(this.lblMaterialUnk6, 1, 2);
            this.materialData.Controls.Add(this.lblMaterialAnisotropyLevel, 1, 3);
            this.materialData.Controls.Add(this.lblMaterialUnkC, 1, 4);
            this.materialData.Controls.Add(this.lblMaterialUnk10, 1, 5);
            this.materialData.Location = new System.Drawing.Point(3, 20);
            this.materialData.Name = "materialData";
            this.materialData.RowCount = 6;
            this.materialData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.materialData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.materialData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.materialData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.materialData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.materialData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.materialData.Size = new System.Drawing.Size(347, 117);
            this.materialData.TabIndex = 1;
            // 
            // lblMaterialFlagsText
            // 
            this.lblMaterialFlagsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialFlagsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialFlagsText.Location = new System.Drawing.Point(3, 0);
            this.lblMaterialFlagsText.Name = "lblMaterialFlagsText";
            this.lblMaterialFlagsText.Size = new System.Drawing.Size(167, 20);
            this.lblMaterialFlagsText.TabIndex = 0;
            this.lblMaterialFlagsText.Text = "Material Flags:";
            this.lblMaterialFlagsText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMaterialTextureIndexText
            // 
            this.lblMaterialTextureIndexText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialTextureIndexText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialTextureIndexText.Location = new System.Drawing.Point(3, 20);
            this.lblMaterialTextureIndexText.Name = "lblMaterialTextureIndexText";
            this.lblMaterialTextureIndexText.Size = new System.Drawing.Size(167, 20);
            this.lblMaterialTextureIndexText.TabIndex = 1;
            this.lblMaterialTextureIndexText.Text = "Texture Index:";
            this.lblMaterialTextureIndexText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMaterialUnk6Text
            // 
            this.lblMaterialUnk6Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialUnk6Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialUnk6Text.Location = new System.Drawing.Point(3, 40);
            this.lblMaterialUnk6Text.Name = "lblMaterialUnk6Text";
            this.lblMaterialUnk6Text.Size = new System.Drawing.Size(167, 20);
            this.lblMaterialUnk6Text.TabIndex = 2;
            this.lblMaterialUnk6Text.Text = "Unk6:";
            this.lblMaterialUnk6Text.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMaterialAnisotropyLevelText
            // 
            this.lblMaterialAnisotropyLevelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialAnisotropyLevelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialAnisotropyLevelText.Location = new System.Drawing.Point(3, 60);
            this.lblMaterialAnisotropyLevelText.Name = "lblMaterialAnisotropyLevelText";
            this.lblMaterialAnisotropyLevelText.Size = new System.Drawing.Size(167, 20);
            this.lblMaterialAnisotropyLevelText.TabIndex = 3;
            this.lblMaterialAnisotropyLevelText.Text = "Anisotropy Level:";
            this.lblMaterialAnisotropyLevelText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMaterialUnkCText
            // 
            this.lblMaterialUnkCText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialUnkCText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialUnkCText.Location = new System.Drawing.Point(3, 80);
            this.lblMaterialUnkCText.Name = "lblMaterialUnkCText";
            this.lblMaterialUnkCText.Size = new System.Drawing.Size(167, 20);
            this.lblMaterialUnkCText.TabIndex = 4;
            this.lblMaterialUnkCText.Text = "UnkC:";
            this.lblMaterialUnkCText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMaterialUnk10Text
            // 
            this.lblMaterialUnk10Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialUnk10Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialUnk10Text.Location = new System.Drawing.Point(3, 100);
            this.lblMaterialUnk10Text.Name = "lblMaterialUnk10Text";
            this.lblMaterialUnk10Text.Size = new System.Drawing.Size(167, 20);
            this.lblMaterialUnk10Text.TabIndex = 5;
            this.lblMaterialUnk10Text.Text = "Unk10:";
            this.lblMaterialUnk10Text.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMaterialFlags
            // 
            this.lblMaterialFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialFlags.Location = new System.Drawing.Point(176, 0);
            this.lblMaterialFlags.Name = "lblMaterialFlags";
            this.lblMaterialFlags.Size = new System.Drawing.Size(168, 20);
            this.lblMaterialFlags.TabIndex = 6;
            this.lblMaterialFlags.Text = "-";
            // 
            // lblMaterialTextureIndex
            // 
            this.lblMaterialTextureIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialTextureIndex.Location = new System.Drawing.Point(176, 20);
            this.lblMaterialTextureIndex.Name = "lblMaterialTextureIndex";
            this.lblMaterialTextureIndex.Size = new System.Drawing.Size(168, 20);
            this.lblMaterialTextureIndex.TabIndex = 7;
            this.lblMaterialTextureIndex.Text = "-";
            // 
            // lblMaterialUnk6
            // 
            this.lblMaterialUnk6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialUnk6.Location = new System.Drawing.Point(176, 40);
            this.lblMaterialUnk6.Name = "lblMaterialUnk6";
            this.lblMaterialUnk6.Size = new System.Drawing.Size(168, 20);
            this.lblMaterialUnk6.TabIndex = 8;
            this.lblMaterialUnk6.Text = "-";
            // 
            // lblMaterialAnisotropyLevel
            // 
            this.lblMaterialAnisotropyLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialAnisotropyLevel.Location = new System.Drawing.Point(176, 60);
            this.lblMaterialAnisotropyLevel.Name = "lblMaterialAnisotropyLevel";
            this.lblMaterialAnisotropyLevel.Size = new System.Drawing.Size(168, 20);
            this.lblMaterialAnisotropyLevel.TabIndex = 9;
            this.lblMaterialAnisotropyLevel.Text = "-";
            // 
            // lblMaterialUnkC
            // 
            this.lblMaterialUnkC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialUnkC.Location = new System.Drawing.Point(176, 80);
            this.lblMaterialUnkC.Name = "lblMaterialUnkC";
            this.lblMaterialUnkC.Size = new System.Drawing.Size(168, 20);
            this.lblMaterialUnkC.TabIndex = 10;
            this.lblMaterialUnkC.Text = "-";
            // 
            // lblMaterialUnk10
            // 
            this.lblMaterialUnk10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialUnk10.Location = new System.Drawing.Point(176, 100);
            this.lblMaterialUnk10.Name = "lblMaterialUnk10";
            this.lblMaterialUnk10.Size = new System.Drawing.Size(168, 20);
            this.lblMaterialUnk10.TabIndex = 11;
            this.lblMaterialUnk10.Text = "-";
            // 
            // textureTable
            // 
            this.textureTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textureTable.ColumnCount = 1;
            this.textureTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.textureTable.Controls.Add(this.textureData, 0, 1);
            this.textureTable.Controls.Add(this.textureHeader, 0, 0);
            this.textureTable.Location = new System.Drawing.Point(0, 0);
            this.textureTable.Margin = new System.Windows.Forms.Padding(0);
            this.textureTable.Name = "textureTable";
            this.textureTable.RowCount = 2;
            this.textureTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.textureTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.textureTable.Size = new System.Drawing.Size(278, 55);
            this.textureTable.TabIndex = 7;
            this.textureTable.Visible = false;
            // 
            // textureData
            // 
            this.textureData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textureData.ColumnCount = 2;
            this.textureData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.textureData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.textureData.Controls.Add(this.lblTextureDimensionsText, 0, 0);
            this.textureData.Controls.Add(this.lblTextureDimensions, 1, 0);
            this.textureData.Controls.Add(this.lblTextureFormatText, 0, 1);
            this.textureData.Controls.Add(this.lblTextureFormat, 1, 1);
            this.textureData.Location = new System.Drawing.Point(0, 17);
            this.textureData.Margin = new System.Windows.Forms.Padding(0);
            this.textureData.Name = "textureData";
            this.textureData.RowCount = 2;
            this.textureData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.textureData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.textureData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.textureData.Size = new System.Drawing.Size(359, 76);
            this.textureData.TabIndex = 4;
            // 
            // lblTextureDimensionsText
            // 
            this.lblTextureDimensionsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTextureDimensionsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextureDimensionsText.Location = new System.Drawing.Point(3, 0);
            this.lblTextureDimensionsText.Name = "lblTextureDimensionsText";
            this.lblTextureDimensionsText.Size = new System.Drawing.Size(173, 20);
            this.lblTextureDimensionsText.TabIndex = 0;
            this.lblTextureDimensionsText.Text = "Dimensions:";
            this.lblTextureDimensionsText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTextureDimensions
            // 
            this.lblTextureDimensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTextureDimensions.Location = new System.Drawing.Point(182, 0);
            this.lblTextureDimensions.Name = "lblTextureDimensions";
            this.lblTextureDimensions.Size = new System.Drawing.Size(174, 20);
            this.lblTextureDimensions.TabIndex = 1;
            this.lblTextureDimensions.Text = "-";
            // 
            // lblTextureFormatText
            // 
            this.lblTextureFormatText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTextureFormatText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextureFormatText.Location = new System.Drawing.Point(3, 20);
            this.lblTextureFormatText.Name = "lblTextureFormatText";
            this.lblTextureFormatText.Size = new System.Drawing.Size(173, 56);
            this.lblTextureFormatText.TabIndex = 2;
            this.lblTextureFormatText.Text = "Format:";
            this.lblTextureFormatText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTextureFormat
            // 
            this.lblTextureFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTextureFormat.Location = new System.Drawing.Point(182, 20);
            this.lblTextureFormat.Name = "lblTextureFormat";
            this.lblTextureFormat.Size = new System.Drawing.Size(174, 56);
            this.lblTextureFormat.TabIndex = 3;
            this.lblTextureFormat.Text = "-";
            // 
            // textureHeader
            // 
            this.textureHeader.AutoSize = true;
            this.textureHeader.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textureHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textureHeader.Location = new System.Drawing.Point(3, 0);
            this.textureHeader.Name = "textureHeader";
            this.textureHeader.Padding = new System.Windows.Forms.Padding(2);
            this.textureHeader.Size = new System.Drawing.Size(353, 17);
            this.textureHeader.TabIndex = 3;
            this.textureHeader.Text = "Texture";
            // 
            // treeTextures
            // 
            this.treeTextures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeTextures.Location = new System.Drawing.Point(3, 3);
            this.treeTextures.Name = "treeTextures";
            this.treeTextures.Size = new System.Drawing.Size(133, 171);
            this.treeTextures.TabIndex = 2;
            this.treeTextures.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeTextures_AfterSelect);
            // 
            // treeMaterials
            // 
            this.treeMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMaterials.Location = new System.Drawing.Point(142, 3);
            this.treeMaterials.Name = "treeMaterials";
            this.treeMaterials.Size = new System.Drawing.Size(133, 171);
            this.treeMaterials.TabIndex = 1;
            this.treeMaterials.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeMaterials_AfterSelect);
            // 
            // textureImage
            // 
            this.textureImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textureImage.Location = new System.Drawing.Point(3, 186);
            this.textureImage.Name = "textureImage";
            this.textureImage.Size = new System.Drawing.Size(278, 177);
            this.textureImage.TabIndex = 7;
            this.textureImage.TabStop = false;
            this.textureImage.Visible = false;
            // 
            // PaneMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 567);
            this.Controls.Add(this.mainTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PaneMaterials";
            this.Text = "Pane_Materials";
            this.Resize += new System.EventHandler(this.PaneMaterials_Resize);
            this.mainTable.ResumeLayout(false);
            this.treesTable.ResumeLayout(false);
            this.dataTable.ResumeLayout(false);
            this.materialTable.ResumeLayout(false);
            this.materialTable.PerformLayout();
            this.materialData.ResumeLayout(false);
            this.textureTable.ResumeLayout(false);
            this.textureTable.PerformLayout();
            this.textureData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textureImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel mainTable;
        private Potassium_WinFormsExt.PictureBoxDownsizeIfNecessary textureImage;
        private System.Windows.Forms.TableLayoutPanel treesTable;
        private Potassium_WinFormsExt.TreeViewAutoPartialCheckBox treeMaterials;
        private Potassium_WinFormsExt.TreeViewAutoPartialCheckBox treeTextures;
        private System.Windows.Forms.TableLayoutPanel dataTable;
        private System.Windows.Forms.TableLayoutPanel materialTable;
        private System.Windows.Forms.Label materialHeader;
        private System.Windows.Forms.TableLayoutPanel materialData;
        private System.Windows.Forms.Label lblMaterialFlagsText;
        private System.Windows.Forms.Label lblMaterialTextureIndexText;
        private System.Windows.Forms.Label lblMaterialUnk6Text;
        private System.Windows.Forms.Label lblMaterialAnisotropyLevelText;
        private System.Windows.Forms.Label lblMaterialUnkCText;
        private System.Windows.Forms.Label lblMaterialUnk10Text;
        private System.Windows.Forms.Label lblMaterialFlags;
        private System.Windows.Forms.Label lblMaterialTextureIndex;
        private System.Windows.Forms.Label lblMaterialUnk6;
        private System.Windows.Forms.Label lblMaterialAnisotropyLevel;
        private System.Windows.Forms.Label lblMaterialUnkC;
        private System.Windows.Forms.Label lblMaterialUnk10;
        private System.Windows.Forms.TableLayoutPanel textureTable;
        private System.Windows.Forms.TableLayoutPanel textureData;
        private System.Windows.Forms.Label lblTextureDimensionsText;
        private System.Windows.Forms.Label lblTextureDimensions;
        private System.Windows.Forms.Label lblTextureFormatText;
        private System.Windows.Forms.Label lblTextureFormat;
        private System.Windows.Forms.Label textureHeader;
    }
}