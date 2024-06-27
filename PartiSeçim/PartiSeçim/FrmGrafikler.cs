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

namespace PartiSeçim
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBLILCE", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();

            // Grafiğe Toplam Sonuçları Getirme
            SqlCommand komut2 = new SqlCommand("Select SUM(APARTI),SUM(BPARTI),SUM(CPARTI),SUM(DPARTI),SUM(EPARTI) from TBLILCE", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTİ", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTİ", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C PARTİ", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D PARTİ", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E PARTİ", dr2[4]);
            }
            bgl.baglanti().Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBLILCE where ILCEAD=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                LblA.Text = dr[2].ToString();
                LblB.Text = dr[3].ToString();
                LblC.Text = dr[4].ToString();
                LblD.Text = dr[5].ToString();
                LblE.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }
    }

}

