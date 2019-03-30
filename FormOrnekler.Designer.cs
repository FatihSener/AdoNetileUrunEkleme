namespace _02_Ornekler
{
    partial class FormOrnekler
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.örneklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunSayısınıVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunStokSayisiniVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorininUrunleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.örneklerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // örneklerToolStripMenuItem
            // 
            this.örneklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriEkleToolStripMenuItem,
            this.urunSayısınıVerToolStripMenuItem,
            this.urunStokSayisiniVerToolStripMenuItem,
            this.kategorininUrunleriToolStripMenuItem});
            this.örneklerToolStripMenuItem.Name = "örneklerToolStripMenuItem";
            this.örneklerToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.örneklerToolStripMenuItem.Text = "Örnekler";
            // 
            // kategoriEkleToolStripMenuItem
            // 
            this.kategoriEkleToolStripMenuItem.Name = "kategoriEkleToolStripMenuItem";
            this.kategoriEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kategoriEkleToolStripMenuItem.Text = "KategoriEkle";
            this.kategoriEkleToolStripMenuItem.Click += new System.EventHandler(this.kategoriEkleToolStripMenuItem_Click);
            // 
            // urunSayısınıVerToolStripMenuItem
            // 
            this.urunSayısınıVerToolStripMenuItem.Name = "urunSayısınıVerToolStripMenuItem";
            this.urunSayısınıVerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urunSayısınıVerToolStripMenuItem.Text = "urunSayısınıVer";
            this.urunSayısınıVerToolStripMenuItem.Click += new System.EventHandler(this.urunSayısınıVerToolStripMenuItem_Click);
            // 
            // urunStokSayisiniVerToolStripMenuItem
            // 
            this.urunStokSayisiniVerToolStripMenuItem.Name = "urunStokSayisiniVerToolStripMenuItem";
            this.urunStokSayisiniVerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urunStokSayisiniVerToolStripMenuItem.Text = "urunStokSayisiniVer";
            this.urunStokSayisiniVerToolStripMenuItem.Click += new System.EventHandler(this.urunStokSayisiniVerToolStripMenuItem_Click);
            // 
            // kategorininUrunleriToolStripMenuItem
            // 
            this.kategorininUrunleriToolStripMenuItem.Name = "kategorininUrunleriToolStripMenuItem";
            this.kategorininUrunleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kategorininUrunleriToolStripMenuItem.Text = "Kategorinin Urunleri";
            this.kategorininUrunleriToolStripMenuItem.Click += new System.EventHandler(this.kategorininUrunleriToolStripMenuItem_Click);
            // 
            // FormOrnekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(444, 523);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormOrnekler";
            this.Text = "FormOrnekler";
           
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem örneklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunSayısınıVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunStokSayisiniVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorininUrunleriToolStripMenuItem;
    }
}