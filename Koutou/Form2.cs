using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static Koutou.Form1;

namespace Koutou
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonaddstudent_Click(object sender, EventArgs e)
        {
            //variable
            string errors = "";
            string name = textBoxNameStudent.Text.Trim();
            string oldText = textBoxOldStudent.Text.Trim();
            string subject = comboBoxSubjectStudent.SelectedItem?.ToString();
            //check if the input is a lettre
            if (string.IsNullOrWhiteSpace(name) || !Regex.IsMatch(name, "^[a-zA-Z ]+$"))
                errors += "- Name must be a text value (only letters and spaces allowed).\n";
            //check if the input is an inter
            if (!int.TryParse(oldText, out int age))
                errors += "- Age must be a numeric value.\n";
            //check if you are select a subject
            if (string.IsNullOrWhiteSpace(subject))
                errors += "- Please select a Subject.\n";
            //show a message if a input is null or empty
            if (!string.IsNullOrEmpty(errors))
            {
                MessageBox.Show(errors, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //create construtor Student
            Student student = new Student(name, age, subject);
            //display result 
            MessageBox.Show(student.GetDescription(), "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
