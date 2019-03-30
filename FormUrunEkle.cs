using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Ornekler
{
    public partial class FormUrunEkle : Form
    {
        SqlConnection cnn = new SqlConnection(@"Server=FATIH-PC\SQLEXPRESS;Database=Northwind;Trusted_Connection=true");

        public delegate void EventTipi();
        public event EventTipi Eklendi;

        public FormUrunEkle()
        {
            InitializeComponent();           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            #region validation
            DialogResult result = MessageBox.Show("Girdiğiniz veriler ile bir kategori kaydı oluşturulacaktır. Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("Kategori adı alanı boş geçilemez.");
                return;
            }
            #endregion


            Product product = new Product();
            product.CategoryID = (int)cmbCategory.SelectedValue;
            product.ProductName = txtProductName.Text;
            product.UnitPrice = Convert.ToDecimal(txtUnitsPrice.Text);
            product.CategoryID = (int)cmbCategory.SelectedValue;
        
            product.Discontinued = chbDiscontinued.Checked;

            SqlCommand cmd = new SqlCommand("insert into Products (ProductName,UnitsInStock,UnitPrice,CategoryID,Discontinued) values" + "('" + txtProductName.Text + "','" + nudUnitsInStok.Value + "','" + txtUnitsPrice.Text + "','" 
                + cmbCategory.SelectedValue + "','" + chbDiscontinued.Checked + "')", cnn);            
   
            try
            {
                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }


                int ess = cmd.ExecuteNonQuery();
                if (ess == 1)
                {
                    MessageBox.Show("Ürün ekleme başarılı şekilde gerçekleşmiştir.");
                    Eklendi();
                    this.Close();
                }
                else if (ess > 1)
                {
                    MessageBox.Show("1den fazla ürün eklenmiştir");
                }
                else
                {
                    MessageBox.Show("Bir hata sebebiyle ürün ekleme gerçekleşememiştir.");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Bir hata nedeniyle kayıt yapılamamıştır.");
            }

            //connection close
            cnn.Close();    //bir daha kullanıcaksam close bir daha hiç kullanmayacaksam dispoze 
        }

        private void ProductListYukle()
        {
            //lstUrunler.DataSource = null;
            if (cmbCategory.SelectedIndex == -1) //hiç bir şey seçilmedi anlamında (combobox o ile başlıyor 2. seçersem 1. olmuş oluyor)
            {

                return;
            }

            int categoryId = (int)cmbCategory.SelectedValue;
            SqlCommand cmd = new SqlCommand("Select * from Products where CategoryID=" + categoryId, cnn); //3. overlad ı kullanıyoruz.

            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }
            List<Product> products = new List<Product>();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        Product product = new Product();
                        product.ProductID = (int)dr["ProductID"];
                        product.ProductName = dr["ProductName"].ToString();
                        product.Discontinued = (bool)dr["Discontinued"];
                        product.CategoryID = (int?)dr["CategoryID"]; // null olabilir diye böyle yapıyoruz.
                        product.UnitPrice = (decimal?)dr["UnitPrice"];
                        product.UnitsInStock = (short?)dr["UnitsInStock"];

                        products.Add(product);
                    }
                }
                dr.Close(); // reader ı da kapatmamız lazım canlı kalmaması için , bakış açısı gibi düşünüyoruz.
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cnn.Close();
            }

            //lstUrunler.DisplayMember = "ProductName";
            //lstUrunler.ValueMember = "ProductID";
            //lstUrunler.DataSource = products;
        }

        private void FormUrunEkle_Load(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("select * from Categories", cnn);

            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }
            List<Category> categories = new List<Category>();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows) //herhangi bir satır var mı diye yazdık
                {
                    while (dr.Read())
                    {
                        Category category = new Category();
                        category.CategoryID = (int)dr[0];
                        category.CategoryName = dr["CategoryName"].ToString();
                        categories.Add(category);

                    }

                }
                dr.Close();
            }
            catch (Exception exe)
            {
                throw;
            }
            finally
            {
                cnn.Close();
            }

            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DataSource = categories;

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductListYukle();
        }
    }
}
