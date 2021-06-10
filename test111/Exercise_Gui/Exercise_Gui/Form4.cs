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
    public partial class Form4 : Form {
        public Form4() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            string code = textBox1.Text;
            string subject = textBox2.Text;
            List<Course> cours = new List<Course>();
            Course c = new Course();
            c.SetCode(code);
            c.SetSubject(subject);
          
            cours.Add(c);
        }
    }
}
