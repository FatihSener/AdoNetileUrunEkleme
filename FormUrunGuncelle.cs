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
    public partial class UrunGuncelle : Form
    {
        public delegate void EventTipi();
        public event EventTipi Guncellendi;
        private Product _product;
        SqlConnection _cnn;
        public UrunGuncelle(Product product)
        {
            InitializeComponent();
            _product = product;
            _cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["BaglantiCumlecigi"].ConnectionString);
        }

        private void UrunGuncelle_Load(object sender, EventArgs e)
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

            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DataSource = categories;

            if (_product.CategoryID!=null)
            {
                cmbCategory.SelectedValue = _product.CategoryID;
            }
            else
            {
                cmbCategory.SelectedIndex = -1;
            }

            txtProductID.Text = _product.ProductID.ToString();
            txtProductName.Text = _product.ProductName;
            nudUnitsInStok.Value = _product.UnitsInStock.Value;
            txtUnitsPrice.Text = _product.UnitPrice.ToString();
            chbDiscontinued.Checked = _product.Discontinued;
        }

        private void btnUptade_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace( txtProductName.Text)) //boş geçilemeyecek her şey için bunu yapmalıyız ya da entity içinde yapmamız gerekiyor valudeyşın işlemlerini
            {
                MessageBox.Show("Ürün adı boş geçilemez.");
                return;
            }
            DialogResult result = MessageBox.Show("Değişiklikler kaydedilecektir.Emin misiniz?","Dikkat",MessageBoxButtons.YesNo);

            if (result!=DialogResult.Yes)
            {
                return;
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _cnn;
            cmd.CommandText = "update Products set " +
                "ProductName=@ProductName " +
                ",CategoryID=@CategoryID " +
                ",Discontinued=@Discontinued " +
                ",UnitsInStock=@UnitsInStock " +
                ",UnitPrice=@UnitPrice " +
                " where ProductID=@ProductID ";

            cmd.Parameters.AddWithValue("@ProductName",txtProductName.Text);
            cmd.Parameters.AddWithValue("@CategoryID", (int)cmbCategory.SelectedValue);
            cmd.Parameters.AddWithValue("@Discontinued", chbDiscontinued.Checked);
            cmd.Parameters.AddWithValue("@UnitsInStock", nudUnitsInStok.Value);
            cmd.Parameters.AddWithValue("@UnitPrice", txtUnitsPrice.Text);
            cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text);

            try
            {
                if (_cnn.State!=ConnectionState.Open)
                {
                    _cnn.Open();
                }
                int ess =cmd.ExecuteNonQuery();//uptdate yaparken result oluşmaz o yüzden nonquery kullanıyoruz
                if (ess==1)
                {
                    MessageBox.Show("Güncelleme Başarılı.");
                    Guncellendi();
                    this.Close();
                }
                else if (ess>1)
                {
                    throw new Exception("birden fazla işlem");
                }
                else
                {
                    MessageBox.Show("Herhangi bir kayıt güncellenmedi.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata nedeniyle güncelleme yapılamadı.");
            }
            finally
            {
                _cnn.Close();
            }
        }

    }
}
