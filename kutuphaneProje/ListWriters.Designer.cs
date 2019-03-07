namespace kutuphaneProje
{
    partial class ListWriters
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
            this.dgListWriters = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgListWriters)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListWriters
            // 
            this.dgListWriters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListWriters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgListWriters.Location = new System.Drawing.Point(0, 0);
            this.dgListWriters.Name = "dgListWriters";
            this.dgListWriters.Size = new System.Drawing.Size(456, 483);
            this.dgListWriters.TabIndex = 0;
            // 
            // ListWriters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 483);
            this.Controls.Add(this.dgListWriters);
            this.Name = "ListWriters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListWriters";
            this.Load += new System.EventHandler(this.ListWriters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListWriters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListWriters;
    }
}