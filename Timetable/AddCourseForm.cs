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
            this.cancelButton.Focus();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            course = new Course();
            this.course.Name = nameTextBox.Text;
            this.course.Classroom = classroomTextBox.Text;
            this.course.NameColor = Color.Yellow;
            this.course.ClassroomColor = Color.Red;
            this.course.BackColor = Color.Blue;
        }
    }
}
