namespace eshift.model
{
    internal class Assistant : SuperModel
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _phone;
        private bool _available;

        public Assistant()
        {
        }

        public Assistant(int id, string firstName, string lastName, string phone, bool available, User createdBy, DateTime createdAt, DateTime updatedAt, User updatedBy) : base(createdBy, createdAt, updatedBy, updatedAt)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _phone = phone;
            _available = available;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public bool Available
        {
            get { return _available; }
            set { _available = value; }
        }
    }
}
