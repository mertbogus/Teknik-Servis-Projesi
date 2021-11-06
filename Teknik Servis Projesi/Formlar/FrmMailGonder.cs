using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Teknik_Servis_Projesi.Formlar
{
    public partial class FrmMailGonder : Form
    {
        public FrmMailGonder()
        {
            InitializeComponent();
        }

        private void Btngonder_Click(object sender, EventArgs e)
        {
            MailMessage mg = new MailMessage();
            string frommail = "dream.mrt1@gmail.com";
            string password = "05432348136";
            string alici = Txtalici.Text;
            string konu = Txtkonu.Text;
            string icerik = Txticerik.Text;

            mg.From=new MailAddress(frommail);
            mg.To.Add(alici);
            mg.Subject = konu;
            mg.Body = icerik;
            mg.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
            smtp.Credentials = new NetworkCredential(frommail, password);
            smtp.EnableSsl = true;
            smtp.Send(mg);
            MessageBox.Show("Mail Başarıyla Gönderilmiştir.");

        }

        private void Btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
