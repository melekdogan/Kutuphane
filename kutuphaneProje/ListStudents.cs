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
    public partial class ListStudents : Form
    {
        public ListStudents()
        {
            InitializeComponent();
        }

        private void ListStudents_Load(object sender, EventArgs e)
        {
            KEntities entities = new KEntities();
            dgListStudents.DataSource = entities.ogrenci.ToList();
        }
    }
}
