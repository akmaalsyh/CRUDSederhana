namespace CRUDSederhana
{
    partial class Form1
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
            this.NIM = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Telepon = new System.Windows.Forms.Label();
            this.Alamat = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NIM
            // 
            this.NIM.AutoSize = true;
            this.NIM.Location = new System.Drawing.Point(87, 57);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(31, 16);
            this.NIM.TabIndex = 0;
            this.NIM.Text = "NIM";
            this.NIM.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(87, 85);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(44, 16);
            this.Nama.TabIndex = 1;
            this.Nama.Text = "Nama";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(87, 113);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 16);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email";
            // 
            // Telepon
            // 
            this.Telepon.AutoSize = true;
            this.Telepon.Location = new System.Drawing.Point(87, 140);
            this.Telepon.Name = "Telepon";
            this.Telepon.Size = new System.Drawing.Size(58, 16);
            this.Telepon.TabIndex = 3;
            this.Telepon.Text = "Telepon";
            // 
            // Alamat
            // 
            this.Alamat.AutoSize = true;
            this.Alamat.Location = new System.Drawing.Point(87, 166);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(49, 16);
            this.Alamat.TabIndex = 4;
            this.Alamat.Text = "Alamat";
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(153, 54);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(304, 22);
            this.txtNIM.TabIndex = 5;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(153, 82);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(304, 22);
            this.txtNama.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(153, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(304, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // txtTelepon
            // 
            this.txtTelepon.Location = new System.Drawing.Point(153, 137);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(304, 22);
            this.txtTelepon.TabIndex = 8;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(153, 166);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(304, 22);
            this.txtAlamat.TabIndex = 9;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(503, 57);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(150, 29);
            this.btnTambah.TabIndex = 10;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(503, 92);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(150, 29);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.Alamat);
            this.Controls.Add(this.Telepon);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.NIM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NIM;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Telepon;
        private System.Windows.Forms.Label Alamat;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
    }
}

