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

namespace personel_kayit
{
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=IZZETTINATUG;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void FrmGrafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("Select PerSehir,Count(*) From Tbl_Personel group by PerSehir", baglanti);
            SqlDataReader gdr1 = komutg1.ExecuteReader();
            while (gdr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(gdr1[0], gdr1[1]);
            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("Select PerMeslek,Avg(PerMaas) From Tbl_Personel group by PerMeslek", baglanti);
            SqlDataReader gdr2 = komutg2.ExecuteReader();
            while (gdr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(gdr2[0],gdr2[1]);
            }
            baglanti.Close();

        }

    }
}


