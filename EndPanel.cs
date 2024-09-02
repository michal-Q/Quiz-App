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
    public partial class EndPanel : UserControl
    {
        public EndPanel(Form1 _form1)
        {
            InitializeComponent();
            form1 = _form1;
        }

        private Form1 form1;

        public void LoadPanel()
        {
            EndLabel.Text = $"Correct Answers {form1.AnsweredCorrectly}/{form1.Answered}";
        }

        private void TryAgainButton_Click(object sender, EventArgs e)
        {

            form1.endpanel.Hide();
            form1.AnsweredCorrectly = 0;
            form1.Answered = 0;
            form1.NotAnsweredQuestion.Clear();
            form1.LoadData();
        }
        
        private void MenuButton_Click(object sender, EventArgs e)
        {
            form1.AnsweredCorrectly = 0;
            form1.Answered = 0;
            form1.NotAnsweredQuestion.Clear();
            form1.MenuButtonLoad();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
