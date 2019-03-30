namespace _02_Ornekler
{
    partial class FormStok
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
            this.lblStoktakiUrunSayisi = new System.Windows.Forms.Label();
            this.txtStoktakiUrunSayisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStoktakiUrunSayisi
            // 
            this.lblStoktakiUrunSayisi.AutoSize = true;
            this.lblStoktakiUrunSayisi.Location = new System.Drawing.Point(22, 13);
            this.lblStoktakiUrunSayisi.Name = "lblStoktakiUrunSayisi";
            this.lblStoktakiUrunSayisi.Size = new System.Drawing.Size(102, 13);
            this.lblStoktakiUrunSayisi.TabIndex = 0;
            this.lblStoktakiUrunSayisi.Text = "Stoktaki Ürün Sayısı";
            // 
            // txtStoktakiUrunSayisi
            // 
            this.txtStoktakiUrunSayisi.Location = new System.Drawing.Point(176, 13);
            this.txtStoktakiUrunSayisi.Name = "txtStoktakiUrunSayisi";
            this.txtStoktakiUrunSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtStoktakiUrunSayisi.TabIndex = 1;

            // 
            // FormStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 50);
            this.Controls.Add(this.txtStoktakiUrunSayisi);
            this.Controls.Add(this.lblStoktakiUrunSayisi);
            this.Name = "FormStok";
            this.Text = "FormStok";
            this.Load += new System.EventHandler(this.FormStok_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStoktakiUrunSayisi;
        private System.Windows.Forms.TextBox txtStoktakiUrunSayisi;
    }
}