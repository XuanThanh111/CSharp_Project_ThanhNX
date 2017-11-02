using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time_WinForm
{
    class Compare
    {
        public int dateCompare(DateTime firstdate, DateTime secondDate)
        {
            int result = 0;
            if (firstdate.Year < secondDate.Year)
            {
                result = -1;
            }
            else if (firstdate.Year > secondDate.Year)
            {
                result = 1;
            }
            else if (firstdate.Month < secondDate.Month)
            {
                result = -1;
            }
            else if (firstdate.Month > secondDate.Month)
            {
                result = 1;
            }
            else if (firstdate.Day < secondDate.Day)
            {
                result = -1;
            }
            else if (firstdate.Day > secondDate.Day)
            {
                result = 1;
            }
            else result = 0;
            return result;
        }
       
    }
}
