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
            SuspendLayout();
            // 
            // Question_lbl
            // 
            Question_lbl.AutoSize = true;
            Question_lbl.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Question_lbl.ForeColor = SystemColors.Control;
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
            QuestionN_lbl.ForeColor = SystemColors.Control;
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
            Timer_lbl.Location = new Point(663, 9);
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
            Option_A.ForeColor = SystemColors.ActiveBorder;
            Option_A.Location = new Point(71, 139);
            Option_A.Name = "Option_A";
            Option_A.Size = new Size(240, 41);
            Option_A.TabIndex = 3;
            Option_A.Text = "radioButton1";
            Option_A.UseVisualStyleBackColor = true;
            // 
            // Option_B
            // 
            Option_B.AutoSize = true;
            Option_B.Cursor = Cursors.Hand;
            Option_B.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Option_B.ForeColor = SystemColors.ActiveBorder;
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
            Option_D.ForeColor = SystemColors.ActiveBorder;
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
            Option_C.ForeColor = SystemColors.ActiveBorder;
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
            Previous_btn.BackColor = Color.FromArgb(70, 47, 204);
            Previous_btn.Cursor = Cursors.Hand;
            Previous_btn.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Previous_btn.ForeColor = SystemColors.InactiveBorder;
            Previous_btn.Location = new Point(203, 407);
            Previous_btn.Name = "Previous_btn";
            Previous_btn.Size = new Size(152, 54);
            Previous_btn.TabIndex = 7;
            Previous_btn.Text = "Previous";
            Previous_btn.UseVisualStyleBackColor = false;
            Previous_btn.Click += Previous_btn_Click;
            // 
            // Next_btn
            // 
            Next_btn.BackColor = Color.FromArgb(70, 47, 204);
            Next_btn.Cursor = Cursors.Hand;
            Next_btn.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Next_btn.ForeColor = SystemColors.InactiveBorder;
            Next_btn.Location = new Point(391, 407);
            Next_btn.Name = "Next_btn";
            Next_btn.Size = new Size(152, 54);
            Next_btn.TabIndex = 8;
            Next_btn.Text = "Next";
            Next_btn.UseVisualStyleBackColor = false;
            Next_btn.Click += Next_btn_Click;
            // 
            // Submit_btn
            // 
            Submit_btn.BackColor = Color.ForestGreen;
            Submit_btn.Cursor = Cursors.Hand;
            Submit_btn.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Submit_btn.ForeColor = SystemColors.InactiveBorder;
            Submit_btn.Location = new Point(636, 471);
            Submit_btn.Name = "Submit_btn";
            Submit_btn.Size = new Size(152, 54);
            Submit_btn.TabIndex = 9;
            Submit_btn.Text = "Submit";
            Submit_btn.UseVisualStyleBackColor = false;
            Submit_btn.Click += Submit_btn_Click_1;
            // 
            // ExaminationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InfoText;
            ClientSize = new Size(800, 557);
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
            Text = "ExaminationForm";
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
    }
}