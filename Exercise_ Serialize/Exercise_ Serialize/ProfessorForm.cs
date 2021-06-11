using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Exercise__Serialize.Impl;
namespace Exercise__Serialize {
    public partial class ProfessorForm : Form {
        public Professor NewProfessor { get; set; }
        public ProfessorForm() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ctrlName_EditValueChanged(object sender, EventArgs e) {
            TextEdit textEdit = (sender as TextEdit);
            if (textEdit.EditValue.ToString().Length == 0) {
                ctrlSurname.EditValue = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (ctrlName.EditValue.ToString().Length > 0) {

                // 1. MODIFY THE OBJECT STUDENT
                NewProfessor.Name = Convert.ToString(ctrlName.EditValue);

                NewProfessor.Surname = Convert.ToString(ctrlSurname.EditValue);
                NewProfessor.Rank = Convert.ToString(ctrlRank.EditValue);

                // 2. CLOSE THE FORM!

                DialogResult = DialogResult.OK;
                Close();
            }
            else {

                MessageBox.Show("Please insert Name!");
            }
        }
    }
}
