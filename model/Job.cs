using eshift.utils.enums;

namespace eshift.model
{
    internal class Job : SuperModel
    {
        private int _id;
        private string _startLocation;
        private string _destination;
        private int _assignedBy;
        private decimal _distanceKm;
        private decimal _totalWeightKg;
        private decimal _subtotal;
        private decimal _taxAmount;
        private decimal _totalCost;
        private Customer _customer;
        private JobStatus _status;

        public Job()
        {
        }

        public Job(int id, string startLocation, string destination, int assignedBy,
                   decimal distanceKm, decimal totalWeightKg, decimal subtotal,
                   decimal taxAmount, decimal totalCost, Customer customer, JobStatus status, DateTime updatedAt, User updatedBy, DateTime createdAt, User createdBy) : base(createdBy, createdAt, updatedBy, updatedAt)
        {
            _id = id;
            _startLocation = startLocation;
            _destination = destination;
            _assignedBy = assignedBy;
            _distanceKm = distanceKm;
            _totalWeightKg = totalWeightKg;
            _subtotal = subtotal;
            _taxAmount = taxAmount;
            _totalCost = totalCost;
            _customer = customer;
            _status = status;
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string StartLocation
        {
            get { return _startLocation; }
            set { _startLocation = value; }
        }

        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public int AssignedBy
        {
            get { return _assignedBy; }
            set { _assignedBy = value; }
        }

        public decimal DistanceKm
        {
            get { return _distanceKm; }
            set { _distanceKm = value; }
        }

        public decimal TotalWeightKg
        {
            get { return _totalWeightKg; }
            set { _totalWeightKg = value; }
        }

        public decimal Subtotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }

        public decimal TaxAmount
        {
            get { return _taxAmount; }
            set { _taxAmount = value; }
        }

        public decimal TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }

        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        public JobStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
