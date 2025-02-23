namespace Koutou
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelname = new System.Windows.Forms.Label();
            this.labelold = new System.Windows.Forms.Label();
            this.labelsubject = new System.Windows.Forms.Label();
            this.textBoxNameStudent = new System.Windows.Forms.TextBox();
            this.textBoxOldStudent = new System.Windows.Forms.TextBox();
            this.comboBoxSubjectStudent = new System.Windows.Forms.ComboBox();
            this.buttonaddstudent = new System.Windows.Forms.Button();
            this.labelnameteach = new System.Windows.Forms.Label();
            this.labeloldteach = new System.Windows.Forms.Label();
            this.labelsubjectteacher = new System.Windows.Forms.Label();
            this.buttonaddteacher = new System.Windows.Forms.Button();
            this.textBoxNameTeacher = new System.Windows.Forms.TextBox();
            this.textBoxOldTeacher = new System.Windows.Forms.TextBox();
            this.comboBoxClassRoom = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // labelsubject
            // 
            this.labelsubject.AutoSize = true;
            this.labelsubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsubject.Location = new System.Drawing.Point(17, 233);
            this.labelsubject.Name = "labelsubject";
            this.labelsubject.Size = new System.Drawing.Size(124, 20);
            this.labelsubject.TabIndex = 2;
            this.labelsubject.Text = "Subject Student";
            this.labelsubject.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxNameStudent
            // 
            this.textBoxNameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameStudent.Location = new System.Drawing.Point(21, 67);
            this.textBoxNameStudent.Name = "textBoxNameStudent";
            this.textBoxNameStudent.Size = new System.Drawing.Size(281, 26);
            this.textBoxNameStudent.TabIndex = 3;
            // 
            // textBoxOldStudent
            // 
            this.textBoxOldStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOldStudent.Location = new System.Drawing.Point(21, 176);
            this.textBoxOldStudent.Name = "textBoxOldStudent";
            this.textBoxOldStudent.Size = new System.Drawing.Size(281, 26);
            this.textBoxOldStudent.TabIndex = 4;
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
            // labelnameteach
            // 
            this.labelnameteach.AutoSize = true;
            this.labelnameteach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnameteach.Location = new System.Drawing.Point(30, 29);
            this.labelnameteach.Name = "labelnameteach";
            this.labelnameteach.Size = new System.Drawing.Size(113, 20);
            this.labelnameteach.TabIndex = 7;
            this.labelnameteach.Text = "Name Teacher";
            // 
            // labeloldteach
            // 
            this.labeloldteach.AutoSize = true;
            this.labeloldteach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeloldteach.Location = new System.Drawing.Point(30, 123);
            this.labeloldteach.Name = "labeloldteach";
            this.labeloldteach.Size = new System.Drawing.Size(95, 20);
            this.labeloldteach.TabIndex = 8;
            this.labeloldteach.Text = "Old Teacher";
            // 
            // labelsubjectteacher
            // 
            this.labelsubjectteacher.AutoSize = true;
            this.labelsubjectteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsubjectteacher.Location = new System.Drawing.Point(30, 233);
            this.labelsubjectteacher.Name = "labelsubjectteacher";
            this.labelsubjectteacher.Size = new System.Drawing.Size(84, 20);
            this.labelsubjectteacher.TabIndex = 9;
            this.labelsubjectteacher.Text = "Classroom";
            // 
            // buttonaddteacher
            // 
            this.buttonaddteacher.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonaddteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaddteacher.Location = new System.Drawing.Point(6, 337);
            this.buttonaddteacher.Name = "buttonaddteacher";
            this.buttonaddteacher.Size = new System.Drawing.Size(326, 37);
            this.buttonaddteacher.TabIndex = 10;
            this.buttonaddteacher.Text = "Add Teacher";
            this.buttonaddteacher.UseVisualStyleBackColor = false;
            this.buttonaddteacher.Click += new System.EventHandler(this.buttonaddteacher_Click);
            // 
            // textBoxNameTeacher
            // 
            this.textBoxNameTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameTeacher.Location = new System.Drawing.Point(34, 67);
            this.textBoxNameTeacher.Name = "textBoxNameTeacher";
            this.textBoxNameTeacher.Size = new System.Drawing.Size(278, 26);
            this.textBoxNameTeacher.TabIndex = 11;
            // 
            // textBoxOldTeacher
            // 
            this.textBoxOldTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOldTeacher.Location = new System.Drawing.Point(34, 176);
            this.textBoxOldTeacher.Name = "textBoxOldTeacher";
            this.textBoxOldTeacher.Size = new System.Drawing.Size(278, 26);
            this.textBoxOldTeacher.TabIndex = 12;
            // 
            // comboBoxClassRoom
            // 
            this.comboBoxClassRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClassRoom.FormattingEnabled = true;
            this.comboBoxClassRoom.Items.AddRange(new object[] {
            "LTL L1",
            "LIAGE L1",
            "LTL L2",
            "LIAGE L2",
            "LTL L3",
            "LIAGE L3"});
            this.comboBoxClassRoom.Location = new System.Drawing.Point(34, 280);
            this.comboBoxClassRoom.Name = "comboBoxClassRoom";
            this.comboBoxClassRoom.Size = new System.Drawing.Size(278, 28);
            this.comboBoxClassRoom.TabIndex = 13;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 380);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations Student";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelnameteach);
            this.groupBox2.Controls.Add(this.textBoxNameTeacher);
            this.groupBox2.Controls.Add(this.labeloldteach);
            this.groupBox2.Controls.Add(this.buttonaddteacher);
            this.groupBox2.Controls.Add(this.comboBoxClassRoom);
            this.groupBox2.Controls.Add(this.textBoxOldTeacher);
            this.groupBox2.Controls.Add(this.labelsubjectteacher);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(414, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 380);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations Teacher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "Add User";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelold;
        private System.Windows.Forms.Label labelsubject;
        private System.Windows.Forms.TextBox textBoxNameStudent;
        private System.Windows.Forms.TextBox textBoxOldStudent;
        private System.Windows.Forms.ComboBox comboBoxSubjectStudent;
        private System.Windows.Forms.Button buttonaddstudent;
        private System.Windows.Forms.Label labelnameteach;
        private System.Windows.Forms.Label labeloldteach;
        private System.Windows.Forms.Label labelsubjectteacher;
        private System.Windows.Forms.Button buttonaddteacher;
        private System.Windows.Forms.TextBox textBoxNameTeacher;
        private System.Windows.Forms.TextBox textBoxOldTeacher;
        private System.Windows.Forms.ComboBox comboBoxClassRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}

