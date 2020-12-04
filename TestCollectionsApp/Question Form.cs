using System;
using System.Windows.Forms;

namespace TestCollectionsApp
{
    public partial class Question_Form : Form
    {
        string[] questionInfo;
        public Question_Form()
        {
            InitializeComponent();
        }

        public Question_Form(string[] str)
        {          
            InitializeComponent();

            questionInfo = str;
            SetupQuestionInfo();
        }

        private void SetupQuestionInfo()
        {
            foreach(string str in questionInfo)
            {
                questionInfoTextBox.Text += str;
                questionInfoTextBox.Text += Environment.NewLine;
            }
        }
    }
}
