
namespace CBT_Examination_System.Student_UC
{
    partial class uC_ViewResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uC_ViewResults));
            this.btnFinish = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridStudentResults = new System.Windows.Forms.DataGridView();
            this.comboSelectUnits = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSelectCourse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.elipseViewResults = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudentResults)).BeginInit();
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
            this.btnFinish.Location = new System.Drawing.Point(77, 659);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.ShadowDecoration.Parent = this.btnFinish;
            this.btnFinish.Size = new System.Drawing.Size(192, 45);
            this.btnFinish.TabIndex = 38;
            this.btnFinish.Text = "Finish";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click_1);
            // 
            // dataGridStudentResults
            // 
            this.dataGridStudentResults.AllowUserToAddRows = false;
            this.dataGridStudentResults.AllowUserToDeleteRows = false;
            this.dataGridStudentResults.AllowUserToOrderColumns = true;
            this.dataGridStudentResults.BackgroundColor = System.Drawing.Color.White;
            this.dataGridStudentResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudentResults.Location = new System.Drawing.Point(77, 259);
            this.dataGridStudentResults.Name = "dataGridStudentResults";
            this.dataGridStudentResults.RowHeadersWidth = 51;
            this.dataGridStudentResults.RowTemplate.Height = 24;
            this.dataGridStudentResults.Size = new System.Drawing.Size(863, 366);
            this.dataGridStudentResults.TabIndex = 37;
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
            this.comboSelectUnits.Location = new System.Drawing.Point(427, 118);
            this.comboSelectUnits.Name = "comboSelectUnits";
            this.comboSelectUnits.ShadowDecoration.Parent = this.comboSelectUnits;
            this.comboSelectUnits.Size = new System.Drawing.Size(365, 36);
            this.comboSelectUnits.StartIndex = 0;
            this.comboSelectUnits.TabIndex = 36;
            this.comboSelectUnits.SelectedIndexChanged += new System.EventHandler(this.comboSelectUnits_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(424, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Units";
            this.label3.UseMnemonic = false;
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
            this.comboSelectCourse.Items.AddRange(new object[] {
            "All"});
            this.comboSelectCourse.ItemsAppearance.Parent = this.comboSelectCourse;
            this.comboSelectCourse.Location = new System.Drawing.Point(77, 117);
            this.comboSelectCourse.Name = "comboSelectCourse";
            this.comboSelectCourse.ShadowDecoration.Parent = this.comboSelectCourse;
            this.comboSelectCourse.Size = new System.Drawing.Size(296, 36);
            this.comboSelectCourse.StartIndex = 0;
            this.comboSelectCourse.TabIndex = 34;
            this.comboSelectCourse.SelectedIndexChanged += new System.EventHandler(this.comboSelectCourse_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Course Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 36);
            this.label1.TabIndex = 32;
            this.label1.Text = "View Results";
            // 
            // elipseViewResults
            // 
            this.elipseViewResults.TargetControl = this;
            // 
            // uC_ViewResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.dataGridStudentResults);
            this.Controls.Add(this.comboSelectUnits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboSelectCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uC_ViewResults";
            this.Size = new System.Drawing.Size(1021, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudentResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnFinish;
        private System.Windows.Forms.DataGridView dataGridStudentResults;
        private Guna.UI2.WinForms.Guna2ComboBox comboSelectUnits;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox comboSelectCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse elipseViewResults;
    }
}
