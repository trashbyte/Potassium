namespace Potassium {
    partial class PaneStageViewer {
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
            this.glControl = new OpenTK.GLControl();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonResetView = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDrawTextures = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // glControl
            // 
            this.glControl.BackColor = System.Drawing.Color.Black;
            this.glControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl.Location = new System.Drawing.Point(0, 0);
            this.glControl.Name = "glControl";
            this.glControl.Size = new System.Drawing.Size(284, 261);
            this.glControl.TabIndex = 0;
            this.glControl.VSync = false;
            this.glControl.Load += new System.EventHandler(this.glControl_Load);
            this.glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_Paint);
            this.glControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseDown);
            this.glControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseMove);
            this.glControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseUp);
            this.glControl.Resize += new System.EventHandler(this.glControl_Resize);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonResetView,
            this.toolStripButtonDrawTextures});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(284, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonResetView
            // 
            this.toolStripButtonResetView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonResetView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonResetView.Name = "toolStripButtonResetView";
            this.toolStripButtonResetView.Size = new System.Drawing.Size(67, 22);
            this.toolStripButtonResetView.Text = "Reset View";
            this.toolStripButtonResetView.Click += new System.EventHandler(this.toolStripButtonResetView_Click);
            // 
            // toolStripButtonDrawTextures
            // 
            this.toolStripButtonDrawTextures.CheckOnClick = true;
            this.toolStripButtonDrawTextures.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDrawTextures.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDrawTextures.Name = "toolStripButtonDrawTextures";
            this.toolStripButtonDrawTextures.Size = new System.Drawing.Size(85, 22);
            this.toolStripButtonDrawTextures.Text = "Draw Textures";
            this.toolStripButtonDrawTextures.Click += new System.EventHandler(this.toolStripButtonDrawTextures_Click);
            // 
            // Pane_StageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.glControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Pane_StageViewer";
            this.Text = "StageViewer";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonResetView;
        private System.Windows.Forms.ToolStripButton toolStripButtonDrawTextures;
    }
}