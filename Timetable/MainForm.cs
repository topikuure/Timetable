using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.coursesListBox.DoDragDrop(this.coursesListBox.SelectedItem.ToString(), DragDropEffects.Move);
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

            //Vaihda labelin tilalle Course ja revi siitä nimi, luokka, värit yms.
            Label label = new Label();
            label.Text = (string)e.Data.GetData(typeof(string));

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
                if (this.timetableLayoutPanel.GetControlFromPosition(cellX, cellY) == null)
                    this.timetableLayoutPanel.Controls.Add(label, cellX, cellY);
            }
        }
    }
}
