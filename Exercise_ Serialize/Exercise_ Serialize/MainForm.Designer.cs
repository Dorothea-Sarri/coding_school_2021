
namespace Exercise__Serialize {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ctrlAddCourse = new System.Windows.Forms.Button();
            this.ctrlAddStudent = new System.Windows.Forms.Button();
            this.ctrlAddProfessor = new System.Windows.Forms.Button();
            this.ctrlExit = new System.Windows.Forms.Button();
            this.ctrlSave = new System.Windows.Forms.Button();
            this.ctrlLoad = new System.Windows.Forms.Button();
            this.ctrlSerialize = new System.Windows.Forms.Button();
            this.ctrlDeserialize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlStudentList = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlAddCourse
            // 
            this.ctrlAddCourse.Location = new System.Drawing.Point(189, 89);
            this.ctrlAddCourse.Name = "ctrlAddCourse";
            this.ctrlAddCourse.Size = new System.Drawing.Size(122, 82);
            this.ctrlAddCourse.TabIndex = 0;
            this.ctrlAddCourse.Text = "Add Course...";
            this.ctrlAddCourse.UseVisualStyleBackColor = true;
            this.ctrlAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // ctrlAddStudent
            // 
            this.ctrlAddStudent.Location = new System.Drawing.Point(38, 89);
            this.ctrlAddStudent.Name = "ctrlAddStudent";
            this.ctrlAddStudent.Size = new System.Drawing.Size(108, 82);
            this.ctrlAddStudent.TabIndex = 1;
            this.ctrlAddStudent.Text = "Add Student...";
            this.ctrlAddStudent.UseVisualStyleBackColor = true;
            this.ctrlAddStudent.Click += new System.EventHandler(this.button2_Click);
            // 
            // ctrlAddProfessor
            // 
            this.ctrlAddProfessor.ForeColor = System.Drawing.Color.Black;
            this.ctrlAddProfessor.Location = new System.Drawing.Point(364, 89);
            this.ctrlAddProfessor.Name = "ctrlAddProfessor";
            this.ctrlAddProfessor.Size = new System.Drawing.Size(119, 82);
            this.ctrlAddProfessor.TabIndex = 2;
            this.ctrlAddProfessor.Text = "Add Professor...";
            this.ctrlAddProfessor.UseVisualStyleBackColor = true;
            this.ctrlAddProfessor.Click += new System.EventHandler(this.button3_Click);
            // 
            // ctrlExit
            // 
            this.ctrlExit.Location = new System.Drawing.Point(704, 415);
            this.ctrlExit.Name = "ctrlExit";
            this.ctrlExit.Size = new System.Drawing.Size(75, 23);
            this.ctrlExit.TabIndex = 3;
            this.ctrlExit.Text = "Exit";
            this.ctrlExit.UseVisualStyleBackColor = true;
            this.ctrlExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // ctrlSave
            // 
            this.ctrlSave.Location = new System.Drawing.Point(613, 415);
            this.ctrlSave.Name = "ctrlSave";
            this.ctrlSave.Size = new System.Drawing.Size(75, 23);
            this.ctrlSave.TabIndex = 4;
            this.ctrlSave.Text = "Save...";
            this.ctrlSave.UseVisualStyleBackColor = true;
            this.ctrlSave.Click += new System.EventHandler(this.ctrlSave_Click);
            // 
            // ctrlLoad
            // 
            this.ctrlLoad.Location = new System.Drawing.Point(505, 415);
            this.ctrlLoad.Name = "ctrlLoad";
            this.ctrlLoad.Size = new System.Drawing.Size(75, 23);
            this.ctrlLoad.TabIndex = 5;
            this.ctrlLoad.Text = "Load...";
            this.ctrlLoad.UseVisualStyleBackColor = true;
            this.ctrlLoad.Click += new System.EventHandler(this.button6_Click);
            // 
            // ctrlSerialize
            // 
            this.ctrlSerialize.Location = new System.Drawing.Point(38, 387);
            this.ctrlSerialize.Name = "ctrlSerialize";
            this.ctrlSerialize.Size = new System.Drawing.Size(173, 51);
            this.ctrlSerialize.TabIndex = 6;
            this.ctrlSerialize.Text = "Serialize to Json";
            this.ctrlSerialize.UseVisualStyleBackColor = true;
            this.ctrlSerialize.Click += new System.EventHandler(this.ctrlSerialize_Click);
            // 
            // ctrlDeserialize
            // 
            this.ctrlDeserialize.Location = new System.Drawing.Point(38, 334);
            this.ctrlDeserialize.Name = "ctrlDeserialize";
            this.ctrlDeserialize.Size = new System.Drawing.Size(173, 47);
            this.ctrlDeserialize.TabIndex = 7;
            this.ctrlDeserialize.Text = "Deserialize from Json";
            this.ctrlDeserialize.UseVisualStyleBackColor = true;
            this.ctrlDeserialize.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "University Management Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ctrlStudentList
            // 
            this.ctrlStudentList.Location = new System.Drawing.Point(38, 192);
            this.ctrlStudentList.Name = "ctrlStudentList";
            this.ctrlStudentList.Size = new System.Drawing.Size(280, 124);
            this.ctrlStudentList.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlStudentList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlDeserialize);
            this.Controls.Add(this.ctrlSerialize);
            this.Controls.Add(this.ctrlLoad);
            this.Controls.Add(this.ctrlSave);
            this.Controls.Add(this.ctrlExit);
            this.Controls.Add(this.ctrlAddProfessor);
            this.Controls.Add(this.ctrlAddStudent);
            this.Controls.Add(this.ctrlAddCourse);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ctrlAddCourse;
        private System.Windows.Forms.Button ctrlAddStudent;
        private System.Windows.Forms.Button ctrlAddProfessor;
        private System.Windows.Forms.Button ctrlExit;
        private System.Windows.Forms.Button ctrlSave;
        private System.Windows.Forms.Button ctrlLoad;
        private System.Windows.Forms.Button ctrlSerialize;
        private System.Windows.Forms.Button ctrlDeserialize;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ListBoxControl ctrlStudentList;
    }
}

