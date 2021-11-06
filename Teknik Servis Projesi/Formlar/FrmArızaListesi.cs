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
    public partial class FrmArızaListesi : Form
    {
        public FrmArızaListesi()
        {
            InitializeComponent();
        }
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        void ArizaListesi()
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.ISLEMID,
                               x.URUNSERINO,
                               CARİ = x.TBLCARİ.AD + " " + x.TBLCARİ.SOYAD,
                               PERSONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                               x.GELISTARIHI,
                               x.CIKISTARIHI,
                               x.DURUMDETAY

                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmArızaListesi_Load(object sender, EventArgs e)
        {
            ArizaListesi();
            labelControl2.Text = db.TBLURUNKABUL.Count(x => x.DURUMDETAY == "Mesaj Bekliyor.").ToString();
            labelControl5.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == false).ToString();
            labelControl3.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == true).ToString();
            labelControl16.Text = db.TBLURUN.Count().ToString();
            labelControl2.Text = db.TBLURUNKABUL.Count(x => x.DURUMDETAY == "Parça Bekliyor.").ToString();
            labelControl14.Text= db.TBLURUNKABUL.Count(x => x.DURUMDETAY == "İptal Bekliyor.").ToString();


            SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-KEJIT91;Initial Catalog=DBTekniKServis;Integrated Security=True");
            bgl.Open();
            SqlCommand kmt = new SqlCommand("SELECT DURUMDETAY,COUNT(*) FROM TBLURUNKABUL GROUP BY DURUMDETAY",bgl);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            bgl.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmArizaDetaylar fr = new FrmArizaDetaylar();
            fr.arizaid = gridView1.GetFocusedRowCellValue("ISLEMID").ToString();
            fr.serino = gridView1.GetFocusedRowCellValue("URUNSERINO").ToString();
            fr.Show();
        }
    }
}
