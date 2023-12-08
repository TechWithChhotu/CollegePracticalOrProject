namespace CBT
{
    partial class ResultForm
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
            label1 = new Label();
            Name_lbl = new Label();
            FatherName_lbl = new Label();
            RollNumber_lbl = new Label();
            Email_lbl = new Label();
            AadharNumber_lbl = new Label();
            CorrectAns_lbl = new Label();
            Marks_lbl = new Label();
            StartExamination_btn = new Button();
            label3 = new Label();
            marks = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(278, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 60);
            label1.TabIndex = 2;
            label1.Text = "Result";
            // 
            // Name_lbl
            // 
            Name_lbl.Anchor = AnchorStyles.None;
            Name_lbl.AutoSize = true;
            Name_lbl.BackColor = SystemColors.ActiveCaption;
            Name_lbl.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Name_lbl.Location = new Point(345, 86);
            Name_lbl.Name = "Name_lbl";
            Name_lbl.Size = new Size(81, 39);
            Name_lbl.TabIndex = 3;
            Name_lbl.Text = "Name:";
            // 
            // FatherName_lbl
            // 
            FatherName_lbl.Anchor = AnchorStyles.None;
            FatherName_lbl.AutoSize = true;
            FatherName_lbl.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FatherName_lbl.Location = new Point(345, 134);
            FatherName_lbl.Name = "FatherName_lbl";
            FatherName_lbl.Size = new Size(174, 39);
            FatherName_lbl.TabIndex = 5;
            FatherName_lbl.Text = "Father`s Name:";
            // 
            // RollNumber_lbl
            // 
            RollNumber_lbl.Anchor = AnchorStyles.None;
            RollNumber_lbl.AutoSize = true;
            RollNumber_lbl.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            RollNumber_lbl.Location = new Point(345, 212);
            RollNumber_lbl.Name = "RollNumber_lbl";
            RollNumber_lbl.Size = new Size(148, 39);
            RollNumber_lbl.TabIndex = 7;
            RollNumber_lbl.Text = "Roll Number:";
            // 
            // Email_lbl
            // 
            Email_lbl.Anchor = AnchorStyles.None;
            Email_lbl.AutoSize = true;
            Email_lbl.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Email_lbl.Location = new Point(345, 251);
            Email_lbl.Name = "Email_lbl";
            Email_lbl.Size = new Size(80, 39);
            Email_lbl.TabIndex = 11;
            Email_lbl.Text = "Email:";
            // 
            // AadharNumber_lbl
            // 
            AadharNumber_lbl.Anchor = AnchorStyles.None;
            AadharNumber_lbl.AutoSize = true;
            AadharNumber_lbl.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            AadharNumber_lbl.Location = new Point(345, 173);
            AadharNumber_lbl.Name = "AadharNumber_lbl";
            AadharNumber_lbl.Size = new Size(185, 39);
            AadharNumber_lbl.TabIndex = 12;
            AadharNumber_lbl.Text = "Aadhar Number:";
            // 
            // CorrectAns_lbl
            // 
            CorrectAns_lbl.Anchor = AnchorStyles.None;
            CorrectAns_lbl.AutoSize = true;
            CorrectAns_lbl.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            CorrectAns_lbl.Location = new Point(347, 327);
            CorrectAns_lbl.Name = "CorrectAns_lbl";
            CorrectAns_lbl.Size = new Size(183, 39);
            CorrectAns_lbl.TabIndex = 13;
            CorrectAns_lbl.Text = "TotalCorrectAns";
            CorrectAns_lbl.Click += CorrectAns_lbl_Click;
            // 
            // Marks_lbl
            // 
            Marks_lbl.Anchor = AnchorStyles.None;
            Marks_lbl.AutoSize = true;
            Marks_lbl.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Marks_lbl.ForeColor = Color.Blue;
            Marks_lbl.Location = new Point(347, 366);
            Marks_lbl.Name = "Marks_lbl";
            Marks_lbl.Size = new Size(39, 39);
            Marks_lbl.TabIndex = 14;
            Marks_lbl.Text = "10";
            // 
            // StartExamination_btn
            // 
            StartExamination_btn.Anchor = AnchorStyles.None;
            StartExamination_btn.BackColor = Color.Red;
            StartExamination_btn.Cursor = Cursors.Hand;
            StartExamination_btn.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            StartExamination_btn.ForeColor = SystemColors.ButtonHighlight;
            StartExamination_btn.Location = new Point(303, 456);
            StartExamination_btn.Name = "StartExamination_btn";
            StartExamination_btn.Size = new Size(183, 64);
            StartExamination_btn.TabIndex = 15;
            StartExamination_btn.Text = "Close";
            StartExamination_btn.UseVisualStyleBackColor = false;
            StartExamination_btn.Click += StartExamination_btn_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(97, 327);
            label3.Name = "label3";
            label3.Size = new Size(195, 39);
            label3.TabIndex = 16;
            label3.Text = "Total Correct Ans";
            // 
            // marks
            // 
            marks.Anchor = AnchorStyles.None;
            marks.AutoSize = true;
            marks.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            marks.ForeColor = Color.Black;
            marks.Location = new Point(100, 366);
            marks.Name = "marks";
            marks.Size = new Size(83, 39);
            marks.TabIndex = 17;
            marks.Text = "Marks";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(97, 251);
            label4.Name = "label4";
            label4.Size = new Size(80, 39);
            label4.TabIndex = 18;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(97, 212);
            label5.Name = "label5";
            label5.Size = new Size(148, 39);
            label5.TabIndex = 19;
            label5.Text = "Roll Number:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(97, 173);
            label6.Name = "label6";
            label6.Size = new Size(185, 39);
            label6.TabIndex = 20;
            label6.Text = "Aadhar Number:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(97, 134);
            label7.Name = "label7";
            label7.Size = new Size(174, 39);
            label7.TabIndex = 21;
            label7.Text = "Father`s Name:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(100, 95);
            label8.Name = "label8";
            label8.Size = new Size(81, 39);
            label8.TabIndex = 22;
            label8.Text = "Name:";
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 551);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(marks);
            Controls.Add(label3);
            Controls.Add(StartExamination_btn);
            Controls.Add(Marks_lbl);
            Controls.Add(CorrectAns_lbl);
            Controls.Add(AadharNumber_lbl);
            Controls.Add(Email_lbl);
            Controls.Add(RollNumber_lbl);
            Controls.Add(FatherName_lbl);
            Controls.Add(Name_lbl);
            Controls.Add(label1);
            Name = "ResultForm";
            Text = "ResultForm";
            Load += ResultForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Name_lbl;
        private Label FatherName_lbl;
        private Label RollNumber_lbl;
        private Label Email_lbl;
        private Label AadharNumber_lbl;
        private Label CorrectAns_lbl;
        private Label Marks_lbl;
        private Button StartExamination_btn;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label marks;
    }
}