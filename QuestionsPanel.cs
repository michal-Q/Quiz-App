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
using System.Threading;
using System.Runtime.CompilerServices;

namespace Quiz_App
{
    public partial class QuestionsPanel : UserControl
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
        public QuestionsPanel(MenuPanel _menuPanel)
        {
            InitializeComponent();
            menuPanel = _menuPanel;
            LoadData();
            AddQuestionPanel _addquestionPanel = new AddQuestionPanel(this);
            addquestionPanel = _addquestionPanel;
        }

        private MenuPanel menuPanel;
        private AddQuestionPanel addquestionPanel;

        private List<Button> buttonsList = new List<Button>();
        public void LoadData()
        {
            foreach (Button button in buttonsList)
            {
                backpanel.Controls.Remove(button);
            }
            buttonsList.Clear();

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Questions.json");
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                var Questionslist = JsonSerializer.Deserialize<QuizData>(jsonString);

                int x = 18;
                int y = 10;
                int margin = 15;
                int questionNumber = -1;

                foreach (var Question in Questionslist.Questions)
                {
                    questionNumber++;
                    int localquestionNumber = questionNumber;
                    Button QuestionButton = new Button();
                    QuestionButton.Size = new Size(400, 40);
                    QuestionButton.Location = new Point(x, y);
                    QuestionButton.Font = new Font(QuestionButton.Font.Name, 12, FontStyle.Bold);
                    QuestionButton.Text = Question.Question;
                    QuestionButton.TextAlign = ContentAlignment.MiddleCenter;
                    QuestionButton.BackColor = Color.Silver;
                    QuestionButton.FlatStyle = FlatStyle.Popup;
                    QuestionButton.Click += (sender, e) => QuestionButton_Click(sender, e, Question, localquestionNumber);
                    backpanel.Controls.Add(QuestionButton);
                    y += QuestionButton.Height + margin;
                    buttonsList.Add(QuestionButton);
                }
            }
            else
            {
                ErrorLabel.Text = "Error Loading Data";
            }
        }

        private void QuestionButton_Click(object sender, EventArgs e, QuestionData question, int questionNumber)
        {
            addquestionPanel.Show();
            this.Controls.Add(addquestionPanel);
            addquestionPanel.Dock = DockStyle.Fill;
            addquestionPanel.BringToFront();
            addquestionPanel.ClearTextBoxes();
            addquestionPanel.EditLoadQuestion(questionNumber, question.Question, question.AnswerA, question.AnswerB, question.AnswerC, question.AnswerD, question.CorrectAnswer);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            addquestionPanel.Show();
            this.Controls.Add(addquestionPanel);
            addquestionPanel.Dock = DockStyle.Fill;
            addquestionPanel.BringToFront();
            addquestionPanel.ClearTextBoxes();
        }

        public void DeleteQuestion()
        {

        }
    }
}
