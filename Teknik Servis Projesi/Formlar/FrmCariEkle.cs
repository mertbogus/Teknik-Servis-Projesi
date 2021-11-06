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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        private void pictureEdit11_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            TBLCARİ tbl = new TBLCARİ();
            tbl.AD = Txtad.Text;
            tbl.SOYAD = Txtsoyad.Text;
            tbl.TELEFON = Txttelefon.Text;
            tbl.İL = Lkil.EditValue.ToString(); 
            tbl.İLCE = lookUpEdit1.EditValue.ToString();
            db.TBLCARİ.Add(tbl);
            db.SaveChanges();
            MessageBox.Show("Yeni Cari Tanımlandı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        int secilen;
        private void FrmCariEkle_Load(object sender, EventArgs e)
        {
            Lkil.Properties.DataSource = (from u in db.iller
                                          select new
                                          {
                                              u.id,
                                              u.sehir

                                          }).ToList();


        }

        private void Lkil_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(Lkil.EditValue.ToString());
            lookUpEdit1.Properties.DataSource = (from u in db.ilceler
                                            select new
                                            {
                                                u.id,
                                                u.ilce,
                                                u.sehir

                                            }).Where(x => x.sehir == secilen).ToList();
        }
    }
}
