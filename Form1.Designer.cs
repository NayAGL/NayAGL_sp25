﻿namespace NayAGL_sp25
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtStudentName = new TextBox();
            lstOutput = new ListBox();
            btnSubmit = new Button();
            txtGPA = new TextBox();
            label3 = new Label();
            btnClear = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 38);
            label1.Name = "label1";
            label1.Size = new Size(563, 31);
            label1.TabIndex = 0;
            label1.Text = "Introduction to Computer Programming for Business";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 116);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Student Name";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(172, 113);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(328, 27);
            txtStudentName.TabIndex = 1;
            txtStudentName.TextChanged += textBox1_TextChanged;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(62, 194);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(679, 204);
            lstOutput.TabIndex = 6;
            lstOutput.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(59, 409);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "&Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(172, 146);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(328, 27);
            txtGPA.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 149);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 5;
            label3.Text = "Student GPA";
            label3.Click += label3_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(172, 409);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 4;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(647, 409);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(94, 29);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(txtGPA);
            Controls.Add(label3);
            Controls.Add(btnSubmit);
            Controls.Add(lstOutput);
            Controls.Add(txtStudentName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Nay Latt's CIS 152 D13";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtStudentName;
        private ListBox lstOutput;
        private Button btnSubmit;
        private TextBox txtGPA;
        private Label label3;
        private Button btnClear;
        private Button btnQuit;
    }
}
