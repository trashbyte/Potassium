namespace Potassium {
    partial class MainWindow {

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.mainDockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.importGmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportGmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importTplToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTplToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.importStageLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportStageLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exportObjMtlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importObjMtlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSaveTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gxExpanderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdLoadGma = new System.Windows.Forms.OpenFileDialog();
            this.ofdLoadTpl = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveTpl = new System.Windows.Forms.SaveFileDialog();
            this.ofdTextureImportPath = new System.Windows.Forms.OpenFileDialog();
            this.sfdTextureExportPath = new System.Windows.Forms.SaveFileDialog();
            this.sfdSaveGma = new System.Windows.Forms.SaveFileDialog();
            this.ofdLoadObj = new System.Windows.Forms.OpenFileDialog();
            this.ofdLoadStageLayout = new System.Windows.Forms.OpenFileDialog();
            this.fbdModelExportPath = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDockPanel
            // 
            this.mainDockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.mainDockPanel.Location = new System.Drawing.Point(0, 24);
            this.mainDockPanel.Name = "mainDockPanel";
            this.mainDockPanel.Size = new System.Drawing.Size(1584, 837);
            this.mainDockPanel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProjectToolStripMenuItem,
            this.saveStageToolStripMenuItem,
            this.toolStripSeparator3,
            this.importGmaToolStripMenuItem,
            this.exportGmaToolStripMenuItem,
            this.toolStripSeparator1,
            this.importTplToolStripMenuItem,
            this.exportTplToolStripMenuItem,
            this.toolStripSeparator2,
            this.importStageLayoutToolStripMenuItem,
            this.exportStageLayoutToolStripMenuItem,
            this.toolStripSeparator4,
            this.exportObjMtlToolStripMenuItem,
            this.importObjMtlToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.loadProjectToolStripMenuItem.Text = "Load Project...";
            this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.loadProjectToolStripMenuItem_Click);
            // 
            // saveStageToolStripMenuItem
            // 
            this.saveStageToolStripMenuItem.Name = "saveStageToolStripMenuItem";
            this.saveStageToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.saveStageToolStripMenuItem.Text = "Save Stage";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // importGmaToolStripMenuItem
            // 
            this.importGmaToolStripMenuItem.Name = "importGmaToolStripMenuItem";
            this.importGmaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.importGmaToolStripMenuItem.Text = "Import GMA";
            this.importGmaToolStripMenuItem.Click += new System.EventHandler(this.importGmaToolStripMenuItem_Click);
            // 
            // exportGmaToolStripMenuItem
            // 
            this.exportGmaToolStripMenuItem.Name = "exportGmaToolStripMenuItem";
            this.exportGmaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exportGmaToolStripMenuItem.Text = "Export GMA";
            this.exportGmaToolStripMenuItem.Click += new System.EventHandler(this.saveGMAAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // importTplToolStripMenuItem
            // 
            this.importTplToolStripMenuItem.Name = "importTplToolStripMenuItem";
            this.importTplToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.importTplToolStripMenuItem.Text = "Import TPL";
            this.importTplToolStripMenuItem.Click += new System.EventHandler(this.loadTPLToolStripMenuItem_Click);
            // 
            // exportTplToolStripMenuItem
            // 
            this.exportTplToolStripMenuItem.Name = "exportTplToolStripMenuItem";
            this.exportTplToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exportTplToolStripMenuItem.Text = "Export TPL";
            this.exportTplToolStripMenuItem.Click += new System.EventHandler(this.saveTPLAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // importStageLayoutToolStripMenuItem
            // 
            this.importStageLayoutToolStripMenuItem.Name = "importStageLayoutToolStripMenuItem";
            this.importStageLayoutToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.importStageLayoutToolStripMenuItem.Text = "Import Stage Layout";
            this.importStageLayoutToolStripMenuItem.Click += new System.EventHandler(this.loadStageLayoutToolStripMenuItem_Click);
            // 
            // exportStageLayoutToolStripMenuItem
            // 
            this.exportStageLayoutToolStripMenuItem.Name = "exportStageLayoutToolStripMenuItem";
            this.exportStageLayoutToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exportStageLayoutToolStripMenuItem.Text = "Export Stage Layout";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(178, 6);
            // 
            // exportObjMtlToolStripMenuItem
            // 
            this.exportObjMtlToolStripMenuItem.Name = "exportObjMtlToolStripMenuItem";
            this.exportObjMtlToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exportObjMtlToolStripMenuItem.Text = "Export OBJ/MTL";
            this.exportObjMtlToolStripMenuItem.Click += new System.EventHandler(this.exportObjMtlToolStripMenuItem_Click);
            // 
            // importObjMtlToolStripMenuItem
            // 
            this.importObjMtlToolStripMenuItem.Name = "importObjMtlToolStripMenuItem";
            this.importObjMtlToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.importObjMtlToolStripMenuItem.Text = "Import OBJ/MTL";
            this.importObjMtlToolStripMenuItem.Click += new System.EventHandler(this.importObjMtlToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSaveTestToolStripMenuItem,
            this.gxExpanderToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // loadSaveTestToolStripMenuItem
            // 
            this.loadSaveTestToolStripMenuItem.Name = "loadSaveTestToolStripMenuItem";
            this.loadSaveTestToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.loadSaveTestToolStripMenuItem.Text = "Load / Save Test";
            this.loadSaveTestToolStripMenuItem.Click += new System.EventHandler(this.loadSaveTestToolStripMenuItem_Click);
            // 
            // gxExpanderToolStripMenuItem
            // 
            this.gxExpanderToolStripMenuItem.Name = "gxExpanderToolStripMenuItem";
            this.gxExpanderToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.gxExpanderToolStripMenuItem.Text = "GxExpander";
            this.gxExpanderToolStripMenuItem.Click += new System.EventHandler(this.gxExpanderToolStripMenuItem_Click);
            // 
            // ofdLoadGma
            // 
            this.ofdLoadGma.DefaultExt = "gma";
            this.ofdLoadGma.Filter = "GMA Files|*.gma|All Files|*.*";
            this.ofdLoadGma.Title = "Load GMA File...";
            // 
            // ofdLoadTpl
            // 
            this.ofdLoadTpl.DefaultExt = "tpl";
            this.ofdLoadTpl.Filter = "TPL Files|*.tpl|All Files|*.*";
            this.ofdLoadTpl.Title = "Load TPL File...";
            // 
            // sfdSaveTpl
            // 
            this.sfdSaveTpl.DefaultExt = "tpl";
            this.sfdSaveTpl.Filter = "TPL Files|*.tpl|All Files|*.*";
            this.sfdSaveTpl.Title = "Save TPL File...";
            // 
            // ofdTextureImportPath
            // 
            this.ofdTextureImportPath.Filter = "Image files|*.png;*.tiff;*.gif;*.jpg;*.jpeg;*.bmp|All Files|*.*";
            this.ofdTextureImportPath.Title = "Select texture file to import...";
            // 
            // sfdTextureExportPath
            // 
            this.sfdTextureExportPath.DefaultExt = "png";
            this.sfdTextureExportPath.Filter = "Image files|*.png,*.tiff,*.gif,*.jpg,*.jpeg,*.bmp|All Files|*.*";
            this.sfdTextureExportPath.Title = "Select file to export to...";
            // 
            // sfdSaveGma
            // 
            this.sfdSaveGma.DefaultExt = "gma";
            this.sfdSaveGma.Filter = "GMA Files|*.gma|All Files|*.*";
            this.sfdSaveGma.Title = "Save GMA File...";
            // 
            // ofdLoadObj
            // 
            this.ofdLoadObj.DefaultExt = "obj";
            this.ofdLoadObj.Filter = "OBJ Files|*.obj|All Files|*.*";
            this.ofdLoadObj.Title = "Load OBJ File...";
            // 
            // ofdLoadStageLayout
            // 
            this.ofdLoadStageLayout.Filter = "Stage Layout Files|*.layout";
            this.ofdLoadStageLayout.Title = "Load Stage Layout File...";
            // 
            // fbdModelExportPath
            // 
            this.fbdModelExportPath.Description = "Select Model Export Path...";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.mainDockPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        
        private WeifenLuo.WinFormsUI.Docking.DockPanel mainDockPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importGmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTplToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdLoadGma;
        private System.Windows.Forms.OpenFileDialog ofdLoadTpl;
        private System.Windows.Forms.SaveFileDialog sfdSaveTpl;
        private System.Windows.Forms.OpenFileDialog ofdTextureImportPath;
        private System.Windows.Forms.SaveFileDialog sfdTextureExportPath;
        private System.Windows.Forms.SaveFileDialog sfdSaveGma;
        private System.Windows.Forms.OpenFileDialog ofdLoadObj;
        private System.Windows.Forms.OpenFileDialog ofdLoadStageLayout;
        private System.Windows.Forms.FolderBrowserDialog fbdModelExportPath;
        private System.Windows.Forms.ToolStripMenuItem importStageLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportGmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportTplToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exportObjMtlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importObjMtlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSaveTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gxExpanderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportStageLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveStageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}