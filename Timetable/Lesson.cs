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
        private TextBox classroomTextBox = new TextBox();

        public string Classroom
        {
            get
            {
                return classroomTextBox.Text;
            }
            set
            {
                classroomTextBox.Text = value;
            }
        }
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
            nameLabel.BackColor = course.BackColor;
            nameLabel.Margin = new Padding(0);

            classroomTextBox.MaxLength = 11;//Vai pitkillä sanoilla perään ... ?
            classroomTextBox.BorderStyle = BorderStyle.None;
            classroomTextBox.ForeColor = course.ClassroomColor;
            classroomTextBox.BackColor = course.BackColor;
            classroomTextBox.Margin = new Padding(3, 0, 0, 0);
            classroomTextBox.LostFocus += new EventHandler(this.classroomTextBox_LostFocus);

            CellControl.BackColor = course.BackColor;
            CellControl.Margin = new Padding(0);
            CellControl.Padding = new Padding(4);
            CellControl.FlowDirection = FlowDirection.TopDown;
            CellControl.Controls.Add(nameLabel);
            CellControl.Controls.Add(classroomTextBox);
        }
        private void classroomTextBox_LostFocus(object sender, EventArgs e)
        {
            //Kysy käyttäjältä muutetaanko kaikkien kurssin tuntien luokat
        }
    }
}
