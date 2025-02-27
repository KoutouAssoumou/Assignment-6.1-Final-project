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
        public abstract class Person
        {
            private string _name;
            private int _old;

            public string Name => _name;
            public int Old => _old;

            protected Person(string name, int old)
            {
                _name = name;
                _old = old;
            }

            public abstract string GetDescription();
        }
        // Classe Student herite Person and add Subject
        public class Student : Person
        {
            private string _subject;
            public string Subject => _subject;

            public Student(string name, int old, string subject) : base(name, old)
            {
                _subject = subject;
            }

            public override string GetDescription()
            {
                return $"Name: {Name}\nOld: {Old}\nSubject: {Subject}";
            }
        }

        // Classe Student herite Person and add Subject
        public class Teacher : Person
        {
            private string _classroom;
            public string Classroom => _classroom;

            public Teacher(string name, int old, string classroom) : base(name, old)
            {
                _classroom = classroom;
            }

            public override string GetDescription()
            {
                return $"Name: {Name}\nOld: {Old}\nClassroom: {Classroom}";
            }
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
        }

        private void buttonaddteacher_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open windows Form2
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //open windows Form3
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
