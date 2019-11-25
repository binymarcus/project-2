using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HostingUnit:IComparable
    {
        private static long stSerialKey = 10000000;
        public readonly long HostingUnitKey;
        bool[,] Diary = new bool[12,31];
        /// <summary>
        /// getter ansd setter like ordered
        /// </summary>
        /// <param name="date"></param>
        /// <returns>returns the date and month </returns>
        public bool this[DateTime date] 
        {
            get { return Diary[date.Month, date.Day]; }
            set { Diary[date.Month, date.Day] = value; }
        }
        /// <summary>
        /// default constructor, sets the hostingunitkey to the static key, and sets all the dates to false
        /// </summary>
        public HostingUnit() 
        {
            HostingUnitKey = ++stSerialKey; 

            DateTime date = new DateTime(1, 1, 2020); 
            for (; date.Year == 2020; date.AddDays(1))
            {
                this[date] = false; 
            }
        }
        /// <summary>
        /// override for tostring like the roders
        /// </summary>
        /// <returns>returns the serial key and the dates of each vacation</returns>
        public override string ToString()
        {
            ArrayList date = VacationDates();
            string temp = "serial number: {0} , list of dates:  ",HostingUnitKey;
            for (int i = 0; i < date.Count; i+=4)
            {
                temp += " start date: " + (int)date[i] + 1 + "." + (int)date[i + 1] + 1 + " end date: " + (int)date[i + 2] + 1 + "." + (int)date[i + 3] + 1;
               // temp += " start date:{0}.{1}, end date:{2}.{3}",(int)date[i] + 1,(int)date[i + 1] + 1,(int)date[i + 2] + 1,(int)date[i + 3] + 1;
            }
            temp += "\n";
            return temp;
        }
        /// <summary>
        /// function we added to make life easier calculates the date of each stay using an arraylist
        /// </summary>
        /// <returns>retuns an arraylist of all the dates</returns>
        private ArrayList VacationDates()
        {
            bool occupied = false;
            ArrayList Dates=new ArrayList();
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
        /// <summary>
        /// calculates the amount of dates
        /// </summary>
        /// <returns>returns the number of days</returns>
        public int GetAnnualBusyDays()
        {
            int count = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    if (Diary[i, j] == true)
                        count++;
                }
            }
            return count;
        }
        /// <summary>
        /// uses the number of days to calculate the percentage
        /// </summary>
        /// <returns>returns the days  used devided by the general population</returns>
        public float GetAnnualBusyPercentage()
        {
            return (GetAnnualBusyDays() / 372) * 100;
        }
        /// <summary>
        /// gives the abillity to compare betwen two hosting units
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>returns a 0 or 1 depending on the outcome</returns>
        public int CompareTo(object obj)
        {
            return GetAnnualBusyDays().CompareTo(((HostingUnit)obj).GetAnnualBusyDays()); 
        }
    }
}
