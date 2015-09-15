using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Timetable
{
    public class Course
    {
        private List<Lesson> lessonList = new List<Lesson>();
        public string Name { get; set; }
        public string Classroom { get; set; }
        public Color NameColor { get; set; }
        public Color ClassroomColor { get; set; }
        public Color BackColor { get; set; }

        public void AddLesson(int cellX, int cellY, int rowSpan = 1)
        {
            lessonList.Add(new Lesson(this, cellX, cellY, rowSpan));
        }
    }
}
