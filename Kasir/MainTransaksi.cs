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
    public partial class MainTransaksi : Form
    {
        public MainTransaksi()
        {
            InitializeComponent();
        }
        void onload()
        {
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            MinimizeBox = false;
            MaximizeBox = false;
        }
        void loadTransaksi()
        {
            string query = "select transaksi.id, pegawai.nama as 'Nama Kasir', total as 'Total Transaksi', dibayar as 'Pembayaran', kembali as 'Kembalian', tanggal as 'Tanggal Transaksi' from transaksi join pegawai on transaksi.id_pegawai = pegawai.id";

            dataGridView1.DataSource = Command.getData(query);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        int id;
        void loadDetailTransaksi()
        {
            string query = "select detailtransaksi.id, barang.barang as 'Nama Barang', quantity as 'Quantitas', subtotal as 'SubTotal' from detailtransaksi join barang on detailtransaksi.id_barang = barang.id where id_transaksi = " + id + "";

            dataGridView2.DataSource = Command.getData(query);
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void MainTransaksi_Load(object sender, EventArgs e)
        {
            onload();
            loadTransaksi();
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string search = "select transaksi.id, pegawai.nama as 'Nama Kasir', total as 'Total Transaksi', dibayar as 'Pembayaran', kembali as 'Kembalian', tanggal as 'Tanggal Transaksi' from transaksi join pegawai on transaksi.id_pegawai = pegawai.id where tanggal like '%" + textBox1.Text + "%'";

            dataGridView1.DataSource = Command.getData(search);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {

            }
            else
            {
                dataGridView1.CurrentRow.Selected = true;

                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                loadDetailTransaksi();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("My Paper", 215, 315);
            printPreviewDialog1.ShowDialog();
        }

        int getStok()
        {
            int stok;
            SqlCommand cmd = new SqlCommand("select SUM(quantity) from transaksi join detailtransaksi on transaksi.id = detailtransaksi.id_transaksi where CONVERT(date, transaksi.tanggal) = CONVERT(date, GETDATE())", Command.conn);
            Command.conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.IsDBNull(0))
            {
                stok = 0;
            }
            else
            {
                stok = reader.GetInt32(0);
            }
            Command.conn.Close();

            return stok;
        }

        int getPeroleh()
        {
            int total;
            SqlCommand cmd = new SqlCommand("select SUM(total) from transaksi where CONVERT(date, transaksi.tanggal) = CONVERT(date, GETDATE())", Command.conn);
            Command.conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.IsDBNull(0))
            {
                total = 0;
            }
            else
            {
                total = reader.GetInt32(0);
            }
            Command.conn.Close();

            return total;
        }

        int getCountBarang()
        {
            int count;
            SqlCommand cmd = new SqlCommand("select COUNT(id) from barang", Command.conn);
            Command.conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            count = reader.GetInt32(0);
            Command.conn.Close();

            return count;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Font font1 = new Font("Arial", 6);
            Font font2 = new Font("Arial", 8);
            Font font3 = new Font("Arial", 10, FontStyle.Bold);
            Brush brush = Brushes.Black;

            float leading = 4;
            float lineheight1 = font1.GetHeight() + leading;
            float lineheight2 = font2.GetHeight() + leading;
            float lineheight3 = font3.GetHeight() + leading;

            float startX = 0;
            float startY = leading;
            float Offset = 0;

            StringFormat formatLeft = new StringFormat(StringFormatFlags.NoClip);
            StringFormat formatCenter = new StringFormat(formatLeft);
            StringFormat formatRight = new StringFormat(formatLeft);

            formatCenter.Alignment = StringAlignment.Center;
            formatRight.Alignment = StringAlignment.Far;
            formatLeft.Alignment = StringAlignment.Near;

            SizeF layoutSize = new SizeF(215 - Offset * 2, lineheight3);
            RectangleF layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString("Laporan Hasil Penjualan", font3, brush, layout, formatCenter);
            Offset = Offset + lineheight3;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString("Harian", font3, brush, layout, formatCenter);
            Offset = Offset + lineheight3;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString("", font3, brush, layout, formatCenter);
            Offset = Offset + lineheight3;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString("Berikut Adalah Laporan Hasil Penjualan Harian Pada Tanggal " + DateTime.Now.ToString("yyyy-MM-dd"), font1, brush, layout, formatLeft);
            Offset = Offset + lineheight1;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString("", font1, brush, layout, formatLeft);
            Offset = Offset + lineheight1;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString("Stok Yang Terjual = " + getStok(), font1, brush, layout, formatLeft);
            Offset = Offset + lineheight1;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString("Penghasilan Yang Diperoleh = " + getPeroleh().ToString("C0"), font1, brush, layout, formatLeft);
            Offset = Offset + lineheight1;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString("Berikut Adalah Rinciannya :", font1, brush, layout, formatLeft);
            Offset = Offset + lineheight1;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString("", font1, brush, layout, formatLeft);
            Offset = Offset + lineheight1;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            for(int i = 1; i <= getCountBarang(); i++)
            {
                SqlCommand cmd = new SqlCommand("select barang, stok from barang where id = "+ i +"", Command.conn);
                Command.conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                graphics.DrawString(reader.GetString(0), font1, brush, layout, formatLeft);
                Offset = Offset + lineheight1;
                layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

                graphics.DrawString("Sisa Stok:", font1, brush, new RectangleF(new PointF(10, startY + Offset), layoutSize), formatLeft);
                graphics.DrawString(reader.GetInt32(1).ToString(), font1, brush, new RectangleF(new PointF(50, startY + Offset), layoutSize), formatLeft);

                Command.conn.Close();

                SqlCommand cmd1 = new SqlCommand("select SUM(quantity), SUM(total) from transaksi join detailtransaksi on transaksi.id = detailtransaksi.id_transaksi where CONVERT(date, tanggal) = CONVERT(date, getdate()) and id_barang = "+ i +"", Command.conn);
                Command.conn.Open();
                SqlDataReader reader1 = cmd1.ExecuteReader();
                reader1.Read();

                if (reader1.IsDBNull(0))
                {
                    graphics.DrawString("Stok Terjual:", font1, brush, new RectangleF(new PointF(80, startY + Offset), layoutSize), formatLeft);
                    graphics.DrawString("0", font1, brush, new RectangleF(new PointF(130, startY + Offset), layoutSize), formatLeft);
                }
                else
                {
                    graphics.DrawString("Stok Terjual:", font1, brush, new RectangleF(new PointF(80, startY + Offset), layoutSize), formatLeft);
                    graphics.DrawString(reader1.GetInt32(0).ToString(), font1, brush, new RectangleF(new PointF(130, startY + Offset), layoutSize), formatLeft);
                }

                Offset = Offset + lineheight1;
                layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

                if (reader1.IsDBNull(0))
                {
                    graphics.DrawString("Perolehan:", font1, brush, new RectangleF(new PointF(80, startY + Offset), layoutSize), formatLeft);
                    graphics.DrawString("0", font1, brush, new RectangleF(new PointF(130, startY + Offset), layoutSize), formatLeft);
                }
                else
                {
                    graphics.DrawString("Perolehan:", font1, brush, new RectangleF(new PointF(80, startY + Offset), layoutSize), formatLeft);
                    graphics.DrawString(reader1.GetInt32(1).ToString(), font1, brush, new RectangleF(new PointF(130, startY + Offset), layoutSize), formatLeft);
                }
                Command.conn.Close();

                Offset = Offset + lineheight1;
                layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
                
            }
        }
    }
}
