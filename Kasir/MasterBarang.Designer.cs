namespace Kasir
{
    partial class MasterBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterBarang));
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panelSimpan = new System.Windows.Forms.Panel();
            this.buttonBat = new System.Windows.Forms.Button();
            this.buttonSim2 = new System.Windows.Forms.Button();
            this.buttonSim1 = new System.Windows.Forms.Button();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonHap = new System.Windows.Forms.Button();
            this.buttonUba = new System.Windows.Forms.Button();
            this.buttonTam = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.numericUpDownStok = new System.Windows.Forms.NumericUpDown();
            this.comboBoxJenisBarang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panelSimpan.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(354, 48);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "Cari Barang...";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.Enter += new System.EventHandler(this.textBox4_Enter);
            // 
            // panelSimpan
            // 
            this.panelSimpan.Controls.Add(this.buttonBat);
            this.panelSimpan.Controls.Add(this.buttonSim2);
            this.panelSimpan.Controls.Add(this.buttonSim1);
            this.panelSimpan.Location = new System.Drawing.Point(423, 286);
            this.panelSimpan.Name = "panelSimpan";
            this.panelSimpan.Size = new System.Drawing.Size(81, 85);
            this.panelSimpan.TabIndex = 10;
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
            // panelButton
            // 
            this.panelButton.Controls.Add(this.buttonHap);
            this.panelButton.Controls.Add(this.buttonUba);
            this.panelButton.Controls.Add(this.buttonTam);
            this.panelButton.Location = new System.Drawing.Point(15, 204);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(277, 40);
            this.panelButton.TabIndex = 9;
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
            // panelForm
            // 
            this.panelForm.Controls.Add(this.numericUpDownStok);
            this.panelForm.Controls.Add(this.comboBoxJenisBarang);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.textBoxHarga);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.textBoxName);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Location = new System.Drawing.Point(15, 250);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(298, 121);
            this.panelForm.TabIndex = 8;
            // 
            // numericUpDownStok
            // 
            this.numericUpDownStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.numericUpDownStok.Location = new System.Drawing.Point(94, 65);
            this.numericUpDownStok.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownStok.Name = "numericUpDownStok";
            this.numericUpDownStok.Size = new System.Drawing.Size(180, 20);
            this.numericUpDownStok.TabIndex = 8;
            // 
            // comboBoxJenisBarang
            // 
            this.comboBoxJenisBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.comboBoxJenisBarang.FormattingEnabled = true;
            this.comboBoxJenisBarang.Location = new System.Drawing.Point(94, 91);
            this.comboBoxJenisBarang.Name = "comboBoxJenisBarang";
            this.comboBoxJenisBarang.Size = new System.Drawing.Size(180, 21);
            this.comboBoxJenisBarang.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Jenis Barang :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stok Barang :";
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.textBoxHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHarga.Location = new System.Drawing.Point(94, 37);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(180, 20);
            this.textBoxHarga.TabIndex = 3;
            this.textBoxHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHarga_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga Barang :";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Location = new System.Drawing.Point(94, 10);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(180, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Barang :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(478, 124);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kelola Barang";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "Print Barcode";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // MasterBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(504, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.panelSimpan);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "MasterBarang";
            this.Text = "MasterBarang";
            this.Load += new System.EventHandler(this.MasterBarang_Load);
            this.panelSimpan.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panelSimpan;
        private System.Windows.Forms.Button buttonBat;
        private System.Windows.Forms.Button buttonSim2;
        private System.Windows.Forms.Button buttonSim1;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonHap;
        private System.Windows.Forms.Button buttonUba;
        private System.Windows.Forms.Button buttonTam;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.NumericUpDown numericUpDownStok;
        private System.Windows.Forms.ComboBox comboBoxJenisBarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}