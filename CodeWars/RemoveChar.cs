using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class RemoveChar
    {
        public static string Remove_char(string s)
        {
            return s.Substring(1, s.Length - 2);
            //return s.Remove(s.Length - 1, 1).Remove(0, 1);
        }
    }
}
