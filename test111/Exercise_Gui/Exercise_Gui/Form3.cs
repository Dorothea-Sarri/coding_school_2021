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
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {
           
        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string age = textBox3.Text;
            string rank = textBox4.Text;
            List<Professor> prof = new List<Professor>();
            Professor p = new Professor();

            p.SetAge(Int32.Parse(age));
            p.SetName(name);
            p.SetSurname(surname);
            p.SetRank(rank);
            prof.Add(p);
        }
    }
}
