using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizFormApp
{
    public partial class Quiz : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex;
        private int score;

        public Quiz()
        {
            InitializeComponent();
            InitializeQuiz();
        }

        Bitmap btn_active = new Bitmap(@"E:\develop\C#\Projects\QuizFormApp\Resources\btn_active.png");
        Bitmap btn_disabled = new Bitmap(@"E:\develop\C#\Projects\QuizFormApp\Resources\btn_disabled.png");

        private void InitializeQuiz()
        {
            questions = new List<Question>
            {
                new Question("Hva er hovedstaden i Frankrike?", "Paris"),
                new Question("Hva er verdens største hav?", "Stillehavet"),
                new Question("Hva er hovedstaden i Italia?", "Roma"),
                new Question("Hva er hovedstaden i Tyskland?", "Berlin"),
                new Question("Hva er verdens høyeste fjell?", "Everest"),
                new Question("Hvilket årstall startet andre verdenskrig?", "1939"),
                new Question("Hva er Jordens største kontinent?", "Asia"),
                new Question("Hva er hovedstaden i Spania?", "Madrid"),
                new Question("Hva heter hovedstaden i Norge?", "Oslo"),
                new Question("Hvilken norsk by er kjent for sin brygge og fjorder?", "Bergen")
            };
            currentQuestionIndex = 0;
            score = 0;
            StartQuiz();
        }

        private void StartQuiz()
        {
            lbl_Question.Text = "Velkommen til quizen!";
            lbl_Answer.Visible = false;
            lbl_Mark.Text = "";
            tbox_Answer.Visible = false;
            btn_Check.Visible = false;
            //btn_next.Visible = true;
            //btn_next.BackgroundImage = btn_active;
            btn_Next.Text = "Start";
        }
        private void ShowQuestion()
        {
            if(currentQuestionIndex == 1)
            {
                lbl_Current_Question.Visible = true;
                tbox_Answer.Visible = true;
                btn_Check.Visible = true;
                //btn_check.BackgroundImage = btn_active;
                //btn_exit.Visible = false;
                //lbl_answer.Visible = false;
                btn_Next.Text = "Neste";
                btn_Next.BackgroundImage = btn_disabled;
            }
            
                
                lbl_Current_Question.Text = $"Spørsmål {currentQuestionIndex} av {questions.Count}";
                lbl_Question.Text = questions[currentQuestionIndex - 1].Text;
                tbox_Answer.Enabled = true;
                tbox_Answer.Text = string.Empty;
                
                lbl_Mark.Text = "";
                lbl_Answer.Visible = false;
                btn_Check.Enabled = true;
                btn_Check.BackgroundImage= btn_active;
                btn_Next.Enabled = false;
                btn_Next.BackgroundImage= btn_disabled;
                btn_Exit.Visible = false;
            

        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex < questions.Count)
            {
                currentQuestionIndex++;
                ShowQuestion();
            }

            else
            {
                //MessageBox.Show($"Quiz avsluttet! \nDitt resultat: {score} av {questions.Count}");
                btn_Next.Visible = false;
                btn_Exit.Visible = true;
                tbox_Answer.Visible = false;
                lbl_Answer.Visible = false;
                lbl_Mark.Visible = false;
                btn_Check.Visible = false;
                lbl_Question.Visible = false;
                lbl_Current_Question.Text = "Quiz avsluttet!";
                lbl_Result.Visible = true;
                lbl_Result.Text = $"Ditt resultat:\n{score} av {questions.Count}";
                pbox_Result.Visible = true;
            }
        }
        private void tb_answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                CheckAnswer();
            }
        }
        private void btn_check_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }
        private void CheckAnswer()
        {
            btn_Check.Enabled = false;
            btn_Check.BackgroundImage = btn_disabled;
            tbox_Answer.Enabled = false;

            if (tbox_Answer.Text.ToLower() == questions[currentQuestionIndex - 1].Answer.ToLower())
            {
                
                lbl_Mark.Text = $"K {score}";
                lbl_Mark.ForeColor = Color.PaleGoldenrod;
                score ++;
            }
            else
            {
                lbl_Mark.ForeColor = Color.Red;
                lbl_Mark.Text = $"F {score}";
                lbl_Answer.Visible = true;
                lbl_Answer.Text = "Riktig svar er: " + questions[currentQuestionIndex - 1].Answer;
            }
            btn_Next.Enabled = true;
            btn_Next.BackgroundImage = btn_active;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class Question
    {
        public string Text { get; }
        public string Answer { get; }

        public Question(string text, string answer)
        {
            Text = text;
            Answer = answer;
        }
    }
}
