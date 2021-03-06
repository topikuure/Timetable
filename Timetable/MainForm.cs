﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Timetable
{
    public partial class MainForm : Form
    {
        private List<Course> courseList = new List<Course>();

        public MainForm()
        {
            InitializeComponent();

            this.timetableLayoutPanel.BackColor = Settings.TimeTableBackColor;
            this.ChangeDayLabelColor(Settings.DayLabelColor);
            this.ChangeTimeLabelColor(Settings.TimeLabelColor);
        }

        public void AddCourse(Course course)
        {
            this.courseList.Add(course);
            this.coursesListBox.Items.Add(course.Name);
        }

        public void RemoveCourse(Course course)
        {
            for (int i = 0; i < course.LessonCount(); ++i)
            {
                //BUGI: Joskus tuhoaa vain osan tunneista
                this.timetableLayoutPanel.Controls.Remove(course.GetLesson(i).CellControl);
            }

            this.courseList.Remove(course);
            this.coursesListBox.Items.Remove(course.Name);
        }

        public void AddLesson(Lesson lesson)
        {
            lesson.Course.AddLesson(lesson);
            this.timetableLayoutPanel.SuspendLayout();
            this.timetableLayoutPanel.Controls.Add(lesson.CellControl, lesson.CellX, lesson.CellY);
            this.timetableLayoutPanel.SetRowSpan(lesson.CellControl, lesson.RowSpan);
            this.timetableLayoutPanel.ResumeLayout();
        }

        public void ChangeDayLabelColor(Color color)
        {
            this.mondayLabel.ForeColor = color;
            this.tuesdayLabel.ForeColor = color;
            this.wednesdayLabel.ForeColor = color;
            this.thursdayLabel.ForeColor = color;
            this.fridayLabel.ForeColor = color;
        }

        public void ChangeTimeLabelColor(Color color)
        {
            this.time1Label.ForeColor = color;
            this.time2Label.ForeColor = color;
            this.time3Label.ForeColor = color;
            this.time4Label.ForeColor = color;
            this.time5Label.ForeColor = color;
            this.time6Label.ForeColor = color;
            this.time7Label.ForeColor = color;
            this.time8Label.ForeColor = color;
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm(this.courseList);
            addCourseForm.ShowDialog(this);

            if (addCourseForm.DialogResult == DialogResult.OK)
            {
                    this.courseList.Add(addCourseForm.Course);
                    this.coursesListBox.Items.Add(addCourseForm.Course.Name);
            }
            addCourseForm.Dispose();
        }

        //Metodi ei tarkista onko kursorin alla valittu kurssi.
        //Vain courseLstBoxissa valitulla kurssilla on väliä.
        private void coursesListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.coursesListBox.Items.Count > 0 && this.coursesListBox.SelectedItem != null)
                {
                    Lesson lesson = new Lesson(courseList[this.coursesListBox.SelectedIndex], this.timetableLayoutPanel);
                    this.coursesListBox.DoDragDrop(lesson, DragDropEffects.Move);
                }
            }
            else if(e.Button == MouseButtons.Right)
            {
                this.coursesListBox.ContextMenuStrip.Show(this.coursesListBox.PointToScreen(new Point(e.X, e.Y)));
            }
        }

        private void timetableLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetData(typeof(Lesson)).GetType() == typeof(Lesson)) e.Effect = DragDropEffects.Move;
        }

        private void timetableLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            int cellX = 0, cellY = 0;
            int columnWidth = this.timetableLayoutPanel.GetColumnWidths()[1];
            int rowHeight = this.timetableLayoutPanel.GetRowHeights()[1];
            Point tableLocation = this.timetableLayoutPanel.Location;
            Point mouse = this.timetableLayoutPanel.PointToClient(new Point(e.X, e.Y));
            Lesson lesson = (Lesson)e.Data.GetData(typeof(Lesson));

            if (mouse.X > columnWidth && mouse.Y > rowHeight)
            {
                for (int i = 1; i <= this.timetableLayoutPanel.ColumnCount; ++i)
                {
                    if (mouse.X < i * columnWidth)
                    {
                        cellX = i - 1;
                        break;
                    }
                }
                for (int i = 1; i <= this.timetableLayoutPanel.RowCount - (lesson.RowSpan - 1); ++i)
                {
                    if (mouse.Y < i * rowHeight)
                    {
                        cellY = i - 1;
                        break;
                    }
                }
                bool cellTaken = false;

                for(int i = 0; i < lesson.RowSpan; ++i)
                {
                    if(this.timetableLayoutPanel.GetControlFromPosition(cellX, cellY + i) != null)
                    {
                        cellTaken = true;
                        break;
                    }
                }

                if (cellTaken == false)
                {
                    lesson.CellX = cellX;
                    lesson.CellY = cellY;
                    this.AddLesson(lesson);
                }
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.timetableLayoutPanel.Size.Width, this.timetableLayoutPanel.Size.Height);
            this.timetableLayoutPanel.DrawToBitmap(bitmap, this.timetableLayoutPanel.ClientRectangle);

            float scaleFactor, scaledWidth, scaledHeight;
            scaleFactor = e.Graphics.VisibleClipBounds.Size.Width / this.timetableLayoutPanel.Width;
            scaledHeight = scaleFactor * this.timetableLayoutPanel.Height;
            scaledWidth = scaleFactor * this.timetableLayoutPanel.Width;

            e.Graphics.DrawImage((Image)bitmap, new RectangleF(0, 0, scaledWidth, scaledHeight));
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.courseList.Count; ++i)
            {
                if (this.coursesListBox.SelectedItem != null)
                {
                    if (this.courseList[i].Name == this.coursesListBox.SelectedItem.ToString())
                        this.RemoveCourse(this.courseList[i]);
                }
            }
        }

        //Menustrip
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented");
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintDialog dialog = new PrintDialog();
            dialog.PrinterSettings = printDocument.PrinterSettings;

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                printDocument.Print();
            }
            dialog.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
