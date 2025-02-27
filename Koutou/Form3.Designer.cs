namespace Koutou
{
    partial class Form3
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelnameteach = new System.Windows.Forms.Label();
            this.textBoxNameTeacher = new System.Windows.Forms.TextBox();
            this.labeloldteach = new System.Windows.Forms.Label();
            this.buttonaddteacher = new System.Windows.Forms.Button();
            this.comboBoxClassRoom = new System.Windows.Forms.ComboBox();
            this.textBoxOldTeacher = new System.Windows.Forms.TextBox();
            this.labelsubjectteacher = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(213, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 380);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations Teacher";
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
            // textBoxNameTeacher
            // 
            this.textBoxNameTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameTeacher.Location = new System.Drawing.Point(34, 67);
            this.textBoxNameTeacher.Name = "textBoxNameTeacher";
            this.textBoxNameTeacher.Size = new System.Drawing.Size(278, 26);
            this.textBoxNameTeacher.TabIndex = 11;
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
            // textBoxOldTeacher
            // 
            this.textBoxOldTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOldTeacher.Location = new System.Drawing.Point(34, 176);
            this.textBoxOldTeacher.Name = "textBoxOldTeacher";
            this.textBoxOldTeacher.Size = new System.Drawing.Size(278, 26);
            this.textBoxOldTeacher.TabIndex = 12;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelnameteach;
        private System.Windows.Forms.TextBox textBoxNameTeacher;
        private System.Windows.Forms.Label labeloldteach;
        private System.Windows.Forms.Button buttonaddteacher;
        private System.Windows.Forms.ComboBox comboBoxClassRoom;
        private System.Windows.Forms.TextBox textBoxOldTeacher;
        private System.Windows.Forms.Label labelsubjectteacher;
    }
}