using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Exercise__Serialize.Impl;

namespace Exercise__Serialize {


    public partial class MainForm : Form {

        private const string _TxtFile = "UniversityData.txt";
        private const string _JsonFile = "UniversityData.json";
        University CoodingSchool = new University();

        List<Student> Students = new List<Student>();
        List<Course> Courses = new List<Course>();
        List<Professor> Professors = new List<Professor>();
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }
        private void AddStudent() {
           Student student = new Student();
            // TODO: 1. ΝΑ ΠΕΡΑΣΩ ΤΟ STUDENT ΟΒJECT ΣΤΗΝ ΦΟΡΜΑ!

            // TODO: OPEN FORM ...
            StudentForm form = new StudentForm();
            form.NewStudent = student;

            DialogResult result = form.ShowDialog();
            switch (result) {
                case DialogResult.OK:
                    Students.Add(student);
                    break;

                default:
                    // messagge  ?
                    break;
            }

        }
        private void AddCourse() {
            Course course = new Course();
            // TODO: 1. ΝΑ ΠΕΡΑΣΩ ΤΟ STUDENT ΟΒJECT ΣΤΗΝ ΦΟΡΜΑ!

            // TODO: OPEN FORM ...
            CourseForm form = new CourseForm();
            form.NewCourse = course;

            DialogResult result = form.ShowDialog();
            switch (result) {
                case DialogResult.OK:
                    Courses.Add(course);
                    break;

                default:
                    // messagge  ?
                    break;
            }

        }
        private void AddProfessor() {
            Professor professor = new Professor();
            // TODO: 1. ΝΑ ΠΕΡΑΣΩ ΤΟ STUDENT ΟΒJECT ΣΤΗΝ ΦΟΡΜΑ!

            // TODO: OPEN FORM ...
            ProfessorForm form = new ProfessorForm();
            form.NewProfessor = professor;

            DialogResult result = form.ShowDialog();
            switch (result) {
                case DialogResult.OK:
                    Professors.Add(professor);
                    break;

                default:
                    // messagge  ?
                    break;
            }

        }
       /* private University CreateUniversity() {
            University university = new University();
            university.Courses = Courses;
            university.Professors = Professors;
            university.Students = Students;
            return university;

        }*/

            private void WriteToTxt() {
           // string path = Path.Combine(Environment.CurrentDirectory, _TxtFile);

          //  string data = string.Empty;
          //  foreach (Student item in Students) {
          
            //    data += string.Format("{0};{1};{2};{3}", item.Name, item.Surname, item.RegistrationNumber, Environment.NewLine);
           // }


          //  File.WriteAllText(path, data);
        }
        private void SerializeToJson() {

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            University university = new University();
            university.Courses = Courses;
            university.Professors = Professors;
            university.Students = Students;


            // TODO: SERIALIZE UNIVERSITY OBJECT INSTEAD OF STUDENTS!
            string data = serializer.Serialize(university);

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            File.WriteAllText(path, data);

        }
        private void DeserializeFromJson() {

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            string data = File.ReadAllText(path);

            Students = serializer.Deserialize<List<Student>>(data);
            Professors= serializer.Deserialize<List<Professor>>(data);
            Courses = serializer.Deserialize<List<Course>>(data);


            //Course physics = new Course() {
            //    Subject = "Physics",
            //    Category = CoursesCategoryEnum.Physics,
            //    Hours = 10
            //};

            //Students[0].Courses = new List<Course>();
            //Students[0].Courses.Add(physics);
        }
        private void ReadFromTxt() {
            
            string path = Path.Combine(Environment.CurrentDirectory, _TxtFile);

            string s = File.ReadAllText(path);

            string[] parser = new string[] { Environment.NewLine };

            List<string> dataLines = s.Split(parser, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (string line in dataLines) {

                string[] parserLine = new string[] { ";" };

                if (line.Length > 0) {

                    List<string> lineData = line.Split(parserLine, StringSplitOptions.None).ToList();

                    Student student = new Student();

                    student.Name = Convert.ToString(lineData[0]);
                    student.Surname = Convert.ToString(lineData[1]);
                    student.RegistrationNumber = Convert.ToInt32(lineData[2]);

                    Students.Add(student);

                }
            } 
        }
        private void RefreshStudentList() {
            ctrlStudentList.Items.Clear();
            foreach (Student item in Students) {
                ctrlStudentList.Items.Add(string.Format("{0} \t {1} \t {2}", item.Name, item.Surname, item.RegistrationNumber));
          }
        }
      //  private void RefreshCourse() {
         //   ctrlStudentList.Items.Clear();
        //    foreach (Student item in Students) {
         //       ctrlStudentList.Items.Add(string.Format("{0} \t {1} \t {2}", item.Name, item.Surname, item.RegistrationNumber));
         //   }
      //  }

        private void button2_Click(object sender, EventArgs e) {
            // Add student using a form
            AddStudent();

            // refresh
            RefreshStudentList();
        }

        private void btnAddCourse_Click(object sender, EventArgs e) {
            AddCourse();

            // refresh
          //  RefreshStudentList();
        }

        private void button3_Click(object sender, EventArgs e) {
            AddProfessor();
        }

        private void button4_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e) {
            // Read data
            ReadFromTxt();

            // refresh
           RefreshStudentList();
        }
          
        private void button8_Click(object sender, EventArgs e) {
            DeserializeFromJson();

            RefreshStudentList();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void ctrlSave_Click(object sender, EventArgs e) {
            // Write ...
            WriteToTxt();
        }

        private void ctrlSerialize_Click(object sender, EventArgs e) {
            SerializeToJson();
        }
    }
}
