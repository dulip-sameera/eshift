namespace eshift.model
{
    internal class SuperModel
    {
        private User _createdBy;
        private DateTime _createdAt;
        private User _updatedBy;
        private DateTime _updatedAt;

        public SuperModel()
        {
        }

        public SuperModel(User createdBy, DateTime createdAt, User updatedBy, DateTime updatedAt)
        {
            _createdBy = createdBy;
            _createdAt = createdAt;
            _updatedBy = updatedBy;
            _updatedAt = updatedAt;
        }

        public User CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }

        public User UpdatedBy
        {
            get { return _updatedBy; }
            set { _updatedBy = value; }
        }

        public DateTime UpdatedAt
        {
            get { return _updatedAt; }
            set { _updatedAt = value; }
        }
    }
}
