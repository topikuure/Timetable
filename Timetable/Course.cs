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
        public Color NameColor { get; set; } = Color.Black;
        public Color ClassroomColor { get; set; } = Color.Black;
        public Color BackColor { get; set; } = Color.White;

        public Course(string name)
        {
            this.Name = name;
        }
        public void AddLesson(Lesson lesson)
        {
            lessonList.Add(lesson);
        }
        public void removeLesson(Lesson lesson)
        {
            lessonList.Remove(lesson);
        }
    }
}
