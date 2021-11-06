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
    public partial class FrmArizaDetaylar : Form
    {
        public FrmArizaDetaylar()
        {
            InitializeComponent();
        }
        public string arizaid,serino;
        private void pictureEdit9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        private void Btnguncelle_Click(object sender, EventArgs e)
        {
            TBLURUNTAKIP t = new TBLURUNTAKIP();
            t.ACIKLAMA = Rchariza.Text;
            t.SERINO = Txtserino.Text;
            t.TARIH = DateTime.Parse(Txttarih.Text);
            db.TBLURUNTAKIP.Add(t);

            //Durum Güncelleme
            TBLURUNKABUL kbl = new TBLURUNKABUL();
            int id = int.Parse(arizaid);
            var deger = db.TBLURUNKABUL.Find(id);
            kbl.DURUMDETAY = comboBox1.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Arıza Detayları Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            Txttarih.Text = DateTime.Now.ToShortDateString();
        }

        private void FrmArizaDetaylar_Load(object sender, EventArgs e)
        {
            Txtserino.Text = serino;
        }
    }
}
