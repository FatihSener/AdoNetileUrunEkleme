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
    public partial class FormUrunListeleme : Form
    {
        SqlConnection _cnn;

        public FormUrunListeleme()
        {
            InitializeComponent();
            _cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["BaglantiCumlecigi"].ConnectionString);
        }

        private void FormUrunListeleme_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Categories", _cnn);

            if (_cnn.State != ConnectionState.Open)
            {
                _cnn.Open();
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
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                _cnn.Close();
            }

            cmbKategoriler.DisplayMember = "CategoryName";
            cmbKategoriler.ValueMember = "CategoryID";
            cmbKategoriler.DataSource = categories;

        }
        // her olay için aç kapa yapıyoruz connected mimari dediğimz olay bu !!
        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductListYukle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndices.Count == 0) // list boxs ın içinde seçilmiş indeksler
            {
                MessageBox.Show("Silme işlemi için önce bir ürün seçmeniz gerekmektedir.");
                return;
            }

            DialogResult result = MessageBox.Show(((Product)lstUrunler.SelectedItem).ProductName + " isimli ürün silinecektir.Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
            {
                return;
            }

            SqlCommand cmd = new SqlCommand("Delete from Products where ProductID=@ProductID", _cnn);
            cmd.Parameters.AddWithValue("@ProductID", lstUrunler.SelectedValue);

            try
            {
                if (_cnn.State != ConnectionState.Open)
                {
                    _cnn.Open();
                }
                int etkilenenSatirSayisi = cmd.ExecuteNonQuery();
                if (etkilenenSatirSayisi == 1)
                {
                    MessageBox.Show("Silme işlemi başarı ile tamamlanmıştır.");
                }
                else if (etkilenenSatirSayisi > 1)
                {
                    throw new Exception(lstUrunler.SelectedValue + " id numarası ile birden fazla ürün silinmiştir");
                }
                else
                {
                    MessageBox.Show("Herhangi silme işlemi gerçekleşmemiştir", "Hata");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Bir hata nedeniyle silme işlemi gerçekleşemedi!", "Hata");
                //loglama -- düzgün bir hata mesajı gösterme - admine ilgili hatayı ilgili parametrelerle beraber mail atma
            }

            finally
            {
                _cnn.Close();
            }
            //lstUrunler ögesini yeniden yükle.
            ProductListYukle();
        }

        public void ProductListYukle()
        {
            lstUrunler.DataSource = null;
            if (cmbKategoriler.SelectedIndex == -1) //hiç bir şey seçilmedi anlamında (combobox o ile başlıyor 2. seçersem 1. olmuş oluyor)
            {

                return;
            }

            int categoryId = (int)cmbKategoriler.SelectedValue;
            SqlCommand cmd = new SqlCommand("Select * from Products where CategoryID=" + categoryId, _cnn); //3. overlad ı kullanıyoruz.

            if (_cnn.State != ConnectionState.Open)
            {
                _cnn.Open();
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
                        product.ProductName =  dr["ProductName"].ToString();
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
                _cnn.Close();
            }

            lstUrunler.DisplayMember = "ProductName";
            lstUrunler.ValueMember = "ProductID";
            lstUrunler.DataSource = products;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem==null)
            {
                MessageBox.Show("Güncelleme işlemi öncesinde bir ürün seçmelisiniz.");
                return;
            }

            UrunGuncelle frm = new UrunGuncelle((Product)lstUrunler.SelectedItem);
            frm.Guncellendi += ProductListYukle;
            frm.MdiParent = this.MdiParent;
            frm.Show();
           
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FormUrunEkle frm = new FormUrunEkle();
            frm.Eklendi += ProductListYukle;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
    }

