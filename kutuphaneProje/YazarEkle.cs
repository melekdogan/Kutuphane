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
    public partial class YazarEkle : Form
    {
        public YazarEkle()
        {
            InitializeComponent();
        }
        KEntities entities = new KEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            yazar yazar = new yazar();
            yazar.yazarad = txtAd.Text;
            yazar.yazarsoyad = txtSoyad.Text;
            entities.yazar.Add(yazar);
            int sonuc = entities.SaveChanges();
            if (sonuc>0)
            {
                MessageBox.Show("Kayıt İşlemi Başarıyla Tamamlanmıştır!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Kayıt İşlemi Başarısız!");
            }
            
        }
    }
}
