using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_Gui {
    public partial class StudentForm : Form {
        public StudentForm() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
           
           
        }

        private void Form2_Load(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            string surname = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {
            string age = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e) {
            string registrationumber = textBox4.Text;
        }

        private void button1_Click(object sender, EventArgs e) {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string age = textBox3.Text;
            string registrationumber = textBox4.Text;
            List<Student> students = new List<Student>();
            Student student = new Student();

            student.SetAge(Int32.Parse(age));
            student.SetName(name);
            student.SetSurname(surname);
            student.SetRegistrationNumber(Int32.Parse(registrationumber));
            students.Add(student);
        }
    }
}
