using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_App
{
    public partial class MenuPanel : UserControl
    {
        public MenuPanel(Form1 _form1)
        {
            InitializeComponent();
            form1 = _form1;

            QuestionsPanel _questionsPanel = new QuestionsPanel(this);
            questionsPanel = _questionsPanel;
        }

        private Form1 form1;
        private QuestionsPanel questionsPanel;

        private void StartButton_Click(object sender, EventArgs e)
        {
            form1.NotAnsweredQuestion.Clear();
            form1.menuPanel.Hide();
            form1.LoadData();
        }
        
        private void QuestionsButton_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(questionsPanel))
            {
                questionsPanel.Show();
                this.Controls.Add(questionsPanel);
                questionsPanel.Dock = DockStyle.Fill;
                questionsPanel.BringToFront();
                questionsPanel.LoadData();
            }
            else
            {
                questionsPanel.LoadData();
                questionsPanel.Show();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
