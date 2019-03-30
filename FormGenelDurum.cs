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
    public partial class FormGenelDurum : Form
    {
        public FormGenelDurum()
        {
            InitializeComponent();
        }

        private void FormGenelDurum_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Server=FATIH-PC\SQLEXPRESS;Database=Northwind;Trusted_Connection=true";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Select count(*) from Products "; //result sete her zaman son sorgu yansır

            cnn.Open();
            //sclar ile reader result sete bakar
            try
            {
               txtUrunSayisi.Text= cmd.ExecuteScalar().ToString(); //1.hücreyi okuyup obje formatında dönüyor ondan dönüştüyoruz.
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem Yapılamadı.");
            }

            cnn.Close();

        }

        private void txtUrunSayisi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
