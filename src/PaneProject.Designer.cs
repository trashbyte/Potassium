namespace Potassium {
    partial class PaneProject {
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
            this.stageList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // stageList
            // 
            this.stageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stageList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stageList.FormattingEnabled = true;
            this.stageList.ItemHeight = 20;
            this.stageList.Location = new System.Drawing.Point(0, 0);
            this.stageList.Name = "stageList";
            this.stageList.Size = new System.Drawing.Size(284, 261);
            this.stageList.TabIndex = 0;
            this.stageList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.stageList_MouseDoubleClick);
            // 
            // Pane_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.stageList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Pane_Project";
            this.Text = "Pane_Materials";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox stageList;
    }
}