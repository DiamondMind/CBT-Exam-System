
namespace CBT_Examination_System
{
    partial class StudentDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboard));
            this.dashboardPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseAll = new Guna.UI2.WinForms.Guna2Button();
            this.labelMatricNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewProfile = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewResults = new Guna.UI2.WinForms.Guna2Button();
            this.btnTakeExam = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewCourses = new Guna.UI2.WinForms.Guna2Button();
            this.labelName = new System.Windows.Forms.Label();
            this.elipseStudentProfile = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_BeginExam = new CBT_Examination_System.Student_UC.uC_BeginExam();
            this.uC_ViewStudentCourses = new CBT_Examination_System.Student_UC.ViewCourses_UC();
            this.uC_ViewProfile = new CBT_Examination_System.Student_UC.ViewProfile_UC();
            this.uC_ViewResults = new CBT_Examination_System.Student_UC.uC_ViewResults();
            this.uC_ExamPage = new CBT_Examination_System.Student_UC.ExamPage_UC();
            this.beginExam1 = new CBT_Examination_System.Student_UC.uC_BeginExam();
            this.dashboardPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.dashboardPanel.Controls.Add(this.label4);
            this.dashboardPanel.Controls.Add(this.label3);
            this.dashboardPanel.Controls.Add(this.label2);
            this.dashboardPanel.Controls.Add(this.btnCloseAll);
            this.dashboardPanel.Controls.Add(this.labelMatricNo);
            this.dashboardPanel.Controls.Add(this.label1);
            this.dashboardPanel.Controls.Add(this.btnViewProfile);
            this.dashboardPanel.Controls.Add(this.label6);
            this.dashboardPanel.Controls.Add(this.btnLogout);
            this.dashboardPanel.Controls.Add(this.btnViewResults);
            this.dashboardPanel.Controls.Add(this.btnTakeExam);
            this.dashboardPanel.Controls.Add(this.btnViewCourses);
            this.dashboardPanel.Controls.Add(this.labelName);
            this.dashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.ShadowDecoration.Parent = this.dashboardPanel;
            this.dashboardPanel.Size = new System.Drawing.Size(346, 768);
            this.dashboardPanel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lavender;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "NAME:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(22, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "--------------------------------------";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(23, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "--------------------------------------";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseAll.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCloseAll.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnCloseAll.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCloseAll.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCloseAll.CheckedState.Parent = this.btnCloseAll;
            this.btnCloseAll.CustomImages.Parent = this.btnCloseAll;
            this.btnCloseAll.FillColor = System.Drawing.Color.Transparent;
            this.btnCloseAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseAll.ForeColor = System.Drawing.Color.Lavender;
            this.btnCloseAll.HoverState.FillColor = System.Drawing.Color.White;
            this.btnCloseAll.HoverState.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnCloseAll.HoverState.Parent = this.btnCloseAll;
            this.btnCloseAll.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseAll.Image")));
            this.btnCloseAll.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCloseAll.Location = new System.Drawing.Point(15, 495);
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCloseAll.ShadowDecoration.Parent = this.btnCloseAll;
            this.btnCloseAll.Size = new System.Drawing.Size(300, 45);
            this.btnCloseAll.TabIndex = 14;
            this.btnCloseAll.Text = "Close All Tabs";
            this.btnCloseAll.Click += new System.EventHandler(this.btnCloseAll_Click);
            // 
            // labelMatricNo
            // 
            this.labelMatricNo.BackColor = System.Drawing.Color.Transparent;
            this.labelMatricNo.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatricNo.ForeColor = System.Drawing.Color.Lavender;
            this.labelMatricNo.Location = new System.Drawing.Point(88, 171);
            this.labelMatricNo.Name = "labelMatricNo";
            this.labelMatricNo.Size = new System.Drawing.Size(227, 37);
            this.labelMatricNo.TabIndex = 13;
            this.labelMatricNo.Text = "800";
            this.labelMatricNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(14, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnViewProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewProfile.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnViewProfile.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewProfile.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewProfile.CheckedState.Parent = this.btnViewProfile;
            this.btnViewProfile.CustomImages.Parent = this.btnViewProfile;
            this.btnViewProfile.FillColor = System.Drawing.Color.Transparent;
            this.btnViewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.ForeColor = System.Drawing.Color.Lavender;
            this.btnViewProfile.HoverState.FillColor = System.Drawing.Color.White;
            this.btnViewProfile.HoverState.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnViewProfile.HoverState.Parent = this.btnViewProfile;
            this.btnViewProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnViewProfile.Image")));
            this.btnViewProfile.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewProfile.Location = new System.Drawing.Point(23, 261);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewProfile.ShadowDecoration.Parent = this.btnViewProfile;
            this.btnViewProfile.Size = new System.Drawing.Size(300, 45);
            this.btnViewProfile.TabIndex = 11;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto Slab", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lavender;
            this.label6.Location = new System.Drawing.Point(23, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 40);
            this.label6.TabIndex = 10;
            this.label6.Text = "Welcome Back!";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogout.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Lavender;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogout.Location = new System.Drawing.Point(15, 551);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(300, 45);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewResults
            // 
            this.btnViewResults.BackColor = System.Drawing.Color.Transparent;
            this.btnViewResults.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewResults.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnViewResults.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewResults.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewResults.CheckedState.Parent = this.btnViewResults;
            this.btnViewResults.CustomImages.Parent = this.btnViewResults;
            this.btnViewResults.FillColor = System.Drawing.Color.Transparent;
            this.btnViewResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewResults.ForeColor = System.Drawing.Color.Lavender;
            this.btnViewResults.HoverState.FillColor = System.Drawing.Color.White;
            this.btnViewResults.HoverState.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnViewResults.HoverState.Parent = this.btnViewResults;
            this.btnViewResults.Image = ((System.Drawing.Image)(resources.GetObject("btnViewResults.Image")));
            this.btnViewResults.ImageSize = new System.Drawing.Size(40, 40);
            this.btnViewResults.Location = new System.Drawing.Point(15, 437);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewResults.ShadowDecoration.Parent = this.btnViewResults;
            this.btnViewResults.Size = new System.Drawing.Size(310, 45);
            this.btnViewResults.TabIndex = 4;
            this.btnViewResults.Text = "View Results";
            this.btnViewResults.Click += new System.EventHandler(this.btnViewResults_Click);
            // 
            // btnTakeExam
            // 
            this.btnTakeExam.BackColor = System.Drawing.Color.Transparent;
            this.btnTakeExam.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTakeExam.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnTakeExam.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnTakeExam.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnTakeExam.CheckedState.Parent = this.btnTakeExam;
            this.btnTakeExam.CustomImages.Parent = this.btnTakeExam;
            this.btnTakeExam.FillColor = System.Drawing.Color.Transparent;
            this.btnTakeExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeExam.ForeColor = System.Drawing.Color.Lavender;
            this.btnTakeExam.HoverState.FillColor = System.Drawing.Color.White;
            this.btnTakeExam.HoverState.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnTakeExam.HoverState.Parent = this.btnTakeExam;
            this.btnTakeExam.Image = ((System.Drawing.Image)(resources.GetObject("btnTakeExam.Image")));
            this.btnTakeExam.ImageSize = new System.Drawing.Size(40, 40);
            this.btnTakeExam.Location = new System.Drawing.Point(15, 377);
            this.btnTakeExam.Name = "btnTakeExam";
            this.btnTakeExam.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTakeExam.ShadowDecoration.Parent = this.btnTakeExam;
            this.btnTakeExam.Size = new System.Drawing.Size(300, 45);
            this.btnTakeExam.TabIndex = 3;
            this.btnTakeExam.Text = "Take Examination";
            this.btnTakeExam.Click += new System.EventHandler(this.btnTakeExam_Click);
            // 
            // btnViewCourses
            // 
            this.btnViewCourses.BackColor = System.Drawing.Color.Transparent;
            this.btnViewCourses.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewCourses.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnViewCourses.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewCourses.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewCourses.CheckedState.Parent = this.btnViewCourses;
            this.btnViewCourses.CustomImages.Parent = this.btnViewCourses;
            this.btnViewCourses.FillColor = System.Drawing.Color.Transparent;
            this.btnViewCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCourses.ForeColor = System.Drawing.Color.Lavender;
            this.btnViewCourses.HoverState.FillColor = System.Drawing.Color.White;
            this.btnViewCourses.HoverState.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnViewCourses.HoverState.Parent = this.btnViewCourses;
            this.btnViewCourses.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCourses.Image")));
            this.btnViewCourses.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewCourses.Location = new System.Drawing.Point(15, 317);
            this.btnViewCourses.Name = "btnViewCourses";
            this.btnViewCourses.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewCourses.ShadowDecoration.Parent = this.btnViewCourses;
            this.btnViewCourses.Size = new System.Drawing.Size(300, 45);
            this.btnViewCourses.TabIndex = 2;
            this.btnViewCourses.Text = "View Courses";
            this.btnViewCourses.Click += new System.EventHandler(this.btnViewCourses_Click);
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Lavender;
            this.labelName.Location = new System.Drawing.Point(93, 133);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(229, 37);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Mr Rabiu";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elipseStudentProfile
            // 
            this.elipseStudentProfile.TargetControl = this.guna2Panel1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Controls.Add(this.uC_BeginExam);
            this.guna2Panel1.Controls.Add(this.uC_ViewStudentCourses);
            this.guna2Panel1.Controls.Add(this.uC_ViewProfile);
            this.guna2Panel1.Controls.Add(this.uC_ViewResults);
            this.guna2Panel1.Controls.Add(this.uC_ExamPage);
            this.guna2Panel1.Location = new System.Drawing.Point(345, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1021, 768);
            this.guna2Panel1.TabIndex = 3;
            // 
            // uC_BeginExam
            // 
            this.uC_BeginExam.BackColor = System.Drawing.Color.White;
            this.uC_BeginExam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_BeginExam.BackgroundImage")));
            this.uC_BeginExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_BeginExam.Location = new System.Drawing.Point(0, 0);
            this.uC_BeginExam.Name = "uC_BeginExam";
            this.uC_BeginExam.Size = new System.Drawing.Size(1021, 768);
            this.uC_BeginExam.TabIndex = 2;
            // 
            // uC_ViewStudentCourses
            // 
            this.uC_ViewStudentCourses.BackColor = System.Drawing.Color.White;
            this.uC_ViewStudentCourses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_ViewStudentCourses.BackgroundImage")));
            this.uC_ViewStudentCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_ViewStudentCourses.Location = new System.Drawing.Point(0, 0);
            this.uC_ViewStudentCourses.Name = "uC_ViewStudentCourses";
            this.uC_ViewStudentCourses.Size = new System.Drawing.Size(1021, 768);
            this.uC_ViewStudentCourses.TabIndex = 1;
            // 
            // uC_ViewProfile
            // 
            this.uC_ViewProfile.BackColor = System.Drawing.Color.White;
            this.uC_ViewProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_ViewProfile.BackgroundImage")));
            this.uC_ViewProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_ViewProfile.Location = new System.Drawing.Point(0, 0);
            this.uC_ViewProfile.Name = "uC_ViewProfile";
            this.uC_ViewProfile.Size = new System.Drawing.Size(1021, 768);
            this.uC_ViewProfile.TabIndex = 0;
            // 
            // uC_ViewResults
            // 
            this.uC_ViewResults.BackColor = System.Drawing.Color.White;
            this.uC_ViewResults.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_ViewResults.BackgroundImage")));
            this.uC_ViewResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_ViewResults.Location = new System.Drawing.Point(0, 0);
            this.uC_ViewResults.Name = "uC_ViewResults";
            this.uC_ViewResults.Size = new System.Drawing.Size(1021, 768);
            this.uC_ViewResults.TabIndex = 4;
            // 
            // uC_ExamPage
            // 
            this.uC_ExamPage.BackColor = System.Drawing.Color.White;
            this.uC_ExamPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_ExamPage.BackgroundImage")));
            this.uC_ExamPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_ExamPage.Location = new System.Drawing.Point(0, 0);
            this.uC_ExamPage.Name = "uC_ExamPage";
            this.uC_ExamPage.Size = new System.Drawing.Size(1021, 768);
            this.uC_ExamPage.TabIndex = 3;
            // 
            // beginExam1
            // 
            this.beginExam1.BackColor = System.Drawing.Color.White;
            this.beginExam1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("beginExam1.BackgroundImage")));
            this.beginExam1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.beginExam1.Location = new System.Drawing.Point(0, 0);
            this.beginExam1.Name = "beginExam1";
            this.beginExam1.Size = new System.Drawing.Size(1021, 768);
            this.beginExam1.TabIndex = 2;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dashboardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentDashboard";
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            this.dashboardPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel dashboardPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnCloseAll;
        private System.Windows.Forms.Label labelMatricNo;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnViewProfile;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnViewResults;
        private Guna.UI2.WinForms.Guna2Button btnTakeExam;
        private Guna.UI2.WinForms.Guna2Button btnViewCourses;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2Elipse elipseStudentProfile;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Student_UC.ViewProfile_UC uC_ViewProfile;
        private Student_UC.ViewCourses_UC uC_ViewStudentCourses;
        private Student_UC.uC_BeginExam beginExam1;
        private Student_UC.uC_BeginExam uC_BeginExam;
        private Student_UC.ExamPage_UC uC_ExamPage;
        private Student_UC.uC_ViewResults uC_ViewResults;
    }
}