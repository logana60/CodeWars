using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
	public static class DubstepTests
	{
		public class Dubstep
		{
			public static string SongDecoder(string input)
			{
				input = input.Replace("WUB", " ");
				input = input.TrimStart(' ');
				input = input.TrimEnd(' ');



				return input;
			}
		}
	}
}
