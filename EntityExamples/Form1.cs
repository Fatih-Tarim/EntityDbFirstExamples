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
                        select new { 
                            item.LessonId, 
                            item.Student, 
                            item.Lesson, 
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
    }
}
