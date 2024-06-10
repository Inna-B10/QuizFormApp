﻿using System;
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
            lbl_question.Text = "Velkommen til quizen!";
            lbl_answer.Visible = false;
            lbl_mark.Text = "";
            tbox_answer.Visible = false;
            btn_check.Visible = false;
            btn_next.Visible = true;
            btn_next.Text = "Start";
        }
        private void ShowQuestion()
        {
            if(currentQuestionIndex == 1)
            {
                tbox_answer.Visible = true;
                btn_check.Visible = true;
                btn_exit.Visible = false;
                lbl_answer.Visible = false;
                btn_next.Text = "Neste";
            }
            if (currentQuestionIndex <= questions.Count)
            {
                lbl_question.Text = questions[currentQuestionIndex - 1].Text;
                tbox_answer.Enabled = true;
                tbox_answer.Text = string.Empty;
                lbl_current_question.Visible = true;
                lbl_current_question.Text = $"Spørsmål { currentQuestionIndex} av {questions.Count}";
                lbl_mark.Text = "";
                lbl_answer.Visible = false;
                btn_check.Enabled = true;
                btn_next.Enabled = false;
                btn_exit.Visible = false;
            }
            else
            {
                //MessageBox.Show($"Quiz avsluttet! \nDitt resultat: {score} av {questions.Count}");
                btn_next.Visible = false;
                btn_exit.Visible = true;
                tbox_answer.Visible = false;
                lbl_answer.Visible = false;
                lbl_mark.Visible = false;
                btn_check.Visible = false;
                lbl_question.Visible = false;
                lbl_current_question.Text = "Quiz avsluttet!";
                lbl_result.Visible = true;
                lbl_result.Text = $"Ditt resultat:\n{score} av {questions.Count}";
                picBox_result.Visible = true;
                //lbl_question.Text = $"Quiz avsluttet! \nDitt resultat: {score} av {questions.Count}";

            }
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            ShowQuestion();
        }
        private void tb_answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btn_check.Enabled = false;
                btn_check.BackgroundImage = Properties.Resources.btn_disabled;
                //btn_check.ForeColor = Color.CadetBlue;
                tbox_answer.Enabled = false;
                CheckAnswer();
            }
        }
        private void btn_check_Click(object sender, EventArgs e)
        {
            btn_check.Enabled = false;
            //btn_check.ForeColor = Color.CadetBlue;
            tbox_answer.Enabled = false;
            CheckAnswer();
        }
        private void CheckAnswer()
        {

            if (tbox_answer.Text.ToLower() == questions[currentQuestionIndex - 1].Answer.ToLower())
            {
                score++;
                lbl_mark.Text = "Korrekt!";
                lbl_mark.ForeColor = Color.PaleGoldenrod;
            }
            else
            {
                lbl_mark.ForeColor = Color.Red;
                lbl_mark.Text = "Feil!";
                lbl_answer.Visible = true;
                lbl_answer.Text = "Riktig svar er: " + questions[currentQuestionIndex - 1].Answer;
            }
            btn_next.Enabled = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    if (backgroundImage != null)
        //    {
        //        e.Graphics.DrawImage(backgroundImage, this.ClientRectangle);
        //    }
        //}
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
