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
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }
        void Listele()
        {
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLFATURADETAY d = new TBLFATURADETAY();
            d.URUN = Txturun.Text;
            d.ADET = short.Parse(Txtadet.Text);
            d.FIYAT = decimal.Parse(Txtfiyat.Text);
            d.TUTAR = decimal.Parse(Txttutar.Text);
            d.FATURAID = int.Parse(Txtfaturaıd.Text);
            db.TBLFATURADETAY.Add(d);
            db.SaveChanges();
            MessageBox.Show("Fatura Kalem Girdisi Başarıyla Kayıt Edilmiştir.", "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }
    }
}
