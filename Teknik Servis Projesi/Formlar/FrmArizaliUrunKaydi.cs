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
    public partial class FrmArizaliUrunKaydi : Form
    {
        public FrmArizaliUrunKaydi()
        {
            InitializeComponent();
        }
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        private void Btnkayityap_Click(object sender, EventArgs e)
        {
            TBLURUNKABUL t = new TBLURUNKABUL();
            t.CARİ = int.Parse(lookUpEdit2.EditValue.ToString());
            t.GELISTARIHI = DateTime.Parse( Txttarih.Text);
            t.PERSONEL = short.Parse( lookUpEdit1.EditValue.ToString());
            t.URUNSERINO = Txtserino.Text;
            db.TBLURUNKABUL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Arıza Kaydı Yapılmıştır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureEdit9_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmArizaliUrunKaydi_Load(object sender, EventArgs e)
        {
            //Müşteri
            lookUpEdit2.Properties.DataSource = (from u in db.TBLCARİ
                                                 select new
                                                 {
                                                     u.ID,
                                                     AD=u.AD +" "+ u.SOYAD

             
                                               }).ToList();
            //Personel
            lookUpEdit1.Properties.DataSource = (from u in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     u.ID,
                                                     AD = u.AD + " " + u.SOYAD

                                                 }).ToList();
        }

        private void Txttarih_Click(object sender, EventArgs e)
        {
            Txttarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}
