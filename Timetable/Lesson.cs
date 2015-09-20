using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable
{
    public class Lesson
    {
        private Course course;
        private Label nameLabel = new Label();
        private Label classroomLabel = new Label();

        public string Classroom { get; set; }
        public FlowLayoutPanel CellControl { get; private set; } = new FlowLayoutPanel();
        public int CellX { get; set; }
        public int CellY { get; set; }
        public int RowSpan { get; set; }

        public Lesson(Course course, int cellX, int cellY, int rowSpan)
        {
            this.course = course;
            this.CellX = cellX;
            this.CellY = cellY;
            this.RowSpan = rowSpan;
            
            nameLabel.Text = course.Name;
            nameLabel.ForeColor = course.NameColor;

            this.Classroom = course.Classroom;
            classroomLabel.Text = this.Classroom;
            classroomLabel.ForeColor = course.ClassroomColor;

            CellControl.Margin = new Padding(0);
            CellControl.Padding = new Padding(0, 2, 0, 2);
            CellControl.FlowDirection = FlowDirection.TopDown;
            CellControl.Controls.Add(nameLabel);
            CellControl.Controls.Add(classroomLabel);
        }
    }
}
