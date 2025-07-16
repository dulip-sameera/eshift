namespace eshift.utils.enums.extensions
{
    internal static class RoleExtensions
    {
        public static int GetId(this Role role)
        {
            return (int)role;
        }

        public static string GetName(this Role role)
        {
            return role.ToString();
        }

        public static Role FromId(int id)
        {
            return (Role)id;
        }
    }
}
