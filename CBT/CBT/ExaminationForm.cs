using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;


namespace CBT
{
    public partial class ExaminationForm : Form
    {
        int Count = 0;
        List<Question> questions = new List<Question>();
        //userDetails userDetails = new userDetails();
        private userDetails userDetails;
        public ExaminationForm()
        {

        }
        public ExaminationForm(userDetails userDetails)
        {
            InitializeComponent();
            SetAllQuestions();
            this.userDetails = userDetails;
            // MessageBox.Show(userDetails.Name);
        }




        System.Timers.Timer timer1;
        int m = 19, s = 59;


        private void ExaminationForm_Load(object sender, EventArgs e)
        {
            timer1 = new System.Timers.Timer();
            timer1.Interval = 1000;
            timer1.Elapsed += OnTimeEvent;
            timer1.Start();

            GetCurrentQuestions();
        }

        //GetCurrentQuestions
        private void GetCurrentQuestions()
        {
            Option_A.Checked = false;
            Option_B.Checked = false;
            Option_C.Checked = false;
            Option_D.Checked = false;


            QuestionN_lbl.Text = $"{Count + 1}.";
            Question_lbl.Text = questions[Count].Text;
            Option_A.Text = questions[Count].Options[0].ToString();
            Option_B.Text = questions[Count].Options[1].ToString();
            Option_C.Text = questions[Count].Options[2].ToString();
            Option_D.Text = questions[Count].Options[3].ToString();
        }


        private void Option_A_CheckedChanged(object sender, EventArgs e, int TotalCorrect)
        {
            //questions[Count].userInput = 'A';
            if (questions[Count].CorrectAnswer == 'A')
            {
                userDetails.TotalCorrect += 1;
            }
        }

        private void Option_B_CheckedChanged(object sender, EventArgs e)
        {
            //questions[Count].userInput = 'B';
            if (questions[Count].CorrectAnswer == 'B')
            {
                userDetails.TotalCorrect += 1;
            }
        }

        private void Option_C_CheckedChanged(object sender, EventArgs e)
        {
            //questions[Count].userInput = 'C';
            if (questions[Count].CorrectAnswer == 'C')
            {
                userDetails.TotalCorrect += 1;
            }
        }

        private void Option_D_CheckedChanged(object sender, EventArgs e)
        {
            //questions[Count].userInput = 'D';
            if (questions[Count].CorrectAnswer == 'D')
            {
                userDetails.TotalCorrect += 1;
            }
        }

        //SetAllQuestions
        private void SetAllQuestions()
        {
            //QuestionNo 1
            Question q1 = new Question(
               "What does C# stand for?",
               new List<string> { "Common Style", "Computer Sharp", "C Sharp", "Code System" },
               'C'
           );
            questions.Add(q1);

            //QuestionNo 2
            Question q2 = new Question(
                "In C#, which keyword is used to declare a class?",
                new List<string> { "type", "class", "struct", "object" },
                'B'
            );
            questions.Add(q2);

            //QuestionNo 3
            Question q3 = new Question(
                "What is the purpose of the \"using\" statement in C#?",
                new List<string> { "To include a namespace", " To declare a variable", " To declare a variable", " To declare a variable" },
                'b'
            );
            questions.Add(q3);

            //QuestionNo 4
            Question q4 = new Question(
                "In C#, what is the default access modifier for class members if no access modifier is specified?",
                new List<string> { "private",
                    "private",
                    "protected",
                    "protected" },
                'b'
            );
            questions.Add(q4);

            //QuestionNo 5
            Question q5 = new Question(
                "How do you declare a constant in C#?",
                new List<string> { "const int x = 5;",
                    "const int x = 5;",
                    "const int x = 5;",
                    "const int x = 5;" },
                'b'
            );
            questions.Add(q5);


            //QuestionNo 6
            Question q6 = new Question(
                "Which of the following statements is used to handle exceptions in C#?",
                new List<string> { "try-catch",
                    "if-else",
                    "if-else",
                    "for loop" },
                'b'
            );
            questions.Add(q6);


            //QuestionNo 7
            Question q7 = new Question(
                "What does the \"this\" keyword refer to in C#?",
                new List<string> { "Current instance of the class",
                    "Current instance of the class",
                    "Derived class",
                    "Static class" },
                'b'
            );
            questions.Add(q7);

            //QuestionNo 8
            Question q8 = new Question(
                "In C#, what is the purpose of the \"as\" operator?",
                new List<string> { "Arithmetic operation",
                    "Arithmetic operation",
                    "Logical AND",
                    "Bitwise shift" },
                'b'
            );
            questions.Add(q8);

            //QuestionNo 9
            Question q9 = new Question(
                "What is the purpose of the \"sealed\" keyword in C#?",
                new List<string> { "To prevent inheritance",
                    " To prevent inheritance", " To prevent inheritance", " To prevent inheritance" },
                'b'
            );
            questions.Add(q9);

            //QuestionNo 10
            Question q10 = new Question(
                "Which of the following is NOT a valid C# data type?",
                new List<string> { "double", "char", "decimal", "byte" },
                'b'
            );
            questions.Add(q10);
        }

        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s -= 1;
                if (s == 0)
                {
                    s = 59;
                    m -= 1;
                }
                if (m == 0 && s == 0)
                {
                    MessageBox.Show("Examination Time Out");
                }
                Timer_lbl.Text = string.Format("{0}:{1}", m.ToString().ToString().PadLeft(2, '0'), s.ToString().ToString().PadLeft(2, '0'));
            }));
        }
      

        private void Next_btn_Click(object sender, EventArgs e)
        {
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
        }

        private void Previous_btn_Click(object sender, EventArgs e)
        {
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
        }

        private void Submit_btn_Click_1(object sender, EventArgs e)
        {
            ResultForm ResultForm = new ResultForm(userDetails);
            this.Hide();
            ResultForm.ShowDialog();
        }
    }
}
