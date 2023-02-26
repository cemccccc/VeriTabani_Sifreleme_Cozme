using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabani_Sifreleme
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection(@"Data Source=CEMC\SQLEXPRESS01;Initial Catalog=DbTest;Integrated Security=True");
		private void Form1_Load(object sender, EventArgs e)
		{
			this.BackColor = ColorTranslator.FromHtml("0xffeda0");
			DataCoz();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into TblVeriler (AD,SOYAD,MAIL,SIFRE,HESAPNO) values (@p1,@p2,@p3,@p4,@p5)",baglanti);
			komut.Parameters.AddWithValue("p1", veriSifrele(TxtAd.Text));
			komut.Parameters.AddWithValue("p2", veriSifrele(TxtSoyad.Text));
			komut.Parameters.AddWithValue("p3", veriSifrele(TxtMail.Text));
			komut.Parameters.AddWithValue("p4", veriSifrele(TxtSifre.Text));
			komut.Parameters.AddWithValue("p5", veriSifrele(TxtHesapNo.Text));
			komut.ExecuteNonQuery();
			MessageBox.Show("İşlem Başarı İle Gerçekleşmiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			DataCoz();
		}


		string veriSifrele(string metin)
		{
			byte[] veridizi = ASCIIEncoding.ASCII.GetBytes(metin);
			string sifreliVeri = Convert.ToBase64String(veridizi);
			return sifreliVeri;
		}

		void DataCoz()
		{
			dataGridView1.DataSource = null;
			dataGridView1.ColumnCount = 6; 
			dataGridView1.Columns[0].Name= "ID";
			dataGridView1.Columns[1].Name = "AD";
			dataGridView1.Columns[2].Name = "SOYAD";
			dataGridView1.Columns[3].Name = "MAIL";
			dataGridView1.Columns[4].Name = "SIFRE";
			dataGridView1.Columns[5].Name = "HESAPNO";


			baglanti.Open();
			SqlCommand komut = new SqlCommand("select * from TblVeriler", baglanti);
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				byte[] adCoz = Convert.FromBase64String(dr[1].ToString());
				string ad = ASCIIEncoding.ASCII.GetString(adCoz);
				byte[] soyadCoz = Convert.FromBase64String(dr[1].ToString());
				string soyad = ASCIIEncoding.ASCII.GetString(soyadCoz);
				byte[] mailCoz = Convert.FromBase64String(dr[1].ToString());
				string mail = ASCIIEncoding.ASCII.GetString(mailCoz);
				byte[] sifreCoz = Convert.FromBase64String(dr[1].ToString());
				string sifre = ASCIIEncoding.ASCII.GetString(sifreCoz);
				byte[] hesapnoCoz = Convert.FromBase64String(dr[1].ToString());
				string hesapno = ASCIIEncoding.ASCII.GetString(hesapnoCoz);

				string[] veri = { dr[0].ToString(),ad,soyad,mail, sifre,hesapno};
				dataGridView1.Rows.Add(veri);
			}
			baglanti.Close();
		}
	
	}
}
