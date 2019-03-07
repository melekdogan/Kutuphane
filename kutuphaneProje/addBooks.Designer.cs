namespace kutuphaneProje
{
    partial class addBooks
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
        public void InitializeComponent()
        {
            this.comboBoxYazar = new System.Windows.Forms.ComboBox();
            this.addW = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSayfaS = new System.Windows.Forms.TextBox();
            this.txtPuan = new System.Windows.Forms.TextBox();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.comboBoxTur = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addK = new System.Windows.Forms.Button();
            this.eklebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxYazar
            // 
            this.comboBoxYazar.AccessibleName = "";
            this.comboBoxYazar.DropDownHeight = 90;
            this.comboBoxYazar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYazar.DropDownWidth = 85;
            this.comboBoxYazar.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxYazar.FormattingEnabled = true;
            this.comboBoxYazar.IntegralHeight = false;
            this.comboBoxYazar.Location = new System.Drawing.Point(166, 136);
            this.comboBoxYazar.Name = "comboBoxYazar";
            this.comboBoxYazar.Size = new System.Drawing.Size(146, 25);
            this.comboBoxYazar.TabIndex = 0;
            // 
            // addW
            // 
            this.addW.BackColor = System.Drawing.Color.RosyBrown;
            this.addW.Location = new System.Drawing.Point(469, 136);
            this.addW.Name = "addW";
            this.addW.Size = new System.Drawing.Size(55, 23);
            this.addW.TabIndex = 1;
            this.addW.Text = "Ekle";
            this.addW.UseVisualStyleBackColor = false;
            this.addW.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(330, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aradığın yazar yok mu?";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtISBN.Location = new System.Drawing.Point(167, 41);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(145, 26);
            this.txtISBN.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "ISBN  No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kitap Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(65, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "Yazar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(88, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tür:";
            // 
            // txtSayfaS
            // 
            this.txtSayfaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayfaS.Location = new System.Drawing.Point(167, 230);
            this.txtSayfaS.Name = "txtSayfaS";
            this.txtSayfaS.Size = new System.Drawing.Size(144, 26);
            this.txtSayfaS.TabIndex = 12;
            // 
            // txtPuan
            // 
            this.txtPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPuan.Location = new System.Drawing.Point(166, 285);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(145, 26);
            this.txtPuan.TabIndex = 13;
           
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAd.Location = new System.Drawing.Point(167, 88);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(145, 26);
            this.txtKitapAd.TabIndex = 15;
            this.txtKitapAd.Tag = "";
            // 
            // comboBoxTur
            // 
            this.comboBoxTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTur.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxTur.FormattingEnabled = true;
            this.comboBoxTur.Location = new System.Drawing.Point(166, 182);
            this.comboBoxTur.Name = "comboBoxTur";
            this.comboBoxTur.Size = new System.Drawing.Size(145, 25);
            this.comboBoxTur.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(7, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 33);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sayfa Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(74, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 33);
            this.label7.TabIndex = 18;
            this.label7.Text = "Puan:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(330, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Aradığın tür yok mu?";
            // 
            // addK
            // 
            this.addK.BackColor = System.Drawing.Color.RosyBrown;
            this.addK.Location = new System.Drawing.Point(469, 179);
            this.addK.Name = "addK";
            this.addK.Size = new System.Drawing.Size(55, 23);
            this.addK.TabIndex = 20;
            this.addK.Text = "Ekle";
            this.addK.UseVisualStyleBackColor = false;
            this.addK.Click += new System.EventHandler(this.addK_Click);
            // 
            // eklebtn
            // 
            this.eklebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eklebtn.FlatAppearance.BorderSize = 0;
            this.eklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eklebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eklebtn.Image = global::kutuphaneProje.Properties.Resources.save__2_;
            this.eklebtn.Location = new System.Drawing.Point(483, 314);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(29, 31);
            this.eklebtn.TabIndex = 21;
            this.eklebtn.TabStop = false;
            this.eklebtn.UseVisualStyleBackColor = false;
            this.eklebtn.Click += new System.EventHandler(this.eklebtn_Click);
            // 
            // addBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(524, 357);
            this.Controls.Add(this.eklebtn);
            this.Controls.Add(this.addK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxTur);
            this.Controls.Add(this.txtKitapAd);
            this.Controls.Add(this.txtPuan);
            this.Controls.Add(this.txtSayfaS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addW);
            this.Controls.Add(this.comboBoxYazar);
            this.Name = "addBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addBooks";
            this.Load += new System.EventHandler(this.addBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       public System.Windows.Forms.ComboBox comboBoxYazar;
        private System.Windows.Forms.Button addW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSayfaS;
        private System.Windows.Forms.TextBox txtPuan;
        private System.Windows.Forms.TextBox txtKitapAd;
        public System.Windows.Forms.ComboBox comboBoxTur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addK;
        private System.Windows.Forms.Button eklebtn;
    }
}