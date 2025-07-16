using eshift.utils.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift.model
{
    internal class Schedule : SuperModel
    {
        private int _id;
        private DateTime _startDateTime;
        private DateTime _endDateTime;
        private ScheduleStatus _status;
        private Job _job;
        private TransportUnit _transportUnit;

        public Schedule()
        {
        }

        public Schedule(int id, DateTime startDateTime, DateTime endDateTime,
                       ScheduleStatus status, Job job, TransportUnit transportUnit, DateTime updatedAt, User updatedBy, DateTime createdAt, User createdBy) : base(createdBy, createdAt, updatedBy, updatedAt)
        {
            _id = id;
            _startDateTime = startDateTime;
            _endDateTime = endDateTime;
            _status = status;
            _job = job;
            _transportUnit = transportUnit;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public DateTime StartDateTime
        {
            get { return _startDateTime; }
            set { _startDateTime = value; }
        }

        public DateTime EndDateTime
        {
            get { return _endDateTime; }
            set { _endDateTime = value; }
        }

        public ScheduleStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public Job Job
        {
            get { return _job; }
            set { _job = value; }
        }

        public TransportUnit TransportUnit
        {
            get { return _transportUnit; }
            set { _transportUnit = value; }
        }
    }
}
