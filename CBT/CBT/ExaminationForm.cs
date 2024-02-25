using System.Timers;


namespace CBT
{
    public partial class ExaminationForm : Form
    {
        int Count = 0;
        int PreviousQuestionN = 0;

        List<Question> questions = new List<Question>();
        private userDetails userDetails = new userDetails();

        public ExaminationForm()
        {
        }

        public ExaminationForm(userDetails userDetails)
        {
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            SetAllQuestions();
            this.userDetails = userDetails;
            currentUserName.Text = userDetails.Name.ToString();
            this.Text = null;
        }

        //-----------> For Timer <----------
        System.Timers.Timer timer1 = new System.Timers.Timer();
        int m = 19, s = 59;

        //==============>> Form Load <<=============
        private void ExaminationForm_Load(object sender, EventArgs e)
        {
            timer1 = new System.Timers.Timer();
            timer1.Interval = 1000;
            timer1.Elapsed += OnTimeEvent;
            timer1.Start();
            GetCurrentQuestions();
        }

        //====================>>ALl Helper Methods Are Below<<==================

        //------------> GetCurrentQuestions <-------------
        private void GetCurrentQuestions()
        {
            QuestionN_lbl.Text = $"{Count + 1}.";
            Question_lbl.Text = questions[Count].Text;
            Option_A.Text = questions[Count].Options[0].ToString();
            Option_B.Text = questions[Count].Options[1].ToString();
            Option_C.Text = questions[Count].Options[2].ToString();
            Option_D.Text = questions[Count].Options[3].ToString();
            SetUserInputOption();
        }

        //------------->>unSelectAllOption<<-------------
        private void unSelectAllOption()
        {
            Option_A.Checked = false;
            Option_B.Checked = false;
            Option_C.Checked = false;
            Option_D.Checked = false;
        }

        //--------------->>SetUserInputOption<<------------
        private void SetUserInputOption()
        {
            //  MessageBox.Show($"User input value of Q {Count+1} = {questions[Count].userInput}");

            switch (questions[Count].userInput)
            {
                case 'A':
                    Option_A.Checked = true;
                    break;
                case 'B':
                    Option_B.Checked = true;
                    break;
                case 'C':
                    Option_C.Checked = true;
                    break;
                case 'D':
                    Option_D.Checked = true;
                    break;
                case ' ':
                    Option_A.Checked = false;
                    Option_B.Checked = false;
                    Option_C.Checked = false;
                    Option_D.Checked = false;
                    break;
            }

        }

        //--------------->>LockConfirmedQuestion<<-----------
        private int LockConfimedQuestions()
        {
            if (getCurrentColorOfQuestionBtn() == Color.Green)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

        //====================>>ALl Helper Methods Are Above<<==================

        //------------->>For Option A<<-------------
        private void Option_A_CheckedChanged(object sender, EventArgs e)
        {
            questions[Count].userInput = 'A';
        }

        //------------->>For Option B<<-------------
        private void Option_B_CheckedChanged(object sender, EventArgs e)
        {
            questions[Count].userInput = 'B';
        }

        //------------->>For Option C<<-------------
        private void Option_C_CheckedChanged(object sender, EventArgs e)
        {
            questions[Count].userInput = 'C';
        }

        //------------->>For Option D<<-------------
        private void Option_D_CheckedChanged(object sender, EventArgs e)
        {
            questions[Count].userInput = 'D';
        }

        //------------->Next,Previous,Submit<<-----------
        private void Next_btn_Click(object sender, EventArgs e)
        {
            if (questions[Count].userInput != ' ' && getCurrentColorOfQuestionBtn() == Color.WhiteSmoke)
            {
                BtnColoringBg(Color.Green);
            }

            unSelectAllOption();
            Previous_btn.BackColor = Color.Indigo;

            if (Count < 9)
            {
                Count++;
                GetCurrentQuestions();
            }
            else
            {
                Next_btn.BackColor = Color.Gray;
            }
            SetUserInputOption();
        }
        private void Previous_btn_Click(object sender, EventArgs e)
        {
            unSelectAllOption();
            Next_btn.BackColor = Color.Indigo;
            if (Count > 0)
            {
                Count--;
                GetCurrentQuestions();
            }
            else
            {
                Previous_btn.BackColor = Color.Gray;
            }
            SetUserInputOption();
        }
        private void Submit_btn_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to submit?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int temp = 0;
                foreach (var element in questions)
                {
                    if (element.CorrectAnswer == element.userInput)
                    {
                        temp++;
                    }
                }
                userDetails.TotalCorrect = temp;
                ResultForm ResultForm = new ResultForm(userDetails);
                this.Hide();
                ResultForm.ShowDialog();
            }
        }

