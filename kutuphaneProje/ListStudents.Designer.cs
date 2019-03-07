namespace kutuphaneProje
{
    partial class ListStudents
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
            this.dgListStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgListStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListStudents
            // 
            this.dgListStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgListStudents.Location = new System.Drawing.Point(0, 0);
            this.dgListStudents.Name = "dgListStudents";
            this.dgListStudents.Size = new System.Drawing.Size(735, 405);
            this.dgListStudents.TabIndex = 0;
            // 
            // ListStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 405);
            this.Controls.Add(this.dgListStudents);
            this.Name = "ListStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListStudents";
            this.Load += new System.EventHandler(this.ListStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListStudents;
    }
}