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
    public partial class ArizaliUrunDetayListesi : Form
    {
        public ArizaliUrunDetayListesi()
        {
            InitializeComponent();
        }
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        private void ArizaliUrunDetayListesi_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLURUNTAKIP
                           select new
                           {
                               u.TAKIPID,
                               u.SERINO,
                               u.TARIH,
                               u.ACIKLAMA
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
