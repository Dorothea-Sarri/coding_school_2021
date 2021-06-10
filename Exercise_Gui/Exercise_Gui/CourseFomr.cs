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
    public partial class CourseForm : Form {
        public CourseForm() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            string code = textBox1.Text;
            string subject = textBox2.Text;
            List<Course> courses = new List<Course>();
            Course course = new Course();
            course.SetCode(code);
            course.SetSubject(subject);

            courses.Add(course);
        }

        private void Form4_Load(object sender, EventArgs e) {

        }
    }
}
