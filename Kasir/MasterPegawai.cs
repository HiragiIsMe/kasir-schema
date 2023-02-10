using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kasir
{
    public partial class MasterPegawai : Form
    {
        private int id_pegawai;
        public MasterPegawai()
        {
            InitializeComponent();
        }
        void onload()
        {
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            MinimizeBox = false;
            MaximizeBox = false;
            textBoxPassword.UseSystemPasswordChar = true;
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
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            comboBoxRole.Text = "";
        }
        void Datagrid()
        {
            string query = "select * from pegawai";
            dataGridView1.DataSource = Command.getData(query);

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;

            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "1")
                {
                    dataGridView1.Rows[i].Cells[4].Value = "Admin";
                }
                else
                {
                    dataGridView1.Rows[i].Cells[4].Value = "Kasir";
                }
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void loadRole()
        {
            Dictionary<int, string> role = new Dictionary<int, string>();
            role.Add(1, "Admin");
            role.Add(2, "Kasir");

            comboBoxRole.DataSource = new BindingSource(role, null);
            comboBoxRole.DisplayMember = "Value";
            comboBoxRole.ValueMember = "Key";
        }
        private void MasterPegawai_Load(object sender, EventArgs e)
        {
            onload();
            Datagrid();
            loadRole();
            Hidee();
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
            if (textBoxName.Text == "" || textBoxUsername.Text == "" || textBoxPassword.Text == "" || comboBoxRole.Text == "")
            {
                MessageBox.Show("Semua Form Wajib Diisi", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBoxPassword.TextLength < 8)
            {
                MessageBox.Show("Password Minimal 8 Character", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Regex numeric = new Regex("[0-9]");
            if (!numeric.IsMatch(textBoxPassword.Text))
            {
                MessageBox.Show("Password Setidaknya Terdapat 1 Character Numeric", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            SqlCommand cmd = new SqlCommand("select * from pegawai where username='" + textBoxUsername.Text + "'", Command.conn);
            Command.conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                MessageBox.Show("Username Telah Digunakan!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Command.conn.Close();
                return false;
            }
            Command.conn.Close();

            return true;
        }

        private void buttonSim1_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                try
                {
                    string pass = Enc.getPass(textBoxPassword.Text);
                    string insert = "insert into pegawai values('" + textBoxName.Text + "', '" + textBoxUsername.Text + "', '" + pass + "', '" + comboBoxRole.SelectedValue + "')";
                    Command.nonGetData(insert);

                    MessageBox.Show("Pegawai Berhasil Di Tambah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonUba_Click(object sender, EventArgs e)
        {
            if (id_pegawai > 0)
            {
                Showw();
            }
            else
            {
                MessageBox.Show("Silahkan Pilih Baris Yang Akan Di Ubah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                id_pegawai = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                comboBoxRole.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "Admin")
                {
                    comboBoxRole.SelectedValue = 1;
                }
                else
                {
                    comboBoxRole.SelectedValue = 2;
                }
            }
        }
        bool validateUp()
        {
            if (textBoxName.Text == "" || textBoxUsername.Text == "" || comboBoxRole.Text == "")
            {
                MessageBox.Show("Semua Form Wajib Diisi", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBoxPassword.Text != "")
            {
                if (textBoxPassword.TextLength < 8)
                {
                    MessageBox.Show("Password Minimal 8 Character", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                Regex numeric = new Regex("[0-9]");
                if (!numeric.IsMatch(textBoxPassword.Text))
                {
                    MessageBox.Show("Password Setidaknya Terdapat 1 Character Numeric", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (textBoxUsername.Text != dataGridView1.SelectedRows[0].Cells[2].Value.ToString())
            {
                SqlCommand cmd = new SqlCommand("select * from pegawai where username='" + textBoxUsername.Text + "'", Command.conn);
                Command.conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    MessageBox.Show("Username Telah Digunakan!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Command.conn.Close();
                    return false;
                }
                Command.conn.Close();
            }

            return true;
        }

        private void buttonSim2_Click(object sender, EventArgs e)
        {
            if (validateUp())
            {
                if (textBoxPassword.Text != "")
                {
                    try
                    {
                        string pass = Enc.getPass(textBoxPassword.Text);
                        string update = "update pegawai set nama='" + textBoxName.Text + "', username='" + textBoxUsername.Text + "', password='" + pass + "', role='" + comboBoxRole.SelectedValue + "' where id = " + id_pegawai + "";
                        Command.nonGetData(update);

                        MessageBox.Show("Pegawai Berhasil Di Ubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Datagrid();
                        Clear();
                        Hidee();
                        id_pegawai = 0;
                    }
                    catch
                    {
                        throw;
                    }
                }
                else
                {
                    try
                    {
                        string update = "update pegawai set nama='" + textBoxName.Text + "', username='" + textBoxUsername.Text + "', role='" + comboBoxRole.SelectedValue + "' where id = " + id_pegawai + "";
                        Command.nonGetData(update);

                        MessageBox.Show("Pegawai Berhasil Di Ubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Datagrid();
                        Clear();
                        Hidee();
                        id_pegawai = 0;
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        private void buttonHap_Click(object sender, EventArgs e)
        {
            if (id_pegawai > 0)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Apakah Yakin Akan Menghapus " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + " ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        string delete = "delete from pegawai where id = " + id_pegawai + "";
                        Command.nonGetData(delete);
                        MessageBox.Show("Pegawai Berhasil Di Hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        id_pegawai = 0;
                        Datagrid();
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
            if (id_pegawai > 0)
            {
                dataGridView1.CurrentRow.Selected = false;
            }
            id_pegawai = 0;
            Datagrid();
            dataGridView1.Enabled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from pegawai where nama like '%@text%'", Command.conn);
            cmd.Parameters.AddWithValue("text", textBox4.Text);
            Command.conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);   
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Command.conn.Close();

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "1")
                {
                    dataGridView1.Rows[i].Cells[4].Value = "Admin";
                }
                else
                {
                    dataGridView1.Rows[i].Cells[4].Value = "Kasir";
                }
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
