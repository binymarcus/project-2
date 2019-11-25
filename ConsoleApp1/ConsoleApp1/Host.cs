using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Host
    {
        public long HostKey;
        readonly List<HostingUnit> HostingUnitCollection;
        /// <summary>
        /// default constructor for host, sets the id, and implements the number of of hosting units in the list as null
        /// </summary>
        /// <param name="hostKey"></param>
        /// <param name="numOfUsedUnits"></param>
        public Host(long hostKey, int numOfUsedUnits)
        {
            HostKey = hostKey;
            for (int i = 0; i < numOfUsedUnits; i++)
            {
                HostingUnitCollection.Add(null);
            }
        }
        /// <summary>
        /// overrides the tostring method and uses the method of hosting unit
        /// </summary>
        /// <returns>returns a list of all the hosting units and their uses</returns>
        public override string ToString()
        {
            string temp = " List of units: ";
            foreach (HostingUnit item in HostingUnitCollection)
            {
                temp += item.ToString();
            }
            return temp;
        }
        private long SubmitRequest(GuestRequest guestReq) { }
    }
}
