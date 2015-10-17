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
        private ContextMenuStrip CellControlContextMenuStrip = new ContextMenuStrip();
        private ToolStripMenuItem removeToolStripMenuItem = new ToolStripMenuItem("Poista");
        private TableLayoutPanel tableLayoutPanel;
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
        public int RowSpan { get; set; } = Settings.RowSpan;

        public Lesson(Course course, TableLayoutPanel tableLayoutPanel)
        {
            this.Course = course;
            this.tableLayoutPanel = tableLayoutPanel;

            this.nameLabel.AutoSize = true;
            this.nameLabel.Text = course.Name;
            this.nameLabel.ForeColor = course.NameColor;
            this.nameLabel.BackColor = course.BackColor;
            this.nameLabel.Margin = new Padding(0);
            this.nameLabel.MouseDown += NameLabel_MouseDown;

            this.classroomTextBox.MaxLength = 11;
            this.classroomTextBox.BorderStyle = BorderStyle.None;
            this.classroomTextBox.ForeColor = course.ClassroomColor;
            this.classroomTextBox.BackColor = course.BackColor;
            this.classroomTextBox.Margin = new Padding(3, 0, 0, 0);
            this.classroomTextBox.LostFocus += new EventHandler(this.classroomTextBox_LostFocus);

            this.CellControl.WrapContents = false;
            this.CellControl.FlowDirection = FlowDirection.TopDown;
            this.CellControl.Dock = DockStyle.Fill;
            this.CellControl.BackColor = course.BackColor;
            this.CellControl.Margin = new Padding(0);
            this.CellControl.Padding = new Padding(0);
            this.CellControl.MouseDown += CellControl_MouseDown;
            this.CellControl.MouseWheel += CellControl_MouseWheel;

            this.CellControl.Controls.Add(nameLabel);
            this.CellControl.Controls.Add(classroomTextBox);

            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.removeToolStripMenuItem.MouseDown += RemoveToolStripMenuItem_MouseDown;

            this.CellControlContextMenuStrip.Items.Add(this.removeToolStripMenuItem);
            this.CellControl.ContextMenuStrip = this.CellControlContextMenuStrip;
        }

        private void RemoveToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            this.course.RemoveLesson(this);
            this.tableLayoutPanel.Controls.Remove(this.CellControl);
        }

        private void CellControl_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta >= 120)
            {
                if (this.RowSpan > 1)
                {
                    --this.RowSpan;
                    this.tableLayoutPanel.SetRowSpan(this.CellControl, this.RowSpan);
                }
            }
            else if(e.Delta <= 120)
            {
                if (this.CellY + this.RowSpan < this.tableLayoutPanel.RowCount)
                {
                    ++this.RowSpan;
                    this.tableLayoutPanel.SetRowSpan(this.CellControl, this.RowSpan);
                }
            }
        }

        private void CellControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.course.RemoveLesson(this);
                this.CellControl.DoDragDrop(this, DragDropEffects.Move);
            }
            else if(e.Button == MouseButtons.Right)
            {
                this.CellControlContextMenuStrip.Show(e.X, e.Y);
            }
        }

        private void NameLabel_MouseDown(object sender, MouseEventArgs e)
        {
            this.CellControl_MouseDown(sender, e);
        }

        private void classroomTextBox_LostFocus(object sender, EventArgs e)
        {
            //Kysy käyttäjältä muutetaanko kaikkien kurssin tuntien luokat
        }

        public void Select(bool value)
        {
            switch(value)
            {
                case false:
                    this.CellControl.BorderStyle = BorderStyle.None;
                    break;
                case true:
                    this.CellControl.BorderStyle = BorderStyle.FixedSingle;
                    break;
            }
        }
    }
}
