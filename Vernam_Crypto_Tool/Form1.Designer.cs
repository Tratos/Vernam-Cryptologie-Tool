namespace Vernam_Crypto_Tool
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.encryptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSourceFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateWAVFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptTheFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWAVFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptTheFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.hb1 = new Be.Windows.Forms.HexBox();
            this.hb2 = new Be.Windows.Forms.HexBox();
            this.generateWAVFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(835, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateWAVFileToolStripMenuItem1,
            this.encryptFileToolStripMenuItem,
            this.decryptFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // encryptFileToolStripMenuItem
            // 
            this.encryptFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSourceFileToolStripMenuItem,
            this.generateWAVFileToolStripMenuItem,
            this.encryptTheFileToolStripMenuItem});
            this.encryptFileToolStripMenuItem.Name = "encryptFileToolStripMenuItem";
            this.encryptFileToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.encryptFileToolStripMenuItem.Text = "Encrypt File...";
            // 
            // openSourceFileToolStripMenuItem
            // 
            this.openSourceFileToolStripMenuItem.Name = "openSourceFileToolStripMenuItem";
            this.openSourceFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openSourceFileToolStripMenuItem.Text = "Open Source File...";
            this.openSourceFileToolStripMenuItem.Click += new System.EventHandler(this.openSourceFileToolStripMenuItem_Click);
            // 
            // generateWAVFileToolStripMenuItem
            // 
            this.generateWAVFileToolStripMenuItem.Name = "generateWAVFileToolStripMenuItem";
            this.generateWAVFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generateWAVFileToolStripMenuItem.Text = "Load WAV File...";
            this.generateWAVFileToolStripMenuItem.Click += new System.EventHandler(this.generateWAVFileToolStripMenuItem_Click);
            // 
            // encryptTheFileToolStripMenuItem
            // 
            this.encryptTheFileToolStripMenuItem.Name = "encryptTheFileToolStripMenuItem";
            this.encryptTheFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.encryptTheFileToolStripMenuItem.Text = "Encrypt the File";
            this.encryptTheFileToolStripMenuItem.Click += new System.EventHandler(this.encryptTheFileToolStripMenuItem_Click);
            // 
            // decryptFileToolStripMenuItem
            // 
            this.decryptFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.loadWAVFileToolStripMenuItem,
            this.decryptTheFileToolStripMenuItem});
            this.decryptFileToolStripMenuItem.Name = "decryptFileToolStripMenuItem";
            this.decryptFileToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.decryptFileToolStripMenuItem.Text = "Decrypt File...";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.openFileToolStripMenuItem.Text = "Open File...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // loadWAVFileToolStripMenuItem
            // 
            this.loadWAVFileToolStripMenuItem.Name = "loadWAVFileToolStripMenuItem";
            this.loadWAVFileToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.loadWAVFileToolStripMenuItem.Text = "Load WAV File...";
            this.loadWAVFileToolStripMenuItem.Click += new System.EventHandler(this.loadWAVFileToolStripMenuItem_Click);
            // 
            // decryptTheFileToolStripMenuItem
            // 
            this.decryptTheFileToolStripMenuItem.Name = "decryptTheFileToolStripMenuItem";
            this.decryptTheFileToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.decryptTheFileToolStripMenuItem.Text = "Decrypt the File";
            this.decryptTheFileToolStripMenuItem.Click += new System.EventHandler(this.decryptTheFileToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 454);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtb1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(827, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtb1
            // 
            this.rtb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb1.Location = new System.Drawing.Point(3, 3);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(821, 422);
            this.rtb1.TabIndex = 0;
            this.rtb1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.hb1);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(827, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Encrypt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(821, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.hb2);
            this.tabPage3.Controls.Add(this.toolStrip2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(827, 428);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Decrypt";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(821, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // hb1
            // 
            this.hb1.BoldFont = null;
            this.hb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hb1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hb1.LineInfoForeColor = System.Drawing.Color.Empty;
            this.hb1.Location = new System.Drawing.Point(3, 28);
            this.hb1.Name = "hb1";
            this.hb1.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hb1.Size = new System.Drawing.Size(821, 397);
            this.hb1.StringViewVisible = true;
            this.hb1.TabIndex = 1;
            this.hb1.VScrollBarVisible = true;
            // 
            // hb2
            // 
            this.hb2.BoldFont = null;
            this.hb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hb2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hb2.LineInfoForeColor = System.Drawing.Color.Empty;
            this.hb2.Location = new System.Drawing.Point(3, 28);
            this.hb2.Name = "hb2";
            this.hb2.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hb2.Size = new System.Drawing.Size(821, 397);
            this.hb2.TabIndex = 1;
            // 
            // generateWAVFileToolStripMenuItem1
            // 
            this.generateWAVFileToolStripMenuItem1.Name = "generateWAVFileToolStripMenuItem1";
            this.generateWAVFileToolStripMenuItem1.Size = new System.Drawing.Size(124, 20);
            this.generateWAVFileToolStripMenuItem1.Text = "Generate WAV File...";
            this.generateWAVFileToolStripMenuItem1.Click += new System.EventHandler(this.generateWAVFileToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 500);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " Vernam Cryptologie Tool (c) 2024 by Eisbaer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripMenuItem encryptFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptFileToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.ToolStripMenuItem generateWAVFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSourceFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadWAVFileToolStripMenuItem;
        private Be.Windows.Forms.HexBox hb1;
        private Be.Windows.Forms.HexBox hb2;
        private System.Windows.Forms.ToolStripMenuItem encryptTheFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptTheFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateWAVFileToolStripMenuItem1;
    }
}

