using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercise__Serialize.Impl;

namespace Exercise__Serialize {
    public partial class StudentForm : Form {

        public Student NewStudent { get; set; }
        public StudentForm() {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e) {
            if (ctrlName.EditValue.ToString().Length > 0) {

                // 1. MODIFY THE OBJECT STUDENT
                NewStudent.Name = Convert.ToString(ctrlName.EditValue);

                NewStudent.Surname = Convert.ToString(ctrlSurname.EditValue);

                // 2. CLOSE THE FORM!

                DialogResult = DialogResult.OK;
                Close();
            }
            else {

                MessageBox.Show("Please insert Name!");
            }
        }

        private void labelControl3_Click(object sender, EventArgs e) {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e) {
            TextEdit textEdit = (sender as TextEdit);
            if (textEdit.EditValue.ToString().Length == 0) {
                ctrlSurname.EditValue = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e) {

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void labelControl2_Click(object sender, EventArgs e) {

        }

        private void ctrlSurname_EditValueChanged(object sender, EventArgs e) {

        }
    }
}
