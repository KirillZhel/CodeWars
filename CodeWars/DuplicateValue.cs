using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class DuplicateValue
    {
        public static int FindDup(int[] arr)
        {
            //arr.Sum();
            var duplicateValue = arr.GroupBy(x => x)
                .First(y => y.Count() > 1)
                .ToList();
            return duplicateValue[0];

            //return arr.GroupBy(x => x).Single(x => x.Count() == 2).Key;
            //return arr.GroupBy(x => x).First(x => x.Count() == 2).Key;
        }
    }
}
