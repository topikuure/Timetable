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
        public Color NameColor { get; set; } = Settings.LessonNameColor;
        public Color ClassroomColor { get; set; } = Settings.LessonClassroomColor;
        public Color BackColor { get; set; } = Settings.LessonBackColor;

        public Course(string name)
        {
            this.Name = name;
        }
        public void AddLesson(Lesson lesson)
        {
            lessonList.Add(lesson);
        }
        public void RemoveLesson(Lesson lesson)
        {
            lessonList.Remove(lesson);
        }
    }
}
