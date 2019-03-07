using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kutuphaneEntity;

namespace kutuphaneProje
{
    public partial class addKnd : Form
    {
        public addKnd()
        {
            InitializeComponent();
        }

        private void addK_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            KEntities entities = new KEntities();
            tur tur = new tur();
            tur.turadi = textBox1.Text;
            entities.tur.Add(tur);
            int sonuc = entities.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt Ekleme İşlemi Başarıyla Tamamlandı!");
            }

            /* -----------------------------------------*/
            addBooks addBooks = new addBooks();
            addBooks.comboBoxTur.Refresh();
            this.Close();
        }

        
    }
}
