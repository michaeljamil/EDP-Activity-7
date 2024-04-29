namespace Activity4EDP_Cervaño
{
    partial class update_students
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
            this.label1 = new System.Windows.Forms.Label();
            this.student_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.update_Selection = new System.Windows.Forms.ComboBox();
            this.update_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "UPDATE STUDENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // student_ID
            // 
            this.student_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.student_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_ID.Location = new System.Drawing.Point(64, 124);
            this.student_ID.Margin = new System.Windows.Forms.Padding(2);
            this.student_ID.Name = "student_ID";
            this.student_ID.Size = new System.Drawing.Size(247, 28);
            this.student_ID.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(149, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Student ID";
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.DeepPink;
            this.update_button.ForeColor = System.Drawing.Color.White;
            this.update_button.Location = new System.Drawing.Point(102, 278);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(174, 35);
            this.update_button.TabIndex = 55;
            this.update_button.Text = "UPDATE";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // update_Selection
            // 
            this.update_Selection.FormattingEnabled = true;
            this.update_Selection.Items.AddRange(new object[] {
            "Student Name",
            "Student Email",
            "Student Address",
            "Student Contact No."});
            this.update_Selection.Location = new System.Drawing.Point(90, 175);
            this.update_Selection.Name = "update_Selection";
            this.update_Selection.Size = new System.Drawing.Size(202, 21);
            this.update_Selection.TabIndex = 59;
            this.update_Selection.Text = "Select the column you want to update";
            this.update_Selection.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // update_Box
            // 
            this.update_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.update_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_Box.Location = new System.Drawing.Point(64, 235);
            this.update_Box.Margin = new System.Windows.Forms.Padding(2);
            this.update_Box.Name = "update_Box";
            this.update_Box.Size = new System.Drawing.Size(247, 28);
            this.update_Box.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "New Value";
            // 
            // update_students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(367, 369);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update_Box);
            this.Controls.Add(this.update_Selection);
            this.Controls.Add(this.student_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "update_students";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.update_students_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox student_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.ComboBox update_Selection;
        private System.Windows.Forms.TextBox update_Box;
        private System.Windows.Forms.Label label2;
    }
}