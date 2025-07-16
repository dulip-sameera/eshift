namespace eshift.utils.enums.extensions
{
    internal static class CustomerStatusExtensions
    {
        public static string GetName(this CustomerStatus status)
        {
            return status.ToString();
        }

        public static int GetId(this CustomerStatus status)
        {
            return (int)status;
        }

        public static CustomerStatus FromId(int id)
        {
            return (CustomerStatus)id;
        }
    }
}
