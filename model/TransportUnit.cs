using eshift.utils.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift.model
{
    internal class TransportUnit : SuperModel
    {
        private int _id;
        private TransportUnitStatus _status;
        private Lorry _lorry;
        private Driver _driver;
        private Assistant _assistant;
        private Container _container;

        public TransportUnit()
        {
        }

        public TransportUnit(int id, TransportUnitStatus status, Lorry lorry,
                             Driver driver, Assistant assistant, Container container, DateTime updatedAt, User updatedBy, DateTime createdAt, User createdBy) : base(createdBy, createdAt, updatedBy, updatedAt)
        {
            _id = id;
            _status = status;
            _lorry = lorry;
            _driver = driver;
            _assistant = assistant;
            _container = container;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public TransportUnitStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public Lorry Lorry
        {
            get { return _lorry; }
            set { _lorry = value; }
        }

        public Driver Driver
        {
            get { return _driver; }
            set { _driver = value; }
        }

        public Assistant Assistant
        {
            get { return _assistant; }
            set { _assistant = value; }
        }

        public Container Container
        {
            get { return _container; }
            set { _container = value; }
        }
    }
}
