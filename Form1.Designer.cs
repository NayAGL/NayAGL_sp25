namespace NayAGL_sp25
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
            lblFormTitle = new Label();
            lblStudentName = new Label();
            txtStudentName = new TextBox();
            lstOutput = new ListBox();
            btnSubmit = new Button();
            txtStudentGPA = new TextBox();
            lblStudentGPA = new Label();
            btnClear = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.Location = new Point(119, 38);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(563, 31);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Introduction to Computer Programming for Business";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(62, 116);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(104, 20);
            lblStudentName.TabIndex = 1;
            lblStudentName.Text = "Student Name";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(172, 113);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(328, 27);
            txtStudentName.TabIndex = 1;
            txtStudentName.TextChanged += textBox1_TextChanged;
            txtStudentName.Enter += txtStudentName_Enter;
            txtStudentName.Leave += txtStudentName_Leave;
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
            // txtStudentGPA
            // 
            txtStudentGPA.Location = new Point(172, 146);
            txtStudentGPA.Name = "txtStudentGPA";
            txtStudentGPA.Size = new Size(328, 27);
            txtStudentGPA.TabIndex = 2;
            txtStudentGPA.Enter += txtGPA_Enter;
            txtStudentGPA.Leave += txtGPA_Leave;
            // 
            // lblStudentGPA
            // 
            lblStudentGPA.AutoSize = true;
            lblStudentGPA.Location = new Point(62, 149);
            lblStudentGPA.Name = "lblStudentGPA";
            lblStudentGPA.Size = new Size(91, 20);
            lblStudentGPA.TabIndex = 5;
            lblStudentGPA.Text = "Student GPA";
            lblStudentGPA.Click += label3_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(172, 409);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 4;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(647, 409);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(94, 29);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(txtStudentGPA);
            Controls.Add(lblStudentGPA);
            Controls.Add(btnSubmit);
            Controls.Add(lstOutput);
            Controls.Add(txtStudentName);
            Controls.Add(lblStudentName);
            Controls.Add(lblFormTitle);
            Name = "Form1";
            Text = "Nay Latt's CIS 152 D13";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private Label lblStudentName;
        private TextBox txtStudentName;
        private ListBox lstOutput;
        private Button btnSubmit;
        private TextBox txtStudentGPA;
        private Label lblStudentGPA;
        private Button btnClear;
        private Button btnQuit;
    }
}
