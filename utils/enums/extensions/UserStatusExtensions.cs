﻿namespace eshift.utils.enums.extensions
{
    internal static class UserStatusExtensions
    {
        public static int GetId(this UserStatus status)
        {
            return (int)status;
        }

        public static string GetName(this UserStatus status)
        {
            return status.ToString();
        }

        public static UserStatus FromId(int id)
        {
            return (UserStatus)id;
        }
    }
}
