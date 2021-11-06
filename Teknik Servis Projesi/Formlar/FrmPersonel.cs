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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        void PersonelListele()
        {
           
                var degerler = from u in db.TBLPERSONEL
                               select new
                               {
                                   u.ID,
                                   u.AD,
                                   u.SOYAD,
                                   u.MAIL,
                                   u.TELEFON,
                                   u.DEPARTMAN
                               };
                gridControl1.DataSource = degerler.ToList();
            }
        
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            Lkdepartman.Properties.DataSource = (from u in db.TBLDEPARTMAN
                                                select new
                                                {
                                                    u.ID,
                                                    u.AD

                                                }).ToList();
            string ad2, soyad2, ad3, soyad3, ad4, soyad4;
            PersonelListele();
            string ad=db.TBLPERSONEL.First(x => x.ID == 1).AD;
            string soyad= db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            labelControl15.Text = ad + ' ' + soyad;
            labelControl16.Text = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            labelControl17.Text = db.TBLPERSONEL.First(x => x.ID == 1).MAIL;
            ad2= db.TBLPERSONEL.First(x => x.ID == 2).AD;
            soyad2= db.TBLPERSONEL.First(x => x.ID == 2).SOYAD;
            labelControl19.Text = ad2+' '+soyad2;
            labelControl20.Text= db.TBLPERSONEL.First(x => x.ID == 2).TBLDEPARTMAN.AD;
            labelControl21.Text= db.TBLPERSONEL.First(x => x.ID == 2).MAIL;
            ad3 = db.TBLPERSONEL.First(x => x.ID == 3).AD;
            soyad3 = db.TBLPERSONEL.First(x => x.ID == 3).SOYAD;
            labelControl22.Text = ad3 + ' ' + soyad3;
            labelControl23.Text= db.TBLPERSONEL.First(x => x.ID == 3).TBLDEPARTMAN.AD;
            labelControl24.Text= db.TBLPERSONEL.First(x => x.ID == 3).MAIL;
            ad4 = db.TBLPERSONEL.First(x => x.ID == 4).AD;
            soyad4 = db.TBLPERSONEL.First(x => x.ID == 4).SOYAD;
            labelControl25.Text = ad4 + ' ' + soyad4;
            labelControl26.Text= db.TBLPERSONEL.First(x => x.ID == 4).TBLDEPARTMAN.AD;
            labelControl27.Text= db.TBLPERSONEL.First(x => x.ID == 3).MAIL;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLPERSONEL t = new TBLPERSONEL();
            t.AD = Txtdepartmanadi.Text;
            t.SOYAD = Txtsoyad.Text;
            t.DEPARTMAN = byte.Parse(Lkdepartman.EditValue.ToString());
            t.FOTOGRAF = Txtfotograf.Text;
            t.MAIL = Txtmail.Text;
            t.TELEFON = Txttelefon.Text;
            db.TBLPERSONEL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Sisteme Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var degerler = db.TBLPERSONEL.Find(id);
            db.TBLPERSONEL.Remove(degerler);
            MessageBox.Show("Personel Başarıyla Sistemden Silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            TBLPERSONEL t = new TBLPERSONEL();
            t.AD = Txtdepartmanadi.Text;
            t.SOYAD = Txtsoyad.Text;
            t.DEPARTMAN = byte.Parse(Lkdepartman.EditValue.ToString());
            t.FOTOGRAF = Txtfotograf.Text;
            t.MAIL = Txtmail.Text;
            t.TELEFON = Txttelefon.Text;
            db.TBLPERSONEL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Personel Bilgileri Başarıyla Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
