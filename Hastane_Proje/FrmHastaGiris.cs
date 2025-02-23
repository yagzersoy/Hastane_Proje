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

namespace Hastane_Proje
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();

        private void lnküyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıt fr=new FrmHastaKayıt();
            fr.Show();
            
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut =new SqlCommand("select * From Tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("p2",txtsifre.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
                
            {
                HastaDetay fr=new HastaDetay();
                fr.tc=mskTC.Text;
                fr.Show();
                this.Hide();    
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGirisler fr =new FrmGirisler();
            fr.Show();
            this.Hide();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlCommand komut = new SqlCommand("select HastaSifre From Tbl_Hastalar where HastaTC=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txtsifre.Text = dr["HastaSifre"].ToString();
            }
            else { MessageBox.Show("Bu TC numarasına ait kullanıcı bulunamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }



        }
    }
}
