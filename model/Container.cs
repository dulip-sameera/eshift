namespace eshift.model
{
    internal class Container: SuperModel
    {
        private int _id;
        private decimal _volume;
        private decimal _weight;
        private bool _available;

        public Container()
        {
        }

        public Container(int id, decimal volume, decimal weight, bool available, User createdBy, DateTime createdAt, User updatedBy, DateTime updatedAt) : base(createdBy, createdAt, updatedBy, updatedAt)
        {
            _id = id;
            _volume = volume;
            _weight = weight;
            _available = available;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public decimal Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }

        public decimal Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public bool Available
        {
            get { return _available; }
            set { _available = value; }
        }
    }
}
