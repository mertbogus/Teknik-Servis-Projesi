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
    public partial class FrmKategoriListele : Form
    {
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        public FrmKategoriListele()
        {
            InitializeComponent();
        }
        void KategoriListeie()
        {
            var degerler = from k in db.TBLKATEGORI
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmKategoriListele_Load(object sender, EventArgs e)
        {
            KategoriListeie();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Txtkategoriad.Text!="" && Txtkategoriad.Text.Length<=30)
            {

            TBLKATEGORI urun = new TBLKATEGORI();
            urun.AD = Txtkategoriad.Text;
            urun.ID = byte.Parse(TxtID.Text);
            db.TBLKATEGORI.Add(urun);
            db.SaveChanges();
            MessageBox.Show("Kategori Kayıt Edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KategoriListeie();
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez. 30 Karakterden Fazla Olamaz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            Txtkategoriad.Text= gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kategoriyi Silmek İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                TBLKATEGORI kategori = new TBLKATEGORI();
                int id = int.Parse(TxtID.Text);
                var degerler = db.TBLKATEGORI.Find(id);
                db.TBLKATEGORI.Remove(degerler);
                db.SaveChanges();
                MessageBox.Show("Kategori Silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (Txtkategoriad.Text != "" && Txtkategoriad.Text.Length <= 30)
            {
                TBLKATEGORI kategori = new TBLKATEGORI();
                int id = int.Parse(TxtID.Text);
                var degerler = db.TBLKATEGORI.Find(id);
                degerler.AD = Txtkategoriad.Text;
                db.TBLKATEGORI.Add(degerler);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez. 30 Karakterden Fazla Olamaz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            TxtID.Text = "";
            Txtkategoriad.Text = "";
        }
    }
}
