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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        void FaturaListele()
        {
            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.TARIH,
                               u.SAAT,
                               u.SERI,
                               u.SIRANO,
                              CARI= u.TBLCARİ.AD+' '+u.TBLCARİ.SOYAD,
                              PERSONEL=u.TBLPERSONEL.AD+' '+u.TBLPERSONEL.SOYAD
                           };
            gridControl1.DataSource = db.TBLFATURABILGI.ToList();
        }
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            FaturaListele();
            Luecari.Properties.DataSource = (from u in db.TBLCARİ
                                                 select new
                                                 {
                                                     u.ID,
                                                     AD = u.AD +" "+ u.SOYAD
                                                 }).ToList();
            Luepersonel.Properties.DataSource = (from u in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     u.ID,
                                                     AD = u.AD + " " + u.SOYAD
                                                 }).ToList();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLFATURABILGI t = new TBLFATURABILGI();
            t.SERI = Txtsira.Text;
            t.SIRANO = Txtsirano.Text;
            t.TARIH = Convert.ToDateTime(Txttarih.Text);
            t.SAAT = Txtsaat.Text;
            t.VERGIDAIRE = Txtvergidaire.Text;
            t.CARI = int.Parse(Luecari.EditValue.ToString());
            t.PERSONEL = short.Parse(Luepersonel.EditValue.ToString());
            db.TBLFATURABILGI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Bilgisi Kayıt Edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FaturaListele();

        }
        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmKalemPopup fr = new FrmKalemPopup();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
