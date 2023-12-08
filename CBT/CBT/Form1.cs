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
            ExaminationForm examinationForm = new ExaminationForm(userDetails);
            this.Hide();
            examinationForm.ShowDialog();
        }
        private void Form1_Name_TextChanged(object sender, EventArgs e)
        {
            userDetails.Name = Form1_Name_TextBox.Text;
        }

        private void Form1_FatherName_TextBox_TextChanged(object sender, EventArgs e)
        {
            userDetails.FatherName = Form1_FatherName_TextBox.Text;
        }

        private void Form1_RollNumber_TextBox_TextChanged(object sender, EventArgs e)
        {
            userDetails.RollNumber = int.Parse(Form1_RollNumber_TextBox.Text);
        }

        private void Form1_Aadhar_TextBox_TextChanged(object sender, EventArgs e)
        {
            userDetails.AadharNumber = Form1_Aadhar_TextBox.Text;
        }

        private void Form1_Email_TextBox_TextChanged(object sender, EventArgs e)
        {
            userDetails.Email = Form1_Email_TextBox.Text;
        }

        private void Form1_Password_TextBox_TextChanged(object sender, EventArgs e)
        {
            userDetails.Password = Form1_Password_TextBox.Text;
        }

        public userDetails GetUserDetails()
        {
            return userDetails;
        }

    }
}