
namespace CBT_Examination_System.Lecturer_UC
{
    partial class UC_AddNewCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddNewCourse));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboSelectLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboSelectDepartment = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCourseCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCourseTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFinish = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.comboUnits = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboTimer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Level";
            // 
            // comboSelectLevel
            // 
            this.comboSelectLevel.BackColor = System.Drawing.Color.Transparent;
            this.comboSelectLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSelectLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSelectLevel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSelectLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSelectLevel.FocusedState.Parent = this.comboSelectLevel;
            this.comboSelectLevel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboSelectLevel.ForeColor = System.Drawing.Color.Black;
            this.comboSelectLevel.HoverState.Parent = this.comboSelectLevel;
            this.comboSelectLevel.ItemHeight = 30;
            this.comboSelectLevel.Items.AddRange(new object[] {
            "All",
            "100 Level",
            "200 Level",
            "300 Level",
            "400 Level "});
            this.comboSelectLevel.ItemsAppearance.Parent = this.comboSelectLevel;
            this.comboSelectLevel.Location = new System.Drawing.Point(72, 138);
            this.comboSelectLevel.Name = "comboSelectLevel";
            this.comboSelectLevel.ShadowDecoration.Parent = this.comboSelectLevel;
            this.comboSelectLevel.Size = new System.Drawing.Size(296, 36);
            this.comboSelectLevel.StartIndex = 0;
            this.comboSelectLevel.TabIndex = 12;
            // 
            // comboSelectDepartment
            // 
            this.comboSelectDepartment.BackColor = System.Drawing.Color.Transparent;
            this.comboSelectDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSelectDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSelectDepartment.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSelectDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSelectDepartment.FocusedState.Parent = this.comboSelectDepartment;
            this.comboSelectDepartment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboSelectDepartment.ForeColor = System.Drawing.Color.Black;
            this.comboSelectDepartment.HoverState.Parent = this.comboSelectDepartment;
            this.comboSelectDepartment.ItemHeight = 30;
            this.comboSelectDepartment.Items.AddRange(new object[] {
            "All",
            "Computer Science",
            "Computer Engineering",
            "Business Adminstration",
            "Banking &Finance",
            "Accounting",
            "Microbiology",
            "Biochemistry",
            "Electrical Engineering",
            "Mechanical Engineering",
            "Civil Engineering",
            "Mass Communication",
            "Sociology"});
            this.comboSelectDepartment.ItemsAppearance.Parent = this.comboSelectDepartment;
            this.comboSelectDepartment.Location = new System.Drawing.Point(385, 139);
            this.comboSelectDepartment.Name = "comboSelectDepartment";
            this.comboSelectDepartment.ShadowDecoration.Parent = this.comboSelectDepartment;
            this.comboSelectDepartment.Size = new System.Drawing.Size(250, 36);
            this.comboSelectDepartment.StartIndex = 0;
            this.comboSelectDepartment.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Department";
            this.label3.UseMnemonic = false;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCourseCode.DefaultText = "";
            this.txtCourseCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCourseCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCourseCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCourseCode.DisabledState.Parent = this.txtCourseCode;
            this.txtCourseCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCourseCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCourseCode.FocusedState.Parent = this.txtCourseCode;
            this.txtCourseCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseCode.ForeColor = System.Drawing.Color.Black;
            this.txtCourseCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCourseCode.HoverState.Parent = this.txtCourseCode;
            this.txtCourseCode.Location = new System.Drawing.Point(72, 418);
            this.txtCourseCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.PasswordChar = '\0';
            this.txtCourseCode.PlaceholderText = "";
            this.txtCourseCode.SelectedText = "";
            this.txtCourseCode.ShadowDecoration.Parent = this.txtCourseCode;
            this.txtCourseCode.Size = new System.Drawing.Size(440, 50);
            this.txtCourseCode.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Course Code:";
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCourseTitle.DefaultText = "";
            this.txtCourseTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCourseTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCourseTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCourseTitle.DisabledState.Parent = this.txtCourseTitle;
            this.txtCourseTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCourseTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCourseTitle.FocusedState.Parent = this.txtCourseTitle;
            this.txtCourseTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseTitle.ForeColor = System.Drawing.Color.Black;
            this.txtCourseTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCourseTitle.HoverState.Parent = this.txtCourseTitle;
            this.txtCourseTitle.Location = new System.Drawing.Point(77, 573);
            this.txtCourseTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.PasswordChar = '\0';
            this.txtCourseTitle.PlaceholderText = "";
            this.txtCourseTitle.SelectedText = "";
            this.txtCourseTitle.ShadowDecoration.Parent = this.txtCourseTitle;
            this.txtCourseTitle.Size = new System.Drawing.Size(440, 50);
            this.txtCourseTitle.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Course Title:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Units:";
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
            this.btnFinish.HoverState.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnFinish.HoverState.Parent = this.btnFinish;
            this.btnFinish.ImageSize = new System.Drawing.Size(25, 25);
            this.btnFinish.Location = new System.Drawing.Point(581, 664);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.ShadowDecoration.Parent = this.btnFinish;
            this.btnFinish.Size = new System.Drawing.Size(400, 45);
            this.btnFinish.TabIndex = 22;
            this.btnFinish.Text = "Finish";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click_1);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
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
            this.btnReset.Location = new System.Drawing.Point(801, 573);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(180, 45);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Clear All";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.Teal;
            this.btnAdd.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.ForeColor = System.Drawing.Color.Teal;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Location = new System.Drawing.Point(595, 573);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(180, 45);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboUnits
            // 
            this.comboUnits.BackColor = System.Drawing.Color.Transparent;
            this.comboUnits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUnits.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboUnits.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboUnits.FocusedState.Parent = this.comboUnits;
            this.comboUnits.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboUnits.ForeColor = System.Drawing.Color.Black;
            this.comboUnits.HoverState.Parent = this.comboUnits;
            this.comboUnits.ItemHeight = 30;
            this.comboUnits.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboUnits.ItemsAppearance.Parent = this.comboUnits;
            this.comboUnits.Location = new System.Drawing.Point(72, 262);
            this.comboUnits.Name = "comboUnits";
            this.comboUnits.ShadowDecoration.Parent = this.comboUnits;
            this.comboUnits.Size = new System.Drawing.Size(124, 36);
            this.comboUnits.StartIndex = 0;
            this.comboUnits.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(306, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Timer:";
            // 
            // comboTimer
            // 
            this.comboTimer.BackColor = System.Drawing.Color.Transparent;
            this.comboTimer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboTimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTimer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboTimer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboTimer.FocusedState.Parent = this.comboTimer;
            this.comboTimer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboTimer.ForeColor = System.Drawing.Color.Black;
            this.comboTimer.HoverState.Parent = this.comboTimer;
            this.comboTimer.ItemHeight = 30;
            this.comboTimer.Items.AddRange(new object[] {
            "00:10:00",
            "00:15:00",
            "00:30:00",
            "00:45:00",
            "01:00:00",
            "01:30:00",
            "02:00:00"});
            this.comboTimer.ItemsAppearance.Parent = this.comboTimer;
            this.comboTimer.Location = new System.Drawing.Point(311, 262);
            this.comboTimer.Name = "comboTimer";
            this.comboTimer.ShadowDecoration.Parent = this.comboTimer;
            this.comboTimer.Size = new System.Drawing.Size(154, 36);
            this.comboTimer.StartIndex = 0;
            this.comboTimer.TabIndex = 30;
            // 
            // UC_AddNewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.comboTimer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboUnits);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboSelectDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboSelectLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "UC_AddNewCourse";
            this.Size = new System.Drawing.Size(1021, 768);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox comboSelectLevel;
        private Guna.UI2.WinForms.Guna2ComboBox comboSelectDepartment;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtCourseCode;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtCourseTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnFinish;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2ComboBox comboTimer;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox comboUnits;
    }
}
