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
    public partial class ProfessorForm : Form {
        public ProfessorForm() {
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
            List<Professor> professors = new List<Professor>();
            Professor professor = new Professor();

            professor.SetAge(Int32.Parse(age));
            professor.SetName(name);
            professor.SetSurname(surname);
            professor.SetRank(rank);
            professors.Add(professor);
        }
    }
}
