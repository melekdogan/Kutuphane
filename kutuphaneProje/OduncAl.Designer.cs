namespace kutuphaneProje
{
    partial class OduncAl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTPVtarih = new System.Windows.Forms.DateTimePicker();
            this.savebtn = new System.Windows.Forms.Button();
            this.cmbOgrenci = new System.Windows.Forms.ComboBox();
            this.cmbKitap = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Öğrenci:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kitap:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Veriş Tarihi:";
            // 
            // DTPVtarih
            // 
            this.DTPVtarih.Location = new System.Drawing.Point(142, 179);
            this.DTPVtarih.Name = "DTPVtarih";
            this.DTPVtarih.Size = new System.Drawing.Size(220, 20);
            this.DTPVtarih.TabIndex = 10;
            // 
            // savebtn
            // 
            this.savebtn.FlatAppearance.BorderSize = 0;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Image = global::kutuphaneProje.Properties.Resources.save__2_;
            this.savebtn.Location = new System.Drawing.Point(329, 247);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(33, 35);
            this.savebtn.TabIndex = 11;
            this.savebtn.TabStop = false;
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // cmbOgrenci
            // 
            this.cmbOgrenci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgrenci.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOgrenci.FormattingEnabled = true;
            this.cmbOgrenci.Location = new System.Drawing.Point(139, 54);
            this.cmbOgrenci.Name = "cmbOgrenci";
            this.cmbOgrenci.Size = new System.Drawing.Size(223, 28);
            this.cmbOgrenci.TabIndex = 12;
            this.cmbOgrenci.SelectedIndexChanged += new System.EventHandler(this.cmbOgrenci_SelectedIndexChanged);
            // 
            // cmbKitap
            // 
            this.cmbKitap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKitap.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKitap.FormattingEnabled = true;
            this.cmbKitap.Location = new System.Drawing.Point(139, 111);
            this.cmbKitap.Name = "cmbKitap";
            this.cmbKitap.Size = new System.Drawing.Size(223, 28);
            this.cmbKitap.TabIndex = 13;
            // 
            // OduncAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(387, 291);
            this.Controls.Add(this.cmbKitap);
            this.Controls.Add(this.cmbOgrenci);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.DTPVtarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "OduncAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OduncAl";
            this.Load += new System.EventHandler(this.OduncAl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTPVtarih;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.ComboBox cmbOgrenci;
        private System.Windows.Forms.ComboBox cmbKitap;
    }
}