        //=============>>Set All Questions<<=============
        private void SetAllQuestions()
        {
            //QuestionNo 1
            Question q1 = new Question(
               "What does C# stand for?",
               new List<string> { "Common Style", "Computer Sharp", "C Sharp", "Code System" },
               'C',
               ' '
           );
            questions.Add(q1);

            //QuestionNo 2
            Question q2 = new Question(
                "In C#, which keyword is used to declare a class?",
                new List<string> { "type", "class", "struct", "object" },
                'B',
                ' '
            );
            questions.Add(q2);

            //QuestionNo 3
            Question q3 = new Question(
                "What is the purpose of the \"using\" statement in C#?",
                new List<string> { "To include a namespace", " To declare a variable", " To declare a variable", " To declare a variable" },
                'A',
                ' '
            );
            questions.Add(q3);

            //QuestionNo 4
            Question q4 = new Question(
                "In C#, what is the default access modifier for class members if no access modifier is specified?",
                new List<string> { "private",
                    "private",
                    "protected",
                    "protected" },
                'B',
                ' '
            );
            questions.Add(q4);

            //QuestionNo 5
            Question q5 = new Question(
                "How do you declare a constant in C#?",
                new List<string> { "const int x = 5;",
                    "const int x = 5;",
                    "const int x = 5;",
                    "const int x = 5;" },
                'A',
                ' '
            );
            questions.Add(q5);


            //QuestionNo 6
            Question q6 = new Question(
                "Which of the following statements is used to handle exceptions in C#?",
                new List<string> { "try-catch",
                    "if-else",
                    "if-else",
                    "for loop" },
                'A',
                ' '
            );
            questions.Add(q6);


            //QuestionNo 7
            Question q7 = new Question(
                "What does the \"this\" keyword refer to in C#?",
                new List<string> { "Current instance of the class",
                    "Current instance of the class",
                    "Derived class",
                    "Static class" },
                'A',
                ' '
            );
            questions.Add(q7);

            //QuestionNo 8
            Question q8 = new Question(
                "In C#, what is the purpose of the \"as\" operator?",
                new List<string> { "Arithmetic operation",
                    "Arithmetic operation",
                    "Logical AND",
                    "Bitwise shift" },
                'B',
                ' '
            );
            questions.Add(q8);

            //QuestionNo 9
            Question q9 = new Question(
                "What is the purpose of the \"sealed\" keyword in C#?",
                new List<string> { "To prevent inheritance",
                    " To prevent inheritance", " To prevent inheritance", " To prevent inheritance" },
                'A',
                ' '
            );
            questions.Add(q9);

            //QuestionNo 10
            Question q10 = new Question(
                "Which of the following is NOT a valid C# data type?",
                new List<string> { "double", "char", "decimal", "byte" },
                'D',
                ' '
            );
            questions.Add(q10);
        }

