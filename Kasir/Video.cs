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
    public partial class Video : Form
    {
        public Video()
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
        private void Video_Load(object sender, EventArgs e)
        {
            onload();
            string url = "C:\\Users\\SMKN 1 BONDOWOSO\\source\\repos\\Kasir\\Asset\\Kasir.mp4";
            axWindowsMediaPlayer1.URL = url;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin Ingin Menutup Video?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
                MainLogin login = new MainLogin();
                login.ShowDialog();
            }
        }
    }
}
