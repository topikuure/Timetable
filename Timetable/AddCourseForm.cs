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
        public Course course = null;

        public AddCourseForm()
        {
            InitializeComponent();
            this.nameTextBox.Select();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            course = new Course(this.nameTextBox.Text, this.defaultClassroomTextBox.Text);
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter) this.AcceptButton.PerformClick();
        }
    }
}
