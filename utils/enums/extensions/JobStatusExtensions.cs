using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift.utils.enums.extensions
{
    internal static class JobStatusExtensions
    {
        public static string GetName(this JobStatus status)
        {
            return status.ToString();
        }

        public static int GetId(this JobStatus status)
        {
            return (int)status;
        }

        public static JobStatus FromId(int id)
        {
            return (JobStatus)id;
        }
    }
}
