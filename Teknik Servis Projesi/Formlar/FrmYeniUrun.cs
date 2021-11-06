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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from u in db.TBLKATEGORI
                                                 select new
                                                 {
                                                     u.ID,
                                                     u.AD
                                                 }).ToList();
        }

        private void Btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
            TBLURUN urun = new TBLURUN();
            urun.AD = Txturunadi.Text;
            urun.MARKA = Txtmarka.Text;
            urun.KATEGORİ = byte.Parse(lookUpEdit1.EditValue.ToString());
            urun.ALISFIYAT = decimal.Parse(Txtalisfiyat.Text);
            urun.SATISFIYAT = decimal.Parse(Txtsatisfiyat.Text);
            urun.STOK = short.Parse(Txtstok.Text);
            db.TBLURUN.Add(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kayıt Edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Txturunadi_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Txturunadi_Click(object sender, EventArgs e)
        {
            Txturunadi.Text = "";
            Txturunadi.Focus();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
