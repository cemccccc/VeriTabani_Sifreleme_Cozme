namespace VeriTabani_Sifreleme
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtAd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtSoyad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtMail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.TxtSifre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TxtHesapNo = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(14, 186);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(670, 280);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 19);
			this.label1.TabIndex = 6;
			this.label1.Text = "Ad:";
			// 
			// TxtAd
			// 
			this.TxtAd.Location = new System.Drawing.Point(82, 14);
			this.TxtAd.Name = "TxtAd";
			this.TxtAd.Size = new System.Drawing.Size(158, 27);
			this.TxtAd.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 19);
			this.label2.TabIndex = 6;
			this.label2.Text = "Soyad:";
			// 
			// TxtSoyad
			// 
			this.TxtSoyad.Location = new System.Drawing.Point(82, 47);
			this.TxtSoyad.Name = "TxtSoyad";
			this.TxtSoyad.Size = new System.Drawing.Size(158, 27);
			this.TxtSoyad.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 19);
			this.label3.TabIndex = 6;
			this.label3.Text = "Mail:";
			// 
			// TxtMail
			// 
			this.TxtMail.Location = new System.Drawing.Point(82, 80);
			this.TxtMail.Name = "TxtMail";
			this.TxtMail.Size = new System.Drawing.Size(158, 27);
			this.TxtMail.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(391, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 19);
			this.label4.TabIndex = 6;
			this.label4.Text = "Şifre:";
			// 
			// TxtSifre
			// 
			this.TxtSifre.Location = new System.Drawing.Point(471, 14);
			this.TxtSifre.Name = "TxtSifre";
			this.TxtSifre.PasswordChar = '*';
			this.TxtSifre.Size = new System.Drawing.Size(158, 27);
			this.TxtSifre.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(391, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 19);
			this.label5.TabIndex = 6;
			this.label5.Text = "Hesap no:";
			// 
			// TxtHesapNo
			// 
			this.TxtHesapNo.Location = new System.Drawing.Point(471, 47);
			this.TxtHesapNo.Name = "TxtHesapNo";
			this.TxtHesapNo.Size = new System.Drawing.Size(158, 27);
			this.TxtHesapNo.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(531, 80);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 29);
			this.button1.TabIndex = 5;
			this.button1.Text = "Kaydet";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(696, 478);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.TxtHesapNo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.TxtSifre);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.TxtMail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TxtSoyad);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TxtAd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtAd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtSoyad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxtMail;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TxtSifre;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TxtHesapNo;
		private System.Windows.Forms.Button button1;
	}
}

