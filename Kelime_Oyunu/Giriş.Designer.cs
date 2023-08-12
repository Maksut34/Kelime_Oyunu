namespace Kelime_Oyunu
{
    partial class Giriş
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
            panel_giriş = new Panel();
            checkBox1 = new CheckBox();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            txt_şifre = new TextBox();
            txt_email = new TextBox();
            btn_kayıt = new Button();
            btn_ = new Button();
            panel_giriş.SuspendLayout();
            SuspendLayout();
            // 
            // panel_giriş
            // 
            panel_giriş.Controls.Add(checkBox1);
            panel_giriş.Controls.Add(label5);
            panel_giriş.Controls.Add(label3);
            panel_giriş.Controls.Add(label6);
            panel_giriş.Controls.Add(txt_şifre);
            panel_giriş.Controls.Add(txt_email);
            panel_giriş.Controls.Add(btn_kayıt);
            panel_giriş.Controls.Add(btn_);
            panel_giriş.Dock = DockStyle.Fill;
            panel_giriş.Location = new Point(0, 0);
            panel_giriş.Name = "panel_giriş";
            panel_giriş.Size = new Size(821, 475);
            panel_giriş.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.Chocolate;
            checkBox1.Location = new Point(536, 225);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 39);
            checkBox1.TabIndex = 25;
            checkBox1.Text = "göster/sakla";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Chartreuse;
            label5.Location = new Point(326, 200);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 22;
            label5.Text = "Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Chartreuse;
            label3.Location = new Point(326, 121);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 23;
            label3.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Chartreuse;
            label6.Location = new Point(192, 332);
            label6.Name = "label6";
            label6.Size = new Size(327, 21);
            label6.TabIndex = 24;
            label6.Text = "Not:Bütün alanları doldurmak zorunludur!";
            // 
            // txt_şifre
            // 
            txt_şifre.BackColor = Color.Purple;
            txt_şifre.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_şifre.ForeColor = Color.Transparent;
            txt_şifre.Location = new Point(183, 224);
            txt_şifre.Name = "txt_şifre";
            txt_şifre.PlaceholderText = "************";
            txt_şifre.Size = new Size(347, 39);
            txt_şifre.TabIndex = 20;
            txt_şifre.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.Purple;
            txt_email.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.ForeColor = Color.Transparent;
            txt_email.Location = new Point(183, 145);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "Örnek@gmail.com";
            txt_email.Size = new Size(347, 39);
            txt_email.TabIndex = 21;
            txt_email.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_kayıt
            // 
            btn_kayıt.BackColor = Color.Aqua;
            btn_kayıt.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_kayıt.ForeColor = Color.Blue;
            btn_kayıt.Location = new Point(356, 275);
            btn_kayıt.Name = "btn_kayıt";
            btn_kayıt.Size = new Size(174, 44);
            btn_kayıt.TabIndex = 18;
            btn_kayıt.Text = "Kayıt";
            btn_kayıt.UseVisualStyleBackColor = false;
            btn_kayıt.Click += btn_kayıt_Click;
            // 
            // btn_
            // 
            btn_.BackColor = Color.Aqua;
            btn_.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_.ForeColor = Color.Blue;
            btn_.Location = new Point(183, 275);
            btn_.Name = "btn_";
            btn_.Size = new Size(174, 44);
            btn_.TabIndex = 18;
            btn_.Text = "Giriş";
            btn_.UseVisualStyleBackColor = false;
            btn_.Click += btn__Click;
            // 
            // Giriş
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            Controls.Add(panel_giriş);
            Name = "Giriş";
            Size = new Size(821, 475);
            Load += Giriş_Load;
            panel_giriş.ResumeLayout(false);
            panel_giriş.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_giriş;
        private CheckBox checkBox1;
        private Label label5;
        private Label label3;
        private Label label6;
        private TextBox txt_şifre;
        private TextBox txt_email;
        private Button btn_;
        private Button btn_kayıt;
    }
}