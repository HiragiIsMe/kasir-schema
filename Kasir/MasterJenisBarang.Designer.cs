namespace Kasir
{
    partial class MasterJenisBarang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonHap = new System.Windows.Forms.Button();
            this.buttonUba = new System.Windows.Forms.Button();
            this.buttonTam = new System.Windows.Forms.Button();
            this.panelSimpan = new System.Windows.Forms.Panel();
            this.buttonBat = new System.Windows.Forms.Button();
            this.buttonSim2 = new System.Windows.Forms.Button();
            this.buttonSim1 = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelButton.SuspendLayout();
            this.panelSimpan.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 121);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kelola Jenis Barang";
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.buttonHap);
            this.panelButton.Controls.Add(this.buttonUba);
            this.panelButton.Controls.Add(this.buttonTam);
            this.panelButton.Location = new System.Drawing.Point(12, 196);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(277, 40);
            this.panelButton.TabIndex = 10;
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
            this.panelSimpan.Location = new System.Drawing.Point(411, 287);
            this.panelSimpan.Name = "panelSimpan";
            this.panelSimpan.Size = new System.Drawing.Size(81, 85);
            this.panelSimpan.TabIndex = 11;
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
            // panelForm
            // 
            this.panelForm.Controls.Add(this.textBoxName);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Location = new System.Drawing.Point(15, 242);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(274, 66);
            this.panelForm.TabIndex = 12;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Location = new System.Drawing.Point(94, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(177, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jenis Barang :";
            // 
            // MasterJenisBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(504, 371);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelSimpan);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MasterJenisBarang";
            this.Text = "MasterJenisBarang";
            this.Load += new System.EventHandler(this.MasterJenisBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panelSimpan.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonHap;
        private System.Windows.Forms.Button buttonUba;
        private System.Windows.Forms.Button buttonTam;
        private System.Windows.Forms.Panel panelSimpan;
        private System.Windows.Forms.Button buttonBat;
        private System.Windows.Forms.Button buttonSim2;
        private System.Windows.Forms.Button buttonSim1;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
    }
}