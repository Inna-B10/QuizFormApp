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
            this.btn_Next = new System.Windows.Forms.Button();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.tbox_Answer = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.btn_Check = new System.Windows.Forms.Button();
            this.lbl_Mark = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.pbox_Result = new System.Windows.Forms.PictureBox();
            this.lbl_Current_Question = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Next
            // 
            this.btn_Next.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Next.BackColor = System.Drawing.Color.Transparent;
            this.btn_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Next.BackgroundImage")));
            this.btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Next.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Next.FlatAppearance.BorderSize = 0;
            this.btn_Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Next.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Next.Location = new System.Drawing.Point(290, 452);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(120, 40);
            this.btn_Next.TabIndex = 0;
            this.btn_Next.Text = "Neste";
            this.btn_Next.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_Question
            // 
            this.lbl_Question.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Question.AutoEllipsis = true;
            this.lbl_Question.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lbl_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Question.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_Question.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Question.Location = new System.Drawing.Point(185, 110);
            this.lbl_Question.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_Question.Size = new System.Drawing.Size(330, 75);
            this.lbl_Question.TabIndex = 1;
            this.lbl_Question.Text = "Spørsmål her";
            this.lbl_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbox_Answer
            // 
            this.tbox_Answer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbox_Answer.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbox_Answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbox_Answer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbox_Answer.Location = new System.Drawing.Point(185, 247);
            this.tbox_Answer.Margin = new System.Windows.Forms.Padding(10);
            this.tbox_Answer.MinimumSize = new System.Drawing.Size(200, 35);
            this.tbox_Answer.Name = "tbox_Answer";
            this.tbox_Answer.Size = new System.Drawing.Size(200, 35);
            this.tbox_Answer.TabIndex = 3;
            this.tbox_Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_Answer.WordWrap = false;
            this.tbox_Answer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_answer_KeyPress);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Exit.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Exit.Location = new System.Drawing.Point(290, 497);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(120, 40);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Answer.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lbl_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Answer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_Answer.Location = new System.Drawing.Point(185, 358);
            this.lbl_Answer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_Answer.Size = new System.Drawing.Size(330, 40);
            this.lbl_Answer.TabIndex = 5;
            this.lbl_Answer.Text = "Svar her";
            this.lbl_Answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Check
            // 
            this.btn_Check.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Check.BackColor = System.Drawing.Color.Transparent;
            this.btn_Check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Check.BackgroundImage")));
            this.btn_Check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Check.FlatAppearance.BorderSize = 0;
            this.btn_Check.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Check.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Check.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Check.Location = new System.Drawing.Point(395, 247);
            this.btn_Check.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Padding = new System.Windows.Forms.Padding(3);
            this.btn_Check.Size = new System.Drawing.Size(120, 40);
            this.btn_Check.TabIndex = 6;
            this.btn_Check.Text = "Sjekk svar";
            this.btn_Check.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // lbl_Mark
            // 
            this.lbl_Mark.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Mark.AutoSize = true;
            this.lbl_Mark.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Mark.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Mark.Location = new System.Drawing.Point(291, 326);
            this.lbl_Mark.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lbl_Mark.Name = "lbl_Mark";
            this.lbl_Mark.Padding = new System.Windows.Forms.Padding(2);
            this.lbl_Mark.Size = new System.Drawing.Size(109, 30);
            this.lbl_Mark.TabIndex = 7;
            this.lbl_Mark.Text = "Mark her";
            this.lbl_Mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Mark.ForeColorChanged += new System.EventHandler(this.btn_check_Click);
            // 
            // lbl_Result
            // 
            this.lbl_Result.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Result.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Result.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lbl_Result.Image = global::QuizFormApp.Properties.Resources.result;
            this.lbl_Result.Location = new System.Drawing.Point(247, 235);
            this.lbl_Result.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_Result.Size = new System.Drawing.Size(203, 66);
            this.lbl_Result.TabIndex = 8;
            this.lbl_Result.Text = "Resultat her";
            this.lbl_Result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Result.Visible = false;
            // 
            // pbox_Result
            // 
            this.pbox_Result.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbox_Result.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Result.BackgroundImage = global::QuizFormApp.Properties.Resources.result;
            this.pbox_Result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbox_Result.Location = new System.Drawing.Point(185, 200);
            this.pbox_Result.Name = "pbox_Result";
            this.pbox_Result.Size = new System.Drawing.Size(330, 137);
            this.pbox_Result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbox_Result.TabIndex = 9;
            this.pbox_Result.TabStop = false;
            this.pbox_Result.Visible = false;
            // 
            // lbl_Current_Question
            // 
            this.lbl_Current_Question.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Current_Question.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Current_Question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Current_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Current_Question.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lbl_Current_Question.Location = new System.Drawing.Point(185, 12);
            this.lbl_Current_Question.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Current_Question.MaximumSize = new System.Drawing.Size(400, 40);
            this.lbl_Current_Question.Name = "lbl_Current_Question";
            this.lbl_Current_Question.Size = new System.Drawing.Size(330, 40);
            this.lbl_Current_Question.TabIndex = 10;
            this.lbl_Current_Question.Text = "№ spm";
            this.lbl_Current_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Current_Question.Visible = false;
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
            this.Controls.Add(this.lbl_Mark);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.tbox_Answer);
            this.Controls.Add(this.lbl_Current_Question);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.pbox_Result);
            this.Controls.Add(this.lbl_Answer);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.lbl_Question);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Answer;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.TextBox tbox_Answer;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Mark;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.PictureBox pbox_Result;
        private System.Windows.Forms.Label lbl_Current_Question;
    }
}

