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
        public override string ToString()
        {
            return "Entry Date: " + EntryDate.Year.ToString() +'.' +EntryDate.Month.ToString()+EntryDate.Day.ToString()+" Release Date: " + ReleaseDate.Year.ToString() +ReleaseDate.Month.ToString()+ReleaseDate.Day.ToString()+ " is approved: " + IsApproveed;

        }
        public GuestRequest()
        {
            EntryDate = new DateTime(2020, 1, 1);
            ReleaseDate = new DateTime(2020, 1, 4);
            IsApproveed = false;
         }


    }
}
