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

namespace kutuphaneProje
{
    public partial class OduncVer : Form
    {
        KEntities entities = new KEntities();
        public OduncVer()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)

        {
            islem islem = new islem();
            islem.kitapno = (int)cmbkitap.SelectedValue;
            islem.ogrno = (int)cmbOgrenci.SelectedValue;
            islem.atarih = DTPAtarih.Value.Date;
            entities.islem.Add(islem);
            if (entities.SaveChanges() > 0)
            {
                MessageBox.Show("Kayıt İşlemi Başarıyla Tamamlandı!");
            }

        }

        private void OduncVer_Load(object sender, EventArgs e)
        {
            OgrenciYukle();

        }
        /// <summary>
        /// 
        /// </summary>
        public void OgrenciYukle()
        {
            var data = entities.ogrenci;
            var modeldata = data.Select(y => new OgrenciModel
            {
                AdSoyad = y.ograd + y.ogrsoyad,
                No = y.ogrno
            }).ToList();

            cmbOgrenci.DataSource = entities.ogrenci.Select(x => new OgrenciModel { AdSoyad = x.ograd.TrimStart().TrimEnd() + " " + x.ogrsoyad.TrimStart().TrimEnd(), No = x.ogrno }).ToList();
            cmbOgrenci.DisplayMember = "AdSoyad";
            cmbOgrenci.ValueMember = "No";
        }
        /// <summary>
        /// 
        /// </summary> 
        private void cmbOgrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            KitapYukle();
        }
        public void KitapYukle()
        {
            if (cmbOgrenci.SelectedValue != null)
            {
               

                var kitaplar = (from k in entities.kitap
                                join isl in entities.islem on k.kitapno equals isl.kitapno
                                where isl.vtarih != null
                                select k).ToList();

                List<KitapModel> kitapModels = new List<KitapModel>();
                foreach (var k in kitaplar)
                {
                    var kitap = entities.kitap.Find(k.kitapno);
                    var model = new KitapModel
                    {
                        ad = kitap.kitapadi,
                        no = kitap.kitapno
                    };
                    kitapModels.Add(model);
                }
                cmbkitap.DataSource = kitapModels;
                cmbkitap.DisplayMember = "ad";
                cmbkitap.ValueMember = "no";

            }
            else MessageBox.Show("Bir sorun var!");




           
        }
    }
}
