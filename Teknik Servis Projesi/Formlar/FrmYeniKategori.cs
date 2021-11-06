using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teknik_Servis_Projesi.Formlar
{
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Txtkategoriadi.Text!="" && Txtkategoriadi.Text.Length<=30)
            {
                TBLKATEGORI urun = new TBLKATEGORI();
                urun.AD = Txtkategoriadi.Text;
                db.TBLKATEGORI.Add(urun);
                db.SaveChanges();
                MessageBox.Show("Kategori Kayıt Edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Kategori Adını 0-30 Karakter Arasında Girin.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
