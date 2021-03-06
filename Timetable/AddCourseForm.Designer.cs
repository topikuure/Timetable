﻿namespace Timetable
{
    partial class AddCourseForm
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
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.defaultClassroomLabel = new System.Windows.Forms.Label();
            this.defaultClassroomTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Location = new System.Drawing.Point(67, 22);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(69, 13);
            this.courseNameLabel.TabIndex = 0;
            this.courseNameLabel.Text = "Course name";
            this.courseNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(135, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(91, 20);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(151, 79);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(54, 79);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // defaultClassroomLabel
            // 
            this.defaultClassroomLabel.AutoSize = true;
            this.defaultClassroomLabel.Location = new System.Drawing.Point(45, 52);
            this.defaultClassroomLabel.Name = "defaultClassroomLabel";
            this.defaultClassroomLabel.Size = new System.Drawing.Size(91, 13);
            this.defaultClassroomLabel.TabIndex = 7;
            this.defaultClassroomLabel.Text = "Default classroom";
            this.defaultClassroomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // defaultClassroomTextBox
            // 
            this.defaultClassroomTextBox.Location = new System.Drawing.Point(135, 49);
            this.defaultClassroomTextBox.Name = "defaultClassroomTextBox";
            this.defaultClassroomTextBox.Size = new System.Drawing.Size(91, 20);
            this.defaultClassroomTextBox.TabIndex = 8;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 144);
            this.Controls.Add(this.defaultClassroomTextBox);
            this.Controls.Add(this.defaultClassroomLabel);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.saveButton);
            this.Name = "AddCourseForm";
            this.Text = "Add Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label defaultClassroomLabel;
        private System.Windows.Forms.TextBox defaultClassroomTextBox;
    }
}