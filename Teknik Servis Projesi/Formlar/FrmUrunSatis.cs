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
    public partial class FrmUrunSatis : Form
    {
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        public FrmUrunSatis()
        {
            InitializeComponent();
        }

        private void pictureEdit9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            TBLURUNHAREKET urnhareket = new TBLURUNHAREKET();
            urnhareket.URUN = int.Parse(Lkurun.EditValue.ToString());
            urnhareket.MUSTERI = int.Parse(Lkmusteri.EditValue.ToString());
            urnhareket.PERSONEL = short.Parse(Lkpersonel.EditValue.ToString());
            urnhareket.TARIH = DateTime.Parse( Txttarih.Text);
            urnhareket.ADET = short.Parse(Txtadet.Text);
            urnhareket.FIYAT = decimal.Parse(Txtsatisfiyat.Text);
            urnhareket.URUNSERINO = Txtserino.Text;
            db.TBLURUNHAREKET.Add(urnhareket);
            db.SaveChanges();
            MessageBox.Show("Ürünün satışı gerçekleşmiştir. ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmUrunSatis_Load(object sender, EventArgs e)
        {
            Lkurun.Properties.DataSource = (from u in db.TBLURUN
                                          select new
                                          {
                                              u.ID,
                                              u.AD

                                          }).ToList();

            Lkmusteri.Properties.DataSource = (from u in db.TBLCARİ
                                            select new
                                            {
                                                u.ID,
                                                AD=u.AD +" "+u.SOYAD

                                            }).ToList();

            Lkpersonel.Properties.DataSource = (from u in db.TBLPERSONEL
                                               select new
                                               {
                                                   u.ID,
                                                   AD = u.AD + " " + u.SOYAD

                                               }).ToList();
        }
    }
}
