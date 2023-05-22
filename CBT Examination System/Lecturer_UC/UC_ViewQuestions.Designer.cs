
namespace CBT_Examination_System.Lecturer_UC
{
    partial class UC_ViewQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ViewQuestions));
            this.comboBoxDept = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinish = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridExamQuestions = new System.Windows.Forms.DataGridView();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.elipseViewQuestions = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCourse = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExamQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxDept.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDept.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxDept.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxDept.FocusedState.Parent = this.comboBoxDept;
            this.comboBoxDept.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxDept.ForeColor = System.Drawing.Color.Black;
            this.comboBoxDept.HoverState.Parent = this.comboBoxDept;
            this.comboBoxDept.ItemHeight = 30;
            this.comboBoxDept.Items.AddRange(new object[] {
            "All",
            "Computer Science",
            "Computer Engineering",
            "Business Adminstration",
            "Accounting",
            "Microbiology",
            "Biochemistry",
            "Electrical Engineering",
            "Mechanical Engineering"});
            this.comboBoxDept.ItemsAppearance.Parent = this.comboBoxDept;
            this.comboBoxDept.Location = new System.Drawing.Point(53, 126);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.ShadowDecoration.Parent = this.comboBoxDept;
            this.comboBoxDept.Size = new System.Drawing.Size(301, 36);
            this.comboBoxDept.StartIndex = 0;
            this.comboBoxDept.TabIndex = 24;
            this.comboBoxDept.SelectedIndexChanged += new System.EventHandler(this.comboBoxDept_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Department";
            this.label3.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "View Exam Questions";
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Transparent;
            this.btnFinish.BorderRadius = 15;
            this.btnFinish.BorderThickness = 1;
            this.btnFinish.CheckedState.Parent = this.btnFinish;
            this.btnFinish.CustomImages.Parent = this.btnFinish;
            this.btnFinish.FillColor = System.Drawing.Color.Navy;
            this.btnFinish.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.HoverState.FillColor = System.Drawing.Color.White;
            this.btnFinish.HoverState.ForeColor = System.Drawing.Color.Navy;
            this.btnFinish.HoverState.Parent = this.btnFinish;
            this.btnFinish.ImageSize = new System.Drawing.Size(25, 25);
            this.btnFinish.Location = new System.Drawing.Point(53, 657);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.ShadowDecoration.Parent = this.btnFinish;
            this.btnFinish.Size = new System.Drawing.Size(192, 45);
            this.btnFinish.TabIndex = 27;
            this.btnFinish.Text = "Finish";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // dataGridExamQuestions
            // 
            this.dataGridExamQuestions.AllowUserToAddRows = false;
            this.dataGridExamQuestions.AllowUserToDeleteRows = false;
            this.dataGridExamQuestions.AllowUserToOrderColumns = true;
            this.dataGridExamQuestions.BackgroundColor = System.Drawing.Color.White;
            this.dataGridExamQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExamQuestions.Location = new System.Drawing.Point(53, 217);
            this.dataGridExamQuestions.Name = "dataGridExamQuestions";
            this.dataGridExamQuestions.RowHeadersWidth = 51;
            this.dataGridExamQuestions.RowTemplate.Height = 24;
            this.dataGridExamQuestions.Size = new System.Drawing.Size(904, 412);
            this.dataGridExamQuestions.TabIndex = 26;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 18;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDelete.Location = new System.Drawing.Point(777, 657);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(180, 45);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // elipseViewQuestions
            // 
            this.elipseViewQuestions.TargetControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(408, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Course";
            this.label4.UseMnemonic = false;
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourse.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxCourse.FocusedState.Parent = this.comboBoxCourse;
            this.comboBoxCourse.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxCourse.ForeColor = System.Drawing.Color.Black;
            this.comboBoxCourse.HoverState.Parent = this.comboBoxCourse;
            this.comboBoxCourse.ItemHeight = 30;
            this.comboBoxCourse.Items.AddRange(new object[] {
            "All"});
            this.comboBoxCourse.ItemsAppearance.Parent = this.comboBoxCourse;
            this.comboBoxCourse.Location = new System.Drawing.Point(413, 126);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.ShadowDecoration.Parent = this.comboBoxCourse;
            this.comboBoxCourse.Size = new System.Drawing.Size(231, 36);
            this.comboBoxCourse.StartIndex = 0;
            this.comboBoxCourse.TabIndex = 29;
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            // 
            // UC_ViewQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.dataGridExamQuestions);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.comboBoxDept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UC_ViewQuestions";
            this.Size = new System.Drawing.Size(1021, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExamQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox comboBoxDept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnFinish;
        private System.Windows.Forms.DataGridView dataGridExamQuestions;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Elipse elipseViewQuestions;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxCourse;
    }
}
