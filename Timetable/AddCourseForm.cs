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
    /*
    Course-fieldiin asetetaan lomakkeella täytetyn kurssin tiedot.
    Tietoja ei palauteta suoraan vaan kutsuvan metodin pitää noutaa ne Save-napin
    painalluksen jälkeen ( newCourse = addCourseForm.Course ).
    */
    public partial class AddCourseForm : Form
    {
        private List<Course> courseList = null;
        public Course Course { get; private set; } = null;

        public AddCourseForm(List<Course> courseList)
        {
            InitializeComponent();
            this.courseList = courseList;
            this.nameTextBox.Select();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < this.courseList.Count; ++i)
            {
                //Whitespacea ei oteta huomioon. "Kurssi" ja "Kurssi  " ovat siis eri nimisiä.
                if(this.courseList[i].Name.Equals(this.nameTextBox.Text))
                {
                    this.DialogResult = DialogResult.None;
                    MessageBox.Show(this, "Course " + this.nameTextBox.Text + " already exists", "Error");
                }
            }
            if (String.IsNullOrWhiteSpace(this.nameTextBox.Text))
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show(this, "Give the course a name", "Error");
            }
            else Course = new Course(this.nameTextBox.Text, this.defaultClassroomTextBox.Text);
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter) this.AcceptButton.PerformClick();
        }
    }
}