        //------------->>Timer<<--------------
        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {
            if (Timer_lbl.IsHandleCreated)
            {
                Timer_lbl.BeginInvoke(new Action(() =>
                {
                    s -= 1;
                    if (s == 0 && m > 0)
                    {
                        s = 59;
                        m -= 1;
                    }
                    if (m == 0 && s == 0)
                    {
                        MessageBox.Show(this, "Examination Time Out");
                        int temp = 0;
                        foreach (var element in questions)
                        {
                            if (element.CorrectAnswer == element.userInput)
                            {
                                temp++;
                            }
                        }

                        userDetails.TotalCorrect = temp;
                        ResultForm ResultForm = new ResultForm(userDetails);
                        this.Hide();
                        ResultForm.ShowDialog();


                    }
                    Timer_lbl.Text = $"{m:00}:{s:00}";
                }));
            }
        }

        private void Q1_btn_Click(object sender, EventArgs e)
        {
            Count = 0;

            if (questions[PreviousQuestionN].userInput != ' ' && getCurrentColorOfQuestionBtn(PreviousQuestionN) == Color.WhiteSmoke)
            {
                BtnColoringBg(Color.Green, PreviousQuestionN);
            }
            GetCurrentQuestions();
            PreviousQuestionN = 0;
        }

        private void Q2_btn_Click(object sender, EventArgs e)
        {
            Count = 1;
            //GetCurrentQuestions();
            if (questions[PreviousQuestionN].userInput != ' ' && getCurrentColorOfQuestionBtn(PreviousQuestionN) == Color.WhiteSmoke)
            {
                BtnColoringBg(Color.Green, PreviousQuestionN);
            }
            GetCurrentQuestions();

            PreviousQuestionN = 1;
        }

        private void Q3_btn_Click(object sender, EventArgs e)
        {
            Count = 2;
            //GetCurrentQuestions();

            if (questions[PreviousQuestionN].userInput != ' ' && getCurrentColorOfQuestionBtn(PreviousQuestionN) == Color.WhiteSmoke)
            {
                BtnColoringBg(Color.Green, PreviousQuestionN);
            }
            GetCurrentQuestions();

            PreviousQuestionN = 2;
        }

        private void Q4_btn_Click(object sender, EventArgs e)
        {
            Count = 3;
            // GetCurrentQuestions();
            if (questions[PreviousQuestionN].userInput != ' ' && getCurrentColorOfQuestionBtn(PreviousQuestionN) == Color.WhiteSmoke)
            {
                BtnColoringBg(Color.Green, PreviousQuestionN);
            }
            GetCurrentQuestions();

            PreviousQuestionN = 3;
        }

        private void Q5_btn_Click(object sender, EventArgs e)
        {
            Count = 4;
            if (questions[PreviousQuestionN].userInput != ' ' && getCurrentColorOfQuestionBtn(PreviousQuestionN) == Color.WhiteSmoke)
            {
                BtnColoringBg(Color.Green, PreviousQuestionN);
            }
            GetCurrentQuestions();
            PreviousQuestionN = 4;
        }

        private void Q6_btn_Click(object sender, EventArgs e)
        {
            Count = 5;
            if (questions[PreviousQuestionN].userInput != ' ' && getCurrentColorOfQuestionBtn(PreviousQuestionN) == Color.WhiteSmoke)
            {
                BtnColoringBg(Color.Green, PreviousQuestionN);
            }
            GetCurrentQuestions();
            PreviousQuestionN = 5;
        }

        private void Q7_btn_Click(object sender, EventArgs e)
        {
            Count = 6;
            if (questions[PreviousQuestionN].userInput != ' ' && getCurrentColorOfQuestionBtn(PreviousQuestionN) == Color.WhiteSmoke)
            {
                BtnColoringBg(Color.Green, PreviousQuestionN);
            }
            GetCurrentQuestions();
            PreviousQuestionN = 6;
        }

        private void Q8_btn_Click(object sender, EventArgs e)
        {
            Count = 7;
            if (questions[PreviousQuestionN].userInput != ' ' && getCurrentColorOfQuestionBtn(PreviousQuestionN) == Color.WhiteSmoke)
            {
                BtnColoringBg(Color.Green, PreviousQuestionN);
            }
            GetCurrentQuestions();
            PreviousQuestionN = 7;
        }

