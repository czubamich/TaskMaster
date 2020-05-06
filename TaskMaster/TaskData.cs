using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace TaskMaster
{
    public class TaskData
    {
        DateTime started;
        public DateTime Started { get => started; set => started = value; }
        DateTime finished;
        public DateTime Finished { get => finished; set => finished = value; }

        [XmlElement(Type = typeof(XmlTimeSpan))]
        public TimeSpan TotalTime { get; set; }

        [XmlElement(Type = typeof(XmlTimeSpan))]
        public TimeSpan StartTime { get; set; }

        bool _checked;
        public bool Checked { get => _checked; set => _checked = value; }

        string taskName;
        public string TaskName { get => taskName; set => taskName = value; }

        public TaskData()
        {
            started = DateTime.Now;
            finished = new DateTime();
            TotalTime = new TimeSpan();
            StartTime = new TimeSpan();
            Checked = false;
            TaskName = "";
        }

        
    }
}
