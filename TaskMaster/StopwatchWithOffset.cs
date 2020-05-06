using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TaskMaster
{
    class StopwatchWithOffset : Stopwatch
    {
        TimeSpan offset;
        public TimeSpan Offset
        {
            get { return offset; }
            set { offset = value; }
        }

        new public TimeSpan Elapsed
        {
            get { return base.Elapsed + Offset; }
        }

        //Constructors
        public StopwatchWithOffset() : base()
        {
            Offset = TimeSpan.FromSeconds(0.0);
        }

        public StopwatchWithOffset(int seconds) : base()
        {
            Offset = TimeSpan.FromSeconds(seconds);
        }

        public StopwatchWithOffset(TimeSpan time) : base()
        {
            Offset = time;
        }

        public void setTime(TimeSpan time)
        {
            if (IsRunning)
                Reset();
            else
                Restart();

            Offset = time;
        }

        public void setTime(int seconds)
        {
            if (IsRunning)
                Restart();
            else
                Reset();

            Offset = TimeSpan.FromSeconds(seconds);
        }

        new public void Reset()
        {
            base.Reset();
            offset = TimeSpan.FromSeconds(0);
        }

        new public void Restart()
        {
            base.Restart();
            offset = TimeSpan.FromSeconds(0);
        }
    }
}
