using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace TaskMaster
{
    public partial class fMain : Form
    {
        XmlSerializer xs;
        AppInstance ins;

        //Settings
        double timeOfJob
        { get => ins.TimeOfJob; set => ins.TimeOfJob = value; }
        double timeOfBreak
        { get => ins.TimeOfBreak; set => ins.TimeOfBreak = value; }

        //Variables
        StopwatchWithOffset spwMain;
        public TimeSpan MainElapsed { get => spwMain.Elapsed; }

        bool counting;
        bool onbreak;
        Stopwatch spwBreak;

        //
        public fMain()
        {
            InitializeComponent();

            ins = new AppInstance();
            spwMain = new StopwatchWithOffset();
            spwBreak = new Stopwatch();
            xs = new XmlSerializer(typeof(AppInstance));

            counting = false;
            onbreak = false;
        }

        void update()
        {
            if (!onbreak)
            {
                btnBreak.BackgroundImage = Properties.Resources.clock;
                pgbTime.Style = ProgressBarStyle.Continuous;
                tltTime.SetToolTip(btnBreak, String.Format("Start a break:\r\n{0}", TimeSpan.FromSeconds(timeOfBreak).ToString()));
                spwBreak.Reset();
            }
            else
            {
                btnBreak.BackgroundImage = Properties.Resources.mughot;
                pgbTime.Style = ProgressBarStyle.Marquee;
                lblTime.BackColor = Color.LightGoldenrodYellow;
                tltTime.SetToolTip(btnBreak, String.Format("Stop the break"));
                spwBreak.Start();
            }

            if (counting)
            {
                btnPauseResume.BackgroundImage = Properties.Resources.stop;
                lblTime.BackColor = Color.White;
                tltTime.SetToolTip(btnPauseResume, String.Format("Stop the timer"));
                spwMain.Start();
            }
            else
            {
                btnPauseResume.BackgroundImage = Properties.Resources.play;
                if (!onbreak)
                    lblTime.BackColor = Color.LightCoral;

                if (!onbreak)
                    tltTime.SetToolTip(btnPauseResume, String.Format("Start the timer"));
                else
                    tltTime.SetToolTip(btnPauseResume, String.Format("Stop the break"));

                spwMain.Stop();
            }

            tmrUpdate_Tick(null, null);
            for(int i=0;i<flpTaskList.Controls.Count-1;i++)
            {
                if (((Task)flpTaskList.Controls[i]).Active)
                    ((Task)flpTaskList.Controls[i]).updateTaskTime();
            }
        }

        public void SaveRead(string file)
        {
            System.IO.FileStream fs = null;
            try
            {
                fs = new System.IO.FileStream(file, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                ins = (AppInstance)xs.Deserialize(fs);

                Control buffer = flpTaskList.Controls[flpTaskList.Controls.Count - 1];
                TaskData[] ddd = ins.getTasksCarryon();

                foreach (TaskData td in ddd)
                {
                    var newTask = new Task(td , this);

                    newTask.tsmConfirmRemove.Click += taskRemove;
                    flpTaskList.Controls.Add(newTask);
                }
                fMain_SizeChanged(this, null);
                flpTaskList.Controls.Remove(buffer);
                flpTaskList.Controls.Add(buffer);
                Size = ins.Size;
                Location = ins.Location;

                if (ins.Date.Date == DateTime.Today.Date)
                    spwMain.setTime(ins.Elapsed);
                else
                    ins.Date = DateTime.Today;
            }
            catch(System.IO.FileNotFoundException e)
            {

            }
            catch(Exception e)
            {
                MessageBox.Show("Couldn't load previous config.");
            }
            finally
            {
                if (fs!=null)
                    fs.Close();
            }
        }

        public void SaveWrite(string file)
        {
            ins.Elapsed = spwMain.Elapsed;
            update();
            ins.Size = Size;
            ins.Location = Location;
      
            var fs = new System.IO.FileStream("config.xml", System.IO.FileMode.Create, System.IO.FileAccess.Write);

            xs.Serialize(fs, ins);
            fs.Close();
        }

        //Interface
        private void fMain_SizeChanged(object sender, EventArgs e)
        {
            flpTaskList.SuspendLayout();
            foreach (Control ctrl in flpTaskList.Controls)
            {
                ctrl.Width = flpTaskList.Width - 8 - (flpTaskList.VerticalScroll.Visible ? 18 : 0);
            }
            flpTaskList.ResumeLayout();

            flpTaskList.VerticalScroll.Maximum = 0;
            flpTaskList.HorizontalScroll.Visible = false;
            flpTaskList.HorizontalScroll.Enabled = false;
        }

        //Timers
        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            //Label update
            if (onbreak)
            {
                if (spwBreak.Elapsed.Seconds >= timeOfBreak)
                {
                    spwBreak.Reset();
                    lblTime.BackColor = Color.LightGray;
                    lblTime.Text = DateTime.Now.ToString("hh\\:mm");
                }
                else if (spwBreak.IsRunning)
                {
                    var timeSpan = (TimeSpan.FromSeconds(timeOfBreak) - spwBreak.Elapsed);
                    lblTime.Text = String.Format("{0}:{1:00}", (int)timeSpan.TotalMinutes, (int)timeSpan.TotalSeconds % 60);
                }
            }
            else
            {
                lblTime.Text = spwMain.Elapsed.ToString("hh\\:mm\\:ss");

                //Progress bar update
                if (spwMain.Elapsed.TotalSeconds >= timeOfJob)
                {
                    pgbTime.Value = 1000;
                    lblTime.BackColor = Color.LightGreen;
            }
                else
                    pgbTime.Value = (int)((spwMain.Elapsed.TotalSeconds / timeOfJob) * 1000.0);
            }
        }

        //Task
        private void taskRemove(object sender, EventArgs e)
        {
            ToolStripItem item = (sender as ToolStripItem);
            if (item is ToolStripItem)
            {
                ins.Tasks.Remove((item.Tag as Task).Data);
                flpTaskList.Controls.Remove(item.Tag as Task);
            }
        }

        //Buttons
        private void btnNewTask_Click(object sender, EventArgs e)
        {
            Control buffer = flpTaskList.Controls[flpTaskList.Controls.Count - 1];
            var newTask = new Task("Task #" + flpTaskList.Controls.Count.ToString(), this);
            ins.Tasks.Add(newTask.Data);

            newTask.tsmConfirmRemove.Click += taskRemove;

            flpTaskList.Controls.Add(newTask);
            flpTaskList.Controls.Remove(buffer);
            flpTaskList.Controls.Add(buffer);
            fMain_SizeChanged(this, null);
            flpTaskList.VerticalScroll.Value = flpTaskList.VerticalScroll.Maximum;

            newTask.ttbTaskName.Focus();
        }

        private void btnPauseResume_Click(object sender, EventArgs e)
        {
            counting = !counting ? true : false;
            onbreak = counting ? false : onbreak;

            update();
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            onbreak = !onbreak ? true : false;
            counting = !onbreak;

            update();
        }

        //Menus
        private void tsmResetTimer_Click(object sender, EventArgs e)
        {
            update();

            if (counting)
                spwMain.Restart();
            else
                spwMain.Reset();

            for (int i = 0; i < flpTaskList.Controls.Count - 1; i++)
            {
                if (((Task)flpTaskList.Controls[i]).Active)
                    ((Task)flpTaskList.Controls[i]).updateStartTime();
            }
        }

        private void tsmSetTime_Click(object sender, EventArgs e)
        {
            string source = (sender as ToolStripItem).Name;

            frmNewTime dialog;
            if (source == tsmSetTargetTime.Name)
                dialog = new frmNewTime((int)timeOfJob);
            else if (source == tsmSetBreakTime.Name)
                dialog = new frmNewTime((int)timeOfBreak);
            else if (source == tsmSetCurrentProgress.Name)
                dialog = new frmNewTime((int)spwMain.Elapsed.TotalSeconds);
            else
                return;

            dialog.FormClosing += tsmSetTime_Result;
            dialog.Tag = source;
            dialog.ShowDialog(this);
        }

        private void tsmSetTime_Result(object sender, EventArgs e)
        {
            for (int i = 0; i < flpTaskList.Controls.Count - 1; i++)
            {
                if (((Task)flpTaskList.Controls[i]).Active)
                    ((Task)flpTaskList.Controls[i]).updateTaskTime();
            }

            var result = sender as frmNewTime;
            if (result != null)
            {
                if ((string)result.Tag == tsmSetTargetTime.Name)
                    timeOfJob = (double)result.Result;
                else if ((string)result.Tag == tsmSetBreakTime.Name)
                    timeOfBreak = (double)result.Result;
                else if ((string)result.Tag == tsmSetCurrentProgress.Name)
                    spwMain.setTime(result.Result);
            }

            for (int i = 0; i < flpTaskList.Controls.Count - 1; i++)
            {
                if (((Task)flpTaskList.Controls[i]).Active)
                    ((Task)flpTaskList.Controls[i]).updateStartTime();
            }
            update();
            tltTime.SetToolTip(pgbTime, String.Format("Target time:\r\n{0}", TimeSpan.FromSeconds(timeOfJob).ToString()));
            tltTime.SetToolTip(lblTime, String.Format("Target time:\r\n{0}", TimeSpan.FromSeconds(timeOfJob).ToString()));
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveWrite("config.xml");
        }

        private void fMain_Shown(object sender, EventArgs e)
        {
            SaveRead("config.xml");
            fMain_SizeChanged(this, null);
            update();

            tltTime.SetToolTip(pgbTime, String.Format("Target time:\r\n{0}", TimeSpan.FromSeconds(timeOfJob).ToString()));
            tltTime.SetToolTip(lblTime, String.Format("Target time:\r\n{0}", TimeSpan.FromSeconds(timeOfJob).ToString()));
            tltTime.SetToolTip(btnBreak, String.Format("Start a break:\r\n{0}", TimeSpan.FromSeconds(timeOfBreak).ToString()));
        }
    }
}
