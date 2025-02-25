﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizFormApp
{
    public partial class Quiz : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private int score = 0;
        private bool flag = true;

        Bitmap btn_disabled = Properties.Resources.btn_disabled;
        Bitmap btn_active = Properties.Resources.btn_active;

        //AS VARIANT, part1
        //declare a variable, but not initialize it
        //Bitmap btn_disabled;

        public Quiz()
        {
            InitializeComponent();
            InitializeQuiz();

            //AS VARIANT, part2
            // now initialize btn_disabled (Copy to output directory property(in Solution Explorer) of image must be copy always or copy if newer)
        //    string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "btn_disabled.png");
        //    if (File.Exists(imagePath))  // checking if the file exists
        //    {
        //        btn_disabled = new Bitmap(imagePath);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Файл btn_disabled.png не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        btn_disabled = btn_active;  // substitute a spare image
        //    }
        }

        public class Question
        {
            public string Text { get; set; }
            public string Answer { get; set; }

            public Question(string text, string answer)
            {
                Text = text;
                Answer = answer;
            }
        }

        private void InitializeQuiz()
        {
            //create list of questions
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
            LoadQuiz();
        }

        //Show welcome screen start/exit buttons
        private void LoadQuiz()
        {
            lbl_Current_Question.Text = "";
            lbl_Question.Text = "Velkommen til quizen!";
            lbl_Answer.Visible = false;
            lbl_Mark.Text = "";
            tbox_Answer.Visible = false;
            btn_Check.Visible = false;
            btn_Next.Text = "Start";
        }
        private void lbl_Current_Question_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X-lbl_Current_Question.Width/2;
                Top += e.Y-lbl_Current_Question.Height/2;
            }
        }

        //Show questions
        private void ShowQuestion()
        {
            if(currentQuestionIndex == 1) //enable necessary elements
            {
                tbox_Answer.Visible = true;
                
                btn_Check.Visible = true;
                btn_Next.Text = "Neste";
                btn_Next.BackgroundImage = btn_disabled;
            }
                            
                lbl_Current_Question.Text = $"Spørsmål {currentQuestionIndex} av {questions.Count}";
                lbl_Question.Text = questions[currentQuestionIndex - 1].Text;
                lbl_Mark.Text = "";
                lbl_Answer.Visible = false;

                tbox_Answer.Enabled = true;
                tbox_Answer.Text = "";

                btn_Check.Enabled = true;
                btn_Check.BackgroundImage= btn_active;
                btn_Next.Enabled = false;
                btn_Next.BackgroundImage= btn_disabled;
                btn_Exit.Visible = false;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex < questions.Count)
            {
                currentQuestionIndex++;
                ShowQuestion();
            }

            else //Show result and exit button
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

        //case: key Enter used
        private void tb_answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                CheckAnswer();
            }
        }


        //case: button Check used
        private void btn_check_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }

        //check the user's answer (increment score if right) and show mark
        private void CheckAnswer()
        {
            btn_Check.Enabled = false;
            btn_Check.BackgroundImage = btn_disabled;
            tbox_Answer.Enabled = false;

            if (tbox_Answer.Text.ToLower().Trim() == questions[currentQuestionIndex - 1].Answer.ToLower().Trim())
            {
                
                score++;
                if (flag == false) {score--; flag = true; } //to neutralize double CheckAnswer after previously fail answer

                lbl_Mark.Text = "Korrekt!";
                lbl_Mark.ForeColor = Color.PaleGoldenrod;
                
            }
            else
            {
                flag = false;
                lbl_Mark.ForeColor = Color.Red;
                lbl_Mark.Text = "Feil!";
                lbl_Answer.Visible = true;
                lbl_Answer.Text = "Riktig svar er: " + questions[currentQuestionIndex - 1].Answer;
            }
            btn_Next.Enabled = true;
            btn_Next.BackgroundImage = btn_active;
        }

        //exit quiz
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
