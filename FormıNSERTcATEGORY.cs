using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Ornekler
{
    public partial class FrmInsertCategory : Form
    {
        public FrmInsertCategory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region validation
            DialogResult result = MessageBox.Show("Girdiğiniz veriler ile bir kategori kaydı oluşturulacaktır. Emin misiniz?","Dikkat",MessageBoxButtons.YesNo);
            if(result!=DialogResult.Yes)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace( txtCategoryName.Text))
            {
                MessageBox.Show("Kategori adı alanı boş geçilemez.");
                return;
            }
            #endregion

            //connection nesnesi oluştur
            SqlConnection cnn = new SqlConnection(@"Server=FATIH-PC\SQLEXPRESS;Database=Northwind;Trusted_Connection=true");

            //command nesnesi oluştur
            SqlCommand cmd = new SqlCommand("insert into Categories (CategoryName,Description) values ('"+txtCategoryName.Text+"','"+txtDescription.Text+"')",cnn);
            // string e çevirebilmek için tek tırnak içinde yazıyoruz,2 tırnak 2 + string birleştirme için konuluyor.

            //connection open
            cnn.Open();
            //command execute
            try
            {
              int etkilenenSatirSayisi=  cmd.ExecuteNonQuery();
                if (etkilenenSatirSayisi>0)
                {
                    MessageBox.Show("Kayıt Başarılıdır.");
                }
                else
                {
                    MessageBox.Show("Bir işlem yapılmamıştır.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata nedeniyle kayıt yapılamamıştır.");
            }

            //connection close
            cnn.Close();    //bir daha kullanıcaksam close bir daha hiç kullanmayacaksam dispoze 

        }


        private void FrmInsertCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
