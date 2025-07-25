﻿namespace eshift.utils.enums.extensions
{
    internal static class ScheduleStatusExtensions
    {
        public static int GetId(this ScheduleStatus status)
        {
            return (int)status;
        }

        public static string GetName(this ScheduleStatus status)
        {
            return status.ToString();
        }

        public static ScheduleStatus FromId(int id)
        {
            return (ScheduleStatus)id;
        }
    }
}
