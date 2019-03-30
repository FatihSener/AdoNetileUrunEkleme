namespace _02_Ornekler
{
    partial class FormUrunEkle
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
            this.chbDiscontinued = new System.Windows.Forms.CheckBox();
            this.nudUnitsInStok = new System.Windows.Forms.NumericUpDown();
            this.txtUnitsPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblUnitsPrice = new System.Windows.Forms.Label();
            this.lblUnitsInStok = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsInStok)).BeginInit();
            this.SuspendLayout();
            // 
            // chbDiscontinued
            // 
            this.chbDiscontinued.AutoSize = true;
            this.chbDiscontinued.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbDiscontinued.Location = new System.Drawing.Point(91, 126);
            this.chbDiscontinued.Name = "chbDiscontinued";
            this.chbDiscontinued.Size = new System.Drawing.Size(136, 21);
            this.chbDiscontinued.TabIndex = 15;
            this.chbDiscontinued.Text = "Satışı Durduruldu";
            this.chbDiscontinued.UseVisualStyleBackColor = true;
            // 
            // nudUnitsInStok
            // 
            this.nudUnitsInStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudUnitsInStok.Location = new System.Drawing.Point(105, 44);
            this.nudUnitsInStok.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudUnitsInStok.Name = "nudUnitsInStok";
            this.nudUnitsInStok.Size = new System.Drawing.Size(120, 23);
            this.nudUnitsInStok.TabIndex = 14;
            // 
            // txtUnitsPrice
            // 
            this.txtUnitsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUnitsPrice.Location = new System.Drawing.Point(105, 70);
            this.txtUnitsPrice.Name = "txtUnitsPrice";
            this.txtUnitsPrice.Size = new System.Drawing.Size(121, 23);
            this.txtUnitsPrice.TabIndex = 12;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductName.Location = new System.Drawing.Point(105, 18);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(121, 23);
            this.txtProductName.TabIndex = 13;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(146, 153);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(79, 29);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(104, 96);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 24);
            this.cmbCategory.TabIndex = 10;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.Location = new System.Drawing.Point(12, 96);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(71, 17);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Kategorisi";
            // 
            // lblUnitsPrice
            // 
            this.lblUnitsPrice.AutoSize = true;
            this.lblUnitsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitsPrice.Location = new System.Drawing.Point(12, 70);
            this.lblUnitsPrice.Name = "lblUnitsPrice";
            this.lblUnitsPrice.Size = new System.Drawing.Size(41, 17);
            this.lblUnitsPrice.TabIndex = 7;
            this.lblUnitsPrice.Text = "Fiyatı";
            // 
            // lblUnitsInStok
            // 
            this.lblUnitsInStok.AutoSize = true;
            this.lblUnitsInStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitsInStok.Location = new System.Drawing.Point(12, 46);
            this.lblUnitsInStok.Name = "lblUnitsInStok";
            this.lblUnitsInStok.Size = new System.Drawing.Size(72, 17);
            this.lblUnitsInStok.TabIndex = 8;
            this.lblUnitsInStok.Text = "Stok Adeti";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(12, 18);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(63, 17);
            this.lblProductName.TabIndex = 9;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // FormUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 200);
            this.Controls.Add(this.chbDiscontinued);
            this.Controls.Add(this.nudUnitsInStok);
            this.Controls.Add(this.txtUnitsPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblUnitsPrice);
            this.Controls.Add(this.lblUnitsInStok);
            this.Controls.Add(this.lblProductName);
            this.Name = "FormUrunEkle";
            this.Text = "FormUrunEkle";
            this.Load += new System.EventHandler(this.FormUrunEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsInStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbDiscontinued;
        private System.Windows.Forms.NumericUpDown nudUnitsInStok;
        private System.Windows.Forms.TextBox txtUnitsPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblUnitsPrice;
        private System.Windows.Forms.Label lblUnitsInStok;
        private System.Windows.Forms.Label lblProductName;
    }
}