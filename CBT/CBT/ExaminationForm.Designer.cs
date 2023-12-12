namespace CBT
{
    partial class ExaminationForm
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
            Question_lbl = new Label();
            QuestionN_lbl = new Label();
            Timer_lbl = new Label();
            Option_A = new RadioButton();
            Option_B = new RadioButton();
            Option_D = new RadioButton();
            Option_C = new RadioButton();
            Previous_btn = new Button();
            Next_btn = new Button();
            Submit_btn = new Button();
            Q1_btn = new Button();
            Q3_btn = new Button();
            Q2_btn = new Button();
            Q5_btn = new Button();
            Q4_btn = new Button();
            Q6_btn = new Button();
            Q7_btn = new Button();
            Q8_btn = new Button();
            Q9_btn = new Button();
            Q10_btn = new Button();
            QuestionInDoubtBtn = new Button();
            QuestionInExceptionBtn = new Button();
            QuestionInConfirmBtn = new Button();
            currentUserName = new Label();
            SuspendLayout();
            // 
            // Question_lbl
            // 
            Question_lbl.AllowDrop = true;
            Question_lbl.AutoSize = true;
            Question_lbl.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Question_lbl.ForeColor = Color.Black;
            Question_lbl.Location = new Point(71, 79);
            Question_lbl.Name = "Question_lbl";
            Question_lbl.Size = new Size(403, 42);
            Question_lbl.TabIndex = 0;
            Question_lbl.Text = "What is C# & Stands for";
            // 
            // QuestionN_lbl
            // 
            QuestionN_lbl.AutoSize = true;
            QuestionN_lbl.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionN_lbl.ForeColor = Color.Black;
            QuestionN_lbl.Location = new Point(26, 79);
            QuestionN_lbl.Name = "QuestionN_lbl";
            QuestionN_lbl.Size = new Size(50, 42);
            QuestionN_lbl.TabIndex = 1;
            QuestionN_lbl.Text = "1.";
            // 
            // Timer_lbl
            // 
            Timer_lbl.AutoSize = true;
            Timer_lbl.BorderStyle = BorderStyle.FixedSingle;
            Timer_lbl.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Timer_lbl.ForeColor = Color.Yellow;
            Timer_lbl.Location = new Point(26, 9);
            Timer_lbl.Name = "Timer_lbl";
            Timer_lbl.Padding = new Padding(5, 0, 5, 0);
            Timer_lbl.Size = new Size(125, 44);
            Timer_lbl.TabIndex = 2;
            Timer_lbl.Text = "20:00";
            // 
            // Option_A
            // 
            Option_A.AutoSize = true;
            Option_A.Cursor = Cursors.Hand;
            Option_A.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Option_A.ForeColor = Color.Black;
            Option_A.Location = new Point(71, 139);
            Option_A.Name = "Option_A";
            Option_A.Size = new Size(240, 41);
            Option_A.TabIndex = 3;
            Option_A.Text = "radioButton1";
            Option_A.UseVisualStyleBackColor = true;
            Option_A.CheckedChanged += Option_A_CheckedChanged;
            // 
            // Option_B
            // 
            Option_B.AutoSize = true;
            Option_B.Cursor = Cursors.Hand;
            Option_B.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Option_B.ForeColor = Color.Black;
            Option_B.Location = new Point(71, 200);
            Option_B.Name = "Option_B";
            Option_B.Size = new Size(240, 41);
            Option_B.TabIndex = 4;
            Option_B.Text = "radioButton1";
            Option_B.UseVisualStyleBackColor = true;
            Option_B.CheckedChanged += Option_B_CheckedChanged;
            // 
            // Option_D
            // 
            Option_D.AutoSize = true;
            Option_D.Cursor = Cursors.Hand;
            Option_D.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Option_D.ForeColor = Color.Black;
            Option_D.Location = new Point(71, 325);
            Option_D.Name = "Option_D";
            Option_D.Size = new Size(240, 41);
            Option_D.TabIndex = 5;
            Option_D.Text = "radioButton1";
            Option_D.UseVisualStyleBackColor = true;
            Option_D.CheckedChanged += Option_D_CheckedChanged;
            // 
            // Option_C
            // 
            Option_C.AutoSize = true;
            Option_C.Cursor = Cursors.Hand;
            Option_C.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Option_C.ForeColor = Color.Black;
            Option_C.Location = new Point(71, 260);
            Option_C.Name = "Option_C";
            Option_C.Size = new Size(240, 41);
            Option_C.TabIndex = 6;
            Option_C.Text = "radioButton1";
            Option_C.UseVisualStyleBackColor = true;
            Option_C.CheckedChanged += Option_C_CheckedChanged;
            // 
            // Previous_btn
            // 
            Previous_btn.Anchor = AnchorStyles.None;
            Previous_btn.BackColor = Color.FromArgb(70, 47, 204);
            Previous_btn.Cursor = Cursors.Hand;
            Previous_btn.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Previous_btn.ForeColor = SystemColors.InactiveBorder;
            Previous_btn.Location = new Point(42, 480);
            Previous_btn.Name = "Previous_btn";
            Previous_btn.Size = new Size(152, 54);
            Previous_btn.TabIndex = 7;
            Previous_btn.Text = "Previous";
            Previous_btn.UseVisualStyleBackColor = false;
            Previous_btn.Click += Previous_btn_Click;
            // 
            // Next_btn
            // 
            Next_btn.Anchor = AnchorStyles.None;
            Next_btn.BackColor = Color.FromArgb(70, 47, 204);
            Next_btn.Cursor = Cursors.Hand;
            Next_btn.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Next_btn.ForeColor = SystemColors.InactiveBorder;
            Next_btn.Location = new Point(1043, 480);
            Next_btn.Name = "Next_btn";
            Next_btn.Size = new Size(152, 54);
            Next_btn.TabIndex = 8;
            Next_btn.Text = "Next";
            Next_btn.UseVisualStyleBackColor = false;
            Next_btn.Click += Next_btn_Click;
            // 
            // Submit_btn
            // 
            Submit_btn.Anchor = AnchorStyles.None;
            Submit_btn.BackColor = Color.ForestGreen;
            Submit_btn.Cursor = Cursors.Hand;
            Submit_btn.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Submit_btn.ForeColor = SystemColors.InactiveBorder;
            Submit_btn.Location = new Point(1052, 611);
            Submit_btn.Name = "Submit_btn";
            Submit_btn.Size = new Size(152, 54);
            Submit_btn.TabIndex = 9;
            Submit_btn.Text = "Submit";
            Submit_btn.UseVisualStyleBackColor = false;
            Submit_btn.Click += Submit_btn_Click_1;
            // 
            // Q1_btn
            // 
            Q1_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Q1_btn.BackColor = Color.WhiteSmoke;
            Q1_btn.Cursor = Cursors.Hand;
            Q1_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Q1_btn.Location = new Point(1095, 21);
            Q1_btn.Name = "Q1_btn";
            Q1_btn.Size = new Size(47, 43);
            Q1_btn.TabIndex = 10;
            Q1_btn.Text = "1";
            Q1_btn.UseVisualStyleBackColor = false;
            Q1_btn.Click += Q1_btn_Click;
            // 
            // Q3_btn
            // 
            Q3_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Q3_btn.BackColor = Color.WhiteSmoke;
            Q3_btn.Cursor = Cursors.Hand;
            Q3_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Q3_btn.Location = new Point(1201, 21);
            Q3_btn.Name = "Q3_btn";
            Q3_btn.Size = new Size(47, 43);
            Q3_btn.TabIndex = 11;
            Q3_btn.Text = "3";
            Q3_btn.UseVisualStyleBackColor = false;
            Q3_btn.Click += Q3_btn_Click;
            // 
            // Q2_btn
            // 
            Q2_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Q2_btn.BackColor = Color.WhiteSmoke;
            Q2_btn.Cursor = Cursors.Hand;
            Q2_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Q2_btn.Location = new Point(1148, 19);
            Q2_btn.Name = "Q2_btn";
            Q2_btn.Size = new Size(47, 43);
            Q2_btn.TabIndex = 12;
            Q2_btn.Text = "2";
            Q2_btn.UseVisualStyleBackColor = false;
            Q2_btn.Click += Q2_btn_Click;
            // 
            // Q5_btn
            // 
            Q5_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Q5_btn.BackColor = Color.WhiteSmoke;
            Q5_btn.Cursor = Cursors.Hand;
            Q5_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Q5_btn.Location = new Point(1148, 68);
            Q5_btn.Name = "Q5_btn";
            Q5_btn.Size = new Size(47, 43);
            Q5_btn.TabIndex = 13;
            Q5_btn.Text = "5";
            Q5_btn.UseVisualStyleBackColor = false;
            Q5_btn.Click += Q5_btn_Click;
            // 
            // Q4_btn
            // 
            Q4_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Q4_btn.BackColor = Color.WhiteSmoke;
            Q4_btn.Cursor = Cursors.Hand;
            Q4_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Q4_btn.Location = new Point(1095, 70);
            Q4_btn.Name = "Q4_btn";
            Q4_btn.Size = new Size(47, 43);
            Q4_btn.TabIndex = 14;
            Q4_btn.Text = "4";
            Q4_btn.UseVisualStyleBackColor = false;
            Q4_btn.Click += Q4_btn_Click;
            // 
            // Q6_btn
            // 
            Q6_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Q6_btn.BackColor = Color.WhiteSmoke;
            Q6_btn.Cursor = Cursors.Hand;
            Q6_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Q6_btn.Location = new Point(1201, 68);
            Q6_btn.Name = "Q6_btn";
            Q6_btn.Size = new Size(47, 43);
            Q6_btn.TabIndex = 15;
            Q6_btn.Text = "6";
            Q6_btn.UseVisualStyleBackColor = false;
            Q6_btn.Click += Q6_btn_Click;
            // 
            // Q7_btn
            // 
            Q7_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Q7_btn.BackColor = Color.WhiteSmoke;
            Q7_btn.Cursor = Cursors.Hand;
            Q7_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Q7_btn.Location = new Point(1095, 119);
            Q7_btn.Name = "Q7_btn";
            Q7_btn.Size = new Size(47, 43);
            Q7_btn.TabIndex = 16;
            Q7_btn.Text = "7";
            Q7_btn.UseVisualStyleBackColor = false;
            Q7_btn.Click += Q7_btn_Click;
            // 
            // Q8_btn
            // 
            Q8_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Q8_btn.BackColor = Color.WhiteSmoke;
            Q8_btn.Cursor = Cursors.Hand;
            Q8_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Q8_btn.Location = new Point(1148, 119);
            Q8_btn.Name = "Q8_btn";
            Q8_btn.Size = new Size(47, 43);
            Q8_btn.TabIndex = 17;
            Q8_btn.Text = "8";
            Q8_btn.UseVisualStyleBackColor = false;
            Q8_btn.Click += Q8_btn_Click;
            // 
            // Q9_btn
            // 
            Q9_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Q9_btn.BackColor = Color.WhiteSmoke;
            Q9_btn.Cursor = Cursors.Hand;
            Q9_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Q9_btn.Location = new Point(1201, 117);
            Q9_btn.Name = "Q9_btn";
            Q9_btn.Size = new Size(47, 43);
            Q9_btn.TabIndex = 18;
            Q9_btn.Text = "9";
            Q9_btn.UseVisualStyleBackColor = false;
            Q9_btn.Click += Q9_btn_Click;
            // 
            // Q10_btn
            // 
            Q10_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Q10_btn.BackColor = Color.WhiteSmoke;
            Q10_btn.Cursor = Cursors.Hand;
            Q10_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Q10_btn.Location = new Point(1144, 168);
            Q10_btn.Name = "Q10_btn";
            Q10_btn.Size = new Size(60, 46);
            Q10_btn.TabIndex = 19;
            Q10_btn.Text = "10";
            Q10_btn.UseVisualStyleBackColor = false;
            Q10_btn.Click += Q10_btn_Click;
            // 
            // QuestionInDoubtBtn
            // 
            QuestionInDoubtBtn.Anchor = AnchorStyles.None;
            QuestionInDoubtBtn.BackColor = Color.Red;
            QuestionInDoubtBtn.Cursor = Cursors.Hand;
            QuestionInDoubtBtn.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionInDoubtBtn.ForeColor = SystemColors.InactiveBorder;
            QuestionInDoubtBtn.Location = new Point(344, 480);
            QuestionInDoubtBtn.Name = "QuestionInDoubtBtn";
            QuestionInDoubtBtn.Size = new Size(152, 54);
            QuestionInDoubtBtn.TabIndex = 20;
            QuestionInDoubtBtn.Text = "Doubt";
            QuestionInDoubtBtn.UseVisualStyleBackColor = false;
            QuestionInDoubtBtn.Click += QuestionInDoubtBtn_Click;
            // 
            // QuestionInExceptionBtn
            // 
            QuestionInExceptionBtn.Anchor = AnchorStyles.None;
            QuestionInExceptionBtn.BackColor = Color.Yellow;
            QuestionInExceptionBtn.Cursor = Cursors.Hand;
            QuestionInExceptionBtn.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionInExceptionBtn.ForeColor = SystemColors.ActiveCaptionText;
            QuestionInExceptionBtn.Location = new Point(529, 480);
            QuestionInExceptionBtn.Name = "QuestionInExceptionBtn";
            QuestionInExceptionBtn.Size = new Size(164, 54);
            QuestionInExceptionBtn.TabIndex = 21;
            QuestionInExceptionBtn.Text = "Exception";
            QuestionInExceptionBtn.UseVisualStyleBackColor = false;
            QuestionInExceptionBtn.Click += QuestionInExceptionBtn_Click;
            // 
            // QuestionInConfirmBtn
            // 
            QuestionInConfirmBtn.Anchor = AnchorStyles.None;
            QuestionInConfirmBtn.BackColor = Color.Lime;
            QuestionInConfirmBtn.Cursor = Cursors.Hand;
            QuestionInConfirmBtn.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionInConfirmBtn.ForeColor = Color.Blue;
            QuestionInConfirmBtn.Location = new Point(727, 480);
            QuestionInConfirmBtn.Name = "QuestionInConfirmBtn";
            QuestionInConfirmBtn.Size = new Size(152, 54);
            QuestionInConfirmBtn.TabIndex = 22;
            QuestionInConfirmBtn.Text = "Confirm";
            QuestionInConfirmBtn.UseVisualStyleBackColor = false;
            QuestionInConfirmBtn.Click += QuestionInConfirmBtn_Click;
            // 
            // currentUserName
            // 
            currentUserName.AutoSize = true;
            currentUserName.Font = new Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point);
            currentUserName.ForeColor = Color.FromArgb(64, 0, 64);
            currentUserName.Location = new Point(602, 1);
            currentUserName.Name = "currentUserName";
            currentUserName.Size = new Size(172, 51);
            currentUserName.TabIndex = 23;
            currentUserName.Text = "chhotu";
            // 
            // ExaminationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 133, 206);
            ClientSize = new Size(1276, 677);
            Controls.Add(currentUserName);
            Controls.Add(QuestionInConfirmBtn);
            Controls.Add(QuestionInExceptionBtn);
            Controls.Add(QuestionInDoubtBtn);
            Controls.Add(Q10_btn);
            Controls.Add(Q9_btn);
            Controls.Add(Q8_btn);
            Controls.Add(Q7_btn);
            Controls.Add(Q6_btn);
            Controls.Add(Q4_btn);
            Controls.Add(Q5_btn);
            Controls.Add(Q2_btn);
            Controls.Add(Q3_btn);
            Controls.Add(Q1_btn);
            Controls.Add(Submit_btn);
            Controls.Add(Next_btn);
            Controls.Add(Previous_btn);
            Controls.Add(Option_C);
            Controls.Add(Option_D);
            Controls.Add(Option_B);
            Controls.Add(Option_A);
            Controls.Add(Timer_lbl);
            Controls.Add(QuestionN_lbl);
            Controls.Add(Question_lbl);
            ForeColor = SystemColors.MenuHighlight;
            Name = "ExaminationForm";
            Text = "C# Examination";
            Load += ExaminationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Question_lbl;
        private Label QuestionN_lbl;
        private Label Timer_lbl;
        private RadioButton Option_A;
        private RadioButton Option_B;
        private RadioButton Option_D;
        private RadioButton Option_C;
        private Button Previous_btn;
        private Button Next_btn;
        private Button Submit_btn;
        private Button Q1_btn;
        private Button Q3_btn;
        private Button Q2_btn;
        private Button Q5_btn;
        private Button Q4_btn;
        private Button Q6_btn;
        private Button Q7_btn;
        private Button Q8_btn;
        private Button Q9_btn;
        private Button Q10_btn;
        private Button QuestionInDoubtBtn;
        private Button QuestionInExceptionBtn;
        private Button QuestionInConfirmBtn;
        private Label currentUserName;
    }
}