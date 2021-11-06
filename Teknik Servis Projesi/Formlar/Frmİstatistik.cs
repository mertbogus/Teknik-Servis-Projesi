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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.TBLURUN.Count().ToString();
            labelControl3.Text = db.TBLKATEGORI.Count().ToString();
            labelControl5.Text = db.TBLURUN.Sum(x=>x.STOK).ToString();
            labelControl18.Text = (from x in db.TBLURUN
                                   orderby x.STOK descending 
                                   select x.AD).FirstOrDefault();
            labelControl16.Text= (from x in db.TBLURUN
                                  orderby x.STOK ascending
                                  select x.AD).FirstOrDefault();
            labelControl12.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT descending
                                   select x.AD).FirstOrDefault();
            labelControl20.Text= (from x in db.TBLURUN
                                  orderby x.SATISFIYAT ascending
                                  select x.AD).FirstOrDefault();
            labelControl23.Text = db.TBLURUN.Count(x => x.KATEGORİ == 4).ToString();
            labelControl21.Text= db.TBLURUN.Count(x => x.KATEGORİ == 1).ToString();
            labelControl29.Text= db.TBLURUN.Count(x => x.KATEGORİ == 3).ToString();
            labelControl33.Text = (from x in db.TBLURUN
                                   select x.MARKA).Distinct().Count().ToString();
            labelControl39.Text = db.TBLURUN.Count().ToString();
            labelControl14.Text = db.MAKSKATEGORİ().FirstOrDefault();

        }

    }
}
