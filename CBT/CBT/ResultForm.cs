using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBT
{
    public partial class ResultForm : Form
    {
        private userDetails userDetails;
        public ResultForm(userDetails userDetails)
        {
            InitializeComponent();
            this.userDetails = userDetails;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            Name_lbl.Text = userDetails.Name;
            FatherName_lbl.Text = userDetails.FatherName;
            AadharNumber_lbl.Text = userDetails.AadharNumber;
            RollNumber_lbl.Text = $"{userDetails.RollNumber}";
            Email_lbl.Text = userDetails.Email;
            CorrectAns_lbl.Text = $"{userDetails.TotalCorrect}";
            Marks_lbl.Text = $"{userDetails.TotalCorrect * 2}";
            //  CorrectAns_lbl.Text = userDetails.TotalCorrect;
            // Marks_lbl.Text = int.Parse(userDetails.TotalCorrect) * 2;
        }

        private void CorrectAns_lbl_Click(object sender, EventArgs e)
        {

        }

        private void StartExamination_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            ExaminationForm exForm = new ExaminationForm();
            this.Close();
            form1.Close();
            exForm.Close();
        }
    }
}
