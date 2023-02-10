using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir
{
    public partial class MasterJenisBarang : Form
    {
        private int id_jenisbarang;
        public MasterJenisBarang()
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
        }
        void Datagrid()
        {
            string query = "select * from jenisbarang";

            dataGridView1.DataSource = Command.getData(query);
            dataGridView1.Columns[0].HeaderText = "No";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void MasterJenisBarang_Load(object sender, EventArgs e)
        {
            onload();
            Hidee();
            Datagrid();
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
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Nama Jenis Barang Wajib Diisi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void buttonSim1_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                try
                {
                    string insert = "insert into jenisbarang values('" + textBoxName.Text + "')";
                    Command.nonGetData(insert);

                    MessageBox.Show("Jenis Barang Berhasil Di Tambah", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hidee();
                    buttonSim2.Show();
                    Datagrid();
                    Clear();
                    dataGridView1.Enabled = true;
                }
                catch
                {
                    throw;
                }
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
                id_jenisbarang = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void buttonUba_Click(object sender, EventArgs e)
        {
            if (id_jenisbarang > 0)
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
                    string update = "update jenisbarang set jenis='" + textBoxName.Text + "' where id = " + id_jenisbarang + "";
                    Command.nonGetData(update);

                    MessageBox.Show("Jenis Barang Berhasil Di Ubah", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hidee();
                    Datagrid();
                    Clear();
                    id_jenisbarang = 0;
                }
                catch
                {
                    throw;
                }
            }
        }

        private void buttonBat_Click(object sender, EventArgs e)
        {
            Clear();
            buttonSim2.Show();
            Hidee();
            if (id_jenisbarang > 0)
            {
                dataGridView1.CurrentRow.Selected = false;
            }
            id_jenisbarang = 0;
            dataGridView1.Enabled = true;
        }

        private void buttonHap_Click(object sender, EventArgs e)
        {
            if (id_jenisbarang > 0)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Apakah Yakin Akan Menghapus " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + " ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        string delete = "delete from jenisbarang where id = " + id_jenisbarang + "";
                        Command.nonGetData(delete);
                        MessageBox.Show("Jenis Barang Berhasil Di Hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Datagrid();
                        id_jenisbarang = 0;
                        Clear();
                        id_jenisbarang = 0;
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
    }
}
