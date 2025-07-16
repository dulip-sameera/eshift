namespace eshift.model
{
    internal class Lorry : SuperModel
    {
        private int _id;
        private string _registrationNumber;
        private string _brand;
        private string _model;
        private int _year;
        private bool _available;

        public Lorry()
        {
        }

        public Lorry(int id, string registrationNumber, string brand, string model, int year, bool available, DateTime updatedAt, User updatedBy, DateTime createdAt, User createdBy) : base(createdBy, createdAt, updatedBy, updatedAt)
        {
            _id = id;
            _registrationNumber = registrationNumber;
            _brand = brand;
            _model = model;
            _year = year;
            _available = available;
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string RegistrationNumber
        {
            get { return _registrationNumber; }
            set { _registrationNumber = value; }
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public bool Available
        {
            get { return _available; }
            set { _available = value; }
        }
    }
}
