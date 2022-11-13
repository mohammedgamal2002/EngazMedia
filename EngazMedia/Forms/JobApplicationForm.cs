using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EngazMedia.CV;
using static EngazMedia.CV.TechnicalSkillsForm;

namespace EngazMedia.Forms
{
    public partial class JobApplicationForm : Form
    {
        List<Form> cvForms = new List<Form>();
        int activeFormIndex = 0;

        public JobApplicationForm()
        {
            InitializeComponent();
            initCVFormsList();
        }
        private void initCVFormsList() {
            cvForms.Add(new ProfileForm());
            cvForms.Add(new EducationForm());
            cvForms.Add(new ProjectForm());
            cvForms.Add(new TechnicalSkillsForm());
            cvForms.Add(new ExperienceForm());
            foreach (Form form in cvForms)
            {
                form.TopLevel = false;
                form.AutoScroll = true;
                form.FormBorderStyle = FormBorderStyle.None;
                childFormPanel.Controls.Add(form);
            }

        }

        private void triggerNextButtonVisibility() {
            if (activeFormIndex + 1 < cvForms.Count - 1)
                nextButton.Visible = true;
            else
                nextButton.Visible = false;

            backButton.Visible = true;
        }



        private void triggerBackButtonVisibility()
        {
            if (activeFormIndex - 1 == 0)
                backButton.Visible = false;
            else
                backButton.Visible = true;
            nextButton.Visible = true;
            submitButton.Visible = false;
        }

        private void triggerSubmitButtonVisibility()
        {
            if (activeFormIndex == cvForms.Count-1)
                submitButton.Visible = true;
            else
                submitButton.Visible = false;
        }


        private void switchToNextForm() {
            cvForms[activeFormIndex].Hide();
            activeFormIndex++;
            try
            {
                cvForms[activeFormIndex].Show();

            }
            catch (System.ArgumentOutOfRangeException)
            {
                activeFormIndex = cvForms.Count;
                throw;
            }


        }
        private void switchToPreviousForm() {
            cvForms[activeFormIndex].Hide();
            activeFormIndex--;

            try
            {
                cvForms[activeFormIndex].Show();

            }
            catch (System.ArgumentOutOfRangeException)
            {
                activeFormIndex = 0;
                throw;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void JopApplicationForm_Load(object sender, EventArgs e)
        {
            
            cvForms[activeFormIndex].Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            triggerBackButtonVisibility();

            switchToPreviousForm();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            triggerNextButtonVisibility();
            switchToNextForm();
            triggerSubmitButtonVisibility();

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
