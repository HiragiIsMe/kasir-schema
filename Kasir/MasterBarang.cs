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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kasir
{
    public partial class MasterBarang : Form
    {
        private int id_barang;
        public MasterBarang()
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
        void Hidee()
        {
            panelForm.Hide();
            panelSimpan.Hide();
            panelButton.Show();
        }
        void Showw()
        {
            panelForm.Show();
            panelSimpan.Show();
            panelButton.Hide();
        }
        void Clear()
        {
            textBoxName.Text = "";
            textBoxHarga.Text = "";
            numericUpDownStok.Text = "";
            comboBoxJenisBarang.Text = "";
        }
        void Datagrid()
        {
            string query = "select barang.id, jenisbarang.id, kode as 'Kode Barang', barang as 'Nama Barang', jenis as 'Jenis Barang', harga as 'Harga Barang', stok as 'Stok Barang' from barang join jenisbarang on barang.id_jenis=jenisbarang.id";
            dataGridView1.DataSource = Command.getData(query);

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void loadJenisBarang()
        {
            string query = "select * from jenisbarang";

            comboBoxJenisBarang.DataSource = Command.getData(query);
            comboBoxJenisBarang.DisplayMember = "jenis";
            comboBoxJenisBarang.ValueMember = "id";
        }
        private void MasterBarang_Load(object sender, EventArgs e)
        {
            onload();
            Datagrid();
            Hidee();
            loadJenisBarang();
        }

        private void buttonTam_Click(object sender, EventArgs e)
        {
            Showw();
            buttonSim2.Hide();
            dataGridView1.Enabled = false;
            Clear();
        }
        bool validate()
        {
            if (textBoxName.Text == "" || textBoxHarga.Text == "" || numericUpDownStok.Value == 0 || comboBoxJenisBarang.Text == "")
            {
                MessageBox.Show("Semua Form Wajib Diisi", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        string loadCode()
        {
            string kodebarang;
            SqlCommand code = new SqlCommand("select top(1) id, kode from barang order by id desc", Command.conn);
            Command.conn.Open();
            SqlDataReader readCode = code.ExecuteReader();
            readCode.Read();
            if (readCode.HasRows)
            {
                string a = readCode["kode"].ToString();
                Command.conn.Close();
                int b = 1;
                int c = a.Length - b;
                int d = Convert.ToInt32(a.Substring(b, c)) + 1;
                kodebarang = "B000" + d.ToString();
                return kodebarang;
            }
            else
            {
                Command.conn.Close();
                kodebarang = "B0001";
                return kodebarang;
            }
        }

        private void buttonSim1_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                try
                {
                    string insert = "insert into barang values(" + comboBoxJenisBarang.SelectedValue + ", '" + loadCode() + "', '" + textBoxName.Text + "', " + numericUpDownStok.Value + ", " + Convert.ToInt32(textBoxHarga.Text) + ")";
                    Command.nonGetData(insert);

                    MessageBox.Show("Barang Berhasil Di Tambah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Datagrid();
                    Clear();
                    Hidee();
                    dataGridView1.Enabled = true;
                    buttonSim2.Show();
                }
                catch
                {
                    throw;
                }
            }
        }

        private void textBoxHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {

            }
            else
            {
                dataGridView1.CurrentRow.Selected = true;
                id_barang = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxHarga.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                numericUpDownStok.Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);

                comboBoxJenisBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                comboBoxJenisBarang.SelectedValue = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            }
        }

        private void buttonUba_Click(object sender, EventArgs e)
        {
            if (id_barang > 0)
            {
                Showw();
            }
            else
            {
                MessageBox.Show("Silahkan Pilih Baris Yang Akan Di Ubah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSim2_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                try
                {
                    string update = "update barang set id_jenis=" + comboBoxJenisBarang.SelectedValue + ", barang='" + textBoxName.Text + "', harga=" + Convert.ToInt32(textBoxHarga.Text) + ", stok=" + numericUpDownStok.Value + " where id = " + id_barang + "";
                    Command.nonGetData(update);

                    MessageBox.Show("Barang Berhasil Di Ubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Datagrid();
                    Clear();
                    Hidee();
                    id_barang = 0;
                }
                catch
                {
                    throw;
                }
            }
        }

        private void buttonHap_Click(object sender, EventArgs e)
        {
            if (id_barang > 0)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Apakah Yakin Akan Menghapus " + dataGridView1.SelectedRows[0].Cells[3].Value.ToString() + " ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        string delete = "delete from barang where id = " + id_barang + "";
                        Command.nonGetData(delete);
                        MessageBox.Show("Barang Berhasil Di Hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Datagrid();
                        id_barang = 0;
                    }
                }
                catch
                {
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Silahkan Pilih Baris Yang Akan Di Hapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBat_Click(object sender, EventArgs e)
        {
            Clear();
            Hidee();
            buttonSim2.Show();
            if (id_barang > 0)
            {
                dataGridView1.CurrentRow.Selected = false;
            }
            id_barang = 0;
            Datagrid();
            dataGridView1.Enabled = true;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string query = "select barang.id, jenisbarang.id, kode as 'Kode Barang', barang as 'Nama Barang', jenis as 'Jenis Barang', harga as 'Harga Barang', stok as 'Stok Barang' from barang join jenisbarang on barang.id_jenis=jenisbarang.id where barang like '%" + textBox4.Text + "%'";
            dataGridView1.DataSource = Command.getData(query);

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            int X = 10;
            int Y = 10;
            int Z = 120;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                e.Graphics.DrawImage(barcode.Draw(dataGridView1.Rows[i].Cells[2].Value.ToString(), 100), new Point(X, Y));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), new Font("Times New Roman", 12), new SolidBrush(Color.Black), new Point(X, Z));
                Y += 150;
                Z += 150;
            }
        }
    }
}
