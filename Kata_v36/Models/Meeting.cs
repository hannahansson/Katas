using System;

namespace Scheduler.Models
{
    public class Meeting
    {
        public DateTime Start;
        public TimeSpan Duration;
        public Applicant Applicant;
        private DateTime _end;

        public Meeting(DateTime start)
        {
            Start = start;
            Duration = TimeSpan.FromMinutes(30);
            Applicant = null;
        }
        public Meeting(DateTime start, TimeSpan duration)
        {
            Start = start;
            Duration = duration;
            Applicant = null;
        }

        public bool Overlap(Meeting meeting)
        {
            bool endIsBefore = (Start + Duration) < meeting.Start;
            bool startIsAfter = (meeting.Start + meeting.Duration) < Start;

            return !(endIsBefore || startIsAfter);
        }

        public override string ToString()
        {
            string date = Start.ToString("d'/'M'/'yy");

            string timeOfDay = Start.ToString(format: " H:mm");
            _end = Start + Duration;
            string timeEnd = _end.ToString(format: " H:mm");

            string info = date + " " + timeOfDay + " - " + timeEnd;


            if (Applicant != null)
                info +=  " with: " +  Applicant.Name;

            return info;
        }
    }
}
