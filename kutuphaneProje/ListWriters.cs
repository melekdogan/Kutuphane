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
    public partial class ListWriters : Form
    {
        public ListWriters()
        {
            InitializeComponent();
        }

        private void ListWriters_Load(object sender, EventArgs e)
        {
            KEntities entities = new KEntities();
            dgListWriters.DataSource = entities.yazar.ToList();
        }
    }
}
