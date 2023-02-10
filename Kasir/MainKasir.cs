using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir
{
    public partial class MainKasir : Form
    {
        private int id_barang, stok_barang, harga_barang, kembali;
        private string nama_barang;
        private bool isSelected;
        public MainKasir()
        {
            InitializeComponent();
        }
        void onLoad()
        {
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            MinimizeBox = false;
            MaximizeBox = false;
            this.CenterToScreen();
        }
        private void MainKasir_Load(object sender, EventArgs e)
        {
            onLoad();
            loadGrid();
            textBoxKode.Focus();
            numericUpDownQty.Text = "";
            this.KeyPreview = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin Ingin Logout?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
                MainLogin login = new MainLogin();
                login.Show();
            }
        }
        void Calculate()
        {
            int total = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }

            labelTotal.Text = total.ToString("C0");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBoxKode.Text == "" || numericUpDownQty.Value == 0)
            {
                MessageBox.Show("Kode Barang Dan Quantity Wajib Diisi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (CheckKode())
                {
                    if (stok_barang > numericUpDownQty.Value)
                    {
                        if (checkBarang())
                        {
                            int harga = Convert.ToInt32(numericUpDownQty.Value) * harga_barang;
                            string[] barangAdd = { id_barang.ToString(), nama_barang, harga_barang.ToString(), numericUpDownQty.Value.ToString(), harga.ToString(), textBoxKode.Text };
                            dataGridView1.Rows.Add(barangAdd);
                            Calculate();

                            textBoxKode.Focus();
                            textBoxKode.Text = "";
                            numericUpDownQty.Value = 1;
                            numericUpDownQty.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("stok tidak memenuhi stok yang tersedia adalah " + stok_barang + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        bool CheckKode()
        {
            SqlCommand cmd = new SqlCommand("select id, barang, stok ,harga from barang where kode='" + textBoxKode.Text + "'", Command.conn);
            Command.conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                id_barang = Convert.ToInt32(reader["id"]);
                nama_barang = reader["barang"].ToString();
                stok_barang = Convert.ToInt32(reader["stok"]);
                harga_barang = Convert.ToInt32(reader["harga"]);
                Command.conn.Close();

                return true;
            }
            else
            {
                Command.conn.Close();
                MessageBox.Show("Kode Barang Tidak Ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxKode.Text = "";
                return false;
            }
        }

        private void textBoxKode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxKode.Text == "")
                {
                    MessageBox.Show("Kode Tidak Boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (CheckKode())
                    {
                        button2.PerformClick();
                    }
                }
            }
        }

        private void numericUpDownQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        void loadGrid()
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Name = "Nama Barang";
            dataGridView1.Columns[2].Name = "Harga";
            dataGridView1.Columns[3].Name = "Quantity";
            dataGridView1.Columns[4].Name = "Sub Total";
            dataGridView1.Columns[5].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["Sub Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void MainKasir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.B)
            {
                textBoxBayar.Focus();
            }

            if (e.KeyCode == Keys.Delete)
            {
                button3.PerformClick();
            }

            if (e.Control == true && e.KeyCode == Keys.K)
            {
                textBoxKode.Focus();
            }
        }

        private void textBoxBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        bool Kembalian()
        {
            int total = int.Parse(labelTotal.Text, NumberStyles.Currency);
            int bayar = Convert.ToInt32(textBoxBayar.Text);

            if (total <= bayar)
            {
                kembali = bayar - total;
                MessageBox.Show("Transaksi Sukses " + "", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Uang Tidak Cukup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void textBoxBayar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSub.PerformClick();
            }
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (textBoxBayar.Text != "")
                {
                    if (Kembalian())
                    {
                        try
                        {
                            string insert = "insert into transaksi values(" + Model.id + ", " + int.Parse(labelTotal.Text, NumberStyles.Currency) + ", " + Convert.ToInt32(textBoxBayar.Text) + ", " + kembali + ", getdate())";
                            Command.nonGetData(insert);

                            try
                            {
                                SqlCommand cmd = new SqlCommand("select top(1) id from transaksi order by id desc", Command.conn);
                                Command.conn.Open();
                                SqlDataReader reader = cmd.ExecuteReader();
                                reader.Read();

                                int idTransaksi = reader.GetInt32(0);
                                Command.conn.Close();

                                try
                                {
                                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                    {
                                        string insert2 = "insert into detailtransaksi values(" + idTransaksi + ", " + Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) + ", " + Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) + ", " + Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) + ")";
                                        Command.nonGetData(insert2);

                                        string update2 = "update barang set stok -= " + Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) + " where id = " + Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) + "";
                                        Command.nonGetData(update2);
                                    }
                                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("My Paper", 215, 330);
                                    printPreviewDialog1.Document = printDocument1;
                                    printPreviewDialog1.ShowDialog();

                                    dataGridView1.Rows.Clear();
                                    textBoxBayar.Text = "";
                                    labelTotal.Text = "0";
                                }
                                catch
                                {
                                    throw;
                                }
                            }
                            catch
                            {
                                throw;
                            }
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Pembayaran Tidak Boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silahkan Masukkan Barang Yang Dibeli Terlebih Dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int loadNumber()
        {
            string num = "select * from transaksi order by id desc";
            SqlCommand cmd = new SqlCommand(num, Command.conn);
            Command.conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                int number = reader.GetInt32(0);
                Command.conn.Close();
                return number;
            }
            else
            {
                Command.conn.Close();
                return 1;
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Font font1 = new Font("Courier New", 6);
            Font font2 = new Font("Courier New", 8);
            Font font3 = new Font("Courier New", 12, FontStyle.Bold);
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

            graphics.DrawString(" My Kasir ", font3, brush, layout, formatCenter);
            Offset = Offset + lineheight3;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString("Jl. Dimana Mana No 25, Kotakulon, Bondowoso", font2, brush, layout, formatCenter);
            Offset = Offset + lineheight3;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString(" ========================================", font1, brush, layout, formatLeft);
            Offset = Offset + lineheight1;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString(" No: " + loadNumber(), font1, brush, layout, formatLeft);
            Offset = Offset + lineheight1;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString(" " + DateTime.Now, font1, brush, layout, formatLeft);
            Offset = Offset + lineheight1;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString(" Kasir: " + Model.name, font1, brush, layout, formatLeft);
            Offset = Offset + lineheight1;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString(" ========================================", font1, brush, layout, formatLeft);
            Offset = Offset + lineheight1;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), font1, brush, new RectangleF(new PointF(10, startY + Offset), layoutSize), formatLeft);
                Offset = Offset + lineheight1;
                layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

                graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), font1, brush, new RectangleF(new PointF(10, startY + Offset), layoutSize), formatLeft);
                graphics.DrawString(" x ", font1, brush, new RectangleF(new PointF(25, startY + Offset), layoutSize), formatLeft);

                int har = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                graphics.DrawString(har.ToString("C0"), font1, brush, new RectangleF(new PointF(50, startY + Offset), layoutSize), formatLeft);

                int sub = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                graphics.DrawString(sub.ToString("C0"), font1, brush, layout, formatRight);

                Offset = Offset + lineheight1;
                layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
            }

            graphics.DrawString(" ========================================", font1, brush, layout, formatLeft);
            Offset = Offset + lineheight1;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString(" Total Item : ", font2, brush, layout, formatLeft);
            graphics.DrawString(totalItem().ToString(), font2, brush, layout, formatRight);
            Offset = Offset + lineheight2;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString(" Total : ", font2, brush, layout, formatLeft);
            int total = int.Parse(labelTotal.Text, NumberStyles.Currency);
            graphics.DrawString(total.ToString("C0"), font2, brush, layout, formatRight);
            Offset = Offset + lineheight2;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString(" Dibayar :", font2, brush, layout, formatLeft);
            int bayar = Convert.ToInt32(textBoxBayar.Text);
            graphics.DrawString(bayar.ToString("C0"), font2, brush, layout, formatRight);
            Offset = Offset + lineheight2;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString(" Kembali :", font2, brush, layout, formatLeft);
            graphics.DrawString(kembali.ToString("C0"), font2, brush, layout, formatRight);
            Offset = Offset + lineheight2;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString(" Terima Kasih ", font1, brush, layout, formatCenter);
            Offset = Offset + lineheight1;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {

            }
            else
            {
                dataGridView1.CurrentRow.Selected = true;
                isSelected = true;

                textBoxKode.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                numericUpDownQty.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isSelected)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                isSelected = false;
            }
            else
            {
                MessageBox.Show("Silahkan Pilih Baris Yang Akan Dihapus", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin Ingin Menutup Aplikasi?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void numericUpDownQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (numericUpDownQty.Value != 0)
                {
                    button2.PerformClick();
                }
                else
                {
                    MessageBox.Show("Quantity Tidak Boleh 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numericUpDownQty.Text = "";
                }
            }
        }

        int totalItem()
        {
            int totalitem = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                totalitem += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }

            return totalitem;
        }
        
        bool checkBarang()
        {
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[j].Cells[0].Value) == id_barang)
                {
                    int a = Convert.ToInt32(numericUpDownQty.Value);

                    dataGridView1.Rows[j].Cells[3].Value = a;
                    dataGridView1.Rows[j].Cells[4].Value = a * harga_barang;
                    textBoxKode.Focus();
                    textBoxKode.Text = "";
                    numericUpDownQty.Value = 1;
                    numericUpDownQty.Text = "";
                    Calculate();

                    return false;
                }
            }

            return true;
        }
    }
}
