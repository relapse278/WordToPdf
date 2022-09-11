namespace WordToPdf
{
    partial class frmApp
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApp));
            this.btnOpenDirectory = new System.Windows.Forms.Button();
            this.proBarConvertionProcess = new System.Windows.Forms.ProgressBar();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.chbSameFolder = new System.Windows.Forms.CheckBox();
            this.lblConvertationProgress = new System.Windows.Forms.Label();
            this.lblDirectoryPath = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenDirectory
            // 
            this.btnOpenDirectory.Location = new System.Drawing.Point(93, 78);
            this.btnOpenDirectory.Name = "btnOpenDirectory";
            this.btnOpenDirectory.Size = new System.Drawing.Size(203, 48);
            this.btnOpenDirectory.TabIndex = 0;
            this.btnOpenDirectory.Text = "&Выберите папку с WORD-документами для их последующей конвертации в PDF";
            this.btnOpenDirectory.UseVisualStyleBackColor = true;
            this.btnOpenDirectory.Click += new System.EventHandler(this.btnOpenDirectory_Click);
            // 
            // proBarConvertionProcess
            // 
            this.proBarConvertionProcess.Location = new System.Drawing.Point(12, 185);
            this.proBarConvertionProcess.Name = "proBarConvertionProcess";
            this.proBarConvertionProcess.Size = new System.Drawing.Size(363, 27);
            this.proBarConvertionProcess.TabIndex = 2;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip2.Size = new System.Drawing.Size(388, 24);
            this.menuStrip2.TabIndex = 4;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "&О программе";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // chbSameFolder
            // 
            this.chbSameFolder.AutoSize = true;
            this.chbSameFolder.Location = new System.Drawing.Point(12, 48);
            this.chbSameFolder.Name = "chbSameFolder";
            this.chbSameFolder.Size = new System.Drawing.Size(363, 17);
            this.chbSameFolder.TabIndex = 5;
            this.chbSameFolder.Text = "Конвертировать файлы в той же папке, где находится программа";
            this.chbSameFolder.UseVisualStyleBackColor = true;
            this.chbSameFolder.CheckedChanged += new System.EventHandler(this.chbSameFolder_CheckedChanged);
            // 
            // lblConvertationProgress
            // 
            this.lblConvertationProgress.AutoSize = true;
            this.lblConvertationProgress.Location = new System.Drawing.Point(15, 163);
            this.lblConvertationProgress.Name = "lblConvertationProgress";
            this.lblConvertationProgress.Size = new System.Drawing.Size(0, 13);
            this.lblConvertationProgress.TabIndex = 6;
            // 
            // lblDirectoryPath
            // 
            this.lblDirectoryPath.AutoSize = true;
            this.lblDirectoryPath.Location = new System.Drawing.Point(15, 137);
            this.lblDirectoryPath.Name = "lblDirectoryPath";
            this.lblDirectoryPath.Size = new System.Drawing.Size(0, 13);
            this.lblDirectoryPath.TabIndex = 7;
            // 
            // frmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 228);
            this.Controls.Add(this.lblDirectoryPath);
            this.Controls.Add(this.lblConvertationProgress);
            this.Controls.Add(this.chbSameFolder);
            this.Controls.Add(this.proBarConvertionProcess);
            this.Controls.Add(this.btnOpenDirectory);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmApp";
            this.Text = "Массовая конвертация WORD в PDF";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenDirectory;
        private System.Windows.Forms.ProgressBar proBarConvertionProcess;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.CheckBox chbSameFolder;
        private System.Windows.Forms.Label lblConvertationProgress;
        private System.Windows.Forms.Label lblDirectoryPath;
    }
}

