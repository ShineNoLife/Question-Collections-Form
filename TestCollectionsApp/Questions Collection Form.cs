using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.IO;

namespace TestCollectionsApp
{
    public partial class QuestionsCollection : Form
    {
        static string connectionString = "datasource=127.0.0.1; port=3306; username=root; password=123456789; database=questiondatabase";
        MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        MySqlCommand databaseCommand = new MySqlCommand();
        MySqlDataReader databaseReader;
        List<string> QuestionIDList = new List<string>();
        List<string> QuestionList = new List<string>();
        string[] QuestionData;
        string searchString = "";
        public QuestionsCollection()
        {
            InitializeComponent();

            SetupListBox();
        }

        private void SearchQuestionButton_Click(object sender, EventArgs e)
        {
            questionListBox.Items.Clear();

            databaseConnection.Open();
            databaseCommand.CommandText = $"SELECT ID, Name FROM questiontable WHERE Name LIKE '%{ searchString }%'";
            databaseReader = databaseCommand.ExecuteReader();
            if (!Search())
            {
                MessageBox.Show("No Questions Found");
            }
            databaseConnection.Close();
        }

        private void QuestionSearchBar_TextChanged(object sender, EventArgs e)
        {
            searchString = questionSearchBar.Text;
        }

        private void openSelectedQuestionButton_Click(object sender, EventArgs e)
        {
            try
            {
                string idString = QuestionIDList[questionListBox.SelectedIndex];
                string questionDirectory = "";
                databaseConnection.Open();
                databaseCommand.CommandText = $"SELECT Directory FROM questiontable WHERE ID = '{ idString }'";
                databaseReader = databaseCommand.ExecuteReader();
                if (databaseReader.HasRows)
                {
                    while (databaseReader.Read())
                        questionDirectory = databaseReader.GetString(0);
                }

                QuestionData = File.ReadAllLines(questionDirectory);
                Form QuestionForm = new Question_Form(QuestionData);
                QuestionForm.Show();

                databaseConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No Question Currently Selected");
            }
        }

        private void SetupListBox()
        {
            databaseConnection.Open();
            databaseCommand.Connection = databaseConnection;
            databaseCommand.CommandText = "SELECT ID, Name FROM questiontable;";
            databaseReader = databaseCommand.ExecuteReader();
            
            if (databaseReader.HasRows)
            {
                while (databaseReader.Read())
                {
                    QuestionIDList.Add($"{ databaseReader.GetString(0) }");
                    QuestionList.Add($"{ databaseReader.GetString(1) }");
                }
            }
            databaseConnection.Close();

            questionListBox.Items.Clear();
            for(int i = 0; i < QuestionList.Count; i++)
            {
                questionListBox.Items.Add($"{ QuestionIDList[i] }: { QuestionList[i] }");
            }           
        }

        private bool Search()
        {
            if (databaseReader.HasRows)
            {
                QuestionIDList.Clear();
                QuestionList.Clear();
                while (databaseReader.Read())
                {
                    QuestionIDList.Add($"{ databaseReader.GetString(0) }");
                    QuestionList.Add($"{ databaseReader.GetString(1) }");
                }
                for (int i = 0; i < QuestionList.Count; i++)
                {
                    questionListBox.Items.Add($"{ QuestionIDList[i] }: { QuestionList[i] }");
                }
                return true;
            }
            return false;
        }

    }
}
