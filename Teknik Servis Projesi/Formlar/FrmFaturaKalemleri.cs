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
    public partial class FrmFaturaKalemleri : Form
    {
        public FrmFaturaKalemleri()
        {
            InitializeComponent();
        }
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Txtid.Text!="")
            {
                int id = Convert.ToInt32(Txtid.Text);
                var degerler = (from u in db.TBLFATURADETAY
                                select new
                                {
                                    u.FATURADETAYID,
                                    u.URUN,
                                    u.ADET,
                                    u.FIYAT,
                                    u.TUTAR,
                                    u.FATURAID
                                }).Where(x => x.FATURAID == id);
                gridControl1.DataSource = degerler.ToList();
            }

                var dg = (from u in db.TBLFATURADETAY.Where(x => x.TBLFATURABILGI.SERI == Txtserino.Text | x.TBLFATURABILGI.SIRANO == Txtsirano.Text)
                          select new
                          {
                              u.URUN,
                              u.TBLFATURABILGI.SIRANO,
                              u.TBLFATURABILGI.SERI,
                              u.ADET,
                              u.FIYAT,
                              u.FATURAID,
                              CARİ = u.TBLFATURABILGI.TBLCARİ.AD + " " + u.TBLFATURABILGI.TBLCARİ.SOYAD
                          });
                gridControl1.DataSource = dg.ToList();
            
           

        }
    }
}
