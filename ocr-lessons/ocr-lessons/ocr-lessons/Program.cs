using System;

namespace ocrlessons
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string a = "oijedf";
			string testResult = test (a);
			Console.WriteLine (testResult);
		}
		static string test(string a)
		{
			if (a == string.Empty) {
				return "Empty String";
			} else {
				return a;
			}
		}
	}
}
