namespace Kelime_Oyunu
{
    partial class Öneriler
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
            txt_cevap = new TextBox();
            txt_soru = new TextBox();
            txt_email = new TextBox();
            btn_öneri_yolla = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txt_cevap
            // 
            txt_cevap.BackColor = Color.Turquoise;
            txt_cevap.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cevap.Location = new Point(61, 214);
            txt_cevap.Name = "txt_cevap";
            txt_cevap.PlaceholderText = "Cevabınız?";
            txt_cevap.Size = new Size(267, 31);
            txt_cevap.TabIndex = 1;
            // 
            // txt_soru
            // 
            txt_soru.BackColor = Color.Turquoise;
            txt_soru.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_soru.Location = new Point(61, 144);
            txt_soru.Name = "txt_soru";
            txt_soru.PlaceholderText = "Sorunuzu yazınız lütfen?";
            txt_soru.Size = new Size(682, 34);
            txt_soru.TabIndex = 1;
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.Turquoise;
            txt_email.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(61, 281);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "Örnek@gmail.com";
            txt_email.Size = new Size(267, 31);
            txt_email.TabIndex = 1;
            // 
            // btn_öneri_yolla
            // 
            btn_öneri_yolla.BackColor = Color.Yellow;
            btn_öneri_yolla.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_öneri_yolla.ForeColor = Color.Brown;
            btn_öneri_yolla.Location = new Point(426, 214);
            btn_öneri_yolla.Name = "btn_öneri_yolla";
            btn_öneri_yolla.Size = new Size(317, 98);
            btn_öneri_yolla.TabIndex = 3;
            btn_öneri_yolla.Text = "Öneriyi yolla";
            btn_öneri_yolla.UseVisualStyleBackColor = false;
            btn_öneri_yolla.Click += btn_öneri_yolla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Aquamarine;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(63, 118);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "Soru";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Aquamarine;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(63, 192);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Cevap";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Aquamarine;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(63, 259);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // Öneriler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_öneri_yolla);
            Controls.Add(txt_soru);
            Controls.Add(txt_email);
            Controls.Add(txt_cevap);
            ForeColor = SystemColors.ButtonShadow;
            Name = "Öneriler";
            Size = new Size(821, 475);
            Load += Öneriler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_cevap;
        private TextBox txt_soru;
        private TextBox txt_email;
        private Button btn_öneri_yolla;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}