using System;
using System.Text.RegularExpressions;

namespace CBT
{
    public partial class Form1 : Form
    {
        userDetails userDetails = new userDetails();

        public Form1()
        {
            InitializeComponent();
        }

        private void StartExamination_btn_Click(object sender, EventArgs e)
        {
            if (ValidateUserData())
            {
                ExaminationForm examinationForm = new ExaminationForm(userDetails);
                this.Hide();
                examinationForm.ShowDialog();
            }

        }

        private bool ValidateUserData()
        {
            // Check if the required fields are not empty and meet specific criteria
            if (string.IsNullOrEmpty(Form1_Name_TextBox.Text) ||
                string.IsNullOrEmpty(Form1_FatherName_TextBox.Text) ||
                string.IsNullOrEmpty(Form1_RollNumber_TextBox.Text) ||
                string.IsNullOrEmpty(Form1_Aadhar_TextBox.Text) ||
                string.IsNullOrEmpty(Form1_Email_TextBox.Text) ||
                string.IsNullOrEmpty(Form1_Password_TextBox.Text))
            {
                MessageBox.Show("Please fill in all the required fields with valid data.");
                return false;
            }

            // Validate Roll Number (numeric input)
            if (!int.TryParse(Form1_RollNumber_TextBox.Text, out int rollNumber))
            {
                MessageBox.Show("Please enter a valid numeric value for Roll Number.");
                return false;
            }

            // Validate Aadhar Number (12-digit numeric input)
            if (Form1_Aadhar_TextBox.Text.Length != 12 || !long.TryParse(Form1_Aadhar_TextBox.Text, out long aadharNumber))
            {
                MessageBox.Show("Please enter a valid 12-digit numeric value for Aadhar Number.");
                return false;
            }

            // Validate Email format
            if (!IsValidEmail(Form1_Email_TextBox.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return false;
            }

            // Additional validation logic can be added for other fields

            // If all validations pass, update the userDetails object
            userDetails.Name = Form1_Name_TextBox.Text;
            userDetails.FatherName = Form1_FatherName_TextBox.Text;
            userDetails.RollNumber = rollNumber;
            userDetails.AadharNumber = aadharNumber.ToString(); // Store Aadhar as string to preserve leading zeros
            userDetails.Email = Form1_Email_TextBox.Text;
            userDetails.Password = Form1_Password_TextBox.Text;

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);

                if (!addr.Host.Contains('.'))
                {
                    return false;
                }

                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
