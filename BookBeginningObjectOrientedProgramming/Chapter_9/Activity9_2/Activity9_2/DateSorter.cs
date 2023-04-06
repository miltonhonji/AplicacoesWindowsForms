using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity9_2
{
    public class DateSorter : IComparer<Request>
    {
        public int Compare(Request R1, Request R2)
        {
            return R1.Date.CompareTo(R2.Date);
        }
    }
}
