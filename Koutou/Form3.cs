using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Koutou.Form1;

namespace Koutou
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonaddteacher_Click(object sender, EventArgs e)
        {
            //variables
            string errors = "";
            string name = textBoxNameTeacher.Text.Trim();
            string oldText = textBoxOldTeacher.Text.Trim();
            string classroom = comboBoxClassRoom.SelectedItem?.ToString();

            //check if the input is a lettre

            if (string.IsNullOrWhiteSpace(name) || !Regex.IsMatch(name, "^[a-zA-Z ]+$"))
                errors += "- Name must be a text value (only letters and spaces allowed).\n";
            //check if the input is an inter
            if (!int.TryParse(oldText, out int age))
                errors += "- Age must be a numeric value.\n";

            //check if you are select a classroom
            if (string.IsNullOrWhiteSpace(classroom))
                errors += "- Please select a Classroom.\n";
            //show a message if a input is null or empty
            if (!string.IsNullOrEmpty(errors))
            {
                MessageBox.Show(errors, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //create construtor Teach
            Teacher teacher = new Teacher(name, age, classroom);
            //display result
            MessageBox.Show(teacher.GetDescription(), "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
