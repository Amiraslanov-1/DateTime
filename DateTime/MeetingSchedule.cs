using System;
using System.Collections.Generic;
using System.Text;

namespace DataTime
{
    class MeetingSchedule
    {
        List<Meeting> _meetingList;
        public MeetingSchedule()
        {
            _meetingList = new List<Meeting>();
        }

        public void SetMeeting(string name, DateTime from, DateTime to)
        {
            Meeting meetings = new Meeting();
            meetings.Name = name;
            meetings.FromDate = from;
            meetings.ToDate = to;
            foreach (var meeting in _meetingList)
            {
                if (meeting.FromDate == meetings.FromDate && meeting.ToDate == meetings.ToDate)
                        throw new Exception("Meeting Already Exist");
                else
                    _meetingList.Add(meeting);
            }
        }
        public int FindMeetingsCount(DateTime date)
        {
            int count = 0;
            foreach (Meeting meeting in _meetingList)
            {
                if (date < meeting.FromDate)
                    count++;
            }

            return count;
        }

        public bool IsExistsMeetingByName(string name)
        {
            foreach (Meeting meeting in _meetingList)
                if (meeting.Name.Contains(name))
                    return true;

            return false;

        }
        public List<Meeting> GetExistMeetings(string name)
        {
            List<Meeting> meetings = new List<Meeting>();

            foreach (var meeting in _meetingList)
            {
                if (meeting.Name.Contains(name))
                    meetings.Add(meeting);
                
            }
            return meetings;
        }

    }
}

