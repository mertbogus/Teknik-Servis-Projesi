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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        int secilen;
        void Carilistele()
        {
            gridControl1.DataSource = (from x in db.TBLCARİ
                                       select new
                                       {
                                           x.ID,
                                           x.AD,
                                           x.SOYAD,
                                           x.İL,
                                           x.İLCE,

                                       }
                                       ).ToList();
        }
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            Carilistele();
            labelControl18.Text = db.TBLCARİ.Count().ToString();
            Lkil.Properties.DataSource = (from u in db.iller
                                                 select new
                                                 {
                                                     u.id,
                                                     u.sehir

                                                 }).ToList();

            labelControl14.Text = db.iller.Distinct().Count().ToString();
            labelControl12.Text= db.ilceler.Distinct().Count().ToString();
            
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(Lkil.EditValue.ToString());
            Lkilce.Properties.DataSource = (from u in db.ilceler
                                                 select new
                                                 {
                                                     u.id,
                                                     u.ilce,
                                                     u.sehir

                                                 }).Where(x=>x.sehir==secilen).ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLCARİ cari = new TBLCARİ();
            cari.AD = Txtad.Text;
            cari.SOYAD = Txtsoyad.Text;
            cari.TELEFON = Txttelefon.Text;
            cari.İL = Lkil.EditValue.ToString();
            cari.İLCE = Lkilce.EditValue.ToString();
            cari.BANKA = Txtbanka.Text;
            cari.VERGIDAIRESI = Txtvergidaire.Text;
            cari.VERGINO = Txtvergino.Text;
            cari.STATÜ = Txtstatü.Text;
            cari.ADRES = Txtadres.Text;
            db.TBLCARİ.Add(cari);
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            TBLCARİ cari = new TBLCARİ();
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLCARİ.Find(id);
            db.TBLCARİ.Remove(deger);
            MessageBox.Show("Cari Başarıyla Silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
