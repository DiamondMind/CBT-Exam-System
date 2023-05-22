
namespace CBT_Examination_System.Student_UC
{
    partial class ExamPage_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamPage_UC));
            this.label1 = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.elipseExamPage = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.comboSelectAnswer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.questionDetails = new System.Windows.Forms.Label();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.labelCourse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTxtGotoQuestion = new System.Windows.Forms.MaskedTextBox();
            this.btnGoToQuestion = new Guna.UI2.WinForms.Guna2Button();
            this.examTimer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "Examination Page";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.Red;
            this.questionLabel.Location = new System.Drawing.Point(806, 298);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(83, 44);
            this.questionLabel.TabIndex = 28;
            this.questionLabel.Text = "999";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(788, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "Question No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Question:";
            // 
            // elipseExamPage
            // 
            this.elipseExamPage.TargetControl = this;
            // 
            // comboSelectAnswer
            // 
            this.comboSelectAnswer.BackColor = System.Drawing.Color.Transparent;
            this.comboSelectAnswer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSelectAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSelectAnswer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSelectAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSelectAnswer.FocusedState.Parent = this.comboSelectAnswer;
            this.comboSelectAnswer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboSelectAnswer.ForeColor = System.Drawing.Color.Black;
            this.comboSelectAnswer.HoverState.Parent = this.comboSelectAnswer;
            this.comboSelectAnswer.ItemHeight = 30;
            this.comboSelectAnswer.Items.AddRange(new object[] {
            "None",
            "Option A",
            "Option B",
            "Option C",
            "Option D"});
            this.comboSelectAnswer.ItemsAppearance.Parent = this.comboSelectAnswer;
            this.comboSelectAnswer.Location = new System.Drawing.Point(766, 415);
            this.comboSelectAnswer.Name = "comboSelectAnswer";
            this.comboSelectAnswer.ShadowDecoration.Parent = this.comboSelectAnswer;
            this.comboSelectAnswer.Size = new System.Drawing.Size(180, 36);
            this.comboSelectAnswer.StartIndex = 0;
            this.comboSelectAnswer.TabIndex = 43;
            this.comboSelectAnswer.SelectedIndexChanged += new System.EventHandler(this.comboSelectAnswer_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(809, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 25);
            this.label10.TabIndex = 42;
            this.label10.Text = "Answer:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.questionDetails);
            this.guna2Panel1.Location = new System.Drawing.Point(44, 188);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(636, 451);
            this.guna2Panel1.TabIndex = 44;
            // 
            // questionDetails
            // 
            this.questionDetails.AutoSize = true;
            this.questionDetails.BackColor = System.Drawing.Color.Transparent;
            this.questionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionDetails.ForeColor = System.Drawing.Color.White;
            this.questionDetails.Location = new System.Drawing.Point(12, 15);
            this.questionDetails.Name = "questionDetails";
            this.questionDetails.Size = new System.Drawing.Size(612, 375);
            this.questionDetails.TabIndex = 31;
            this.questionDetails.Text = resources.GetString("questionDetails.Text");
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BorderRadius = 15;
            this.btnSubmit.BorderThickness = 1;
            this.btnSubmit.CheckedState.Parent = this.btnSubmit;
            this.btnSubmit.CustomImages.Parent = this.btnSubmit;
            this.btnSubmit.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSubmit.HoverState.Parent = this.btnSubmit;
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSubmit.Location = new System.Drawing.Point(697, 682);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(249, 45);
            this.btnSubmit.TabIndex = 46;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BorderRadius = 15;
            this.btnPrevious.BorderThickness = 1;
            this.btnPrevious.CheckedState.Parent = this.btnPrevious;
            this.btnPrevious.CustomImages.Parent = this.btnPrevious;
            this.btnPrevious.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPrevious.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPrevious.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPrevious.HoverState.Parent = this.btnPrevious;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPrevious.Location = new System.Drawing.Point(766, 594);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.ShadowDecoration.Parent = this.btnPrevious;
            this.btnPrevious.Size = new System.Drawing.Size(180, 45);
            this.btnPrevious.TabIndex = 45;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderRadius = 15;
            this.btnNext.BorderThickness = 1;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnNext.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.FillColor = System.Drawing.Color.White;
            this.btnNext.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNext.Location = new System.Drawing.Point(766, 515);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(180, 45);
            this.btnNext.TabIndex = 47;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.BackColor = System.Drawing.Color.Transparent;
            this.labelCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourse.ForeColor = System.Drawing.Color.White;
            this.labelCourse.Location = new System.Drawing.Point(787, 203);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(136, 32);
            this.labelCourse.TabIndex = 48;
            this.labelCourse.Text = "CSC 562";
            this.labelCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 681);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 49;
            this.label2.Text = "Go To Question:";
            // 
            // mskTxtGotoQuestion
            // 
            this.mskTxtGotoQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTxtGotoQuestion.Location = new System.Drawing.Point(256, 682);
            this.mskTxtGotoQuestion.Mask = "000";
            this.mskTxtGotoQuestion.Name = "mskTxtGotoQuestion";
            this.mskTxtGotoQuestion.Size = new System.Drawing.Size(100, 34);
            this.mskTxtGotoQuestion.TabIndex = 50;
            this.mskTxtGotoQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGoToQuestion
            // 
            this.btnGoToQuestion.BackColor = System.Drawing.Color.Transparent;
            this.btnGoToQuestion.BorderRadius = 10;
            this.btnGoToQuestion.BorderThickness = 1;
            this.btnGoToQuestion.CheckedState.Parent = this.btnGoToQuestion;
            this.btnGoToQuestion.CustomImages.Parent = this.btnGoToQuestion;
            this.btnGoToQuestion.FillColor = System.Drawing.Color.Teal;
            this.btnGoToQuestion.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToQuestion.ForeColor = System.Drawing.Color.White;
            this.btnGoToQuestion.HoverState.FillColor = System.Drawing.Color.White;
            this.btnGoToQuestion.HoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnGoToQuestion.HoverState.Parent = this.btnGoToQuestion;
            this.btnGoToQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnGoToQuestion.Image")));
            this.btnGoToQuestion.Location = new System.Drawing.Point(386, 682);
            this.btnGoToQuestion.Name = "btnGoToQuestion";
            this.btnGoToQuestion.ShadowDecoration.Parent = this.btnGoToQuestion;
            this.btnGoToQuestion.Size = new System.Drawing.Size(100, 35);
            this.btnGoToQuestion.TabIndex = 51;
            this.btnGoToQuestion.Text = "Go";
            this.btnGoToQuestion.Click += new System.EventHandler(this.btnGoToQuestion_Click);
            // 
            // examTimer
            // 
            this.examTimer.Interval = 1000;
            this.examTimer.Tick += new System.EventHandler(this.examTimer_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timerLabel.Location = new System.Drawing.Point(829, 99);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(117, 35);
            this.timerLabel.TabIndex = 52;
            this.timerLabel.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(691, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 35);
            this.label3.TabIndex = 53;
            this.label3.Text = "Time Left:";
            // 
            // ExamPage_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.btnGoToQuestion);
            this.Controls.Add(this.mskTxtGotoQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.comboSelectAnswer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ExamPage_UC";
            this.Size = new System.Drawing.Size(1021, 768);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Elipse elipseExamPage;
        private Guna.UI2.WinForms.Guna2ComboBox comboSelectAnswer;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label questionDetails;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.MaskedTextBox mskTxtGotoQuestion;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnGoToQuestion;
        private System.Windows.Forms.Timer examTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timerLabel;
    }
}
