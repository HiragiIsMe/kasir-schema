namespace Kasir
{
    partial class MasterPegawai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelForm = new System.Windows.Forms.Panel();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonHap = new System.Windows.Forms.Button();
            this.buttonUba = new System.Windows.Forms.Button();
            this.buttonTam = new System.Windows.Forms.Button();
            this.panelSimpan = new System.Windows.Forms.Panel();
            this.buttonBat = new System.Windows.Forms.Button();
            this.buttonSim2 = new System.Windows.Forms.Button();
            this.buttonSim1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelForm.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panelSimpan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelola Pegawai";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(478, 124);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.comboBoxRole);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.textBoxPassword);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.textBoxUsername);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.textBoxName);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Location = new System.Drawing.Point(15, 255);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(391, 104);
            this.panelForm.TabIndex = 2;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(283, 10);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(101, 21);
            this.comboBoxRole.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Role :";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Location = new System.Drawing.Point(89, 63);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(136, 20);
            this.textBoxPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password :";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Location = new System.Drawing.Point(89, 37);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(136, 20);
            this.textBoxUsername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username :";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Location = new System.Drawing.Point(89, 11);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(136, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama :";
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.buttonHap);
            this.panelButton.Controls.Add(this.buttonUba);
            this.panelButton.Controls.Add(this.buttonTam);
            this.panelButton.Location = new System.Drawing.Point(15, 209);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(277, 40);
            this.panelButton.TabIndex = 3;
            // 
            // buttonHap
            // 
            this.buttonHap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.buttonHap.FlatAppearance.BorderSize = 0;
            this.buttonHap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHap.ForeColor = System.Drawing.Color.White;
            this.buttonHap.Location = new System.Drawing.Point(203, 3);
            this.buttonHap.Name = "buttonHap";
            this.buttonHap.Size = new System.Drawing.Size(71, 34);
            this.buttonHap.TabIndex = 2;
            this.buttonHap.Text = "Hapus";
            this.buttonHap.UseVisualStyleBackColor = false;
            this.buttonHap.Click += new System.EventHandler(this.buttonHap_Click);
            // 
            // buttonUba
            // 
            this.buttonUba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.buttonUba.FlatAppearance.BorderSize = 0;
            this.buttonUba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUba.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUba.ForeColor = System.Drawing.Color.White;
            this.buttonUba.Location = new System.Drawing.Point(105, 3);
            this.buttonUba.Name = "buttonUba";
            this.buttonUba.Size = new System.Drawing.Size(71, 34);
            this.buttonUba.TabIndex = 1;
            this.buttonUba.Text = "Ubah";
            this.buttonUba.UseVisualStyleBackColor = false;
            this.buttonUba.Click += new System.EventHandler(this.buttonUba_Click);
            // 
            // buttonTam
            // 
            this.buttonTam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.buttonTam.FlatAppearance.BorderSize = 0;
            this.buttonTam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTam.ForeColor = System.Drawing.Color.White;
            this.buttonTam.Location = new System.Drawing.Point(3, 3);
            this.buttonTam.Name = "buttonTam";
            this.buttonTam.Size = new System.Drawing.Size(71, 34);
            this.buttonTam.TabIndex = 0;
            this.buttonTam.Text = "Tambah";
            this.buttonTam.UseVisualStyleBackColor = false;
            this.buttonTam.Click += new System.EventHandler(this.buttonTam_Click);
            // 
            // panelSimpan
            // 
            this.panelSimpan.Controls.Add(this.buttonBat);
            this.panelSimpan.Controls.Add(this.buttonSim2);
            this.panelSimpan.Controls.Add(this.buttonSim1);
            this.panelSimpan.Location = new System.Drawing.Point(412, 255);
            this.panelSimpan.Name = "panelSimpan";
            this.panelSimpan.Size = new System.Drawing.Size(81, 104);
            this.panelSimpan.TabIndex = 4;
            // 
            // buttonBat
            // 
            this.buttonBat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.buttonBat.FlatAppearance.BorderSize = 0;
            this.buttonBat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBat.ForeColor = System.Drawing.Color.White;
            this.buttonBat.Location = new System.Drawing.Point(3, 43);
            this.buttonBat.Name = "buttonBat";
            this.buttonBat.Size = new System.Drawing.Size(75, 34);
            this.buttonBat.TabIndex = 2;
            this.buttonBat.Text = "Batal";
            this.buttonBat.UseVisualStyleBackColor = false;
            this.buttonBat.Click += new System.EventHandler(this.buttonBat_Click);
            // 
            // buttonSim2
            // 
            this.buttonSim2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.buttonSim2.FlatAppearance.BorderSize = 0;
            this.buttonSim2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSim2.ForeColor = System.Drawing.Color.White;
            this.buttonSim2.Location = new System.Drawing.Point(3, 3);
            this.buttonSim2.Name = "buttonSim2";
            this.buttonSim2.Size = new System.Drawing.Size(75, 34);
            this.buttonSim2.TabIndex = 1;
            this.buttonSim2.Text = "Simpan";
            this.buttonSim2.UseVisualStyleBackColor = false;
            this.buttonSim2.Click += new System.EventHandler(this.buttonSim2_Click);
            // 
            // buttonSim1
            // 
            this.buttonSim1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.buttonSim1.FlatAppearance.BorderSize = 0;
            this.buttonSim1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSim1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSim1.ForeColor = System.Drawing.Color.White;
            this.buttonSim1.Location = new System.Drawing.Point(3, 3);
            this.buttonSim1.Name = "buttonSim1";
            this.buttonSim1.Size = new System.Drawing.Size(75, 34);
            this.buttonSim1.TabIndex = 0;
            this.buttonSim1.Text = "Simpan";
            this.buttonSim1.UseVisualStyleBackColor = false;
            this.buttonSim1.Click += new System.EventHandler(this.buttonSim1_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(354, 53);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Cari Pegawai...";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.Enter += new System.EventHandler(this.textBox4_Enter);
            // 
            // MasterPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(504, 371);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.panelSimpan);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "MasterPegawai";
            this.Text = "MasterPegawai";
            this.Load += new System.EventHandler(this.MasterPegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.panelSimpan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonHap;
        private System.Windows.Forms.Button buttonUba;
        private System.Windows.Forms.Button buttonTam;
        private System.Windows.Forms.Panel panelSimpan;
        private System.Windows.Forms.Button buttonBat;
        private System.Windows.Forms.Button buttonSim2;
        private System.Windows.Forms.Button buttonSim1;
        private System.Windows.Forms.TextBox textBox4;
    }
}