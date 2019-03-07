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
    public partial class Islemler : Form
    {
        public Islemler()
        {
            InitializeComponent();
        }
        KEntities entities = new KEntities();
        private void Islemler_Load(object sender, EventArgs e)
        {

            var list = entities.islem.Select(x => new IslemModel {
                islemNo = x.islemno,
                KitapAd = x.kitap.kitapadi,
                OgrenciAd = x.ogrenci.ograd.TrimEnd().TrimStart() + " " + x.ogrenci.ogrsoyad.TrimStart().TrimEnd(),
                alistarih = x.atarih,
                veristarih = x.vtarih
            }).ToList();
            dataGridView1.DataSource = list;
        }


    }

    public class IslemModel
    {
        public int islemNo { get; set; }
        [DisplayName("Öğrenci Ad Soyad")]
        public string OgrenciAd { get; set; }
        [DisplayName("Kitap Adı")]
        public string KitapAd { get; set; }
        public DateTime? alistarih { get; set; }
        
        public DateTime? veristarih { get; set; }
        

    } 
}
