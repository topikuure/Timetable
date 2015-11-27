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
        public string DefaultClassroom { get; set; }
        public Color NameColor { get; set; } = Settings.LessonNameColor;
        public Color ClassroomColor { get; set; } = Settings.LessonClassroomColor;
        public Color BackColor { get; set; } = Settings.LessonBackColor;

        public Course(string name, string defaultClassroom = null)
        {
            this.Name = name;
            this.DefaultClassroom = defaultClassroom;
        }
        public void AddLesson(Lesson lesson)
        {
            this.lessonList.Add(lesson);
        }
        public void RemoveLesson(Lesson lesson)
        {
            this.lessonList.Remove(lesson);
        }
        public void ClearLessons()
        {
            this.lessonList.Clear();
        }
        public Lesson GetLesson(int index)
        {
            return this.lessonList[index];
        }
        public int LessonCount()
        {
            return this.lessonList.Count;
        }
    }
}
