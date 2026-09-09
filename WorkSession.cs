using System;
using System.Collections.Generic;
using System.Text;

namespace WorkTime
{
    internal class WorkSession
    {
        TimeOnly StartTime;
        TimeOnly EndTime;

        public WorkSession (TimeOnly startTime, TimeOnly endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public TimeSpan CalculateDuration()
        {
            return EndTime - StartTime;
        }   

    }
}
