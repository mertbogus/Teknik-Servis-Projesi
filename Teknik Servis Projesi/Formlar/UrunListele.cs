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
    public partial class UrunListele : Form
    {
        public UrunListele()
        {
            InitializeComponent();
        }
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        void Listele()
        {
            //var degerler = db.TBLURUN.ToList();
            var degerler = from u in db.TBLURUN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.MARKA,
                               u.STOK,
                              KATEGORİ= u.TBLKATEGORI.AD,
                               u.ALISFIYAT,
                               u.SATISFIYAT,

                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void UrunListele_Load(object sender, EventArgs e)
        {
            Listele();
            lookUpEdit1.Properties.DataSource = db.TBLKATEGORI.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.AD = Txturunad.Text;
            t.MARKA = Txtmarka.Text;
            t.ALISFIYAT = decimal.Parse(Txtalisfiyat.Text);
            t.SATISFIYAT= decimal.Parse(Txtsatisfiyat.Text);
            t.STOK = short.Parse(Txtstok.Text);
            t.DURUM = false;
            t.KATEGORİ = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kayıt Edildi.", "İşlem Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                Txturunad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                Txtmarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
                Txtstok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
                Txtalisfiyat.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
                Txtsatisfiyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata", "Hata Ekranı");
            }
            

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Seçili Ürün Silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLURUN.Find(id);
            deger.AD = Txturunad.Text;
            deger.MARKA = Txtmarka.Text;
            deger.STOK = short.Parse(Txtstok.Text);
            deger.ALISFIYAT = decimal.Parse(Txtalisfiyat.Text);
            deger.SATISFIYAT = decimal.Parse(Txtsatisfiyat.Text);
            deger.KATEGORİ = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi.", "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            TxtID.Text = "";
            Txturunad.Text = "";
            Txtmarka.Text = "";
            Txtstok.Text = "";
            Txtsatisfiyat.Text = "";
            Txtalisfiyat.Text = "";
        }
    }
}
