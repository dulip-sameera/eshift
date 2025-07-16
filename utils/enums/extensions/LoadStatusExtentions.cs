namespace eshift.utils.enums.extensions
{
    internal static class LoadStatusExtensions
    {
        public static string GetName(this LoadStatus loadStatus)
        {
            return loadStatus.ToString();
        }

        public static int GetId(this LoadStatus loadStatus)
        {
            return (int)loadStatus;
        }
    }
}
