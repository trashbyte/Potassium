namespace Potassium {
    partial class PaneStageLayout {
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
            this.treeStageLayout = new System.Windows.Forms.TreeView();
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableBanana = new System.Windows.Forms.TableLayoutPanel();
            this.lblBananaType = new System.Windows.Forms.Label();
            this.textBoxBananaZ = new System.Windows.Forms.TextBox();
            this.textBoxBananaY = new System.Windows.Forms.TextBox();
            this.lblBananaZ = new System.Windows.Forms.Label();
            this.lblBananaY = new System.Windows.Forms.Label();
            this.lblBananaX = new System.Windows.Forms.Label();
            this.bananaHeader = new System.Windows.Forms.Label();
            this.textBoxBananaX = new System.Windows.Forms.TextBox();
            this.comboBananaType = new System.Windows.Forms.ComboBox();
            this.mainTable.SuspendLayout();
            this.tableBanana.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeStageLayout
            // 
            this.treeStageLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeStageLayout.Location = new System.Drawing.Point(3, 3);
            this.treeStageLayout.Name = "treeStageLayout";
            this.treeStageLayout.Size = new System.Drawing.Size(278, 349);
            this.treeStageLayout.TabIndex = 0;
            this.treeStageLayout.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeStageLayout_AfterSelect);
            // 
            // mainTable
            // 
            this.mainTable.ColumnCount = 1;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.Controls.Add(this.treeStageLayout, 0, 0);
            this.mainTable.Controls.Add(this.tableBanana, 0, 1);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 2;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.mainTable.Size = new System.Drawing.Size(284, 480);
            this.mainTable.TabIndex = 1;
            // 
            // tableBanana
            // 
            this.tableBanana.ColumnCount = 2;
            this.tableBanana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBanana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBanana.Controls.Add(this.lblBananaType, 0, 1);
            this.tableBanana.Controls.Add(this.textBoxBananaZ, 1, 4);
            this.tableBanana.Controls.Add(this.textBoxBananaY, 1, 3);
            this.tableBanana.Controls.Add(this.lblBananaZ, 0, 4);
            this.tableBanana.Controls.Add(this.lblBananaY, 0, 3);
            this.tableBanana.Controls.Add(this.lblBananaX, 0, 2);
            this.tableBanana.Controls.Add(this.bananaHeader, 0, 0);
            this.tableBanana.Controls.Add(this.textBoxBananaX, 1, 2);
            this.tableBanana.Controls.Add(this.comboBananaType, 1, 1);
            this.tableBanana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBanana.Location = new System.Drawing.Point(3, 358);
            this.tableBanana.Name = "tableBanana";
            this.tableBanana.RowCount = 5;
            this.tableBanana.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableBanana.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableBanana.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableBanana.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableBanana.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableBanana.Size = new System.Drawing.Size(278, 119);
            this.tableBanana.TabIndex = 1;
            // 
            // lblBananaType
            // 
            this.lblBananaType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBananaType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBananaType.Location = new System.Drawing.Point(3, 17);
            this.lblBananaType.Name = "lblBananaType";
            this.lblBananaType.Size = new System.Drawing.Size(133, 27);
            this.lblBananaType.TabIndex = 12;
            this.lblBananaType.Text = "Type:";
            this.lblBananaType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxBananaZ
            // 
            this.textBoxBananaZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBananaZ.Location = new System.Drawing.Point(142, 99);
            this.textBoxBananaZ.Name = "textBoxBananaZ";
            this.textBoxBananaZ.Size = new System.Drawing.Size(133, 20);
            this.textBoxBananaZ.TabIndex = 10;
            this.textBoxBananaZ.TextChanged += new System.EventHandler(this.textBoxBananaPos_TextChanged);
            // 
            // textBoxBananaY
            // 
            this.textBoxBananaY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBananaY.Location = new System.Drawing.Point(142, 73);
            this.textBoxBananaY.Name = "textBoxBananaY";
            this.textBoxBananaY.Size = new System.Drawing.Size(133, 20);
            this.textBoxBananaY.TabIndex = 9;
            this.textBoxBananaY.TextChanged += new System.EventHandler(this.textBoxBananaPos_TextChanged);
            // 
            // lblBananaZ
            // 
            this.lblBananaZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBananaZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBananaZ.Location = new System.Drawing.Point(3, 96);
            this.lblBananaZ.Name = "lblBananaZ";
            this.lblBananaZ.Size = new System.Drawing.Size(133, 26);
            this.lblBananaZ.TabIndex = 7;
            this.lblBananaZ.Text = "Z:";
            this.lblBananaZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBananaY
            // 
            this.lblBananaY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBananaY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBananaY.Location = new System.Drawing.Point(3, 70);
            this.lblBananaY.Name = "lblBananaY";
            this.lblBananaY.Size = new System.Drawing.Size(133, 26);
            this.lblBananaY.TabIndex = 6;
            this.lblBananaY.Text = "Y:";
            this.lblBananaY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBananaX
            // 
            this.lblBananaX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBananaX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBananaX.Location = new System.Drawing.Point(3, 44);
            this.lblBananaX.Name = "lblBananaX";
            this.lblBananaX.Size = new System.Drawing.Size(133, 26);
            this.lblBananaX.TabIndex = 5;
            this.lblBananaX.Text = "X:";
            this.lblBananaX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bananaHeader
            // 
            this.bananaHeader.AutoSize = true;
            this.bananaHeader.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tableBanana.SetColumnSpan(this.bananaHeader, 2);
            this.bananaHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bananaHeader.Location = new System.Drawing.Point(3, 0);
            this.bananaHeader.Name = "bananaHeader";
            this.bananaHeader.Padding = new System.Windows.Forms.Padding(2);
            this.bananaHeader.Size = new System.Drawing.Size(272, 17);
            this.bananaHeader.TabIndex = 4;
            this.bananaHeader.Text = "Banana";
            // 
            // textBoxBananaX
            // 
            this.textBoxBananaX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBananaX.Location = new System.Drawing.Point(142, 47);
            this.textBoxBananaX.Name = "textBoxBananaX";
            this.textBoxBananaX.Size = new System.Drawing.Size(133, 20);
            this.textBoxBananaX.TabIndex = 8;
            this.textBoxBananaX.TextChanged += new System.EventHandler(this.textBoxBananaPos_TextChanged);
            // 
            // comboBananaType
            // 
            this.comboBananaType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBananaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBananaType.FormattingEnabled = true;
            this.comboBananaType.Items.AddRange(new object[] {
            "Single",
            "Bunch"});
            this.comboBananaType.Location = new System.Drawing.Point(142, 20);
            this.comboBananaType.Name = "comboBananaType";
            this.comboBananaType.Size = new System.Drawing.Size(133, 21);
            this.comboBananaType.TabIndex = 11;
            this.comboBananaType.SelectedValueChanged += new System.EventHandler(this.comboBananaType_SelectedValueChanged);
            // 
            // PaneStageLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 480);
            this.Controls.Add(this.mainTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PaneStageLayout";
            this.Text = "Pane_StageLayout";
            this.mainTable.ResumeLayout(false);
            this.tableBanana.ResumeLayout(false);
            this.tableBanana.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeStageLayout;
        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.TableLayoutPanel tableBanana;
        private System.Windows.Forms.Label bananaHeader;
        private System.Windows.Forms.Label lblBananaX;
        private System.Windows.Forms.Label lblBananaZ;
        private System.Windows.Forms.Label lblBananaY;
        private System.Windows.Forms.TextBox textBoxBananaX;
        private System.Windows.Forms.TextBox textBoxBananaZ;
        private System.Windows.Forms.TextBox textBoxBananaY;
        private System.Windows.Forms.Label lblBananaType;
        private System.Windows.Forms.ComboBox comboBananaType;
    }
}