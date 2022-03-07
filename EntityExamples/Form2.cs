using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityExamples
{
    public partial class Form2 : Form
    {
        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                var values = db.TBLExamNotes.Where(p => p.exam1 < 50);
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton2.Checked == true)
            {
                var values = db.TBLStudent.Where(p => p.FirstName == "ali");
            }
            if (radioButton3.Checked == true)
            {
                var values = db.TBLStudent.Where(p => p.FirstName == textBox1.Text || p.LastName == textBox1.Text);
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton4.Checked == true)
            {
                var values = db.TBLStudent.Select(p => new
                {
                    Soyad = p.LastName
                });
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton5.Checked == true)
            {
                var values = db.TBLStudent.Select(x => new
                {
                    AD = x.FirstName.ToUpper(),
                    Soyad = x.LastName.ToLower()
                });
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton6.Checked == true)
            {
                var values = db.TBLExamNotes.Select(x => new
                {
                    Ogrenciadi = x.TBLStudent.FirstName,
                    OgrenciSoyad = x.TBLStudent.LastName,
                    Sınav1 = x.exam1,
                    Sınav2 = x.exam2,
                    Sınav3 = x.exam3,
                    Ortalama = x.exam_averages,
                    Durumu = x.situation == true ? "Geçti" : "Kaldı"
                });
                dataGridView1.DataSource = values.ToList();
            }
        }
    }
}
