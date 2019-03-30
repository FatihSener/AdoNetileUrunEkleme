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
    public partial class FormStok : Form
    {
        public FormStok()
        {
            InitializeComponent();
        }

        private void FormStok_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Server=FATIH-PC\SQLEXPRESS;Database=Northwind;Trusted_Connection=true";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Select sum(UnitsInStock) from Products "; 

            cnn.Open();
        
            try
            {
                txtStoktakiUrunSayisi.Text = cmd.ExecuteScalar().ToString(); 
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem Yapılamadı.");
            }
            finally // ister başarılı ol ister başarısız ol return bile yazılsa çalışıcak metotdur.
            {
              cnn.Close();
            }
           
        }
    }
}
