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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_question = new System.Windows.Forms.Label();
            this.tbox_answer = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.lbl_mark = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.picBox_result = new System.Windows.Forms.PictureBox();
            this.lbl_current_question = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_result)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_next.BackgroundImage")));
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_next.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_next.Location = new System.Drawing.Point(290, 452);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(120, 40);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = "Neste";
            this.btn_next.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_question
            // 
            this.lbl_question.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_question.AutoEllipsis = true;
            this.lbl_question.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lbl_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_question.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_question.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_question.Location = new System.Drawing.Point(185, 110);
            this.lbl_question.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_question.Size = new System.Drawing.Size(330, 75);
            this.lbl_question.TabIndex = 1;
            this.lbl_question.Text = "Spørsmål her";
            this.lbl_question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbox_answer
            // 
            this.tbox_answer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbox_answer.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbox_answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbox_answer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbox_answer.Location = new System.Drawing.Point(185, 247);
            this.tbox_answer.Margin = new System.Windows.Forms.Padding(10);
            this.tbox_answer.MinimumSize = new System.Drawing.Size(200, 35);
            this.tbox_answer.Name = "tbox_answer";
            this.tbox_answer.Size = new System.Drawing.Size(200, 35);
            this.tbox_answer.TabIndex = 3;
            this.tbox_answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_answer.WordWrap = false;
            this.tbox_answer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_answer_KeyPress);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_exit.Location = new System.Drawing.Point(290, 497);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(120, 40);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_answer
            // 
            this.lbl_answer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_answer.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lbl_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_answer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_answer.Location = new System.Drawing.Point(185, 358);
            this.lbl_answer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_answer.Size = new System.Drawing.Size(330, 40);
            this.lbl_answer.TabIndex = 5;
            this.lbl_answer.Text = "Svar her";
            this.lbl_answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_check
            // 
            this.btn_check.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_check.BackColor = System.Drawing.Color.Transparent;
            this.btn_check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_check.BackgroundImage")));
            this.btn_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_check.FlatAppearance.BorderSize = 0;
            this.btn_check.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_check.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_check.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_check.Location = new System.Drawing.Point(395, 247);
            this.btn_check.Margin = new System.Windows.Forms.Padding(0);
            this.btn_check.Name = "btn_check";
            this.btn_check.Padding = new System.Windows.Forms.Padding(3);
            this.btn_check.Size = new System.Drawing.Size(120, 40);
            this.btn_check.TabIndex = 6;
            this.btn_check.Text = "Sjekk svar";
            this.btn_check.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // lbl_mark
            // 
            this.lbl_mark.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_mark.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_mark.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_mark.Location = new System.Drawing.Point(291, 326);
            this.lbl_mark.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lbl_mark.Name = "lbl_mark";
            this.lbl_mark.Padding = new System.Windows.Forms.Padding(2);
            this.lbl_mark.Size = new System.Drawing.Size(118, 30);
            this.lbl_mark.TabIndex = 7;
            this.lbl_mark.Text = "Mark her";
            this.lbl_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_mark.ForeColorChanged += new System.EventHandler(this.btn_check_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_result.BackColor = System.Drawing.Color.Transparent;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_result.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lbl_result.Image = global::QuizFormApp.Properties.Resources.result;
            this.lbl_result.Location = new System.Drawing.Point(247, 235);
            this.lbl_result.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_result.Size = new System.Drawing.Size(203, 66);
            this.lbl_result.TabIndex = 8;
            this.lbl_result.Text = "Resultat her";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_result.Visible = false;
            // 
            // picBox_result
            // 
            this.picBox_result.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picBox_result.BackColor = System.Drawing.Color.Transparent;
            this.picBox_result.BackgroundImage = global::QuizFormApp.Properties.Resources.result;
            this.picBox_result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBox_result.Location = new System.Drawing.Point(185, 200);
            this.picBox_result.Name = "picBox_result";
            this.picBox_result.Size = new System.Drawing.Size(330, 137);
            this.picBox_result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_result.TabIndex = 9;
            this.picBox_result.TabStop = false;
            this.picBox_result.Visible = false;
            // 
            // lbl_current_question
            // 
            this.lbl_current_question.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_current_question.BackColor = System.Drawing.Color.Transparent;
            this.lbl_current_question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_current_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_current_question.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lbl_current_question.Location = new System.Drawing.Point(185, 12);
            this.lbl_current_question.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_current_question.MaximumSize = new System.Drawing.Size(400, 40);
            this.lbl_current_question.Name = "lbl_current_question";
            this.lbl_current_question.Size = new System.Drawing.Size(330, 40);
            this.lbl_current_question.TabIndex = 10;
            this.lbl_current_question.Text = "№ spm";
            this.lbl_current_question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_current_question.Visible = false;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = global::QuizFormApp.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(701, 600);
            this.Controls.Add(this.lbl_mark);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.tbox_answer);
            this.Controls.Add(this.lbl_current_question);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.picBox_result);
            this.Controls.Add(this.lbl_answer);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_question);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Quiz";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.TransparencyKey = System.Drawing.Color.PowderBlue;
            this.Load += new System.EventHandler(this.Quiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_answer;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.TextBox tbox_answer;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_mark;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.PictureBox picBox_result;
        private System.Windows.Forms.Label lbl_current_question;
    }
}

