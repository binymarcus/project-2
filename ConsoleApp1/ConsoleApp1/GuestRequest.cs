using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GuestRequest
    {
      public DateTime EntryDate;
      public DateTime ReleaseDate;
      public bool IsApproveed;
        /// <summary>
        /// the function overrides th ToString function 
        /// </summary>
        /// <returns>returns the date of start and end and the approval status</returns>
        public override string ToString()
        {
            return "Entry Date: " + EntryDate.Day.ToString() + '.' + EntryDate.Month.ToString()+" Release Date: "  +ReleaseDate.Day.ToString() + '.' + ReleaseDate.Month.ToString()+ " is approved: " + IsApproveed;

        }
        /// <summary>
        /// base constructor for the class sette the first to the first as the start date, the second as the end date, and approval as false
        /// </summary>
        public GuestRequest()
        {
            EntryDate = new DateTime(2020, 1, 1);
            ReleaseDate = new DateTime(2020, 1, 2);
            IsApproveed = false;
         }


    }
}
