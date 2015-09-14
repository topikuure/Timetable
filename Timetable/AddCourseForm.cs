using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable
{
    public partial class AddCourseForm : Form
    {
        public Course course;

        public AddCourseForm()
        {
            InitializeComponent();
            this.nameTextBox.Focus();
            //Tai:
            //this.cancelButton.Focus();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            course = new Course();
            this.course.Name = nameTextBox.Text;
            this.course.Classroom = classroomColorButton.Text;
            this.course.NameColor = Color.Black;
            this.course.ClassroomColor = Color.Red;
            this.course.BackColor = Color.Beige;
        }
    }
}
