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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenci ogrenci = new ogrenci();
            ogrenci.ograd = txtad.Text;
            ogrenci.ogrsoyad = txtsoyad.Text;
            
            if (RBKiz.Checked)
            {
                ogrenci.cinsiyet = "K";
            }
            else if (RBErkek.Checked)
            {
                ogrenci.cinsiyet = "E";
            }
            ogrenci.dtarih = DTPDogumt.Value.Date;
            ogrenci.sinif = txtsinif.Text;
            ogrenci.puan = Convert.ToInt32(puanlb.Text);
            KEntities entity = new KEntities();
            entity.ogrenci.Add(ogrenci);
            int sonuc = entity.SaveChanges();
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
