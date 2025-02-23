using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koutou
{
    public partial class Form1 : Form
    {
        // Class Person with Name et Old
        public class Person
        {
            public string Name { get; set; }
            public int Old { get; set; }
        }
        // Classe Student herite Person and add Subject
        public class Student : Person
        {
            public string Subject { get; set; }
        }

        // Classe Student herite Person and add Subject
        public class Teacher : Person
        {
            public string Classroom { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonaddstudent_Click(object sender, EventArgs e)
        {
            string errors = "";
            string name = textBoxNameStudent.Text.Trim();
            string oldText = textBoxOldStudent.Text.Trim();
            string subject = comboBoxSubjectStudent.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(name) || !Regex.IsMatch(name, "[a-zA-Z]"))
            {
                errors += "- Name must be a text value (only letters and spaces allowed).\n";
            }

            if (!int.TryParse(oldText, out int age))
            {
                errors += "- Old must be a numeric value.\n";
            }

            if (string.IsNullOrWhiteSpace(subject))
            {
                errors += "- Please select a Subject.\n";
            }

            if (!string.IsNullOrEmpty(errors))
            {
                MessageBox.Show(errors, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // create  Student
            Student student = new Student()
            {
                Name = name,
                Old = age,
                Subject = subject
            };

            // message
            MessageBox.Show("Name Student : " + student.Name + "\nOld Student : " + student.Old + "\nSubject : " + student.Subject, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonaddteacher_Click(object sender, EventArgs e)
        {
            string errors = "";
            string name = textBoxNameTeacher.Text.Trim();
            string oldText = textBoxOldTeacher.Text.Trim();
            string classroom = comboBoxClassRoom.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(name) || !Regex.IsMatch(name, "[a-zA-Z]"))
            {
                errors += "- Name must be a text value (only letters and spaces allowed).\n";
            }

            if (!int.TryParse(oldText, out int age))
            {
                errors += "- Old must be a numeric value.\n";
            }

            if (string.IsNullOrWhiteSpace(classroom))
            {
                errors += "- Please select a Subject.\n";
            }

            if (!string.IsNullOrEmpty(errors))
            {
                MessageBox.Show(errors, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create Teacher
            Teacher teacher = new Teacher()
            {
                Name = name,
                Old = age,
                Classroom = classroom
            };

            // Message
            MessageBox.Show("Name Student : " + teacher.Name + "\nOld Student : " + teacher.Old + "\nClassRoom : " + teacher.Classroom, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
