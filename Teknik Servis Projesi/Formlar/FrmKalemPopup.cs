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
    public partial class FrmKalemPopup : Form
    {
        public FrmKalemPopup()
        {
            InitializeComponent();
        }
        public int id;
        private void FrmKalemPopup_Load(object sender, EventArgs e)
        {
            DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
            gridControl1.DataSource = db.TBLFATURADETAY.Where(x => x.FATURAID == id).ToList();
            gridControl2.DataSource = db.TBLFATURABILGI.Where(x => x.ID == id).ToList();
        }

        private void pictureEdit1_Properties_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.pdf";
            gridControl1.ExportToPdf(path);
            
        }

        private void pictureEdit2_Properties_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.xls";
            gridControl1.ExportToXls(path);
        }
    }
}