        private void Q9_btn_Click(object sender, EventArgs e)
        {
            Count = 8;
            if (questions[PreviousQuestionN].userInput != ' ' && getCurrentColorOfQuestionBtn(PreviousQuestionN) == Color.WhiteSmoke)
            {
                BtnColoringBg(Color.Green, PreviousQuestionN);
            }
            GetCurrentQuestions();
            PreviousQuestionN = 8;
        }

        private void Q10_btn_Click(object sender, EventArgs e)
        {
            Count = 9;
            if (questions[PreviousQuestionN].userInput != ' ' && getCurrentColorOfQuestionBtn(PreviousQuestionN) == Color.WhiteSmoke)
            {
                BtnColoringBg(Color.Green, PreviousQuestionN);
            }

            GetCurrentQuestions();
            PreviousQuestionN = 9;
        }

        private void QuestionInDoubtBtn_Click(object sender, EventArgs e)
        {
            BtnColoringBg(Color.Red);
        }

        private void QuestionInExceptionBtn_Click(object sender, EventArgs e)
        {
            BtnColoringBg(Color.Yellow);
        }

        private void QuestionInConfirmBtn_Click(object sender, EventArgs e)
        {
            BtnColoringBg(Color.Green);
        }

        private void BtnColoringBg(Color bg)
        {
            switch (Count)
            {
                case 0:
                    Q1_btn.BackColor = bg;
                    break;
                case 1:
                    Q2_btn.BackColor = bg;
                    break;
                case 2:
                    Q3_btn.BackColor = bg;
                    break;
                case 3:
                    Q4_btn.BackColor = bg;
                    break;
                case 4:
                    Q5_btn.BackColor = bg;
                    break;
                case 5:
                    Q6_btn.BackColor = bg;
                    break;
                case 6:
                    Q7_btn.BackColor = bg;
                    break;
                case 7:
                    Q8_btn.BackColor = bg;
                    break;
                case 8:
                    Q9_btn.BackColor = bg;
                    break;
                case 9:
                    Q10_btn.BackColor = bg;
                    break;
            }
        }

        private void BtnColoringBg(Color bg, int QN)
        {
            switch (QN)
            {
                case 0:
                    Q1_btn.BackColor = bg;
                    break;
                case 1:
                    Q2_btn.BackColor = bg;
                    break;
                case 2:
                    Q3_btn.BackColor = bg;
                    break;
                case 3:
                    Q4_btn.BackColor = bg;
                    break;
                case 4:
                    Q5_btn.BackColor = bg;
                    break;
                case 5:
                    Q6_btn.BackColor = bg;
                    break;
                case 6:
                    Q7_btn.BackColor = bg;
                    break;
                case 7:
                    Q8_btn.BackColor = bg;
                    break;
                case 8:
                    Q9_btn.BackColor = bg;
                    break;
                case 9:
                    Q10_btn.BackColor = bg;
                    break;
            }
        }

        private Color getCurrentColorOfQuestionBtn()
        {

            Button[] questionButtons = { Q1_btn, Q2_btn, Q3_btn, Q4_btn, Q5_btn, Q6_btn, Q7_btn, Q8_btn, Q9_btn, Q10_btn };

            if (Count >= 0 && Count < questionButtons.Length)
            {
                return questionButtons[Count].BackColor;
            }
            else
            {
                return Color.WhiteSmoke;
            }
        }

        private Color getCurrentColorOfQuestionBtn(int PreviousQN)
        {
            Button[] questionButtons = { Q1_btn, Q2_btn, Q3_btn, Q4_btn, Q5_btn, Q6_btn, Q7_btn, Q8_btn, Q9_btn, Q10_btn };

            if (PreviousQN >= 0 && PreviousQN < questionButtons.Length)
            {
                return questionButtons[PreviousQN].BackColor;
            }
            else
            {
                return Color.WhiteSmoke;
            }
        }
    }
}