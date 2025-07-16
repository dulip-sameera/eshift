using eshift.utils.enums;

namespace eshift.model
{
    internal class User : SuperModel
    {
        private int _id;
        private string _username;
        private string _email;
        private string _password;
        private string _firstName;
        private string _lastName;
        private string _phone;
        private Role _role;
        private UserStatus _status;

        public User()
        {
        }

        public User(int id, string username, string email, string password, string firstName,
                    string lastName, string phone, Role role, UserStatus status, DateTime updatedAt, User updatedBy, DateTime createdAt, User createdBy) : base(createdBy, createdAt, updatedBy, updatedAt)
        {
            _id = id;
            _username = username;
            _email = email;
            _password = password;
            _firstName = firstName;
            _lastName = lastName;
            _phone = phone;
            _role = role;
            _status = status;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
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

        public Role Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public UserStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
