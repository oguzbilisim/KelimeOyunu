namespace KelimeBulmaOyunu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.isimText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.soruTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.puanEklemeText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cevapEklemeText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.soruEklemeText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.puanLabel = new System.Windows.Forms.Label();
            this.puanTablosuButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblScreen = new System.Windows.Forms.Label();
            this.adsoyadlbl = new System.Windows.Forms.Label();
            this.puanlbl = new System.Windows.Forms.Label();
            this.kalansurelbl = new System.Windows.Forms.Label();
            this.tarihlbl = new System.Windows.Forms.Label();
            this.tarih2lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(18, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tahmin Et";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(3, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(3, 26);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 30);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(224, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 88);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bulunacak Kelime";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 59);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = ": 240";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ders11_KelimeBulmaOyunu.Properties.Resources.clock;
            this.pictureBox1.Location = new System.Drawing.Point(18, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(31, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "Oyuna Başla";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // isimText
            // 
            this.isimText.Location = new System.Drawing.Point(31, 64);
            this.isimText.Name = "isimText";
            this.isimText.Size = new System.Drawing.Size(203, 30);
            this.isimText.TabIndex = 10;
            this.isimText.TextChanged += new System.EventHandler(this.isimText_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ad Soyad";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.isimText);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(430, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 179);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Soru";
            // 
            // soruTextBox
            // 
            this.soruTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruTextBox.ForeColor = System.Drawing.Color.Red;
            this.soruTextBox.Location = new System.Drawing.Point(18, 322);
            this.soruTextBox.Name = "soruTextBox";
            this.soruTextBox.Size = new System.Drawing.Size(1024, 139);
            this.soruTextBox.TabIndex = 14;
            this.soruTextBox.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.puanEklemeText);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.cevapEklemeText);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.soruEklemeText);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(695, 57);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(337, 259);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Soru Ekleme";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(26, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 40);
            this.button3.TabIndex = 18;
            this.button3.Text = "Soru Ekle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // puanEklemeText
            // 
            this.puanEklemeText.Location = new System.Drawing.Point(26, 162);
            this.puanEklemeText.Name = "puanEklemeText";
            this.puanEklemeText.Size = new System.Drawing.Size(236, 30);
            this.puanEklemeText.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Puan";
            // 
            // cevapEklemeText
            // 
            this.cevapEklemeText.Location = new System.Drawing.Point(26, 110);
            this.cevapEklemeText.Name = "cevapEklemeText";
            this.cevapEklemeText.Size = new System.Drawing.Size(236, 30);
            this.cevapEklemeText.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cevap";
            // 
            // soruEklemeText
            // 
            this.soruEklemeText.Location = new System.Drawing.Point(26, 55);
            this.soruEklemeText.Name = "soruEklemeText";
            this.soruEklemeText.Size = new System.Drawing.Size(236, 30);
            this.soruEklemeText.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Soru";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(107, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Puan";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // puanLabel
            // 
            this.puanLabel.AutoSize = true;
            this.puanLabel.Location = new System.Drawing.Point(171, 19);
            this.puanLabel.Name = "puanLabel";
            this.puanLabel.Size = new System.Drawing.Size(23, 25);
            this.puanLabel.TabIndex = 16;
            this.puanLabel.Text = "0";
            // 
            // puanTablosuButton
            // 
            this.puanTablosuButton.BackColor = System.Drawing.Color.Yellow;
            this.puanTablosuButton.Location = new System.Drawing.Point(263, 12);
            this.puanTablosuButton.Name = "puanTablosuButton";
            this.puanTablosuButton.Size = new System.Drawing.Size(147, 28);
            this.puanTablosuButton.TabIndex = 17;
            this.puanTablosuButton.Text = "Puan Tablosu";
            this.puanTablosuButton.UseVisualStyleBackColor = false;
            this.puanTablosuButton.Click += new System.EventHandler(this.puanTablosuButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Fuchsia;
            this.button4.Location = new System.Drawing.Point(416, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 29);
            this.button4.TabIndex = 18;
            this.button4.Text = "Harf Lütfen";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(48, 191);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 85);
            this.button5.TabIndex = 19;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button5_MouseClick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblScreen
            // 
            this.lblScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScreen.ForeColor = System.Drawing.Color.Red;
            this.lblScreen.Location = new System.Drawing.Point(97, 144);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(68, 37);
            this.lblScreen.TabIndex = 20;
            // 
            // adsoyadlbl
            // 
            this.adsoyadlbl.AutoSize = true;
            this.adsoyadlbl.Location = new System.Drawing.Point(227, 162);
            this.adsoyadlbl.Name = "adsoyadlbl";
            this.adsoyadlbl.Size = new System.Drawing.Size(0, 25);
            this.adsoyadlbl.TabIndex = 21;
            this.adsoyadlbl.Visible = false;
            this.adsoyadlbl.Click += new System.EventHandler(this.adsoyadlbl_Click);
            // 
            // puanlbl
            // 
            this.puanlbl.AutoSize = true;
            this.puanlbl.Location = new System.Drawing.Point(227, 197);
            this.puanlbl.Name = "puanlbl";
            this.puanlbl.Size = new System.Drawing.Size(0, 25);
            this.puanlbl.TabIndex = 22;
            this.puanlbl.Click += new System.EventHandler(this.puanlbl_Click);
            // 
            // kalansurelbl
            // 
            this.kalansurelbl.AutoSize = true;
            this.kalansurelbl.Location = new System.Drawing.Point(227, 235);
            this.kalansurelbl.Name = "kalansurelbl";
            this.kalansurelbl.Size = new System.Drawing.Size(0, 25);
            this.kalansurelbl.TabIndex = 23;
            // 
            // tarihlbl
            // 
            this.tarihlbl.AutoSize = true;
            this.tarihlbl.Location = new System.Drawing.Point(227, 270);
            this.tarihlbl.Name = "tarihlbl";
            this.tarihlbl.Size = new System.Drawing.Size(49, 25);
            this.tarihlbl.TabIndex = 24;
            this.tarihlbl.Text = "tarih";
            this.tarihlbl.Visible = false;
            // 
            // tarih2lbl
            // 
            this.tarih2lbl.AutoSize = true;
            this.tarih2lbl.Location = new System.Drawing.Point(227, 299);
            this.tarih2lbl.Name = "tarih2lbl";
            this.tarih2lbl.Size = new System.Drawing.Size(60, 25);
            this.tarih2lbl.TabIndex = 25;
            this.tarih2lbl.Text = "tarih2";
            this.tarih2lbl.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 475);
            this.Controls.Add(this.tarih2lbl);
            this.Controls.Add(this.tarihlbl);
            this.Controls.Add(this.kalansurelbl);
            this.Controls.Add(this.puanlbl);
            this.Controls.Add(this.adsoyadlbl);
            this.Controls.Add(this.lblScreen);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.puanTablosuButton);
            this.Controls.Add(this.puanLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.soruTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Kelime Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox isimText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox soruTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox puanEklemeText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cevapEklemeText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox soruEklemeText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label puanLabel;
        private System.Windows.Forms.Button puanTablosuButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Label adsoyadlbl;
        private System.Windows.Forms.Label puanlbl;
        private System.Windows.Forms.Label kalansurelbl;
        private System.Windows.Forms.Label tarihlbl;
        private System.Windows.Forms.Label tarih2lbl;
    }
}

