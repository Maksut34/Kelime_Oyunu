namespace Kelime_Oyunu
{
    partial class YeniOyun
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbl_Ekran = new Label();
            btn_başla = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lbl_saniye = new Label();
            label1 = new Label();
            lbl_dakika = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            txt_cevap = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btn_cevap = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Ekran
            // 
            lbl_Ekran.BackColor = SystemColors.ActiveCaptionText;
            lbl_Ekran.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Ekran.ForeColor = Color.Chartreuse;
            lbl_Ekran.Location = new Point(131, 94);
            lbl_Ekran.Name = "lbl_Ekran";
            lbl_Ekran.Size = new Size(572, 78);
            lbl_Ekran.TabIndex = 0;
            lbl_Ekran.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_başla
            // 
            btn_başla.BackColor = Color.YellowGreen;
            btn_başla.Location = new Point(31, 110);
            btn_başla.Name = "btn_başla";
            btn_başla.Size = new Size(85, 48);
            btn_başla.TabIndex = 2;
            btn_başla.Text = "Başla";
            btn_başla.UseVisualStyleBackColor = false;
            btn_başla.Click += btn_başla_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lbl_saniye
            // 
            lbl_saniye.AutoSize = true;
            lbl_saniye.Location = new Point(51, 54);
            lbl_saniye.Name = "lbl_saniye";
            lbl_saniye.Size = new Size(19, 15);
            lbl_saniye.TabIndex = 3;
            lbl_saniye.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 54);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 3;
            label1.Text = ":";
            // 
            // lbl_dakika
            // 
            lbl_dakika.AutoSize = true;
            lbl_dakika.Location = new Point(6, 54);
            lbl_dakika.Name = "lbl_dakika";
            lbl_dakika.Size = new Size(19, 15);
            lbl_dakika.TabIndex = 3;
            lbl_dakika.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 31);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 3;
            label4.Text = "SN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 31);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 3;
            label5.Text = "DK";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lbl_saniye);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbl_dakika);
            groupBox1.Location = new Point(32, 235);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(85, 85);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Zaman";
            // 
            // txt_cevap
            // 
            txt_cevap.BackColor = Color.Wheat;
            txt_cevap.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cevap.ForeColor = Color.Sienna;
            txt_cevap.Location = new Point(131, 276);
            txt_cevap.Name = "txt_cevap";
            txt_cevap.Size = new Size(238, 34);
            txt_cevap.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ravie", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Chocolate;
            label2.Location = new Point(131, 235);
            label2.Name = "label2";
            label2.Size = new Size(88, 27);
            label2.TabIndex = 3;
            label2.Text = "Cevap";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(410, 235);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 191);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btn_cevap
            // 
            btn_cevap.BackColor = Color.PaleTurquoise;
            btn_cevap.Location = new Point(131, 343);
            btn_cevap.Name = "btn_cevap";
            btn_cevap.Size = new Size(238, 48);
            btn_cevap.TabIndex = 2;
            btn_cevap.Text = "Doğru mu?";
            btn_cevap.UseVisualStyleBackColor = false;
            btn_cevap.Click += btn_cevap_Click;
            // 
            // YeniOyun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            Controls.Add(pictureBox1);
            Controls.Add(txt_cevap);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(btn_cevap);
            Controls.Add(btn_başla);
            Controls.Add(lbl_Ekran);
            ForeColor = SystemColors.ControlText;
            Name = "YeniOyun";
            Size = new Size(821, 475);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Ekran;
        private Button btn_başla;
        private System.Windows.Forms.Timer timer1;
        private Label lbl_saniye;
        private Label label1;
        private Label lbl_dakika;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox txt_cevap;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btn_cevap;
    }
}
