
namespace CBT_Examination_System.Student_UC
{
    partial class uC_BeginExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uC_BeginExam));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboSelectCourse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelExamTime = new System.Windows.Forms.Label();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.beginExamElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Clarendon BT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(213, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "EXAMINATION INSTRUCTIONS";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Slab", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(218, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(640, 357);
            this.label2.TabIndex = 14;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Clarendon BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(439, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Select Your Course";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(222, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(636, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "------";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(222, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(636, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "------";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.comboSelectCourse.Location = new System.Drawing.Point(446, 551);
            this.comboSelectCourse.Name = "comboSelectCourse";
            this.comboSelectCourse.ShadowDecoration.Parent = this.comboSelectCourse;
            this.comboSelectCourse.Size = new System.Drawing.Size(198, 36);
            this.comboSelectCourse.TabIndex = 28;
            this.comboSelectCourse.SelectedIndexChanged += new System.EventHandler(this.comboSelectCourse_SelectedIndexChanged);
            // 
            // labelExamTime
            // 
            this.labelExamTime.AutoSize = true;
            this.labelExamTime.BackColor = System.Drawing.Color.Transparent;
            this.labelExamTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExamTime.ForeColor = System.Drawing.Color.Red;
            this.labelExamTime.Location = new System.Drawing.Point(475, 667);
            this.labelExamTime.Name = "labelExamTime";
            this.labelExamTime.Size = new System.Drawing.Size(135, 32);
            this.labelExamTime.TabIndex = 29;
            this.labelExamTime.Text = "99:99:99";
            this.labelExamTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BorderRadius = 15;
            this.btnStart.BorderThickness = 1;
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStart.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnStart.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnStart.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.ImageSize = new System.Drawing.Size(25, 25);
            this.btnStart.Location = new System.Drawing.Point(449, 607);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(192, 45);
            this.btnStart.TabIndex = 32;
            this.btnStart.Text = "START";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // beginExamElipse
            // 
            this.beginExamElipse.TargetControl = this;
            // 
            // uC_BeginExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelExamTime);
            this.Controls.Add(this.comboSelectCourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "uC_BeginExam";
            this.Size = new System.Drawing.Size(1021, 768);
            this.Load += new System.EventHandler(this.BeginExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox comboSelectCourse;
        private System.Windows.Forms.Label labelExamTime;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2Elipse beginExamElipse;
    }
}
