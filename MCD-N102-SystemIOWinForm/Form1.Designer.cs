
namespace MCD_N102_SystemIOWinForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnpersonelgetir = new System.Windows.Forms.Button();
            this.btnpersonelKaydet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtulke = new System.Windows.Forms.TextBox();
            this.txtfirma = new System.Windows.Forms.TextBox();
            this.txtemailadres = new System.Windows.Forms.TextBox();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstpersonel = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstpersonel);
            this.groupBox1.Location = new System.Drawing.Point(21, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(444, 579);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Liste";
            // 
            // btnpersonelgetir
            // 
            this.btnpersonelgetir.Location = new System.Drawing.Point(111, 615);
            this.btnpersonelgetir.Name = "btnpersonelgetir";
            this.btnpersonelgetir.Size = new System.Drawing.Size(263, 43);
            this.btnpersonelgetir.TabIndex = 1;
            this.btnpersonelgetir.Text = "Personel Getir";
            this.btnpersonelgetir.UseVisualStyleBackColor = true;
            this.btnpersonelgetir.Click += new System.EventHandler(this.btnpersonelgetir_Click);
            // 
            // btnpersonelKaydet
            // 
            this.btnpersonelKaydet.Location = new System.Drawing.Point(111, 679);
            this.btnpersonelKaydet.Name = "btnpersonelKaydet";
            this.btnpersonelKaydet.Size = new System.Drawing.Size(263, 43);
            this.btnpersonelKaydet.TabIndex = 2;
            this.btnpersonelKaydet.Text = "Personel Kaydet";
            this.btnpersonelKaydet.UseVisualStyleBackColor = true;
            this.btnpersonelKaydet.Click += new System.EventHandler(this.btnpersonelKaydet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtulke);
            this.groupBox2.Controls.Add(this.txtfirma);
            this.groupBox2.Controls.Add(this.txtemailadres);
            this.groupBox2.Controls.Add(this.txtsoyisim);
            this.groupBox2.Controls.Add(this.txtisim);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(524, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 336);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Detay";
            // 
            // txtulke
            // 
            this.txtulke.Location = new System.Drawing.Point(175, 273);
            this.txtulke.Name = "txtulke";
            this.txtulke.Size = new System.Drawing.Size(240, 30);
            this.txtulke.TabIndex = 9;
            // 
            // txtfirma
            // 
            this.txtfirma.Location = new System.Drawing.Point(175, 222);
            this.txtfirma.Name = "txtfirma";
            this.txtfirma.Size = new System.Drawing.Size(240, 30);
            this.txtfirma.TabIndex = 8;
            // 
            // txtemailadres
            // 
            this.txtemailadres.Location = new System.Drawing.Point(176, 170);
            this.txtemailadres.Name = "txtemailadres";
            this.txtemailadres.Size = new System.Drawing.Size(240, 30);
            this.txtemailadres.TabIndex = 7;
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(175, 119);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(240, 30);
            this.txtsoyisim.TabIndex = 6;
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(175, 74);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(240, 30);
            this.txtisim.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ülke :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Firma :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email Adres :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim :";
            // 
            // lstpersonel
            // 
            this.lstpersonel.FormattingEnabled = true;
            this.lstpersonel.ItemHeight = 24;
            this.lstpersonel.Location = new System.Drawing.Point(24, 31);
            this.lstpersonel.Name = "lstpersonel";
            this.lstpersonel.Size = new System.Drawing.Size(395, 532);
            this.lstpersonel.TabIndex = 0;
            this.lstpersonel.DoubleClick += new System.EventHandler(this.lstpersonel_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 739);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnpersonelKaydet);
            this.Controls.Add(this.btnpersonelgetir);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnpersonelgetir;
        private System.Windows.Forms.Button btnpersonelKaydet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtulke;
        private System.Windows.Forms.TextBox txtfirma;
        private System.Windows.Forms.TextBox txtemailadres;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstpersonel;
    }
}

