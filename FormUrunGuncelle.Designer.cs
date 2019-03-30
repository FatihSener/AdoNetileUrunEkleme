namespace _02_Ornekler
{
    partial class UrunGuncelle
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
            this.lblProductID = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnUptade = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.nudUnitsInStok = new System.Windows.Forms.NumericUpDown();
            this.txtUnitsPrice = new System.Windows.Forms.TextBox();
            this.lblUnitsInStok = new System.Windows.Forms.Label();
            this.lblUnitsPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.chbDiscontinued = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsInStok)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductID.Location = new System.Drawing.Point(25, 26);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(56, 17);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Ürün ID";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(117, 138);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 24);
            this.cmbCategory.TabIndex = 1;
            // 
            // btnUptade
            // 
            this.btnUptade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUptade.Location = new System.Drawing.Point(159, 195);
            this.btnUptade.Name = "btnUptade";
            this.btnUptade.Size = new System.Drawing.Size(79, 29);
            this.btnUptade.TabIndex = 2;
            this.btnUptade.Text = "Güncelle";
            this.btnUptade.UseVisualStyleBackColor = true;
            this.btnUptade.Click += new System.EventHandler(this.btnUptade_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductID.Location = new System.Drawing.Point(118, 26);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(121, 23);
            this.txtProductID.TabIndex = 3;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(25, 60);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(63, 17);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductName.Location = new System.Drawing.Point(118, 60);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(121, 23);
            this.txtProductName.TabIndex = 3;
            // 
            // nudUnitsInStok
            // 
            this.nudUnitsInStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudUnitsInStok.Location = new System.Drawing.Point(118, 86);
            this.nudUnitsInStok.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudUnitsInStok.Name = "nudUnitsInStok";
            this.nudUnitsInStok.Size = new System.Drawing.Size(120, 23);
            this.nudUnitsInStok.TabIndex = 4;
            // 
            // txtUnitsPrice
            // 
            this.txtUnitsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUnitsPrice.Location = new System.Drawing.Point(118, 112);
            this.txtUnitsPrice.Name = "txtUnitsPrice";
            this.txtUnitsPrice.Size = new System.Drawing.Size(121, 23);
            this.txtUnitsPrice.TabIndex = 3;
            // 
            // lblUnitsInStok
            // 
            this.lblUnitsInStok.AutoSize = true;
            this.lblUnitsInStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitsInStok.Location = new System.Drawing.Point(25, 88);
            this.lblUnitsInStok.Name = "lblUnitsInStok";
            this.lblUnitsInStok.Size = new System.Drawing.Size(72, 17);
            this.lblUnitsInStok.TabIndex = 0;
            this.lblUnitsInStok.Text = "Stok Adeti";
            // 
            // lblUnitsPrice
            // 
            this.lblUnitsPrice.AutoSize = true;
            this.lblUnitsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitsPrice.Location = new System.Drawing.Point(25, 112);
            this.lblUnitsPrice.Name = "lblUnitsPrice";
            this.lblUnitsPrice.Size = new System.Drawing.Size(41, 17);
            this.lblUnitsPrice.TabIndex = 0;
            this.lblUnitsPrice.Text = "Fiyatı";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.Location = new System.Drawing.Point(25, 138);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(71, 17);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategorisi";
            // 
            // chbDiscontinued
            // 
            this.chbDiscontinued.AutoSize = true;
            this.chbDiscontinued.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbDiscontinued.Location = new System.Drawing.Point(104, 168);
            this.chbDiscontinued.Name = "chbDiscontinued";
            this.chbDiscontinued.Size = new System.Drawing.Size(136, 21);
            this.chbDiscontinued.TabIndex = 5;
            this.chbDiscontinued.Text = "Satışı Durduruldu";
            this.chbDiscontinued.UseVisualStyleBackColor = true;
            // 
            // UrunGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 241);
            this.Controls.Add(this.chbDiscontinued);
            this.Controls.Add(this.nudUnitsInStok);
            this.Controls.Add(this.txtUnitsPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.btnUptade);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblUnitsPrice);
            this.Controls.Add(this.lblUnitsInStok);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductID);
            this.Name = "UrunGuncelle";
            this.Text = "Ürün Güncelle";
            this.Load += new System.EventHandler(this.UrunGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsInStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnUptade;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.NumericUpDown nudUnitsInStok;
        private System.Windows.Forms.TextBox txtUnitsPrice;
        private System.Windows.Forms.Label lblUnitsInStok;
        private System.Windows.Forms.Label lblUnitsPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.CheckBox chbDiscontinued;
    }
}