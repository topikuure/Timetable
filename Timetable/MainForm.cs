using System;
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
        public static int TimeTableRowCount { get; set; }
        public static int TimeTableColumnCount { get; set; }

        public List<Course> courseList = new List<Course>();

        public MainForm()
        {
            InitializeComponent();
            TimeTableRowCount = this.timetableLayoutPanel.RowCount;
            TimeTableColumnCount = this.timetableLayoutPanel.ColumnCount;

            //Testi
            Course course = new Course("Kurssi");
            course.NameColor = Color.Black;
            course.BackColor = Color.Khaki;
            course.ClassroomColor = Color.IndianRed;
            courseList.Add(course);
            coursesListBox.Items.Add(course.Name);
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.ShowDialog(this);

            if(addCourseForm.DialogResult == DialogResult.OK)
            {
                courseList.Add(addCourseForm.course);
                coursesListBox.Items.Add(addCourseForm.course.Name);
            }
            addCourseForm.Dispose();
        }

        private void coursesListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.coursesListBox.Items.Count > 0 && this.coursesListBox.SelectedItem != null)
            {
                Lesson lesson = new Lesson(courseList[this.coursesListBox.SelectedIndex], this.timetableLayoutPanel);
                this.coursesListBox.DoDragDrop(lesson, DragDropEffects.Move);
            }
        }

        private void timetableLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            //Tarkista onko hyväksyttävä objekti
            e.Effect = DragDropEffects.Move;
        }

        private void timetableLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            int cellX = 0, cellY = 0;
            int columnWidth = this.timetableLayoutPanel.GetColumnWidths()[1];
            int rowHeight = this.timetableLayoutPanel.GetRowHeights()[1];
            Point tableLocation = this.timetableLayoutPanel.Location;
            Point mouse = this.timetableLayoutPanel.PointToClient(new Point(e.X, e.Y));

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
                for (int i = 1; i <= this.timetableLayoutPanel.RowCount; ++i)
                {
                    if (mouse.Y < i * rowHeight)
                    {
                        cellY = i - 1;
                        break;
                    }
                }
                bool cellTaken = false;

                if (this.timetableLayoutPanel.GetControlFromPosition(cellX, cellY) != null)
                    cellTaken = true;
                //defaultrowspannin tilalle lesson.rowspan.
                else if (this.timetableLayoutPanel.GetControlFromPosition(cellX, cellY + (Settings.DefaultRowSpan - 1)) != null)
                    cellTaken = true;

                if (cellTaken == false)
                {
                    Lesson lesson = (Lesson)e.Data.GetData(typeof(Lesson));
                    lesson.CellX = cellX;
                    lesson.CellY = cellY;

                    lesson.Course.AddLesson(lesson);
                    this.timetableLayoutPanel.Controls.Add(lesson.CellControl, cellX, cellY);
                    this.timetableLayoutPanel.SetRowSpan(lesson.CellControl, lesson.RowSpan);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.timetableLayoutPanel.Size.Width, this.timetableLayoutPanel.Size.Height);
            this.timetableLayoutPanel.DrawToBitmap(bitmap, this.timetableLayoutPanel.ClientRectangle);

            //EI TOIMI
            float scaleFactor, scaledWidth, scaledHeight;
            scaleFactor = e.Graphics.VisibleClipBounds.Size.Width / this.timetableLayoutPanel.Width;
            scaledHeight = scaleFactor * this.timetableLayoutPanel.Height;
            scaledWidth = scaleFactor * this.timetableLayoutPanel.Width;

            e.Graphics.DrawImage((Image)bitmap, new RectangleF(0, 0, scaledWidth, scaledHeight));
        }
    }
}
