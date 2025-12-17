using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace ApıİleVeriCekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class post
        {
            public int Id { get; set; }
            public String Title { get; set; }
            public String Body { get; set; }
        }

        private async void btnVeriCek_Click(object sender, EventArgs e)
        {
            try
            {
                btnVeriCek.Enabled = false;
                btnVeriCek.Text = "Bağlanıyor...";
                string url = "https://jsonplaceholder.typicode.com/posts";
                using (HttpClient client = new HttpClient())

                {
                    string jsonResult = await client.GetStringAsync(url); // Burada veriyi çektim
                    GridiGuzellestir(dataGridView1);
                    List<post> postlar = JsonConvert.DeserializeObject<List<post>>(jsonResult);// burada indiridiğim nuget paketi olan network.json paketi ile üst satırda çektiğimiz bilgileri listeliyorum
                    dataGridView1.DataSource = postlar;//burada datagridimize bağladım
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.Columns["Id"].Width = 50;
                    dataGridView1.Columns["Title"].HeaderText = "Başlık";
                    dataGridView1.Columns["Body"].HeaderText = "İçerik";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı Hatası:" + ex.Message);

            }
            finally
            {
                btnVeriCek.Enabled = true;
                btnVeriCek.Text = "VeriÇek";
            }
        }
        private void GridiGuzellestir(DataGridView dgv)
        {
            // 1. Genel Renk ve Kenarlık Ayarları
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(230, 230, 230); // Açık gri çizgi
            dgv.EnableHeadersVisualStyles = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;

            // 2. Başlık (Header) Tasarımı
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.FromArgb(44, 62, 80); // Koyu lacivert/gri tonu
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersDefaultCellStyle = headerStyle;
            dgv.ColumnHeadersHeight = 45;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // 3. Satır Tasarımı ve Zebra Efekti
            dgv.RowTemplate.Height = 40;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219); // Şık mavi seçim rengi
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            // Alternatif (Zebra) satır rengi
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);

            // 4. Diğer Ayarlar
            dgv.RowHeadersVisible = false; // Sol boşluğu kaldır
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tam sığdır
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridiGuzellestir(dataGridView1);
        }


    }
}
