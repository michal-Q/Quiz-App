using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quiz_App
{
    public partial class AddQuestionPanel : UserControl
    {
        class QuestionData
        {
            public string Question { get; set; }
            public string AnswerA { get; set; }
            public string AnswerB { get; set; }
            public string AnswerC { get; set; }
            public string AnswerD { get; set; }
            public string CorrectAnswer { get; set; }
        }

        class QuizData
        {
            public List<QuestionData> Questions { get; set; }
        }
        public AddQuestionPanel(QuestionsPanel _questionsPanel)
        {
            InitializeComponent();
            questionsPanel = _questionsPanel;
            ClearTextBoxes();
            LoadData();
            DeleteButton.Hide();
        }

        private QuestionsPanel questionsPanel;

        public void ClearTextBoxes()
        {
            QuestionTextBox.Text = "";
            AnswerTextBox_A.Text = "";
            AnswerTextBox_B.Text = "";
            AnswerTextBox_C.Text = "";
            AnswerTextBox_D.Text = "";

            checkBoxA.Checked = false;
            checkBoxB.Checked = false;
            checkBoxC.Checked = false;
            checkBoxD.Checked = false;
        }

        private CheckBox lastChecked;
        private void checkBoxA_CheckedChanged(object sender, EventArgs e)
        {
            if (lastChecked != null && lastChecked != checkBoxA)
            {
                lastChecked.Checked = false;
            }
            lastChecked = checkBoxA;
        }
        private void checkBoxB_CheckedChanged(object sender, EventArgs e)
        {
            if (lastChecked != null && lastChecked != checkBoxB)
            {
                lastChecked.Checked = false;
            }
            lastChecked = checkBoxB;
        }
        private void checkBoxC_CheckedChanged(object sender, EventArgs e)
        {
            if (lastChecked != null && lastChecked != checkBoxC)
            {
                lastChecked.Checked = false;
            }
            lastChecked = checkBoxC;
        }
        private void checkBoxD_CheckedChanged(object sender, EventArgs e)
        {
            if (lastChecked != null && lastChecked != checkBoxD)
            {
                lastChecked.Checked = false;
            }
            lastChecked = checkBoxD;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            CheckIfEmpty();
        }

        string CorrectAnswer;
        private void CheckIfEmpty()
        {
            int IfNotEmpty = 0;
            if(QuestionTextBox.Text != "")
            {
                IfNotEmpty += 1;
            }
            else
            {
                RedTheTextBox(QuestionTextBox);
            }

            if (AnswerTextBox_A.Text != "")
            {
                IfNotEmpty += 1;
            }
            else
            {
                RedTheTextBox(AnswerTextBox_A);
            }

            if (AnswerTextBox_B.Text != "")
            {
                IfNotEmpty += 1;
            }
            else
            {
                RedTheTextBox(AnswerTextBox_B);
            }

            if (AnswerTextBox_C.Text != "")
            {
                IfNotEmpty += 1;
            }
            else
            {
                RedTheTextBox(AnswerTextBox_C);
            }

            if (AnswerTextBox_D.Text != "")
            {
                IfNotEmpty += 1;
            }
            else
            {
                RedTheTextBox(AnswerTextBox_D);
            }

            if(checkBoxA.Checked || checkBoxB.Checked || checkBoxC.Checked || checkBoxD.Checked)
            {
                IfNotEmpty += 1;
                if (checkBoxA.Checked)
                {
                    CorrectAnswer = "A";
                }else if (checkBoxB.Checked)
                {
                    CorrectAnswer = "B";
                }else if (checkBoxC.Checked)
                {
                    CorrectAnswer = "C";
                }else if (checkBoxD.Checked)
                {
                    CorrectAnswer = "D";
                }
            }
            else
            {
                RedTheCheckBox();
            }


            if(IfNotEmpty == 6)
            {
                SaveQuestion();
            }
            else
            {
                IfNotEmpty = 0;
            }
        }
        private async void RedTheTextBox(TextBox textboxToRed)
        {
            Color OriginalColor = textboxToRed.BackColor;
            textboxToRed.BackColor = Color.Red;
            await Task.Delay(1000);
            textboxToRed.BackColor = OriginalColor;
        }
        private async void RedTheCheckBox()
        {
            Color OriginalColor = checkBoxA.ForeColor;
            checkBoxA.ForeColor = Color.Red;
            checkBoxB.ForeColor = Color.Red;
            checkBoxC.ForeColor = Color.Red;
            checkBoxD.ForeColor = Color.Red;

            await Task.Delay(1000);

            checkBoxA.ForeColor = OriginalColor;
            checkBoxB.ForeColor = OriginalColor;
            checkBoxC.ForeColor = OriginalColor;
            checkBoxD.ForeColor = OriginalColor;
        }

        string jsonString;
        string filePath;
        public void LoadData()
        {
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Questions.json");
            if (File.Exists(filePath))
            {
                jsonString = File.ReadAllText(filePath);
            }
            else
            {
                TitleLable.Text = "Error, Questions file not found";
            }
        }

        bool isEditing = false;
        int questionNumber;
        public void EditLoadQuestion(int _questionNumber, string SQuestionTextBox, string SAnswerTextBox_A, string SAnswerTextBox_B, string SAnswerTextBox_C, string SAnswerTextBox_D, string SCorrectAnswer)
        {
            DeleteButton.Show();
            ClearTextBoxes();
            questionNumber = _questionNumber;
            TitleLable.Text = "" + SCorrectAnswer;
            QuestionTextBox.Text = SQuestionTextBox;
            AnswerTextBox_A.Text = SAnswerTextBox_A;
            AnswerTextBox_B.Text = SAnswerTextBox_B;
            AnswerTextBox_C.Text = SAnswerTextBox_C;
            AnswerTextBox_D.Text = SAnswerTextBox_D;
            if(SCorrectAnswer == "A")
            {
                checkBoxA.Checked = true;
            }else if (SCorrectAnswer == "B")
            {
                checkBoxB.Checked = true;
            }else if (SCorrectAnswer == "C")
            {
                checkBoxC.Checked = true;
            }else if (SCorrectAnswer == "D")
            {
                checkBoxD.Checked = true;
            }
            isEditing = true;   
        }

        private void SaveQuestion()
        {
            if (!isEditing)
            {
                var Questionslist = JsonSerializer.Deserialize<QuizData>(jsonString) ?? new QuizData { Questions = new List<QuestionData>() };

                var newQuestion = new QuestionData
                {
                    Question = QuestionTextBox.Text,
                    AnswerA = AnswerTextBox_A.Text,
                    AnswerB = AnswerTextBox_B.Text,
                    AnswerC = AnswerTextBox_C.Text,
                    AnswerD = AnswerTextBox_D.Text,
                    CorrectAnswer = CorrectAnswer
                };

                Questionslist.Questions.Add(newQuestion);

                jsonString = JsonSerializer.Serialize(Questionslist, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);
                questionsPanel.LoadData();
                ClearTextBoxes();
                this.Hide();
                DeleteButton.Hide();
            }
            else
            {
                var Questionslist = JsonSerializer.Deserialize<QuizData>(jsonString);
                Questionslist.Questions[questionNumber].Question = QuestionTextBox.Text;
                Questionslist.Questions[questionNumber].AnswerA = AnswerTextBox_A.Text;
                Questionslist.Questions[questionNumber].AnswerB = AnswerTextBox_B.Text;
                Questionslist.Questions[questionNumber].AnswerC = AnswerTextBox_C.Text;
                Questionslist.Questions[questionNumber].AnswerD = AnswerTextBox_D.Text;
                Questionslist.Questions[questionNumber].CorrectAnswer = CorrectAnswer;
                jsonString = JsonSerializer.Serialize(Questionslist, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);
                isEditing = false;
                questionsPanel.LoadData();
                ClearTextBoxes();
                this.Hide();
                DeleteButton.Hide();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            questionsPanel.LoadData();
            ClearTextBoxes();
            this.Hide();
            DeleteButton.Hide();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var Questionslist = JsonSerializer.Deserialize<QuizData>(jsonString);
            Questionslist.Questions.RemoveAt(questionNumber);
            jsonString = JsonSerializer.Serialize(Questionslist, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);
            questionsPanel.LoadData();
            ClearTextBoxes();
            this.Hide();
            DeleteButton.Hide();
        }
    }
}
