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
    public partial class FrmCariİller : Form
    {
        public FrmCariİller()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-KEJIT91;Initial Catalog=DBTekniKServis;Integrated Security=True");
        DBTekniKServisEntities2 db = new DBTekniKServisEntities2();
        private void FrmCariİller_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 2);
            //chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 5);
            //chartControl1.Series["Series 1"].Points.AddPoint("Ağrı", 1);

            gridControl1.DataSource = db.TBLCARİ.OrderBy(x => x.İL).GroupBy(y => y.İL).Select(z => new { İL = z.Key,Toplam=z.Count() }).ToList();
            bgl.Open();
            SqlCommand komut = new SqlCommand("Select İL,Count(*) From TBLCARİ group by İL", bgl);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]),int.Parse(dr[1].ToString()));
            }
            bgl.Close();
        }
    }
}
