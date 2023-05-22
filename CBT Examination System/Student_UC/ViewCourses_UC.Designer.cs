
namespace CBT_Examination_System.Student_UC
{
    partial class ViewCourses_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCourses_UC));
            this.btnFinish = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridStudentCourses = new System.Windows.Forms.DataGridView();
            this.comboSelectUnits = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSelectLecturer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.elipseViewCourses = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudentCourses)).BeginInit();
            this.SuspendLayout();
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
            this.btnFinish.Location = new System.Drawing.Point(82, 674);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.ShadowDecoration.Parent = this.btnFinish;
            this.btnFinish.Size = new System.Drawing.Size(192, 45);
            this.btnFinish.TabIndex = 31;
            this.btnFinish.Text = "Finish";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // dataGridStudentCourses
            // 
            this.dataGridStudentCourses.AllowUserToAddRows = false;
            this.dataGridStudentCourses.AllowUserToDeleteRows = false;
            this.dataGridStudentCourses.AllowUserToOrderColumns = true;
            this.dataGridStudentCourses.BackgroundColor = System.Drawing.Color.White;
            this.dataGridStudentCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudentCourses.Location = new System.Drawing.Point(82, 274);
            this.dataGridStudentCourses.Name = "dataGridStudentCourses";
            this.dataGridStudentCourses.RowHeadersWidth = 51;
            this.dataGridStudentCourses.RowTemplate.Height = 24;
            this.dataGridStudentCourses.Size = new System.Drawing.Size(863, 366);
            this.dataGridStudentCourses.TabIndex = 30;
            // 
            // comboSelectUnits
            // 
            this.comboSelectUnits.BackColor = System.Drawing.Color.Transparent;
            this.comboSelectUnits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSelectUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSelectUnits.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSelectUnits.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSelectUnits.FocusedState.Parent = this.comboSelectUnits;
            this.comboSelectUnits.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboSelectUnits.ForeColor = System.Drawing.Color.Black;
            this.comboSelectUnits.HoverState.Parent = this.comboSelectUnits;
            this.comboSelectUnits.ItemHeight = 30;
            this.comboSelectUnits.Items.AddRange(new object[] {
            "All"});
            this.comboSelectUnits.ItemsAppearance.Parent = this.comboSelectUnits;
            this.comboSelectUnits.Location = new System.Drawing.Point(432, 133);
            this.comboSelectUnits.Name = "comboSelectUnits";
            this.comboSelectUnits.ShadowDecoration.Parent = this.comboSelectUnits;
            this.comboSelectUnits.Size = new System.Drawing.Size(365, 36);
            this.comboSelectUnits.StartIndex = 0;
            this.comboSelectUnits.TabIndex = 29;
            this.comboSelectUnits.SelectedIndexChanged += new System.EventHandler(this.comboSelectUnits_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(429, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Units";
            this.label3.UseMnemonic = false;
            // 
            // comboSelectLecturer
            // 
            this.comboSelectLecturer.BackColor = System.Drawing.Color.Transparent;
            this.comboSelectLecturer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSelectLecturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSelectLecturer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSelectLecturer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSelectLecturer.FocusedState.Parent = this.comboSelectLecturer;
            this.comboSelectLecturer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboSelectLecturer.ForeColor = System.Drawing.Color.Black;
            this.comboSelectLecturer.HoverState.Parent = this.comboSelectLecturer;
            this.comboSelectLecturer.ItemHeight = 30;
            this.comboSelectLecturer.Items.AddRange(new object[] {
            "All"});
            this.comboSelectLecturer.ItemsAppearance.Parent = this.comboSelectLecturer;
            this.comboSelectLecturer.Location = new System.Drawing.Point(82, 132);
            this.comboSelectLecturer.Name = "comboSelectLecturer";
            this.comboSelectLecturer.ShadowDecoration.Parent = this.comboSelectLecturer;
            this.comboSelectLecturer.Size = new System.Drawing.Size(296, 36);
            this.comboSelectLecturer.StartIndex = 0;
            this.comboSelectLecturer.TabIndex = 27;
            this.comboSelectLecturer.SelectedIndexChanged += new System.EventHandler(this.comboSeelectLecturer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Lecturer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "View Courses";
            // 
            // elipseViewCourses
            // 
            this.elipseViewCourses.TargetControl = this;
            // 
            // ViewCourses_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.dataGridStudentCourses);
            this.Controls.Add(this.comboSelectUnits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboSelectLecturer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ViewCourses_UC";
            this.Size = new System.Drawing.Size(1021, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudentCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnFinish;
        private System.Windows.Forms.DataGridView dataGridStudentCourses;
        private Guna.UI2.WinForms.Guna2ComboBox comboSelectUnits;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox comboSelectLecturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse elipseViewCourses;
    }
}
