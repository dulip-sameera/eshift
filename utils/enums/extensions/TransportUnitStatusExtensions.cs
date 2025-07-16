using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift.utils.enums.extensions
{
    internal static class TransportUnitStatusExtensions
    {
        public static int GetId(this TransportUnitStatus status)
        {
            return (int)status;
        }

        public static string GetName(this TransportUnitStatus status)
        {
            return status.ToString();
        }

        public static TransportUnitStatus FromId(int id)
        {
            return (TransportUnitStatus)id;
        }
    }
}
