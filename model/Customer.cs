using eshift.utils.enums;

namespace eshift.model
{
    internal class Customer : SuperModel
    {
        private int _id;
        private string _cusId;
        private string _firstName;
        private string _lastName;
        private string _phone;
        private string _email;
        private string _address;
        private CustomerStatus _status;

        public Customer()
        {
        }

        public Customer(int id, string cusId, string firstName, string lastName,
                        string phone, string email, string address, CustomerStatus status, DateTime updatedAt, User updatedBy, DateTime createdAt, User createdBy) : base(createdBy, createdAt, updatedBy, updatedAt)
        {
            _id = id;
            _cusId = cusId;
            _firstName = firstName;
            _lastName = lastName;
            _phone = phone;
            _email = email;
            _address = address;
            _status = status;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string CusId
        {
            get { return _cusId; }
            set { _cusId = value; }
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

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public CustomerStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
