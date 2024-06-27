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
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        bool durum;

        private void secimkontrol()
        {
            durum = true;
            SqlCommand komut = new SqlCommand("Select * from TBLILCE", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (TxtİlceAd.Text == dr[1].ToString() || TxtİlceAd.Text == "")
                {
                    durum = false;
                }
                bgl.baglanti().Close();
            }

        }

        private void TxtOyGirisi_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Oy Girişi Yapmak İstediğinizden Emin Misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog == DialogResult.Yes)
            {
                secimkontrol();
                if (durum == true)
                {
                    SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@P1,@P2,@P3,@P4,@P5,@P6)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@P1", TxtİlceAd.Text);
                    komut.Parameters.AddWithValue("@P2", TxtA.Text);
                    komut.Parameters.AddWithValue("@P3", TxtB.Text);
                    komut.Parameters.AddWithValue("@P4", TxtC.Text);
                    komut.Parameters.AddWithValue("@P5", TxtD.Text);
                    komut.Parameters.AddWithValue("@P6", TxtE.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Oy Girişi Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Böyle bir ilçe zaten var.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }

            }
        }
            
        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog==DialogResult.Yes)
            {
                this.Close();
            }
           
        }
    }
}
