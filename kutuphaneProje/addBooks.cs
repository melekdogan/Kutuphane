using kutuphaneEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneProje
{
    public partial class addBooks : Form
    {
        public addBooks()
        {
            InitializeComponent();
        }
          KEntities kEntities = new KEntities();


        private void addBooks_Load(object sender, EventArgs e)
        {
            YazarYukle();
            TurYukle();
            comboBoxTur.SelectedIndex = -1;
            comboBoxYazar.SelectedIndex = -1;
        }

        
        public void YazarYukle()
        {
            
            var data = kEntities.yazar;
            var modeldata = data.Select(y => new YazarModel
            {
                AdSoyad=y.yazarad+y.yazarsoyad,
                No=y.yazarno
            }).ToList();
            //--------------------------------------------------------------------------------------------------------------------------------
            comboBoxYazar.DataSource = kEntities.yazar.Select(x=> new YazarModel { AdSoyad=x.yazarad.TrimStart().TrimEnd()+" " + x.yazarsoyad.TrimStart().TrimEnd(), No=x.yazarno}).ToList();
            comboBoxYazar.DisplayMember = "AdSoyad";
            comboBoxYazar.ValueMember = "No";
            //    silme işlemi
            //    yazar y=kEntities.yazar.Find(1);
            //    kEntities.yazar.Remove(y);
            //    kEntities.SaveChanges();
        }
        
        public void TurYukle()
        {
            var data = kEntities.tur;
            var modeldata = data.Select(z => new TurModel
            {
                turAdi = z.turadi,
                Turno = z.turno
            }).ToList();
            comboBoxTur.DataSource = kEntities.tur.Select(x => new TurModel { turAdi = x.turadi.TrimStart().TrimEnd(), Turno = x.turno }).ToList();
            comboBoxTur.DisplayMember = "turAdi";
            comboBoxTur.ValueMember = "Turno";
        }
        
    
            //---------------------------------------------------------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            AddWriter writer = new AddWriter();
            writer.ShowDialog();
            YazarYukle();
        }

        private void addK_Click(object sender, EventArgs e)
        {
            addKnd add = new addKnd();
            add.ShowDialog();
            TurYukle();
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {

            kitap kitap = new kitap();
            kitap.isbnno = txtISBN.Text;
            kitap.kitapadi = txtKitapAd.Text;
            kitap.yazarno = (int)(comboBoxYazar.SelectedValue);
            kitap.turno = (int)(comboBoxTur.SelectedValue);
            kitap.sayfasayisi = Convert.ToInt32(txtSayfaS.Text);
            kitap.puan = Convert.ToInt32(txtPuan.Text);
            kEntities.kitap.Add(kitap);
            if (comboBoxYazar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir yazar seçiniz!");
            }
            else if (comboBoxTur.SelectedIndex == -1)
            {
              MessageBox.Show("Lütfen bir tür seçiniz!");
               
            }
            int sonuc = kEntities.SaveChanges();
            if ( sonuc > 0)
            {
                MessageBox.Show("Ekleme İşlemi Başarılı!");
                this.Close();
            }
            TurYukle();
            YazarYukle();
        }

       
    }


    public class YazarModel
         {
           public string AdSoyad { get; set; }
           public int No { get; set; }
          }
        public class TurModel
        {
        public string turAdi { get; set; }
        public int Turno { get; set; }
        }

}
