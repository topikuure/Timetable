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
        public FlowLayoutPanel cellControl = new FlowLayoutPanel();
        public Label nameLabel = new Label();
        public Label classroomLabel = new Label();
        public int cellX;
        public int cellY;
        public int rowSpan;

        public Lesson(Course course, int cellX, int cellY, int rowSpan)
        {
            this.course = course;
            this.cellX = cellX;
            this.cellY = cellY;
            this.rowSpan = rowSpan;
            
            nameLabel.Text = course.Name;
            nameLabel.ForeColor = course.NameColor;
            
            classroomLabel.Text = course.Classroom;
            classroomLabel.ForeColor = course.ClassroomColor;

            cellControl.Margin = new Padding(0);
            cellControl.Padding = new Padding(0, 2, 0, 2);
            cellControl.FlowDirection = FlowDirection.TopDown;
            cellControl.Controls.Add(nameLabel);
            cellControl.Controls.Add(classroomLabel);
        }
    }
}
