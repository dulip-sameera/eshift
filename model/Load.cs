using eshift.utils.enums;

namespace eshift.model
{
    internal class Load : SuperModel
    {
        private int _id;
        private string _description;
        private decimal _weightKg;
        private decimal _volumeCubicM;
        private Job _job;
        private LoadStatus _status;

        public Load()
        {
        }

        public Load(int id, string description, decimal weightKg,
                    decimal volumeCubicM, Job job, LoadStatus status, DateTime updatedAt, User updatedBy, DateTime createdAt, User createdBy) : base(createdBy, createdAt, updatedBy, updatedAt)
        {
            _id = id;
            _description = description;
            _weightKg = weightKg;
            _volumeCubicM = volumeCubicM;
            _job = job;
            _status = status;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public decimal WeightKg
        {
            get { return _weightKg; }
            set { _weightKg = value; }
        }

        public decimal VolumeCubicM
        {
            get { return _volumeCubicM; }
            set { _volumeCubicM = value; }
        }

        public Job Job
        {
            get { return _job; }
            set { _job = value; }
        }

        public LoadStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
