using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable
{
    public class Lesson
    {
        private Course course;
        public int CellX { get; set; }
        public int CellY { get; set; }
        public int RowSpan { get; set; }

        public Lesson(Course course, int cellX, int cellY, int rowSpan = 1)
        {
            this.course = course;
            this.CellX = cellX;
            this.CellY = cellY;
            this.RowSpan = rowSpan;
        }
    }
}
