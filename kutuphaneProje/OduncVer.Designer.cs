namespace kutuphaneProje
{
    partial class OduncVer
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
            this.cmbkitap = new System.Windows.Forms.ComboBox();
            this.DTPAtarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOgrenci = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbkitap
            // 
            this.cmbkitap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkitap.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbkitap.FormattingEnabled = true;
            this.cmbkitap.Location = new System.Drawing.Point(125, 110);
            this.cmbkitap.Name = "cmbkitap";
            this.cmbkitap.Size = new System.Drawing.Size(223, 28);
            this.cmbkitap.TabIndex = 1;
            // 
            // DTPAtarih
            // 
            this.DTPAtarih.Location = new System.Drawing.Point(128, 167);
            this.DTPAtarih.Name = "DTPAtarih";
            this.DTPAtarih.Size = new System.Drawing.Size(220, 20);
            this.DTPAtarih.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kitap:";
            // 
            // cmbOgrenci
            // 
            this.cmbOgrenci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgrenci.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOgrenci.FormattingEnabled = true;
            this.cmbOgrenci.Location = new System.Drawing.Point(125, 56);
            this.cmbOgrenci.Name = "cmbOgrenci";
            this.cmbOgrenci.Size = new System.Drawing.Size(223, 28);
            this.cmbOgrenci.TabIndex = 5;
            this.cmbOgrenci.SelectedIndexChanged += new System.EventHandler(this.cmbOgrenci_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Öğrenci:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alış Tarihi:";
            // 
            // savebtn
            // 
            this.savebtn.FlatAppearance.BorderSize = 0;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Image = global::kutuphaneProje.Properties.Resources.save__2_;
            this.savebtn.Location = new System.Drawing.Point(315, 210);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(33, 35);
            this.savebtn.TabIndex = 0;
            this.savebtn.TabStop = false;
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // OduncVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(360, 257);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOgrenci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPAtarih);
            this.Controls.Add(this.cmbkitap);
            this.Controls.Add(this.savebtn);
            this.Name = "OduncVer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OduncVer";
            this.Load += new System.EventHandler(this.OduncVer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.ComboBox cmbkitap;
        private System.Windows.Forms.DateTimePicker DTPAtarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOgrenci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}