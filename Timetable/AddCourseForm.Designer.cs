namespace Timetable
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.classroomLabel = new System.Windows.Forms.Label();
            this.backColorLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nameColorButton = new System.Windows.Forms.Button();
            this.classroomColorButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.classroomTextBox = new System.Windows.Forms.TextBox();
            this.backColorTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.classroomLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.backColorLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nameColorButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.classroomColorButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.classroomTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.backColorTextBox, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(79, 33);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nimi";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classroomLabel
            // 
            this.classroomLabel.AutoSize = true;
            this.classroomLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classroomLabel.Location = new System.Drawing.Point(3, 33);
            this.classroomLabel.Name = "classroomLabel";
            this.classroomLabel.Size = new System.Drawing.Size(79, 33);
            this.classroomLabel.TabIndex = 1;
            this.classroomLabel.Text = "Luokka";
            this.classroomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backColorLabel
            // 
            this.backColorLabel.AutoSize = true;
            this.backColorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backColorLabel.Location = new System.Drawing.Point(3, 66);
            this.backColorLabel.Name = "backColorLabel";
            this.backColorLabel.Size = new System.Drawing.Size(79, 34);
            this.backColorLabel.TabIndex = 2;
            this.backColorLabel.Text = "Taustan väri";
            this.backColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tallenna";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Peruuta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // nameColorButton
            // 
            this.nameColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameColorButton.Location = new System.Drawing.Point(173, 3);
            this.nameColorButton.Name = "nameColorButton";
            this.nameColorButton.Size = new System.Drawing.Size(24, 27);
            this.nameColorButton.TabIndex = 3;
            this.nameColorButton.UseVisualStyleBackColor = true;
            // 
            // classroomColorButton
            // 
            this.classroomColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classroomColorButton.Location = new System.Drawing.Point(173, 36);
            this.classroomColorButton.Name = "classroomColorButton";
            this.classroomColorButton.Size = new System.Drawing.Size(24, 27);
            this.classroomColorButton.TabIndex = 4;
            this.classroomColorButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(173, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 28);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(88, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(79, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // classroomTextBox
            // 
            this.classroomTextBox.Location = new System.Drawing.Point(88, 36);
            this.classroomTextBox.Name = "classroomTextBox";
            this.classroomTextBox.Size = new System.Drawing.Size(79, 20);
            this.classroomTextBox.TabIndex = 7;
            // 
            // backColorTextBox
            // 
            this.backColorTextBox.Location = new System.Drawing.Point(88, 69);
            this.backColorTextBox.Name = "backColorTextBox";
            this.backColorTextBox.Size = new System.Drawing.Size(79, 20);
            this.backColorTextBox.TabIndex = 8;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 188);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddCourseForm";
            this.Text = "Lisää Kurssi";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label classroomLabel;
        private System.Windows.Forms.Label backColorLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button nameColorButton;
        private System.Windows.Forms.Button classroomColorButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox classroomTextBox;
        private System.Windows.Forms.TextBox backColorTextBox;
    }
}