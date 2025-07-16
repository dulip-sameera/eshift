namespace eshift.model
{
    internal class PricingRule : SuperModel
    {
        private int _id;
        private decimal _baseRatePerKm;
        private decimal _chargePerKg;
        private decimal _taxPercentage;
        private DateTime _effectiveDate;

        public PricingRule()
        {
        }

        public PricingRule(int id, decimal baseRatePerKm, decimal chargePerKg,
                           decimal taxPercentage, DateTime effectiveDate, DateTime updatedAt, User updatedBy, DateTime createdAt, User createdBy) : base(createdBy, createdAt, updatedBy, updatedAt)
        {
            _id = id;
            _baseRatePerKm = baseRatePerKm;
            _chargePerKg = chargePerKg;
            _taxPercentage = taxPercentage;
            _effectiveDate = effectiveDate;
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public decimal BaseRatePerKm
        {
            get { return _baseRatePerKm; }
            set { _baseRatePerKm = value; }
        }

        public decimal ChargePerKg
        {
            get { return _chargePerKg; }
            set { _chargePerKg = value; }
        }

        public decimal TaxPercentage
        {
            get { return _taxPercentage; }
            set { _taxPercentage = value; }
        }

        public DateTime EffectiveDate
        {
            get { return _effectiveDate; }
            set { _effectiveDate = value; }
        }
    }
}
