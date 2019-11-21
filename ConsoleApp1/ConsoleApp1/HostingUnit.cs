using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HostingUnit
    {
        private static long stSerialkey;
        public readonly long HostingUnitKey;
        bool[,] Diary = new bool[12,31];

        public HostingUnit()
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0;  j < 31;  j++)
                {
                    Diary[i, j] = false;
                }
            }
        }

        public HostingUnit( bool[,] diary)
        {
            HostingUnitKey = stSerialkey;
            Diary = diary;
        }
        public override string ToString()
        {
            string jack;
            for (int i = 0; i < length; i++)
            {

            }
            return 
        }
    }
}
