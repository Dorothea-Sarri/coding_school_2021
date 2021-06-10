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
    public partial class ManagerApp : Form {
        //private Form2 form2;
        public ManagerApp() {
            InitializeComponent();
        }

        private void Application_Click(object sender, EventArgs e) {
            
        }

        private void button1_Click(object sender, EventArgs e) {

            Form2 f2 = new Form2();
            f2.ShowDialog(); // Shows Form2
        }

        private void button2_Click(object sender, EventArgs e) {
            Form3 f3 = new Form3();
            f3.ShowDialog(); // Shows Form2
        }

      private void button3_Click_1(object sender, EventArgs e) {
          Form4 f4 = new Form4();
         f4.ShowDialog(); // Shows Form2
       }

        private void button4_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
