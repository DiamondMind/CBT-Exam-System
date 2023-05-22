
namespace CBT_Examination_System
{
    partial class LecturerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerDashboard));
            this.dashboardPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseAll = new Guna.UI2.WinForms.Guna2Button();
            this.labelLecturerID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewCourse = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewResults = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewDeleteQuestions = new Guna.UI2.WinForms.Guna2Button();
            this.btnSetQuestions = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewDeleteCourses = new Guna.UI2.WinForms.Guna2Button();
            this.labelName = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_ViewQuestions = new CBT_Examination_System.Lecturer_UC.UC_ViewQuestions();
            this.uC_SetQuestions = new CBT_Examination_System.Lecturer_UC.UC_SetQuestions();
            this.uC_ViewCourses = new CBT_Examination_System.UC_ViewCourses();
            this.uC_AddNewCourse = new CBT_Examination_System.Lecturer_UC.UC_AddNewCourse();
            this.uC_ViewStudentsResults = new CBT_Examination_System.Lecturer_UC.UC_ViewStudentsResults();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.dashboardPanel.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackColor = System.Drawing.Color.Teal;
            this.dashboardPanel.Controls.Add(this.label4);
            this.dashboardPanel.Controls.Add(this.label3);
            this.dashboardPanel.Controls.Add(this.label2);
            this.dashboardPanel.Controls.Add(this.btnCloseAll);
            this.dashboardPanel.Controls.Add(this.labelLecturerID);
            this.dashboardPanel.Controls.Add(this.label1);
            this.dashboardPanel.Controls.Add(this.btnAddNewCourse);
            this.dashboardPanel.Controls.Add(this.label6);
            this.dashboardPanel.Controls.Add(this.btnLogout);
            this.dashboardPanel.Controls.Add(this.btnViewResults);
            this.dashboardPanel.Controls.Add(this.btnViewDeleteQuestions);
            this.dashboardPanel.Controls.Add(this.btnSetQuestions);
            this.dashboardPanel.Controls.Add(this.btnViewDeleteCourses);
            this.dashboardPanel.Controls.Add(this.labelName);
            this.dashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.ShadowDecoration.Parent = this.dashboardPanel;
            this.dashboardPanel.Size = new System.Drawing.Size(346, 768);
            this.dashboardPanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lavender;
            this.label4.Location = new System.Drawing.Point(12, 175);
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
            this.btnCloseAll.HoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnCloseAll.HoverState.Parent = this.btnCloseAll;
            this.btnCloseAll.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseAll.Image")));
            this.btnCloseAll.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCloseAll.Location = new System.Drawing.Point(15, 568);
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCloseAll.ShadowDecoration.Parent = this.btnCloseAll;
            this.btnCloseAll.Size = new System.Drawing.Size(300, 45);
            this.btnCloseAll.TabIndex = 14;
            this.btnCloseAll.Text = "Close All Tabs";
            this.btnCloseAll.Click += new System.EventHandler(this.btnCloseAll_Click);
            // 
            // labelLecturerID
            // 
            this.labelLecturerID.BackColor = System.Drawing.Color.Transparent;
            this.labelLecturerID.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLecturerID.ForeColor = System.Drawing.Color.Lavender;
            this.labelLecturerID.Location = new System.Drawing.Point(100, 133);
            this.labelLecturerID.Name = "labelLecturerID";
            this.labelLecturerID.Size = new System.Drawing.Size(112, 37);
            this.labelLecturerID.TabIndex = 13;
            this.labelLecturerID.Text = "800";
            this.labelLecturerID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(14, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddNewCourse
            // 
            this.btnAddNewCourse.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewCourse.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddNewCourse.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnAddNewCourse.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddNewCourse.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewCourse.CheckedState.Parent = this.btnAddNewCourse;
            this.btnAddNewCourse.CustomImages.Parent = this.btnAddNewCourse;
            this.btnAddNewCourse.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCourse.ForeColor = System.Drawing.Color.Lavender;
            this.btnAddNewCourse.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddNewCourse.HoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnAddNewCourse.HoverState.Parent = this.btnAddNewCourse;
            this.btnAddNewCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewCourse.Image")));
            this.btnAddNewCourse.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewCourse.Location = new System.Drawing.Point(23, 261);
            this.btnAddNewCourse.Name = "btnAddNewCourse";
            this.btnAddNewCourse.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddNewCourse.ShadowDecoration.Parent = this.btnAddNewCourse;
            this.btnAddNewCourse.Size = new System.Drawing.Size(300, 45);
            this.btnAddNewCourse.TabIndex = 11;
            this.btnAddNewCourse.Text = "Add New Course";
            this.btnAddNewCourse.Click += new System.EventHandler(this.btnAddNewCourse_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto Slab", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lavender;
            this.label6.Location = new System.Drawing.Point(28, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 40);
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
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogout.Location = new System.Drawing.Point(15, 624);
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
            this.btnViewResults.HoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnViewResults.HoverState.Parent = this.btnViewResults;
            this.btnViewResults.Image = ((System.Drawing.Image)(resources.GetObject("btnViewResults.Image")));
            this.btnViewResults.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewResults.Location = new System.Drawing.Point(23, 505);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewResults.ShadowDecoration.Parent = this.btnViewResults;
            this.btnViewResults.Size = new System.Drawing.Size(300, 45);
            this.btnViewResults.TabIndex = 5;
            this.btnViewResults.Text = "All Students Results";
            this.btnViewResults.Click += new System.EventHandler(this.btnViewResults_Click);
            // 
            // btnViewDeleteQuestions
            // 
            this.btnViewDeleteQuestions.BackColor = System.Drawing.Color.Transparent;
            this.btnViewDeleteQuestions.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewDeleteQuestions.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnViewDeleteQuestions.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewDeleteQuestions.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewDeleteQuestions.CheckedState.Parent = this.btnViewDeleteQuestions;
            this.btnViewDeleteQuestions.CustomImages.Parent = this.btnViewDeleteQuestions;
            this.btnViewDeleteQuestions.FillColor = System.Drawing.Color.Transparent;
            this.btnViewDeleteQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDeleteQuestions.ForeColor = System.Drawing.Color.Lavender;
            this.btnViewDeleteQuestions.HoverState.FillColor = System.Drawing.Color.White;
            this.btnViewDeleteQuestions.HoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnViewDeleteQuestions.HoverState.Parent = this.btnViewDeleteQuestions;
            this.btnViewDeleteQuestions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDeleteQuestions.Image")));
            this.btnViewDeleteQuestions.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewDeleteQuestions.Location = new System.Drawing.Point(15, 437);
            this.btnViewDeleteQuestions.Name = "btnViewDeleteQuestions";
            this.btnViewDeleteQuestions.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewDeleteQuestions.ShadowDecoration.Parent = this.btnViewDeleteQuestions;
            this.btnViewDeleteQuestions.Size = new System.Drawing.Size(310, 45);
            this.btnViewDeleteQuestions.TabIndex = 4;
            this.btnViewDeleteQuestions.Text = "View & Delete Questions";
            this.btnViewDeleteQuestions.Click += new System.EventHandler(this.btnViewDeleteQuestions_Click);
            // 
            // btnSetQuestions
            // 
            this.btnSetQuestions.BackColor = System.Drawing.Color.Transparent;
            this.btnSetQuestions.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSetQuestions.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnSetQuestions.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSetQuestions.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnSetQuestions.CheckedState.Parent = this.btnSetQuestions;
            this.btnSetQuestions.CustomImages.Parent = this.btnSetQuestions;
            this.btnSetQuestions.FillColor = System.Drawing.Color.Transparent;
            this.btnSetQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetQuestions.ForeColor = System.Drawing.Color.Lavender;
            this.btnSetQuestions.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSetQuestions.HoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnSetQuestions.HoverState.Parent = this.btnSetQuestions;
            this.btnSetQuestions.Image = ((System.Drawing.Image)(resources.GetObject("btnSetQuestions.Image")));
            this.btnSetQuestions.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSetQuestions.Location = new System.Drawing.Point(15, 377);
            this.btnSetQuestions.Name = "btnSetQuestions";
            this.btnSetQuestions.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetQuestions.ShadowDecoration.Parent = this.btnSetQuestions;
            this.btnSetQuestions.Size = new System.Drawing.Size(300, 45);
            this.btnSetQuestions.TabIndex = 3;
            this.btnSetQuestions.Text = "Set Questions";
            this.btnSetQuestions.Click += new System.EventHandler(this.btnSetQuestions_Click);
            // 
            // btnViewDeleteCourses
            // 
            this.btnViewDeleteCourses.BackColor = System.Drawing.Color.Transparent;
            this.btnViewDeleteCourses.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewDeleteCourses.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnViewDeleteCourses.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewDeleteCourses.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewDeleteCourses.CheckedState.Parent = this.btnViewDeleteCourses;
            this.btnViewDeleteCourses.CustomImages.Parent = this.btnViewDeleteCourses;
            this.btnViewDeleteCourses.FillColor = System.Drawing.Color.Transparent;
            this.btnViewDeleteCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDeleteCourses.ForeColor = System.Drawing.Color.Lavender;
            this.btnViewDeleteCourses.HoverState.FillColor = System.Drawing.Color.White;
            this.btnViewDeleteCourses.HoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnViewDeleteCourses.HoverState.Parent = this.btnViewDeleteCourses;
            this.btnViewDeleteCourses.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDeleteCourses.Image")));
            this.btnViewDeleteCourses.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewDeleteCourses.Location = new System.Drawing.Point(15, 317);
            this.btnViewDeleteCourses.Name = "btnViewDeleteCourses";
            this.btnViewDeleteCourses.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewDeleteCourses.ShadowDecoration.Parent = this.btnViewDeleteCourses;
            this.btnViewDeleteCourses.Size = new System.Drawing.Size(300, 45);
            this.btnViewDeleteCourses.TabIndex = 2;
            this.btnViewDeleteCourses.Text = "View & Delete Courses";
            this.btnViewDeleteCourses.Click += new System.EventHandler(this.btnViewDeleteCourses_Click);
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Lavender;
            this.labelName.Location = new System.Drawing.Point(99, 168);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(223, 37);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Mr Rabiu";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.guna2Panel2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel2.BackgroundImage")));
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel2.Controls.Add(this.uC_ViewQuestions);
            this.guna2Panel2.Controls.Add(this.uC_SetQuestions);
            this.guna2Panel2.Controls.Add(this.uC_ViewCourses);
            this.guna2Panel2.Controls.Add(this.uC_AddNewCourse);
            this.guna2Panel2.Controls.Add(this.uC_ViewStudentsResults);
            this.guna2Panel2.Location = new System.Drawing.Point(345, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1025, 768);
            this.guna2Panel2.TabIndex = 2;
            // 
            // uC_ViewQuestions
            // 
            this.uC_ViewQuestions.BackColor = System.Drawing.Color.White;
            this.uC_ViewQuestions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_ViewQuestions.BackgroundImage")));
            this.uC_ViewQuestions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_ViewQuestions.Location = new System.Drawing.Point(0, 0);
            this.uC_ViewQuestions.Name = "uC_ViewQuestions";
            this.uC_ViewQuestions.Size = new System.Drawing.Size(1021, 768);
            this.uC_ViewQuestions.TabIndex = 3;
            // 
            // uC_SetQuestions
            // 
            this.uC_SetQuestions.BackColor = System.Drawing.Color.White;
            this.uC_SetQuestions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_SetQuestions.BackgroundImage")));
            this.uC_SetQuestions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_SetQuestions.Location = new System.Drawing.Point(0, 0);
            this.uC_SetQuestions.Name = "uC_SetQuestions";
            this.uC_SetQuestions.Size = new System.Drawing.Size(1021, 768);
            this.uC_SetQuestions.TabIndex = 2;
            // 
            // uC_ViewCourses
            // 
            this.uC_ViewCourses.BackColor = System.Drawing.Color.White;
            this.uC_ViewCourses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_ViewCourses.BackgroundImage")));
            this.uC_ViewCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_ViewCourses.Location = new System.Drawing.Point(0, 0);
            this.uC_ViewCourses.Name = "uC_ViewCourses";
            this.uC_ViewCourses.Size = new System.Drawing.Size(1021, 768);
            this.uC_ViewCourses.TabIndex = 1;
            // 
            // uC_AddNewCourse
            // 
            this.uC_AddNewCourse.BackColor = System.Drawing.Color.White;
            this.uC_AddNewCourse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_AddNewCourse.BackgroundImage")));
            this.uC_AddNewCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_AddNewCourse.Location = new System.Drawing.Point(0, 0);
            this.uC_AddNewCourse.Name = "uC_AddNewCourse";
            this.uC_AddNewCourse.Size = new System.Drawing.Size(1021, 768);
            this.uC_AddNewCourse.TabIndex = 0;
            // 
            // uC_ViewStudentsResults
            // 
            this.uC_ViewStudentsResults.BackColor = System.Drawing.Color.White;
            this.uC_ViewStudentsResults.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_ViewStudentsResults.BackgroundImage")));
            this.uC_ViewStudentsResults.Location = new System.Drawing.Point(0, 0);
            this.uC_ViewStudentsResults.Name = "uC_ViewStudentsResults";
            this.uC_ViewStudentsResults.Size = new System.Drawing.Size(1021, 768);
            this.uC_ViewStudentsResults.TabIndex = 4;
            // 
            // LecturerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.dashboardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LecturerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LecturerDashboard";
            this.Load += new System.EventHandler(this.LecturerDashboard_Load);
            this.dashboardPanel.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel dashboardPanel;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnViewResults;
        private Guna.UI2.WinForms.Guna2Button btnViewDeleteQuestions;
        private Guna.UI2.WinForms.Guna2Button btnSetQuestions;
        private Guna.UI2.WinForms.Guna2Button btnViewDeleteCourses;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnAddNewCourse;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLecturerID;
        private Guna.UI2.WinForms.Guna2Button btnCloseAll;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Lecturer_UC.UC_ViewQuestions uC_ViewQuestions;
        private Lecturer_UC.UC_SetQuestions uC_SetQuestions;
        private UC_ViewCourses uC_ViewCourses;
        private Lecturer_UC.UC_AddNewCourse uC_AddNewCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Lecturer_UC.UC_ViewStudentsResults uC_ViewStudentsResults;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
    }
}