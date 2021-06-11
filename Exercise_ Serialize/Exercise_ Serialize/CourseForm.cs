using System;
using DevExpress.XtraEditors;
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
    public partial class CourseForm : Form {
        public Course NewCourse { get; set; }
        public CourseForm() {
            InitializeComponent();
        }

        private void labelControl3_Click(object sender, EventArgs e) {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e) {
            TextEdit textEdit = (sender as TextEdit);
            if (textEdit.EditValue.ToString().Length == 0) {
                ctrlCode.EditValue = string.Empty;
              
            }
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (ctrlCode.EditValue.ToString().Length > 0) {

                // 1. MODIFY THE OBJECT STUDENT
                NewCourse.Code = Convert.ToString(ctrlCode.EditValue);

                NewCourse.Subject = Convert.ToString(ctrlCode.EditValue);

                // 2. CLOSE THE FORM!

                DialogResult = DialogResult.OK;
                Close();
            }
            else {

                MessageBox.Show("Please insert Code!");
            }
        }
    }
}
