using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Quiz_App
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
            LoadData();

            EndPanel _endpanel = new EndPanel(this);
            endpanel = _endpanel;

            MenuPanel _menuPanel = new MenuPanel(this);
            menuPanel = _menuPanel;
            menuPanel.Show();
            this.Controls.Add(menuPanel);
            menuPanel.Dock = DockStyle.Fill;
            menuPanel.BringToFront();
        }

        public EndPanel endpanel;
        public MenuPanel menuPanel;

        DataTable QuestionsList = new DataTable();
        public List <int> NotAnsweredQuestion = new List<int>();
        public int AnsweredCorrectly = 0;
        string CorrectAnswer;
        int randomIndex;
        int chosenIndexes;
        public int Answered = 0;

        string jsonString;

        bool CanAnswer = true;

        public void LoadData()
        {
            if (File.Exists("Questions.json"))
            {
                jsonString = File.ReadAllText("Questions.json");
                var QuizData = JsonSerializer.Deserialize<QuizData>(jsonString);
                
                int i = 0;
                while(i < QuizData.Questions.Count)
                {
                    NotAnsweredQuestion.Add(i);
                    i++;
                }

                if (i > 0)
                {
                    ShowData(jsonString);
                }
                else
                {
                    NoQuestionsError();
                }
            }
            else
            {
                questionLabel.Text = "Error, Questions file not found";
            }
        }

        private async void NoQuestionsError()
        {
            TitleLable.Hide();
            Button_A.Hide();
            Button_B.Hide();
            Button_C.Hide();
            Button_D.Hide();
            questionLabel.Text = "add more questions";
            await Task.Delay(2000);
            menuPanel.Show();
            TitleLable.Show();
            Button_A.Show();
            Button_B.Show();
            Button_C.Show();
            Button_D.Show();
        }

        private void ShowData(string jsonString)
        {
            var QuizData = JsonSerializer.Deserialize<QuizData>(jsonString);

            if(Answered < QuizData.Questions.Count)
            {
                Random random = new Random();
                randomIndex = random.Next(NotAnsweredQuestion.Count);
                chosenIndexes = NotAnsweredQuestion[randomIndex];

                var ThisQuestion = QuizData.Questions[chosenIndexes];

                if (NotAnsweredQuestion.Contains(chosenIndexes))
                {
                    TitleLable.Text = $"Question {Answered}";
                    questionLabel.Text = $"{ThisQuestion.Question}";
                    Button_A.Text = $"{ThisQuestion.AnswerA}";
                    Button_B.Text = $"{ThisQuestion.AnswerB}";
                    Button_C.Text = $"{ThisQuestion.AnswerC}";
                    Button_D.Text = $"{ThisQuestion.AnswerD}";

                    CorrectAnswer = ThisQuestion.CorrectAnswer;
                }
                else
                {
                    questionLabel.Text = "Error, repeted Question";
                }

            }
            else
            {
                endpanel.Show();
                this.Controls.Add(endpanel);
                endpanel.Dock = DockStyle.Fill;
                endpanel.BringToFront();
                endpanel.LoadPanel();


            }
        }

        private void Button_A_Click(object sender, EventArgs e)
        {
            if (CanAnswer)
            {
                if (CorrectAnswer == "A")
                {
                    AfterCorrectClicked();
                }
                else
                {
                    AfterWrongClicked();
                }
            }
        }

        private void Button_B_Click(object sender, EventArgs e)
        {
            if (CanAnswer)
            {
                if (CorrectAnswer == "B")
                {
                    AfterCorrectClicked();
                }
                else
                {
                    AfterWrongClicked();
                }
            }
        }

        private void Button_C_Click(object sender, EventArgs e)
        {
            if (CanAnswer)
            {
                if (CorrectAnswer == "C")
                {
                    AfterCorrectClicked();
                }
                else
                {
                    AfterWrongClicked();
                }
            }
        }

        private void Button_D_Click(object sender, EventArgs e)
        {
            if (CanAnswer)
            {
                if (CorrectAnswer == "D")
                {
                    AfterCorrectClicked();
                }
                else
                {
                    AfterWrongClicked();
                }
            }
        }

        private void TitleLable_Click(object sender, EventArgs e)
        {

        }

        private async void AfterCorrectClicked()
        {
            CanAnswer = false;
            AnsweredCorrectly++;
            NotAnsweredQuestion.Remove(chosenIndexes);
            Answered++;
            await Task.Delay(1000);
            ShowData(jsonString);
            CanAnswer = true;
        }

        private async void AfterWrongClicked()
        {
            CanAnswer = false;
            NotAnsweredQuestion.Remove(chosenIndexes);
            Answered++;
            await Task.Delay(1000);
            ShowData(jsonString);
            CanAnswer = true;
        }

        public void MenuButtonLoad()
        {
            endpanel.Hide();
            AnsweredCorrectly = 0;
            Answered = 0;
            NotAnsweredQuestion.Clear();
            menuPanel.Show();
        }

    }
}