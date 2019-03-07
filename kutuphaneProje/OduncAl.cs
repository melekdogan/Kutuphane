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
using kutuphaneProje.Model;
using System.Data.Sql;
using System.Data.SqlClient;

namespace kutuphaneProje
{
    public partial class OduncAl : Form
    {
        public OduncAl()
        {
            InitializeComponent();
            
        }
        KEntities entities = new KEntities();       
        private void OduncAl_Load(object sender, EventArgs e)
        {
            OgrenciYukle();
        }
        public void OgrenciYukle()
        {
            var data = entities.ogrenci;
            var modeldata = data.Select(y => new OgrenciModel
            {
                AdSoyad = y.ograd + y.ogrsoyad,
                No = y.ogrno
            }).ToList();

            cmbOgrenci.DisplayMember = "AdSoyad";
            cmbOgrenci.ValueMember = "No";
            cmbOgrenci.DataSource = entities.ogrenci.Select(x => new OgrenciModel { AdSoyad = x.ograd.TrimStart().TrimEnd() + " " + x.ogrsoyad.TrimStart().TrimEnd(), No = x.ogrno }).ToList();

            cmbOgrenci.SelectedIndex = 0;
        }


        private void cmbOgrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            KitapYukle();

        }
        public void KitapYukle()
        {
            if (cmbOgrenci.SelectedValue != null)
            {
                int ogrno = (int)cmbOgrenci.SelectedValue;
                List<int> kitapno = entities.islem.Where(x => x.ogrno == ogrno && x.vtarih == null).Select(k => k.kitapno).ToList();
                List<KitapModel> kitapModels = new List<KitapModel>();
                foreach (var kno in kitapno)
                {
                    var kitap = entities.kitap.Find(kno);
                    var model = new KitapModel
                    {
                        ad = kitap.kitapadi,
                        no = kitap.kitapno
                    };
                    kitapModels.Add(model);
                   
                }
                cmbKitap.DataSource = kitapModels;
                cmbKitap.ValueMember = "no";
                cmbKitap.DisplayMember = "ad";

               
            }
            else
            {
                MessageBox.Show("Başarısız");
            }



        }

        private void savebtn_Click(object sender, EventArgs e)
        {
           
          
            int ogrno = (int)cmbOgrenci.SelectedValue;
            int kitapno = (int)cmbKitap.SelectedValue;
            int islemno = entities.islem.Where(x => x.ogrno == ogrno && x.kitapno == kitapno).First().islemno;
            islem islem=entities.islem.Find(islemno);
            islem.vtarih = DTPVtarih.Value.Date;
           int sonuc= entities.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Başarılı!");
                Close();
            }
            else
            {
                MessageBox.Show("Hata!");
            }

            //    List<int> islemno = entities.islem.Where(x => x.ogrno == ogrno && x.kitapno==kitapno).;              
           

        }
    }


}
       
        
   