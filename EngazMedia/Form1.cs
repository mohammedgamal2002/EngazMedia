using EngazMedia.Forms;
using WindowsFormsApp12;

namespace EngazMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            JobApplicationForm jobApplicationForm = new JobApplicationForm();
            jobApplicationForm.ShowDialog();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

        }
    }
}