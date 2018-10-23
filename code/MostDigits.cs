using System;
using System.Linq;

namespace code
{
	public class MostDigits
	{
		public int GetDigits(int[] numbers)
		{
            int longestDigit = 0;
            foreach (var number in numbers)
            {
                if(number.ToString().Length > longestDigit.ToString().Length)
                {
                    longestDigit = number;
                }
            }
			return longestDigit;
		}
	}
}