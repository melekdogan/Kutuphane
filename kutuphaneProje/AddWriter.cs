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
    public partial class AddWriter : Form
    {
        public AddWriter()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            KEntities entities = new KEntities();
            yazar yazar = new yazar();
            yazar.yazarad = TxtAd.Text; 
            yazar.yazarsoyad = TxtSoyad.Text;
            entities.yazar.Add(yazar);
            int sonuc=entities.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt Ekleme İşlemi Başarıyla Tamamlandı!");
                addBooks addBooksForm = new addBooks();
                addBooksForm.Refresh();
            }
            this.Close();
            /* -----------------------------------------*/
           
            
        }

       
    }
}
