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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        void Listele()
        {

            gridControl1.DataSource = db.TBLNOTLARIM.Where(x => x.OKUMA == false).ToList();
            gridControl2.DataSource = db.TBLNOTLARIM.Where(x => x.OKUMA == true).ToList();
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLNOTLARIM nt = new TBLNOTLARIM();
            nt.BASLIK = Txtbaslik.Text;
            nt.ICERIK = Txticerik.Text;
            nt.OKUMA = false;
            nt.TARİH = DateTime.Parse( Txttarih.Text);
            db.TBLNOTLARIM.Add(nt);
            db.SaveChanges();
            MessageBox.Show("Not Sisteme Başarılı Bir Şekilde Eklenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            Txtbaslik.Text= gridView1.GetFocusedRowCellValue("BASLIK").ToString();
            Txticerik.Text= gridView1.GetFocusedRowCellValue("ICERIK").ToString();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (Checkokundu.Checked==true)
            {
                int id = int.Parse(TxtID.Text);
                var degerler = db.TBLNOTLARIM.Find(id);
                degerler.OKUMA = true;
                db.TBLNOTLARIM.Add(degerler);
                db.SaveChanges();
                MessageBox.Show("Not Durumu Değiştirildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
        }
    }
}
