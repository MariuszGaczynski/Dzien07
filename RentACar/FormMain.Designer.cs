namespace RentACar
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmu_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mmu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmu_CarRent = new System.Windows.Forms.ToolStripMenuItem();
            this.mmu_CarList = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ts_Info = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.mmu_CarRent});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmu_Login,
            this.toolStripMenuItem1,
            this.mmu_Exit});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "&Plik";
            // 
            // mmu_Login
            // 
            this.mmu_Login.Image = ((System.Drawing.Image)(resources.GetObject("mmu_Login.Image")));
            this.mmu_Login.Name = "mmu_Login";
            this.mmu_Login.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mmu_Login.Size = new System.Drawing.Size(180, 22);
            this.mmu_Login.Text = "Login...";
            this.mmu_Login.Click += new System.EventHandler(this.mmu_Login_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // mmu_Exit
            // 
            this.mmu_Exit.Name = "mmu_Exit";
            this.mmu_Exit.Size = new System.Drawing.Size(180, 22);
            this.mmu_Exit.Text = "Zakończ";
            this.mmu_Exit.Click += new System.EventHandler(this.mmu_Exit_Click);
            // 
            // mmu_CarRent
            // 
            this.mmu_CarRent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmu_CarList});
            this.mmu_CarRent.Enabled = false;
            this.mmu_CarRent.Name = "mmu_CarRent";
            this.mmu_CarRent.Size = new System.Drawing.Size(97, 20);
            this.mmu_CarRent.Text = "&Wypożyczalnia";
            // 
            // mmu_CarList
            // 
            this.mmu_CarList.Name = "mmu_CarList";
            this.mmu_CarList.Size = new System.Drawing.Size(180, 22);
            this.mmu_CarList.Text = "Lista samochodów";
            this.mmu_CarList.Click += new System.EventHandler(this.mmu_CarList_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Info});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "XXXXXXX";
            // 
            // ts_Info
            // 
            this.ts_Info.AutoSize = false;
            this.ts_Info.Name = "ts_Info";
            this.ts_Info.Size = new System.Drawing.Size(300, 17);
            this.ts_Info.Text = "xxxxxxxx";
            this.ts_Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Rent A Car";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmu_Login;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mmu_Exit;
        private System.Windows.Forms.ToolStripMenuItem mmu_CarRent;
        private System.Windows.Forms.ToolStripMenuItem mmu_CarList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ts_Info;
    }
}

