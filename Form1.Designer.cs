namespace QuizFormApp
{
    partial class Quiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_question = new System.Windows.Forms.Label();
            this.tb_answer = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.lbl_mark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_next.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_next.Location = new System.Drawing.Point(333, 480);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(120, 40);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = "Neste";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_question
            // 
            this.lbl_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_question.Location = new System.Drawing.Point(92, 56);
            this.lbl_question.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_question.Size = new System.Drawing.Size(600, 150);
            this.lbl_question.TabIndex = 1;
            this.lbl_question.Text = "Spørsmål her";
            this.lbl_question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_answer
            // 
            this.tb_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_answer.Location = new System.Drawing.Point(276, 245);
            this.tb_answer.Margin = new System.Windows.Forms.Padding(6);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.Size = new System.Drawing.Size(233, 35);
            this.tb_answer.TabIndex = 3;
            this.tb_answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_answer.WordWrap = false;
            this.tb_answer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_answer_KeyPress);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Location = new System.Drawing.Point(333, 480);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(120, 40);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Avslutte";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_answer
            // 
            this.lbl_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_answer.Location = new System.Drawing.Point(92, 363);
            this.lbl_answer.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_answer.Size = new System.Drawing.Size(600, 50);
            this.lbl_answer.TabIndex = 5;
            this.lbl_answer.Text = "Svar";
            this.lbl_answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_check.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_check.Location = new System.Drawing.Point(539, 244);
            this.btn_check.Name = "btn_check";
            this.btn_check.Padding = new System.Windows.Forms.Padding(2);
            this.btn_check.Size = new System.Drawing.Size(120, 35);
            this.btn_check.TabIndex = 6;
            this.btn_check.Text = "Sjekk svar";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // lbl_mark
            // 
            this.lbl_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_mark.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_mark.Location = new System.Drawing.Point(242, 305);
            this.lbl_mark.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_mark.Name = "lbl_mark";
            this.lbl_mark.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_mark.Size = new System.Drawing.Size(300, 50);
            this.lbl_mark.TabIndex = 7;
            this.lbl_mark.Text = "Korrekt!";
            this.lbl_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_mark.ForeColorChanged += new System.EventHandler(this.btn_check_Click);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbl_mark);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.lbl_answer);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.tb_answer);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.btn_next);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Quiz";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Quiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_answer;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.TextBox tb_answer;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_mark;
    }
}

