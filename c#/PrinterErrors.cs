using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
	public static class PrinterTests
	{
		public class Printer
		{
			public static string PrinterError(String s)
			{
				float LengthOfString = s.Length;
				string Acceptable = "abcdefghijklm";
				int errors = 0;

				s = s.ToLower();

				foreach (char letter in s)
				{
					if(!Acceptable.Contains(letter))
					{
						errors += 1;
					}
				}

				return (errors.ToString() + "/" + LengthOfString.ToString());
			}
		}
	}
}
