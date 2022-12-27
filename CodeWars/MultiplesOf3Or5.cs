using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class MultiplesOf3Or5
    {
        public static int Solution(int value)
        {
            int result = 0;
            
            if (value > 0)
            {
                for (int i = 0; i < value; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0) result += i;
                }
            }
            return result;

            //return Enumerable.Range(0, value).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }
    }
}
