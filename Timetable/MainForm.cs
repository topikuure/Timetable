using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Timetable
{
    public partial class MainForm : Form
    {
        public ArrayList courseList = new ArrayList();

        public MainForm()
        {
            InitializeComponent();
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.ShowDialog(this);

            if(addCourseForm.DialogResult == DialogResult.OK)
            {
                courseList.Add(addCourseForm.course);
                coursesListBox.Items.Add(addCourseForm.course.Name);
            }
            addCourseForm.Dispose();
        }
    }
}
