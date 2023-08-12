namespace Kelime_Oyunu
{
    partial class AnaSayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            btnAnasayfa = new TabControl();
            ansayfa = new TabPage();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btn_çııkış = new Button();
            btn_öneriler = new Button();
            btn_kayıt = new Button();
            btn_giriş = new Button();
            tabPage2 = new TabPage();
            İletişim = new TabPage();
            btnAnasayfa.SuspendLayout();
            ansayfa.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnAnasayfa
            // 
            btnAnasayfa.Controls.Add(ansayfa);
            btnAnasayfa.Controls.Add(tabPage2);
            btnAnasayfa.Controls.Add(İletişim);
            btnAnasayfa.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnasayfa.Location = new Point(-1, 3);
            btnAnasayfa.Name = "btnAnasayfa";
            btnAnasayfa.SelectedIndex = 0;
            btnAnasayfa.Size = new Size(1045, 524);
            btnAnasayfa.TabIndex = 2;
            btnAnasayfa.Click += AnaSayfa_Load;
            btnAnasayfa.MouseClick += btnAnasayfa_MouseClick;
            // 
            // ansayfa
            // 
            ansayfa.BackColor = Color.Teal;
            ansayfa.Controls.Add(panel1);
            ansayfa.Controls.Add(panel3);
            ansayfa.ForeColor = Color.Red;
            ansayfa.ImeMode = ImeMode.NoControl;
            ansayfa.Location = new Point(4, 37);
            ansayfa.Name = "ansayfa";
            ansayfa.Padding = new Padding(3);
            ansayfa.Size = new Size(1037, 483);
            ansayfa.TabIndex = 0;
            ansayfa.Text = "AnaSayfa";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(821, 475);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(36, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(752, 428);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.SkyBlue;
            label1.Font = new Font("Segoe Print", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(160, 61);
            label1.Name = "label1";
            label1.Size = new Size(433, 62);
            label1.TabIndex = 10;
            label1.Text = "Kelime Oyunu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(160, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(433, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SpringGreen;
            panel3.Controls.Add(btn_çııkış);
            panel3.Controls.Add(btn_öneriler);
            panel3.Controls.Add(btn_kayıt);
            panel3.Controls.Add(btn_giriş);
            panel3.Location = new Point(841, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(178, 423);
            panel3.TabIndex = 0;
            // 
            // btn_çııkış
            // 
            btn_çııkış.BackColor = Color.SkyBlue;
            btn_çııkış.Font = new Font("Segoe Print", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_çııkış.ForeColor = Color.Chocolate;
            btn_çııkış.Location = new Point(50, 268);
            btn_çııkış.Name = "btn_çııkış";
            btn_çııkış.Size = new Size(90, 39);
            btn_çııkış.TabIndex = 0;
            btn_çııkış.Text = "Çıkış";
            btn_çııkış.UseVisualStyleBackColor = false;
            btn_çııkış.Click += btn_çııkış_Click;
            // 
            // btn_öneriler
            // 
            btn_öneriler.BackColor = Color.SkyBlue;
            btn_öneriler.Font = new Font("Segoe Print", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_öneriler.ForeColor = Color.Chocolate;
            btn_öneriler.Location = new Point(50, 207);
            btn_öneriler.Name = "btn_öneriler";
            btn_öneriler.Size = new Size(90, 39);
            btn_öneriler.TabIndex = 0;
            btn_öneriler.Text = "Öneriler";
            btn_öneriler.UseVisualStyleBackColor = false;
            btn_öneriler.Click += btn_öneriler_Click;
            // 
            // btn_kayıt
            // 
            btn_kayıt.BackColor = Color.SkyBlue;
            btn_kayıt.Font = new Font("Segoe Print", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_kayıt.ForeColor = Color.Chocolate;
            btn_kayıt.Location = new Point(50, 145);
            btn_kayıt.Name = "btn_kayıt";
            btn_kayıt.Size = new Size(90, 39);
            btn_kayıt.TabIndex = 0;
            btn_kayıt.Text = "Kayıt";
            btn_kayıt.UseVisualStyleBackColor = false;
            btn_kayıt.Click += btn_kayıt_Click;
            // 
            // btn_giriş
            // 
            btn_giriş.BackColor = Color.SkyBlue;
            btn_giriş.Font = new Font("Segoe Print", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_giriş.ForeColor = Color.Chocolate;
            btn_giriş.Location = new Point(50, 87);
            btn_giriş.Name = "btn_giriş";
            btn_giriş.Size = new Size(90, 39);
            btn_giriş.TabIndex = 0;
            btn_giriş.Text = "Giriş";
            btn_giriş.UseVisualStyleBackColor = false;
            btn_giriş.Click += btn_giriş_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1037, 483);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Hakkımızda";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // İletişim
            // 
            İletişim.Location = new Point(4, 37);
            İletişim.Name = "İletişim";
            İletişim.Padding = new Padding(3);
            İletişim.Size = new Size(1037, 483);
            İletişim.TabIndex = 2;
            İletişim.Text = "İletişim";
            İletişim.UseVisualStyleBackColor = true;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1043, 526);
            Controls.Add(btnAnasayfa);
            Name = "AnaSayfa";
            Text = "Ana Sayfa";
            
            btnAnasayfa.ResumeLayout(false);
            ansayfa.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl btnAnasayfa;
        private TabPage ansayfa;
        private Panel panel3;
        private Button btn_çııkış;
        private Button btn_öneriler;
        private Button btn_kayıt;
        private Button btn_giriş;
        private TabPage tabPage2;
        private TabPage İletişim;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}