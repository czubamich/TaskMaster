using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;


namespace TaskMaster
{
    public partial class Task : UserControl
    {
        TaskData taskData;
        public TaskData Data { get => taskData; }

        public DateTime Started { get => taskData.Started; set => taskData.Started = value; }
        public DateTime Finished { get => taskData.Finished; set => taskData.Finished = value; }
        public TimeSpan TotalTime { get => taskData.TotalTime; set => taskData.TotalTime = value; }
        public TimeSpan StartTime { get => taskData.StartTime; set => taskData.StartTime = value; }
        public fMain Source;

        public string TaskName { get { taskData.TaskName = ttbTaskName.Text; return taskData.TaskName; } }
        public bool Checked { get => ckbComplete.Checked; }
        public bool Active { get => ckbActive.Checked; }

        private Task()
        {
            taskData = new TaskData();
            InitializeComponent();

            tltInfo.SetToolTip(this, getTaskTooltipText());
            foreach (Control ctrl in this.Controls)
                tltInfo.SetToolTip(ctrl, getTaskTooltipText());
        }

        public Task(string name, fMain source) : this()
        {
            this.ttbTaskName.Text = name;    
            this.tsmConfirmRemove.Tag = this;

            taskData.TaskName = TaskName;
            Source = source;
            StartTime = Source.MainElapsed;
        }

        public Task(TaskData data, fMain source) : this()
        {
            this.tsmConfirmRemove.Tag = this;
            Source = source;

            this.ttbTaskName.Text = data.TaskName;
            taskData = data;
            var buffer = data.Finished;
            ckbComplete.Checked = data.Checked;
            taskData.Finished = buffer;
        }

        public string getTaskTooltipText()
        {
            TimeSpan total = Active ? (TotalTime + Source.MainElapsed - StartTime) : TotalTime;

            String timeFormat = "hh\\:mm";
            String dateFormat = Started.Date == DateTime.Today.Date ? "HH:mm" : "HH:mm dd.MM.yy";


            if (Checked)
            {
                return String.Format(
    "Started:   \t{1}\r\n" +
    "Finished: \t{2}\r\n" +
    "Duration: \t{3}\r\n", 
    TaskName, Started.ToString(dateFormat), 
    Finished.ToString(dateFormat), 
    total.ToString(timeFormat));
            }
            else
            {
                return String.Format(
    "Started:   \t{1}\r\n" +
    "Duration: \t{2}\r\n", 
    TaskName, Started.ToString(dateFormat), 
    total.ToString(timeFormat));
            }
        }

        private void ckbActive_CheckedChanged(object sender, EventArgs e)
        {
            if (Checked)
            {
                ckbActive.Checked = false;
                ckbActive.BackgroundImage = null;
                return;

            }

            if (!Active)
            {
                ckbActive.BackgroundImage = null;
                updateTaskTime();
                return;
            }

            foreach (Control ctrl in this.Parent.Controls)
            {
                if((ctrl.Tag as string) != "btnNewTask" && ctrl!=this)
                {
                    var ctrl2 = (Task)ctrl;
                    ctrl2.ckbActive.Checked = false;
                }
                    
            }
            ckbActive.BackgroundImage = Properties.Resources.code;
            StartTime = Source.MainElapsed;
        }

        private void ckbComplete_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbComplete.Checked)
            {
                ckbComplete.BackgroundImage = Properties.Resources.check;
                Finished = DateTime.Now;
                if (Active)
                {
                    updateTaskTime();
                    ckbActive.Checked = false;
                }
            }
            else
                ckbComplete.BackgroundImage = null;

            Data.Checked = ckbComplete.Checked;
        }

        public void updateTaskTime()
        {
            TotalTime = TotalTime + Source.MainElapsed - StartTime;
            StartTime = Source.MainElapsed;
        }

        public void updateStartTime()
        {
            StartTime = Source.MainElapsed;
        }

            private void tltInfo_Popup(object sender, PopupEventArgs e)
        {
            (sender as ToolTip).Popup -= tltInfo_Popup;
            tltInfo.SetToolTip(e.AssociatedControl, getTaskTooltipText());
            (sender as ToolTip).Popup += tltInfo_Popup;
        }

        private void ttbTaskName_TextChanged(object sender, EventArgs e)
        {
            taskData.TaskName = TaskName;
            tltInfo.ToolTipTitle = TaskName;
        }
    }
}
