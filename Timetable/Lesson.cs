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
        public Course Course
        {
            get
            {
                return course;
            }
            private set
            {
                course = value;
            }
        }
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

        public Lesson(Course course)
        {
            this.Course = course;

            this.nameLabel.Text = course.Name;
            this.nameLabel.ForeColor = course.NameColor;
            this.nameLabel.BackColor = course.BackColor;
            this.nameLabel.Margin = new Padding(0);

            this.classroomTextBox.MaxLength = 11;//Vai pitkillä sanoilla perään ... ?
            this.classroomTextBox.BorderStyle = BorderStyle.None;
            this.classroomTextBox.ForeColor = course.ClassroomColor;
            this.classroomTextBox.BackColor = course.BackColor;
            this.classroomTextBox.Margin = new Padding(3, 0, 0, 0);
            this.classroomTextBox.LostFocus += new EventHandler(this.classroomTextBox_LostFocus);

            this.CellControl.BackColor = course.BackColor;
            this.CellControl.Margin = new Padding(0);
            this.CellControl.Padding = new Padding(4);
            this.CellControl.FlowDirection = FlowDirection.TopDown;
            this.CellControl.MouseDown += CellControl_MouseDown;
            this.CellControl.Controls.Add(nameLabel);
            this.CellControl.Controls.Add(classroomTextBox);
        }

        private void CellControl_MouseDown(object sender, MouseEventArgs e)
        {
            this.CellControl.DoDragDrop(this, DragDropEffects.Move);
        }

        private void classroomTextBox_LostFocus(object sender, EventArgs e)
        {
            //Kysy käyttäjältä muutetaanko kaikkien kurssin tuntien luokat
        }
    }
}
