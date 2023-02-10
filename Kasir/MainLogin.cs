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
using System.Xml.Linq;

namespace Kasir
{
    public partial class MainLogin : Form
    {
        public MainLogin()
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
            textPassword.UseSystemPasswordChar = true;
            textUsername.Focus();
        }
        private void MainLogin_Load(object sender, EventArgs e)
        {
            //button3.Hide();
            onload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin Ingin Menutup Aplikasi?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        bool validate()
        {
            if (textUsername.Text == "" || textPassword.Text == "")
            {
                MessageBox.Show("Silahkan Isi Username Dan Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textPassword.TextLength < 8)
            {
                MessageBox.Show("Password Minimal 8 Character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string pass = Enc.getPass(textPassword.Text);
                try
                {
                    string query = "select * from pegawai where username=@username and password=@password";
                    SqlCommand log = new SqlCommand(query, Command.conn);
                    log.Parameters.AddWithValue("@username", textUsername.Text);
                    log.Parameters.AddWithValue("@password", pass);
                    Command.conn.Open();
                    SqlDataReader reader = log.ExecuteReader();
                    reader.Read();

                    if (reader.HasRows)
                    {
                        Model.id = reader.GetInt32(0);
                        Model.name = reader.GetString(1);
                        Model.role = Convert.ToChar(reader["role"]);
                        Command.conn.Close();

                        if (Model.role == '1')
                        {
                            this.Close();
                            MainAdmin admin = new MainAdmin();
                            admin.Show();
                        }

                        if (Model.role == '2')
                        {
                            this.Close();
                            MainKasir kasir = new MainKasir();
                            kasir.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username Atau Password Salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Command.conn.Close();
                    }
                    Command.conn.Close();
                }
                catch
                {
                    throw;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Video vide = new Video();
            vide.Show();
        }

        private void textUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
               button2.PerformClick();
            }
        }

        private void textPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
            }
        }
    }
}
