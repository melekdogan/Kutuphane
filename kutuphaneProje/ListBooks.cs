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
    public partial class ListBooks : Form
    {
        public ListBooks()
        {
            InitializeComponent();
        }

        private void ListBooks_Load(object sender, EventArgs e)
        {
            KEntities entities = new KEntities();
            dataGridView1.DataSource = entities.kitap.ToList();

            //kitap kitap = new kitap
            //{
            //    kitapadi = "TEST KİTAP ADI",
            //    yazarno = 0
            //};

           // entities.kitap.Add(kitap);
            //int sonuc=entities.SaveChanges();
        }

        
    }
}
