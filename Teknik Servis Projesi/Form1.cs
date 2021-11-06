using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teknik_Servis_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Formlar.UrunListele urnliste;
        private void BtnUrunListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (urnliste == null || urnliste.IsDisposed)
            {
                urnliste = new Formlar.UrunListele();
                urnliste.MdiParent = this;
                urnliste.Show();
            }
        }

        private void BtYeniurun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniUrun yeniurun = new Formlar.FrmYeniUrun();
            yeniurun.Show();
        }
        Formlar.FrmKategoriListele kategori;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (kategori == null || kategori.IsDisposed)
            {
                kategori = new Formlar.FrmKategoriListele();
                kategori.MdiParent = this;
                kategori.Show();
            }
            
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniKategori yeni = new Formlar.FrmYeniKategori();
            yeni.Show();
        }
        Formlar.Frmİstatistik ist;
        private void Btnistatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ist == null || ist.IsDisposed)
            {
                ist = new Formlar.Frmİstatistik();
                ist.MdiParent = this;
                ist.Show();
            }
        }

        private void Btnmarkaistatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmMarkalar marka = new Formlar.FrmMarkalar();
            marka.MdiParent = this;
            marka.Show();
        }
        Formlar.FrmCariListesi cariliste;
        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cariliste == null || cariliste.IsDisposed)
            {
                cariliste = new Formlar.FrmCariListesi();
                cariliste.MdiParent = this;
                cariliste.Show();
            }
        }
        Formlar.FrmCariİller cariiller;
        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cariiller == null || cariiller.IsDisposed)
            {
                cariiller = new Formlar.FrmCariİller();
                cariiller.MdiParent = this;
                cariiller.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariEkle cari = new Formlar.FrmCariEkle();
            cari.Show();
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmDepartmanListesi departman = new Formlar.FrmDepartmanListesi();
            departman.MdiParent = this;
            departman.Show();
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniDepartman dp = new Formlar.FrmYeniDepartman();
            dp.Show();
        }
        Formlar.FrmPersonel prs;
        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (prs == null || prs.IsDisposed)
            {
                prs = new Formlar.FrmPersonel();
                prs.MdiParent = this;
                prs.Show();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (sts == null)
            {
                sts = new Formlar.FrmAnasayfa();
                sts.MdiParent = this;
                sts.Show();
            }
        }

        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }
        Formlar.FrmKurlar krl;
        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (krl == null || krl.IsDisposed)
            {
                krl = new Formlar.FrmKurlar();
                krl.MdiParent = this;
                krl.Show();
            }
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }
        Formlar.FrmYoutube yt;
        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (yt == null || yt.IsDisposed)
            {
                yt= new Formlar.FrmYoutube();
                yt.MdiParent = this;
                yt.Show();
            }
           
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        Formlar.FrmNotlar ajd;
        private void btnajanda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (ajd == null || ajd.IsDisposed)
            {
                ajd = new Formlar.FrmNotlar();
                ajd.MdiParent = this;
                ajd.Show();
            }
           
        }
        Formlar.FrmArızaListesi arzl;
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (arzl == null || arzl.IsDisposed)
            {
                arzl = new Formlar.FrmArızaListesi();
               arzl.MdiParent = this;
                arzl.Show();
            }
        }
            
        

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmUrunSatis urn = new Formlar.FrmUrunSatis();
            urn.Show();
        }

        private void BtnSatisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmSatisListesi sts = new Formlar.FrmSatisListesi();
            sts.MdiParent = this;
            sts.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaliUrunKaydi urn = new Formlar.FrmArizaliUrunKaydi();
            urn.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaDetaylar urn = new Formlar.FrmArizaDetaylar();
            urn.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.ArizaliUrunDetayListesi sts = new Formlar.ArizaliUrunDetayListesi();
            sts.MdiParent = this;
            sts.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FRMQRCode urn = new Formlar.FRMQRCode();
            urn.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFaturaListesi sts = new Formlar.FrmFaturaListesi();
            sts.MdiParent = this;
            sts.Show();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFaturaKalem sts = new Formlar.FrmFaturaKalem();
            sts.MdiParent = this;
            sts.Show();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFaturaKalemleri sts = new Formlar.FrmFaturaKalemleri();
            sts.MdiParent = this;
            sts.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGaugue sts = new Formlar.FrmGaugue();
            sts.MdiParent = this;
            sts.Show();
        }
        Formlar.FrmHarita hrt;
        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hrt == null || hrt.IsDisposed)
            {
                hrt = new Formlar.FrmHarita();
                hrt.MdiParent = this;
                hrt.Show();
            }
        }
        Formlar.FrmAnasayfa sts;
        private void barButtonItem42_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sts==null || sts.IsDisposed)
            {
                sts = new Formlar.FrmAnasayfa();
                sts.MdiParent = this;
                sts.Show();
            }
            
        }

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        Formlar.FrmRehber rehber;
        private void barButtonItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rehber == null || rehber.IsDisposed)
            {
                rehber = new Formlar.FrmRehber();
                rehber.MdiParent = this;
               rehber.Show();
            }
        }
        Formlar.FrmGelenMesajlar mesajlar;
        private void barButtonItem38_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mesajlar == null || mesajlar.IsDisposed)
            {
                mesajlar = new Formlar.FrmGelenMesajlar();
                mesajlar.MdiParent = this;
                mesajlar.Show();
            }
        }
        Formlar.FrmMailGonder mailg;
        private void barButtonItem39_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mailg == null || mailg.IsDisposed)
            {
                mailg = new Formlar.FrmMailGonder();
               mailg.Show();
            }
        }
    }
}
