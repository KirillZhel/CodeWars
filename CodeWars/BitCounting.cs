using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
	public static class BitCounting
	{
		/*
		 * Write a function that takes an integer as input,
		 * and returns the number of bits that are equal to
		 * one in the binary representation of that number.
		 * You can guarantee that input is non-negative.
		 * Example: The binary representation of 1234 is
		 * 10011010010, so the function should return 5
		 * in this case
		 */

		public static int CountBits(int n)
		{
			var bitStr = Convert.ToString(n, 2);

			var result = bitStr.Count(ch => ch == '1');

			return result;
		}

	}
}
