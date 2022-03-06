using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityExamples
{
    public partial class Form1 : Form
    {
        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BtnDersListesi_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbSinavOgrenci;Integrated Security=True");
            SqlCommand command = new SqlCommand("Select * from TBLLessons", connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnOgrenciListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLStudent.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void BtnNotListesi_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLExamNotes
                        select new
                        {
                            item.LessonId,
                            item.TBLStudent.FirstName,
                            item.TBLStudent.LastName,
                            item.TBLLessons.LessonName,
                            item.exam1,
                            item.exam2,
                            item.exam3,
                            item.exam_averages,
                            item.situation
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLStudent student = new TBLStudent();
            student.FirstName = TxtOgrenciAd.Text;
            student.LastName = TxtOgrenciSoyad.Text;
            db.TBLStudent.Add(student);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Eklendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBLLessons lesson = new TBLLessons();
            lesson.LessonName = TxtDersAd.Text;
            db.TBLLessons.Add(lesson);
            db.SaveChanges();
            MessageBox.Show("Ders Eklendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtOgrenciId.Text);
            var query = db.TBLStudent.Find(id);
            db.TBLStudent.Remove(query);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Silindi");
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtOgrenciId.Text);
            var query = db.TBLStudent.Find(id);
            query.FirstName = TxtOgrenciAd.Text;
            query.LastName = TxtOgrenciSoyad.Text;
            query.Image = TxtOgrenciFotograf.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Güncellendi");
        }

        private void BtnProsedur_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NotListesi();
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLStudent.Where(x => x.FirstName == TxtOgrenciAd.Text || x.LastName == TxtOgrenciSoyad.Text).ToList();

        }

        private void TxtOgrenciAd_TextChanged(object sender, EventArgs e)
        {
            string search = TxtOgrenciAd.Text;
            var values = from item in db.TBLStudent
                         where item.FirstName.Contains(search)
                         select item;
            dataGridView1.DataSource = values.ToList();

        }

        private void BtnLinqEntity_Click(object sender, EventArgs e)
        {
            //Asc - Ascending
            if (radioButton1.Checked == true)
            {
                List<TBLStudent> Studenta_z = db.TBLStudent.OrderBy(p => p.FirstName).ToList();
                dataGridView1.DataSource = Studenta_z;

            }
            //Desc - Descending
            if (radioButton2.Checked == true)
            {
                List<TBLStudent> Studentz_a = db.TBLStudent.OrderByDescending(x => x.FirstName).ToList();
                dataGridView1.DataSource = Studentz_a;
            }
            if (radioButton3.Checked == true)
            {
                List<TBLStudent> Last5Record = db.TBLStudent.OrderByDescending(p => p.FirstName).Take(5).ToList();
                dataGridView1.DataSource = Last5Record;
            }
            if (radioButton4.Checked == true)
            {
                var TextId = Convert.ToInt32(TextIdBul.Text);
                List<TBLStudent> IdList = db.TBLStudent.Where(x => x.Id == TextId).ToList();
                dataGridView1.DataSource = IdList;
            }
            if (radioButton5.Checked == true)
            {
                List<TBLStudent> orderA = db.TBLStudent.Where(x => x.FirstName.StartsWith("a")).ToList();
                dataGridView1.DataSource = orderA;
            }
            if (radioButton6.Checked == true)
            {
                List<TBLStudent> orderDescendingA = db.TBLStudent.Where(x => x.FirstName.EndsWith("a")).ToList();
                dataGridView1.DataSource = orderDescendingA;
            }
            if (radioButton7.Checked == true)
            {
                bool value = db.TBLStudent.Any();
                MessageBox.Show(value.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton8.Checked == true)
            {
                int sum = db.TBLStudent.Count();
                MessageBox.Show(sum.ToString(), "Toplam Öğrenci Sayısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton9.Checked == true)
            {
                var sum = db.TBLExamNotes.Sum(p => p.exam1);
                MessageBox.Show("Birinci Sınavlar Toplamı: " + sum.ToString());
            }
            if (radioButton10.Checked == true)
            {
                var average = db.TBLExamNotes.Average(x => x.exam1);
                MessageBox.Show("Birinci Sınavlar Toplamı: " + average.ToString());
            }
            if (radioButton11.Checked == true)
            {
                var average = db.TBLExamNotes.Average(x => x.exam1);
                List<TBLExamNotes> exam1 = db.TBLExamNotes.Where(p => p.exam1 >= average).ToList();
                dataGridView1.DataSource = exam1;
            }
            if (radioButton12.Checked == true)
            {
                var high = db.TBLExamNotes.Max(p => p.exam1);
                MessageBox.Show("Birinci Sınavın En yüksek puanı: " + high);
            }
            if (radioButton13.Checked == true)
            {
                //En Yüksek Sınav Notu kime ait??
                var high = db.TBLExamNotes.Max(p => p.exam1);
                var enyuksek = from item in db.TBLExamNotes
                               where item.exam1 == high
                               select new
                               {
                                   Ad = item.TBLStudent.FirstName,
                                   Soyad = item.TBLStudent.LastName,
                                   Sınav1 = item.exam1,
                                   DersAdı = item.TBLLessons.LessonName
                               };
                dataGridView1.DataSource = enyuksek.ToList();
            }

        }

        private void BtnJoin_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLExamNotes
                        join item2 in db.TBLStudent
                        on item.Student equals item2.Id
                        join item3 in db.TBLLessons
                        on item.Lesson equals item3.LessonId
                        select new
                        {
                            Öğrenci = item2.FirstName + " " + item2.LastName,
                            Ders = item3.LessonName,
                            Sınav1 = item.exam1,
                            Sınav2 = item.exam2,
                            Sınav3 = item.exam3,
                            Ortalama = item.exam_averages,
                        };
            dataGridView1.DataSource = query.ToList();
        }
    }
}
