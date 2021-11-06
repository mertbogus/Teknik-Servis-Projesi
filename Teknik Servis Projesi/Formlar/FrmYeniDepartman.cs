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
    public partial class FrmYeniDepartman : Form
    {
        public FrmYeniDepartman()
        {
            InitializeComponent();
        }
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN dp = new TBLDEPARTMAN();
            dp.AD = Txtdepartmanadi.Text;
            db.TBLDEPARTMAN.Add(dp);
            db.SaveChanges();
            MessageBox.Show("Yeni Departman Oluşturuldu.", "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
