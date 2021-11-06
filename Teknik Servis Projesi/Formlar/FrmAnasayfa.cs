using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Teknik_Servis_Projesi.Formlar
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            gridControl3.DataSource = (from u in db.TBLURUN
                                       select new
                                       {
                                           u.AD,
                                           u.STOK
                                       }).Where(x => x.STOK < 30).ToList();
            gridControl1.DataSource = (from m in db.TBLCARİ
                                       select new
                                       {
                                           m.AD,
                                           m.SOYAD,
                                           m.İL
                                       }).ToList();
            gridControl2.DataSource = db.URUNKATEGORI().ToList();
            DateTime dt = DateTime.Today;
            var deger = (from x in db.TBLNOTLARIM.OrderBy(y => y.TARİH) where (x.TARİH == dt)
                         select new
                         {

                             x.BASLIK,
                             x.ICERIK
                         }).ToList();
            gridControl4.DataSource = deger;

            string konu1, konu2, konu3, konu4, konu5, konu6,baslik1,baslik2,baslik3,baslik4,baslik5,baslik6;
            konu1 = db.TBLILETISIM.First(x => x.ID == 1).KONU;
            baslik1= db.TBLILETISIM.First(x => x.ID == 1).ADSOYAD;
            konu2 = db.TBLILETISIM.First(x => x.ID == 2).KONU;
            baslik2 = db.TBLILETISIM.First(x => x.ID == 2).ADSOYAD;
            konu3 = db.TBLILETISIM.First(x => x.ID == 3).KONU;
            baslik3 = db.TBLILETISIM.First(x => x.ID == 3).ADSOYAD;
            konu4 = db.TBLILETISIM.First(x => x.ID == 4).KONU;
            baslik4 = db.TBLILETISIM.First(x => x.ID == 4).ADSOYAD;
            konu5 = db.TBLILETISIM.First(x => x.ID == 5).KONU;
            baslik5 = db.TBLILETISIM.First(x => x.ID == 5).ADSOYAD;
            konu6 = db.TBLILETISIM.First(x => x.ID == 6).KONU;
            baslik6 = db.TBLILETISIM.First(x => x.ID == 6).ADSOYAD;
            labelControl1.Text = konu1 + " " + baslik1;
            labelControl2.Text = konu2 + " " + baslik2;
            labelControl3.Text = konu3 + " " + baslik3;
            labelControl4.Text = konu4 + " " + baslik4;
            labelControl5.Text = konu5 + " " + baslik5;
            labelControl6.Text = konu6 + " " + baslik6;

        }
    }
}
