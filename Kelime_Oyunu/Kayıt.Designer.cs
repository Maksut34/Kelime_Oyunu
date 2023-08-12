namespace Kelime_Oyunu
{
    partial class Kayıt
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
            panel_kayıt = new Panel();
            maskedtxt_gsm = new MaskedTextBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label1 = new Label();
            txt_ad = new TextBox();
            txt_şifre = new TextBox();
            txt_email = new TextBox();
            txt_soyad = new TextBox();
            btn_giriş = new Button();
            btn_kaydet = new Button();
            panel_kayıt.SuspendLayout();
            SuspendLayout();
            // 
            // panel_kayıt
            // 
            panel_kayıt.Controls.Add(maskedtxt_gsm);
            panel_kayıt.Controls.Add(checkBox1);
            panel_kayıt.Controls.Add(label5);
            panel_kayıt.Controls.Add(label4);
            panel_kayıt.Controls.Add(label3);
            panel_kayıt.Controls.Add(label2);
            panel_kayıt.Controls.Add(label6);
            panel_kayıt.Controls.Add(label1);
            panel_kayıt.Controls.Add(txt_ad);
            panel_kayıt.Controls.Add(txt_şifre);
            panel_kayıt.Controls.Add(txt_email);
            panel_kayıt.Controls.Add(txt_soyad);
            panel_kayıt.Controls.Add(btn_giriş);
            panel_kayıt.Controls.Add(btn_kaydet);
            panel_kayıt.Dock = DockStyle.Fill;
            panel_kayıt.Location = new Point(0, 0);
            panel_kayıt.Name = "panel_kayıt";
            panel_kayıt.Size = new Size(821, 475);
            panel_kayıt.TabIndex = 0;
            // 
            // maskedtxt_gsm
            // 
            maskedtxt_gsm.BackColor = Color.Purple;
            maskedtxt_gsm.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            maskedtxt_gsm.ForeColor = Color.Transparent;
            maskedtxt_gsm.Location = new Point(183, 250);
            maskedtxt_gsm.Mask = "(999) 000-0000";
            maskedtxt_gsm.Name = "maskedtxt_gsm";
            maskedtxt_gsm.Size = new Size(347, 39);
            maskedtxt_gsm.TabIndex = 18;
            // 
            // checkBox1
            // 
            checkBox1.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.Chocolate;
            checkBox1.Location = new Point(536, 317);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 39);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "göster/sakla";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Chartreuse;
            label5.Location = new Point(326, 292);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 11;
            label5.Text = "Şifre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Chartreuse;
            label4.Location = new Point(326, 226);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 12;
            label4.Text = "Gsm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Chartreuse;
            label3.Location = new Point(326, 160);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 13;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Chartreuse;
            label2.Location = new Point(326, 95);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 14;
            label2.Text = "Soy Adınız";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Chartreuse;
            label6.Location = new Point(192, 424);
            label6.Name = "label6";
            label6.Size = new Size(327, 21);
            label6.TabIndex = 15;
            label6.Text = "Not:Bütün alanları doldurmak zorunludur!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Chartreuse;
            label1.Location = new Point(326, 29);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 16;
            label1.Text = "Adınız";
            // 
            // txt_ad
            // 
            txt_ad.BackColor = Color.Purple;
            txt_ad.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ad.ForeColor = Color.Transparent;
            txt_ad.Location = new Point(183, 53);
            txt_ad.Name = "txt_ad";
            txt_ad.PlaceholderText = "En az iki karakter!";
            txt_ad.Size = new Size(347, 39);
            txt_ad.TabIndex = 7;
            txt_ad.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_şifre
            // 
            txt_şifre.BackColor = Color.Purple;
            txt_şifre.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_şifre.ForeColor = Color.Transparent;
            txt_şifre.Location = new Point(183, 316);
            txt_şifre.Name = "txt_şifre";
            txt_şifre.PlaceholderText = "************";
            txt_şifre.Size = new Size(347, 39);
            txt_şifre.TabIndex = 8;
            txt_şifre.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.Purple;
            txt_email.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.ForeColor = Color.Transparent;
            txt_email.Location = new Point(183, 184);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "Örnek@gmail.com";
            txt_email.Size = new Size(347, 39);
            txt_email.TabIndex = 9;
            txt_email.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_soyad
            // 
            txt_soyad.BackColor = Color.Purple;
            txt_soyad.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_soyad.ForeColor = Color.Transparent;
            txt_soyad.Location = new Point(183, 119);
            txt_soyad.Name = "txt_soyad";
            txt_soyad.PlaceholderText = "En az iki karakter!";
            txt_soyad.Size = new Size(347, 39);
            txt_soyad.TabIndex = 10;
            txt_soyad.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_giriş
            // 
            btn_giriş.BackColor = Color.Aqua;
            btn_giriş.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_giriş.ForeColor = Color.Blue;
            btn_giriş.Location = new Point(374, 367);
            btn_giriş.Name = "btn_giriş";
            btn_giriş.Size = new Size(156, 44);
            btn_giriş.TabIndex = 5;
            btn_giriş.Text = "Giriş";
            btn_giriş.UseVisualStyleBackColor = false;
            btn_giriş.Click += btn_giriş_Click;
            // 
            // btn_kaydet
            // 
            btn_kaydet.BackColor = Color.Aqua;
            btn_kaydet.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_kaydet.ForeColor = Color.Blue;
            btn_kaydet.Location = new Point(183, 367);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(161, 44);
            btn_kaydet.TabIndex = 6;
            btn_kaydet.Text = "Kaydet";
            btn_kaydet.UseVisualStyleBackColor = false;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // Kayıt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(panel_kayıt);
            Name = "Kayıt";
            Size = new Size(821, 475);
            Load += Kayıt_Load;
            panel_kayıt.ResumeLayout(false);
            panel_kayıt.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_kayıt;
        private MaskedTextBox maskedtxt_gsm;
        private CheckBox checkBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label1;
        private TextBox txt_ad;
        private TextBox txt_şifre;
        private TextBox txt_email;
        private TextBox txt_soyad;
        private Button btn_giriş;
        private Button btn_kaydet;
    }
}