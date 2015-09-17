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
        public Label label = new Label();
        public int cellX;
        public int cellY;
        public int rowSpan;

        public Lesson(Course course, int cellX, int cellY, int rowSpan)
        {
            this.course = course;
            this.cellX = cellX;
            this.cellY = cellY;
            this.rowSpan = rowSpan;
            
            label.Margin = new Padding(0);
            label.Dock = DockStyle.Fill;
            label.Text = course.Name + Environment.NewLine + course.Classroom;
            label.BackColor = course.BackColor;
            label.ForeColor = course.NameColor;
        }
    }
}
