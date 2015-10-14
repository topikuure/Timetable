namespace Timetable
{
    partial class MainForm
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
            this.timetableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mondayLabel = new System.Windows.Forms.Label();
            this.tuesdayLabel = new System.Windows.Forms.Label();
            this.wednesdayLabel = new System.Windows.Forms.Label();
            this.thursdayLabel = new System.Windows.Forms.Label();
            this.fridayLabel = new System.Windows.Forms.Label();
            this.time1Label = new System.Windows.Forms.Label();
            this.time2Label = new System.Windows.Forms.Label();
            this.time3Label = new System.Windows.Forms.Label();
            this.time4Label = new System.Windows.Forms.Label();
            this.time5Label = new System.Windows.Forms.Label();
            this.time6Label = new System.Windows.Forms.Label();
            this.time7Label = new System.Windows.Forms.Label();
            this.time8Label = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseManagerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.coursesListBox = new System.Windows.Forms.ListBox();
            this.timetableLayoutPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.courseManagerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timetableLayoutPanel
            // 
            this.timetableLayoutPanel.AllowDrop = true;
            this.timetableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.timetableLayoutPanel.ColumnCount = 6;
            this.timetableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.timetableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.timetableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.timetableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.timetableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.timetableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.timetableLayoutPanel.Controls.Add(this.mondayLabel, 1, 0);
            this.timetableLayoutPanel.Controls.Add(this.tuesdayLabel, 2, 0);
            this.timetableLayoutPanel.Controls.Add(this.wednesdayLabel, 3, 0);
            this.timetableLayoutPanel.Controls.Add(this.thursdayLabel, 4, 0);
            this.timetableLayoutPanel.Controls.Add(this.fridayLabel, 5, 0);
            this.timetableLayoutPanel.Controls.Add(this.time1Label, 0, 1);
            this.timetableLayoutPanel.Controls.Add(this.time2Label, 0, 2);
            this.timetableLayoutPanel.Controls.Add(this.time3Label, 0, 3);
            this.timetableLayoutPanel.Controls.Add(this.time4Label, 0, 4);
            this.timetableLayoutPanel.Controls.Add(this.time5Label, 0, 5);
            this.timetableLayoutPanel.Controls.Add(this.time6Label, 0, 6);
            this.timetableLayoutPanel.Controls.Add(this.time7Label, 0, 7);
            this.timetableLayoutPanel.Controls.Add(this.time8Label, 0, 8);
            this.timetableLayoutPanel.Location = new System.Drawing.Point(204, 39);
            this.timetableLayoutPanel.Name = "timetableLayoutPanel";
            this.timetableLayoutPanel.RowCount = 9;
            this.timetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.timetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.timetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.timetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.timetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.timetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.timetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.timetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.timetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.timetableLayoutPanel.Size = new System.Drawing.Size(523, 392);
            this.timetableLayoutPanel.TabIndex = 0;
            this.timetableLayoutPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.timetableLayoutPanel_DragDrop);
            this.timetableLayoutPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.timetableLayoutPanel_DragEnter);
            // 
            // mondayLabel
            // 
            this.mondayLabel.AutoSize = true;
            this.mondayLabel.Location = new System.Drawing.Point(90, 1);
            this.mondayLabel.Name = "mondayLabel";
            this.mondayLabel.Size = new System.Drawing.Size(23, 13);
            this.mondayLabel.TabIndex = 0;
            this.mondayLabel.Text = "MA";
            // 
            // tuesdayLabel
            // 
            this.tuesdayLabel.AutoSize = true;
            this.tuesdayLabel.Location = new System.Drawing.Point(176, 1);
            this.tuesdayLabel.Name = "tuesdayLabel";
            this.tuesdayLabel.Size = new System.Drawing.Size(17, 13);
            this.tuesdayLabel.TabIndex = 1;
            this.tuesdayLabel.Text = "TI";
            // 
            // wednesdayLabel
            // 
            this.wednesdayLabel.AutoSize = true;
            this.wednesdayLabel.Location = new System.Drawing.Point(262, 1);
            this.wednesdayLabel.Name = "wednesdayLabel";
            this.wednesdayLabel.Size = new System.Drawing.Size(21, 13);
            this.wednesdayLabel.TabIndex = 2;
            this.wednesdayLabel.Text = "KE";
            // 
            // thursdayLabel
            // 
            this.thursdayLabel.AutoSize = true;
            this.thursdayLabel.Location = new System.Drawing.Point(348, 1);
            this.thursdayLabel.Name = "thursdayLabel";
            this.thursdayLabel.Size = new System.Drawing.Size(22, 13);
            this.thursdayLabel.TabIndex = 3;
            this.thursdayLabel.Text = "TO";
            // 
            // fridayLabel
            // 
            this.fridayLabel.AutoSize = true;
            this.fridayLabel.Location = new System.Drawing.Point(434, 1);
            this.fridayLabel.Name = "fridayLabel";
            this.fridayLabel.Size = new System.Drawing.Size(21, 13);
            this.fridayLabel.TabIndex = 4;
            this.fridayLabel.Text = "PE";
            // 
            // time1Label
            // 
            this.time1Label.AutoSize = true;
            this.time1Label.Location = new System.Drawing.Point(4, 44);
            this.time1Label.Name = "time1Label";
            this.time1Label.Size = new System.Drawing.Size(28, 13);
            this.time1Label.TabIndex = 5;
            this.time1Label.Text = "8:15";
            // 
            // time2Label
            // 
            this.time2Label.AutoSize = true;
            this.time2Label.Location = new System.Drawing.Point(4, 87);
            this.time2Label.Name = "time2Label";
            this.time2Label.Size = new System.Drawing.Size(28, 13);
            this.time2Label.TabIndex = 6;
            this.time2Label.Text = "9:15";
            // 
            // time3Label
            // 
            this.time3Label.AutoSize = true;
            this.time3Label.Location = new System.Drawing.Point(4, 130);
            this.time3Label.Name = "time3Label";
            this.time3Label.Size = new System.Drawing.Size(34, 13);
            this.time3Label.TabIndex = 7;
            this.time3Label.Text = "10:15";
            // 
            // time4Label
            // 
            this.time4Label.AutoSize = true;
            this.time4Label.Location = new System.Drawing.Point(4, 173);
            this.time4Label.Name = "time4Label";
            this.time4Label.Size = new System.Drawing.Size(34, 13);
            this.time4Label.TabIndex = 8;
            this.time4Label.Text = "11:15";
            // 
            // time5Label
            // 
            this.time5Label.AutoSize = true;
            this.time5Label.Location = new System.Drawing.Point(4, 216);
            this.time5Label.Name = "time5Label";
            this.time5Label.Size = new System.Drawing.Size(34, 13);
            this.time5Label.TabIndex = 9;
            this.time5Label.Text = "12:15";
            // 
            // time6Label
            // 
            this.time6Label.AutoSize = true;
            this.time6Label.Location = new System.Drawing.Point(4, 259);
            this.time6Label.Name = "time6Label";
            this.time6Label.Size = new System.Drawing.Size(34, 13);
            this.time6Label.TabIndex = 10;
            this.time6Label.Text = "13:15";
            // 
            // time7Label
            // 
            this.time7Label.AutoSize = true;
            this.time7Label.Location = new System.Drawing.Point(4, 302);
            this.time7Label.Name = "time7Label";
            this.time7Label.Size = new System.Drawing.Size(34, 13);
            this.time7Label.TabIndex = 11;
            this.time7Label.Text = "14:15";
            // 
            // time8Label
            // 
            this.time8Label.AutoSize = true;
            this.time8Label.Location = new System.Drawing.Point(4, 345);
            this.time8Label.Name = "time8Label";
            this.time8Label.Size = new System.Drawing.Size(34, 13);
            this.time8Label.TabIndex = 12;
            this.time8Label.Text = "15:15";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(739, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.FileToolStripMenuItem.Text = "Tiedosto";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.newToolStripMenuItem.Text = "Uusi";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.openToolStripMenuItem.Text = "Avaa";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.saveToolStripMenuItem.Text = "Tallenna";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.printToolStripMenuItem.Text = "Tulosta";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.exitToolStripMenuItem.Text = "Poistu";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // courseManagerPanel
            // 
            this.courseManagerPanel.ColumnCount = 1;
            this.courseManagerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.courseManagerPanel.Controls.Add(this.addCourseButton, 0, 0);
            this.courseManagerPanel.Controls.Add(this.coursesListBox, 0, 1);
            this.courseManagerPanel.Location = new System.Drawing.Point(0, 40);
            this.courseManagerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.courseManagerPanel.Name = "courseManagerPanel";
            this.courseManagerPanel.RowCount = 2;
            this.courseManagerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.courseManagerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.88889F));
            this.courseManagerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.courseManagerPanel.Size = new System.Drawing.Size(200, 391);
            this.courseManagerPanel.TabIndex = 2;
            // 
            // addCourseButton
            // 
            this.addCourseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCourseButton.Location = new System.Drawing.Point(5, 5);
            this.addCourseButton.Margin = new System.Windows.Forms.Padding(5);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(190, 33);
            this.addCourseButton.TabIndex = 0;
            this.addCourseButton.Text = "Lisää kurssi";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // coursesListBox
            // 
            this.coursesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coursesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesListBox.FormattingEnabled = true;
            this.coursesListBox.ItemHeight = 16;
            this.coursesListBox.Location = new System.Drawing.Point(3, 46);
            this.coursesListBox.MultiColumn = true;
            this.coursesListBox.Name = "coursesListBox";
            this.coursesListBox.Size = new System.Drawing.Size(194, 342);
            this.coursesListBox.TabIndex = 1;
            this.coursesListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.coursesListBox_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 443);
            this.Controls.Add(this.courseManagerPanel);
            this.Controls.Add(this.timetableLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Lukujärjestys";
            this.timetableLayoutPanel.ResumeLayout(false);
            this.timetableLayoutPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.courseManagerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel timetableLayoutPanel;
        private System.Windows.Forms.Label mondayLabel;
        private System.Windows.Forms.Label tuesdayLabel;
        private System.Windows.Forms.Label wednesdayLabel;
        private System.Windows.Forms.Label thursdayLabel;
        private System.Windows.Forms.Label fridayLabel;
        private System.Windows.Forms.Label time1Label;
        private System.Windows.Forms.Label time2Label;
        private System.Windows.Forms.Label time3Label;
        private System.Windows.Forms.Label time4Label;
        private System.Windows.Forms.Label time5Label;
        private System.Windows.Forms.Label time6Label;
        private System.Windows.Forms.Label time7Label;
        private System.Windows.Forms.Label time8Label;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel courseManagerPanel;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.ListBox coursesListBox;
    }
}

