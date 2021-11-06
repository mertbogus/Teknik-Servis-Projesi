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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMIN where x.KULLANICIAD == textEdit1.Text & x.SIFRE == textEdit2.Text select x;
            if (sorgu.Any())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız. Kullanıcı adı veya Şifrenizi kontrol ediniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
