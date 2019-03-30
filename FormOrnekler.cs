using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Ornekler
{
    public partial class FormOrnekler : Form
    {
        public FormOrnekler()
        {
            InitializeComponent();
        }

        private void kategoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsertCategory frm = new FrmInsertCategory();
            frm.MdiParent = this;
            frm.Show();
        }

        private void urunSayısınıVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGenelDurum frm = new FormGenelDurum();
            frm.MdiParent = this;
            frm.Show();
        }

        private void urunStokSayisiniVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStok frm = new FormStok();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kategorininUrunleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUrunListeleme frm = new FormUrunListeleme();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
