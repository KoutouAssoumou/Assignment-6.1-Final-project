namespace Koutou
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelname = new System.Windows.Forms.Label();
            this.textBoxNameStudent = new System.Windows.Forms.TextBox();
            this.labelold = new System.Windows.Forms.Label();
            this.textBoxOldStudent = new System.Windows.Forms.TextBox();
            this.labelsubject = new System.Windows.Forms.Label();
            this.comboBoxSubjectStudent = new System.Windows.Forms.ComboBox();
            this.buttonaddstudent = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelname);
            this.groupBox1.Controls.Add(this.textBoxNameStudent);
            this.groupBox1.Controls.Add(this.labelold);
            this.groupBox1.Controls.Add(this.textBoxOldStudent);
            this.groupBox1.Controls.Add(this.labelsubject);
            this.groupBox1.Controls.Add(this.comboBoxSubjectStudent);
            this.groupBox1.Controls.Add(this.buttonaddstudent);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(215, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 380);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations Student";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(17, 29);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(112, 20);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "Name Student";
            // 
            // textBoxNameStudent
            // 
            this.textBoxNameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameStudent.Location = new System.Drawing.Point(21, 67);
            this.textBoxNameStudent.Name = "textBoxNameStudent";
            this.textBoxNameStudent.Size = new System.Drawing.Size(281, 26);
            this.textBoxNameStudent.TabIndex = 3;
            // 
            // labelold
            // 
            this.labelold.AutoSize = true;
            this.labelold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelold.Location = new System.Drawing.Point(17, 123);
            this.labelold.Name = "labelold";
            this.labelold.Size = new System.Drawing.Size(94, 20);
            this.labelold.TabIndex = 1;
            this.labelold.Text = "Old Student";
            // 
            // textBoxOldStudent
            // 
            this.textBoxOldStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOldStudent.Location = new System.Drawing.Point(21, 176);
            this.textBoxOldStudent.Name = "textBoxOldStudent";
            this.textBoxOldStudent.Size = new System.Drawing.Size(281, 26);
            this.textBoxOldStudent.TabIndex = 4;
            // 
            // labelsubject
            // 
            this.labelsubject.AutoSize = true;
            this.labelsubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsubject.Location = new System.Drawing.Point(17, 233);
            this.labelsubject.Name = "labelsubject";
            this.labelsubject.Size = new System.Drawing.Size(124, 20);
            this.labelsubject.TabIndex = 2;
            this.labelsubject.Text = "Subject Student";
            // 
            // comboBoxSubjectStudent
            // 
            this.comboBoxSubjectStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubjectStudent.FormattingEnabled = true;
            this.comboBoxSubjectStudent.Items.AddRange(new object[] {
            "English",
            "Math",
            "Programmation"});
            this.comboBoxSubjectStudent.Location = new System.Drawing.Point(21, 280);
            this.comboBoxSubjectStudent.Name = "comboBoxSubjectStudent";
            this.comboBoxSubjectStudent.Size = new System.Drawing.Size(281, 28);
            this.comboBoxSubjectStudent.TabIndex = 5;
            // 
            // buttonaddstudent
            // 
            this.buttonaddstudent.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonaddstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaddstudent.Location = new System.Drawing.Point(6, 338);
            this.buttonaddstudent.Name = "buttonaddstudent";
            this.buttonaddstudent.Size = new System.Drawing.Size(390, 36);
            this.buttonaddstudent.TabIndex = 6;
            this.buttonaddstudent.Text = "Add Student";
            this.buttonaddstudent.UseVisualStyleBackColor = false;
            this.buttonaddstudent.Click += new System.EventHandler(this.buttonaddstudent_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.TextBox textBoxNameStudent;
        private System.Windows.Forms.Label labelold;
        private System.Windows.Forms.TextBox textBoxOldStudent;
        private System.Windows.Forms.Label labelsubject;
        private System.Windows.Forms.ComboBox comboBoxSubjectStudent;
        private System.Windows.Forms.Button buttonaddstudent;
    }
}