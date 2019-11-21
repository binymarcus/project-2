using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HostingUnit
    {
        private static long stSerialKey = 10000000;
        public readonly long HostingUnitKey;
        bool[,] Diary = new bool[12,31];
public bool this[DateTime date] //property (getter/setter)
        {
            get { return Diary[date.Month, date.Day]; }
            set { Diary[date.Month, date.Day] = value; }
        }

        public HostingUnit() // constrocter
        {
            HostingUnitKey = ++stSerialKey; // this way each hosting unit has a diffrent serial key

            DateTime date = new DateTime(1, 1, 2020); //indexer
            for (; date.Year == 2020; date.AddDays(1))
            {
                this[date] = false; //initialize as false
            }
        }
        public override string ToString()// override for tostring, print the serial number then the start and end date of each vacation
        {
           
        }
        private string VacationDates()//returns list of dates of occupied days (start and end)
        {
            bool occupied = false;
            string Dates;
            for (int i = 0; i < 12; i++)
            {
                int stop;
                if (i==1||1==3||1==5||i==7||i==8||i==10||i==12) { stop = 31; }
                else if (i == 4 || 1 == 6 || 1 == 9 || i == 10) { stop = 30; }
                else { stop = 29;}
                for (int j = 0; j < stop; j++)
                {
                    if (Diary[i, j] != occupied)
                    {
                        Dates.Add(i + 1);
                        Dates.Add(j + 1);
                        occupied = !occupied;
                    }
                }
            }
            return Dates;
        }
    }
}
