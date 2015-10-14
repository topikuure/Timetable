using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Timetable
{
    static class Settings
    {
        public static Color TimeTableBackColor { get; set; } = Color.White;

        public static Color DayLabelColor { get; set; } = Color.Black;
        public static Color TimeLabelColor { get; set; } = Color.Black;

        public static Color LessonBackColor { get; set; } = Color.White;
        public static Color LessonNameColor { get; set; } = Color.Black;
        public static Color LessonClassroomColor { get; set; } = Color.Red;

        public static int RowSpan { get; set; } = 2;
    }
}
