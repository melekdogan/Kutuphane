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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListBooks_Click(object sender, EventArgs e)
        {
            ListBooks list = new ListBooks();
            list.ShowDialog();
        }

        private void btnListStudents_Click(object sender, EventArgs e)
        {
            ListStudents students = new ListStudents();
            students.ShowDialog();
        }

        private void btnListWriters_Click(object sender, EventArgs e)
        {
            ListWriters writers = new ListWriters();
            writers.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addBooks addBooks = new addBooks();
            addBooks.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudent student = new AddStudent();
            student.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YazarEkle yazarEkle = new YazarEkle();
            yazarEkle.ShowDialog();
        }

        private void btnIslemliste_Click(object sender, EventArgs e)
        {
            Islemler form = new Islemler();
            form.ShowDialog();
        }

        private void oduncverbtn_Click(object sender, EventArgs e)
        {
            OduncVer odunc = new OduncVer();
            odunc.ShowDialog();
        }

        private void btnOduncAl_Click(object sender, EventArgs e)
        {
            OduncAl oduncAl = new OduncAl();
            oduncAl.ShowDialog();
        }
    }
}
