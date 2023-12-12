namespace CBT
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
            StartExamination_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            Form1_Name_TextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Form1_FatherName_TextBox = new TextBox();
            Form1_RollNumber_TextBox = new TextBox();
            label5 = new Label();
            Form1_Aadhar_TextBox = new TextBox();
            label6 = new Label();
            Form1_Email_TextBox = new TextBox();
            Form1_Password_TextBox = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // StartExamination_btn
            // 
            StartExamination_btn.Anchor = AnchorStyles.None;
            StartExamination_btn.BackColor = Color.FromArgb(0, 192, 0);
            StartExamination_btn.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            StartExamination_btn.ForeColor = SystemColors.ButtonHighlight;
            StartExamination_btn.Location = new Point(321, 554);
            StartExamination_btn.Name = "StartExamination_btn";
            StartExamination_btn.Size = new Size(183, 64);
            StartExamination_btn.TabIndex = 0;
            StartExamination_btn.Text = "Start";
            StartExamination_btn.UseVisualStyleBackColor = false;
            StartExamination_btn.Click += StartExamination_btn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(235, 9);
            label1.Name = "label1";
            label1.Size = new Size(334, 60);
            label1.TabIndex = 1;
            label1.Text = "Examination";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(132, 128);
            label2.Name = "label2";
            label2.Size = new Size(81, 39);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // Form1_Name_TextBox
            // 
            Form1_Name_TextBox.Anchor = AnchorStyles.None;
            Form1_Name_TextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Form1_Name_TextBox.Location = new Point(332, 128);
            Form1_Name_TextBox.Name = "Form1_Name_TextBox";
            Form1_Name_TextBox.PlaceholderText = "  Name";
            Form1_Name_TextBox.Size = new Size(404, 45);
            Form1_Name_TextBox.TabIndex = 3;
            Form1_Name_TextBox.TextChanged += Form1_Name_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(132, 190);
            label3.Name = "label3";
            label3.Size = new Size(174, 39);
            label3.TabIndex = 4;
            label3.Text = "Father`s Name:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(132, 258);
            label4.Name = "label4";
            label4.Size = new Size(148, 39);
            label4.TabIndex = 6;
            label4.Text = "Roll Number:";
            // 
            // Form1_FatherName_TextBox
            // 
            Form1_FatherName_TextBox.Anchor = AnchorStyles.None;
            Form1_FatherName_TextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Form1_FatherName_TextBox.Location = new Point(332, 190);
            Form1_FatherName_TextBox.Name = "Form1_FatherName_TextBox";
            Form1_FatherName_TextBox.PlaceholderText = "  Father`s Name";
            Form1_FatherName_TextBox.Size = new Size(404, 50);
            Form1_FatherName_TextBox.TabIndex = 5;
            Form1_FatherName_TextBox.TextChanged += Form1_FatherName_TextBox_TextChanged;
            // 
            // Form1_RollNumber_TextBox
            // 
            Form1_RollNumber_TextBox.Anchor = AnchorStyles.None;
            Form1_RollNumber_TextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Form1_RollNumber_TextBox.Location = new Point(332, 258);
            Form1_RollNumber_TextBox.Name = "Form1_RollNumber_TextBox";
            Form1_RollNumber_TextBox.PlaceholderText = "  Roll Number";
            Form1_RollNumber_TextBox.Size = new Size(404, 50);
            Form1_RollNumber_TextBox.TabIndex = 7;
            Form1_RollNumber_TextBox.TextChanged += Form1_RollNumber_TextBox_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(132, 328);
            label5.Name = "label5";
            label5.Size = new Size(185, 39);
            label5.TabIndex = 8;
            label5.Text = "Aadhar Number:";
            // 
            // Form1_Aadhar_TextBox
            // 
            Form1_Aadhar_TextBox.Anchor = AnchorStyles.None;
            Form1_Aadhar_TextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Form1_Aadhar_TextBox.Location = new Point(332, 328);
            Form1_Aadhar_TextBox.Name = "Form1_Aadhar_TextBox";
            Form1_Aadhar_TextBox.PlaceholderText = "  Aadhar Number";
            Form1_Aadhar_TextBox.Size = new Size(404, 50);
            Form1_Aadhar_TextBox.TabIndex = 9;
            Form1_Aadhar_TextBox.TextChanged += Form1_Aadhar_TextBox_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(132, 397);
            label6.Name = "label6";
            label6.Size = new Size(80, 39);
            label6.TabIndex = 10;
            label6.Text = "Email:";
            // 
            // Form1_Email_TextBox
            // 
            Form1_Email_TextBox.Anchor = AnchorStyles.None;
            Form1_Email_TextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Form1_Email_TextBox.Location = new Point(332, 397);
            Form1_Email_TextBox.Name = "Form1_Email_TextBox";
            Form1_Email_TextBox.PlaceholderText = "  Email";
            Form1_Email_TextBox.Size = new Size(404, 50);
            Form1_Email_TextBox.TabIndex = 11;
            Form1_Email_TextBox.TextChanged += Form1_Email_TextBox_TextChanged;
            // 
            // Form1_Password_TextBox
            // 
            Form1_Password_TextBox.Anchor = AnchorStyles.None;
            Form1_Password_TextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Form1_Password_TextBox.Location = new Point(332, 465);
            Form1_Password_TextBox.Name = "Form1_Password_TextBox";
            Form1_Password_TextBox.PasswordChar = '*';
            Form1_Password_TextBox.PlaceholderText = "  Password";
            Form1_Password_TextBox.Size = new Size(404, 50);
            Form1_Password_TextBox.TabIndex = 13;
            Form1_Password_TextBox.TextChanged += Form1_Password_TextBox_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(132, 465);
            label7.Name = "label7";
            label7.Size = new Size(125, 39);
            label7.TabIndex = 12;
            label7.Text = "Password:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(869, 630);
            Controls.Add(Form1_Password_TextBox);
            Controls.Add(label7);
            Controls.Add(Form1_Email_TextBox);
            Controls.Add(label6);
            Controls.Add(Form1_Aadhar_TextBox);
            Controls.Add(label5);
            Controls.Add(Form1_RollNumber_TextBox);
            Controls.Add(label4);
            Controls.Add(Form1_FatherName_TextBox);
            Controls.Add(label3);
            Controls.Add(Form1_Name_TextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StartExamination_btn);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartExamination_btn;
        private Label label1;
        private Label label2;
        private TextBox Form1_Name_TextBox;
        private Label label3;
        private Label label4;
        private TextBox Form1_FatherName_TextBox;
        private TextBox Form1_RollNumber_TextBox;
        private Label label5;
        private TextBox Form1_Aadhar_TextBox;
        private Label label6;
        private TextBox Form1_Email_TextBox;
        private TextBox Form1_Password_TextBox;
        private Label label7;
    }
}