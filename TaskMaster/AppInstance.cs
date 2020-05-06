using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Drawing;

namespace TaskMaster
{
    public class AppInstance
    {
        List<TaskData> tasks;
        public List<TaskData> Tasks { get => tasks; }
        DateTime date = DateTime.Today;
        public DateTime Date { get => date; set => date = value; }

        double timeOfJob;
        public double TimeOfJob { get => timeOfJob; set => timeOfJob = value; }
        double timeOfBreak;
        public double TimeOfBreak { get => timeOfBreak; set => timeOfBreak = value; }
        int breakNumberCounter;
        public int BreakNumberCounter { get => breakNumberCounter; set => breakNumberCounter = value; }
        public Size Size { get; set; }
        public Point Location { get; set; }

        [XmlElement(Type = typeof(XmlTimeSpan))]
        public TimeSpan BreakTimeCounter { get; set; }

        [XmlElement(Type = typeof(XmlTimeSpan))]
        public TimeSpan Elapsed { get; set; }

        public AppInstance()
        {
            tasks = new List<TaskData>();
            date = DateTime.Today;
            timeOfJob = 60 * 60 * 8;
            timeOfBreak = 60 * 15;
            breakNumberCounter = 0;
            BreakTimeCounter = TimeSpan.FromSeconds(1);
            Elapsed = TimeSpan.FromSeconds(1);
        }

        public TaskData[] getTasks(DateTime date)
        {
            List<TaskData> taskList = new List<TaskData>();

            foreach(TaskData t in tasks)
            {
                if (t.Started.Date == date.Date)
                    taskList.Add(t);
            }

            return taskList.ToArray();
        }

        public TaskData[] getTasksCarryon()
        {
            List<TaskData> taskList = new List<TaskData>();

            foreach (TaskData t in tasks)
            {
                if (t.Started.Date == DateTime.Today.Date || !t.Checked)
                    taskList.Add(t);
            }

            return taskList.ToArray();
        }

        public void addTask(TaskData newTask)
        {
            tasks.Add(newTask);
        }

        public void update(TimeSpan Elapsed)
        {
            this.Elapsed = Elapsed;
        }
    }
}
