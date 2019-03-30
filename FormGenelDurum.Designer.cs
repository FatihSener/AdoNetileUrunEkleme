namespace _02_Ornekler
{
    partial class FormGenelDurum
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
            this.lblUrunSayisi = new System.Windows.Forms.Label();
            this.txtUrunSayisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUrunSayisi
            // 
            this.lblUrunSayisi.AutoSize = true;
            this.lblUrunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunSayisi.Location = new System.Drawing.Point(13, 13);
            this.lblUrunSayisi.Name = "lblUrunSayisi";
            this.lblUrunSayisi.Size = new System.Drawing.Size(104, 24);
            this.lblUrunSayisi.TabIndex = 0;
            this.lblUrunSayisi.Text = "Ürün Sayısı";
            // 
            // txtUrunSayisi
            // 
            this.txtUrunSayisi.Location = new System.Drawing.Point(176, 16);
            this.txtUrunSayisi.Name = "txtUrunSayisi";
            this.txtUrunSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunSayisi.TabIndex = 1;
            this.txtUrunSayisi.TextChanged += new System.EventHandler(this.txtUrunSayisi_TextChanged);
            // 
            // FormGenelDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 51);
            this.Controls.Add(this.txtUrunSayisi);
            this.Controls.Add(this.lblUrunSayisi);
            this.Name = "FormGenelDurum";
            this.Text = "FormGenelDurum";
            this.Load += new System.EventHandler(this.FormGenelDurum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrunSayisi;
        private System.Windows.Forms.TextBox txtUrunSayisi;
    }
}