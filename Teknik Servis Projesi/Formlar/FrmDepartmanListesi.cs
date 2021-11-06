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
    public partial class FrmDepartmanListesi : Form
    {
        public FrmDepartmanListesi()
        {
            InitializeComponent();
        }
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        void DepartmanListele()
        {
            var degerler = from u in db.TBLDEPARTMAN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.ACIKLAMA
                           };
            gridControl1.DataSource = degerler.ToList();
            labelControl18.Text = db.TBLDEPARTMAN.Count().ToString();
            labelControl16.Text = db.TBLPERSONEL.Count().ToString();
        }
        private void FrmDepartmanListesi_Load(object sender, EventArgs e)
        {
            DepartmanListele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN dp = new TBLDEPARTMAN();
            if (Txtdepartmanadi.Text.Length<=50 && Txtdepartmanadi.Text!=null && Rchaciklama.Text.Length>=1)
            {
                dp.AD = Txtdepartmanadi.Text;
                dp.ACIKLAMA = Rchaciklama.Text;
                db.TBLDEPARTMAN.Add(dp);
                db.SaveChanges();
                MessageBox.Show("Yeni Departman Oluşturuldu.", "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DepartmanListele();
            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı. Departman veya açıklama boş olamaz. Departman ismi 50 karakter üstü olamaz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var degerler = db.TBLDEPARTMAN.Find(id);
            db.TBLDEPARTMAN.Remove(degerler);
            db.SaveChanges();
            MessageBox.Show("Seçili Departman Silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var degerler = db.TBLDEPARTMAN.Find(id);
            degerler.AD = Txtdepartmanadi.Text;
            degerler.ACIKLAMA = Rchaciklama.Text;
            db.SaveChanges();
            MessageBox.Show("Seçili Departman Başarıyla Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            Txtdepartmanadi.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            Rchaciklama.Text= gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
        }
    }
}
