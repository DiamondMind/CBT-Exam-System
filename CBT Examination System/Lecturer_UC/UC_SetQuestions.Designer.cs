
namespace CBT_Examination_System.Lecturer_UC
{
    partial class UC_SetQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SetQuestions));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSelectDept = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboSelectCourse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinish = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOptionD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOptionC = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOptionB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOptionA = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuestion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboSelectAnswer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.elipseSetQuestion = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set Questions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Department";
            this.label3.UseMnemonic = false;
            // 
            // comboSelectDept
            // 
            this.comboSelectDept.BackColor = System.Drawing.Color.Transparent;
            this.comboSelectDept.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSelectDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSelectDept.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSelectDept.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSelectDept.FocusedState.Parent = this.comboSelectDept;
            this.comboSelectDept.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboSelectDept.ForeColor = System.Drawing.Color.Black;
            this.comboSelectDept.HoverState.Parent = this.comboSelectDept;
            this.comboSelectDept.ItemHeight = 30;
            this.comboSelectDept.ItemsAppearance.Parent = this.comboSelectDept;
            this.comboSelectDept.Location = new System.Drawing.Point(72, 137);
            this.comboSelectDept.Name = "comboSelectDept";
            this.comboSelectDept.ShadowDecoration.Parent = this.comboSelectDept;
            this.comboSelectDept.Size = new System.Drawing.Size(301, 36);
            this.comboSelectDept.TabIndex = 20;
            this.comboSelectDept.SelectedIndexChanged += new System.EventHandler(this.comboSelectDept_SelectedIndexChanged);
            // 
            // comboSelectCourse
            // 
            this.comboSelectCourse.BackColor = System.Drawing.Color.Transparent;
            this.comboSelectCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSelectCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSelectCourse.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSelectCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSelectCourse.FocusedState.Parent = this.comboSelectCourse;
            this.comboSelectCourse.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboSelectCourse.ForeColor = System.Drawing.Color.Black;
            this.comboSelectCourse.HoverState.Parent = this.comboSelectCourse;
            this.comboSelectCourse.ItemHeight = 30;
            this.comboSelectCourse.ItemsAppearance.Parent = this.comboSelectCourse;
            this.comboSelectCourse.Location = new System.Drawing.Point(399, 137);
            this.comboSelectCourse.Name = "comboSelectCourse";
            this.comboSelectCourse.ShadowDecoration.Parent = this.comboSelectCourse;
            this.comboSelectCourse.Size = new System.Drawing.Size(227, 36);
            this.comboSelectCourse.TabIndex = 22;
            this.comboSelectCourse.SelectedIndexChanged += new System.EventHandler(this.comboSelectCourse_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(394, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Course";
            this.label4.UseMnemonic = false;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Transparent;
            this.btnFinish.BorderRadius = 15;
            this.btnFinish.BorderThickness = 1;
            this.btnFinish.CheckedState.Parent = this.btnFinish;
            this.btnFinish.CustomImages.Parent = this.btnFinish;
            this.btnFinish.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnFinish.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.HoverState.FillColor = System.Drawing.Color.White;
            this.btnFinish.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFinish.HoverState.Parent = this.btnFinish;
            this.btnFinish.ImageSize = new System.Drawing.Size(25, 25);
            this.btnFinish.Location = new System.Drawing.Point(588, 667);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.ShadowDecoration.Parent = this.btnFinish;
            this.btnFinish.Size = new System.Drawing.Size(400, 45);
            this.btnFinish.TabIndex = 39;
            this.btnFinish.Text = "Finish";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BorderRadius = 15;
            this.btnReset.BorderThickness = 1;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.FillColor = System.Drawing.Color.Teal;
            this.btnReset.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.FillColor = System.Drawing.Color.White;
            this.btnReset.HoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReset.Location = new System.Drawing.Point(804, 588);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(180, 45);
            this.btnReset.TabIndex = 38;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderRadius = 15;
            this.btnNext.BorderThickness = 1;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.FillColor = System.Drawing.Color.Teal;
            this.btnNext.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.FillColor = System.Drawing.Color.White;
            this.btnNext.HoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNext.Location = new System.Drawing.Point(592, 588);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(180, 45);
            this.btnNext.TabIndex = 37;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(678, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 25);
            this.label10.TabIndex = 35;
            this.label10.Text = "Answer:";
            // 
            // txtOptionD
            // 
            this.txtOptionD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOptionD.DefaultText = "";
            this.txtOptionD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOptionD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOptionD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOptionD.DisabledState.Parent = this.txtOptionD;
            this.txtOptionD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOptionD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOptionD.FocusedState.Parent = this.txtOptionD;
            this.txtOptionD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionD.ForeColor = System.Drawing.Color.Black;
            this.txtOptionD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOptionD.HoverState.Parent = this.txtOptionD;
            this.txtOptionD.Location = new System.Drawing.Point(72, 669);
            this.txtOptionD.Margin = new System.Windows.Forms.Padding(4);
            this.txtOptionD.Name = "txtOptionD";
            this.txtOptionD.PasswordChar = '\0';
            this.txtOptionD.PlaceholderText = "";
            this.txtOptionD.SelectedText = "";
            this.txtOptionD.ShadowDecoration.Parent = this.txtOptionD;
            this.txtOptionD.Size = new System.Drawing.Size(440, 50);
            this.txtOptionD.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 639);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 25);
            this.label9.TabIndex = 33;
            this.label9.Text = "Option D:";
            // 
            // txtOptionC
            // 
            this.txtOptionC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOptionC.DefaultText = "";
            this.txtOptionC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOptionC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOptionC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOptionC.DisabledState.Parent = this.txtOptionC;
            this.txtOptionC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOptionC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOptionC.FocusedState.Parent = this.txtOptionC;
            this.txtOptionC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionC.ForeColor = System.Drawing.Color.Black;
            this.txtOptionC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOptionC.HoverState.Parent = this.txtOptionC;
            this.txtOptionC.Location = new System.Drawing.Point(73, 567);
            this.txtOptionC.Margin = new System.Windows.Forms.Padding(4);
            this.txtOptionC.Name = "txtOptionC";
            this.txtOptionC.PasswordChar = '\0';
            this.txtOptionC.PlaceholderText = "";
            this.txtOptionC.SelectedText = "";
            this.txtOptionC.ShadowDecoration.Parent = this.txtOptionC;
            this.txtOptionC.Size = new System.Drawing.Size(440, 50);
            this.txtOptionC.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 536);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Option C:";
            // 
            // txtOptionB
            // 
            this.txtOptionB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOptionB.DefaultText = "";
            this.txtOptionB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOptionB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOptionB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOptionB.DisabledState.Parent = this.txtOptionB;
            this.txtOptionB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOptionB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOptionB.FocusedState.Parent = this.txtOptionB;
            this.txtOptionB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionB.ForeColor = System.Drawing.Color.Black;
            this.txtOptionB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOptionB.HoverState.Parent = this.txtOptionB;
            this.txtOptionB.Location = new System.Drawing.Point(72, 464);
            this.txtOptionB.Margin = new System.Windows.Forms.Padding(4);
            this.txtOptionB.Name = "txtOptionB";
            this.txtOptionB.PasswordChar = '\0';
            this.txtOptionB.PlaceholderText = "";
            this.txtOptionB.SelectedText = "";
            this.txtOptionB.ShadowDecoration.Parent = this.txtOptionB;
            this.txtOptionB.Size = new System.Drawing.Size(440, 50);
            this.txtOptionB.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Option B:";
            // 
            // txtOptionA
            // 
            this.txtOptionA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOptionA.DefaultText = "";
            this.txtOptionA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOptionA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOptionA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOptionA.DisabledState.Parent = this.txtOptionA;
            this.txtOptionA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOptionA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOptionA.FocusedState.Parent = this.txtOptionA;
            this.txtOptionA.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionA.ForeColor = System.Drawing.Color.Black;
            this.txtOptionA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOptionA.HoverState.Parent = this.txtOptionA;
            this.txtOptionA.Location = new System.Drawing.Point(72, 358);
            this.txtOptionA.Margin = new System.Windows.Forms.Padding(4);
            this.txtOptionA.Name = "txtOptionA";
            this.txtOptionA.PasswordChar = '\0';
            this.txtOptionA.PlaceholderText = "";
            this.txtOptionA.SelectedText = "";
            this.txtOptionA.ShadowDecoration.Parent = this.txtOptionA;
            this.txtOptionA.Size = new System.Drawing.Size(440, 50);
            this.txtOptionA.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Option A:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuestion.DefaultText = "";
            this.txtQuestion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuestion.DisabledState.Parent = this.txtQuestion;
            this.txtQuestion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuestion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuestion.FocusedState.Parent = this.txtQuestion;
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.ForeColor = System.Drawing.Color.Black;
            this.txtQuestion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuestion.HoverState.Parent = this.txtQuestion;
            this.txtQuestion.Location = new System.Drawing.Point(72, 251);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.PasswordChar = '\0';
            this.txtQuestion.PlaceholderText = "";
            this.txtQuestion.SelectedText = "";
            this.txtQuestion.ShadowDecoration.Parent = this.txtQuestion;
            this.txtQuestion.Size = new System.Drawing.Size(440, 50);
            this.txtQuestion.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Question";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.Red;
            this.questionLabel.Location = new System.Drawing.Point(770, 251);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(41, 44);
            this.questionLabel.TabIndex = 24;
            this.questionLabel.Text = "9";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(714, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Question No:";
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
            "Option A",
            "Option B",
            "Option C",
            "Option D"});
            this.comboSelectAnswer.ItemsAppearance.Parent = this.comboSelectAnswer;
            this.comboSelectAnswer.Location = new System.Drawing.Point(683, 358);
            this.comboSelectAnswer.Name = "comboSelectAnswer";
            this.comboSelectAnswer.ShadowDecoration.Parent = this.comboSelectAnswer;
            this.comboSelectAnswer.Size = new System.Drawing.Size(265, 36);
            this.comboSelectAnswer.StartIndex = 0;
            this.comboSelectAnswer.TabIndex = 41;
            // 
            // elipseSetQuestion
            // 
            this.elipseSetQuestion.TargetControl = this;
            // 
            // UC_SetQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.comboSelectAnswer);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtOptionD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOptionC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOptionB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOptionA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboSelectCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboSelectDept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "UC_SetQuestions";
            this.Size = new System.Drawing.Size(1021, 768);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox comboSelectDept;
        private Guna.UI2.WinForms.Guna2ComboBox comboSelectCourse;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnFinish;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtOptionD;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtOptionC;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtOptionB;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtOptionA;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtQuestion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox comboSelectAnswer;
        private Guna.UI2.WinForms.Guna2Elipse elipseSetQuestion;
    }
}
