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

namespace Kasir
{
    public partial class MainAdmin : Form
    {
        public MainAdmin()
        {
            InitializeComponent();
        }

        void onload()
        {

            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            MinimizeBox = false;
            MaximizeBox = false;
            this.CenterToScreen();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin Ingin Menutup Aplikasi?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        void loadYear()
        {
            int year = 1990;

            for(int i = 1; i < 100; i++)
            {
                comboBox1.Items.Add(year.ToString());
                year += 1;
            }
        }
        void Chart()
        {
            string[] bulan = { "January", "February", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
            int[] angka = { 4000, 5000, 6000, 7000, 8000, 9000, 10000, 8000, 7000, 3000, 5000, 9000 };
            chart1.Series.Clear();
            chart1.Series.Add("Total Perbulan");
            for(int i = 0; i <= 11; i++)
            {
                if(comboBox1.Text == "")
                {
                    int month = i + 1;
                    SqlCommand cmd = new SqlCommand("select sum(total) from transaksi where month(tanggal) = " + month + " and year(tanggal) = 2023", Command.conn);
                    Command.conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.IsDBNull(0))
                    {
                        chart1.Series["Total Perbulan"].Points.AddXY(bulan[i].ToString(), 0);
                    }
                    else
                    {
                        chart1.Series["Total Perbulan"].Points.AddXY(bulan[i].ToString(), reader.GetInt32(0));
                    }
                    
                    Command.conn.Close();
                }
                else
                {
                    int month = i + 1;
                    SqlCommand cmd1 = new SqlCommand("select sum(total) from transaksi where month(tanggal) = " + month + " and year(tanggal) = " + Convert.ToInt32(comboBox1.Text) + "", Command.conn);
                    Command.conn.Open();
                    SqlDataReader reader1 = cmd1.ExecuteReader();
                    reader1.Read();
                    if (reader1.IsDBNull(0))
                    {
                        chart1.Series["Total Perbulan"].Points.AddXY(bulan[i].ToString(), 0);
                    }
                    else
                    {
                        chart1.Series["Total Perbulan"].Points.AddXY(bulan[i].ToString(), reader1.GetInt32(0));
                    }
                    Command.conn.Close();
                }
            }
        }
        private void MainAdmin_Load(object sender, EventArgs e)
        {
            loadYear();
            Chart();
            onload();
            labelWelcome.Text = "Welcome " + Model.name.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MasterPegawai pegawai = new MasterPegawai()
            {
                TopLevel = false,
                TopMost = true
            };

            panelMain.Controls.Clear();
            panelMain.Controls.Add(pegawai);
            pegawai.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MasterBarang barang = new MasterBarang()
            {
                TopLevel = false,
                TopMost = true
            };

            panelMain.Controls.Clear();
            panelMain.Controls.Add(barang);
            barang.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            MasterJenisBarang jenisBarang = new MasterJenisBarang()
            {
                TopLevel = false,
                TopMost = true
            };

            panelMain.Controls.Clear();
            panelMain.Controls.Add(jenisBarang);
            jenisBarang.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            MainTransaksi transaksi = new MainTransaksi()
            {
                TopLevel = false,
                TopMost = true
            };

            panelMain.Controls.Clear();
            panelMain.Controls.Add(transaksi);
            transaksi.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin Ingin Logout?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
                MainLogin login = new MainLogin();
                login.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            MainAdmin admin = new MainAdmin();
            admin.Show();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Chart();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chart();
        }
    }
}
