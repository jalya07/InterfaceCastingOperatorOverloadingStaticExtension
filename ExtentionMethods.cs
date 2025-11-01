using System;
namespace StaticInterfaceOperatocOvverloading1
{
	public static class ExtentionMethods
	{
		
		
		public static bool IsOdd(this int number)
		{
			if (number % 2 != 0)
				return true;
			else
				return false;
		}
		public static  bool IsEven(this int number)
		{
			if (number % 2 == 0)
				return true;
			else
				return false;
		}
		public static bool IsPalindrome(this int number)
		{
			string numStr = number.ToString();
			char[] reversed = numStr.ToCharArray();
			Array.Reverse(reversed);
			string reversedStr = new string(reversed);
			return numStr == reversedStr;
		}

        public static bool IsContainsDigit(this string text)
		{
			foreach(char c in text)
			{
				if (char.IsDigit(c))
					return true;
				
			}
			return false;
		}
		public static string ToCapitalize(this string text)
		{
			if (string.IsNullOrEmpty(text))
				return text;
			text = text.Trim();
			if (text.Length == 1)
				return text.ToUpper();
			return char.ToUpper(text[0]) + text.Substring(1).ToLower();
		}
		public static int[] GetValueIndexes(this string text,char c)
		{
			List<int> indexes= new List<int>();
			for(int i = 0; i < text.Length; i++)
			{
				if (text[i] == c)
					indexes.Add(i);

			}
			return indexes.ToArray();
		}
		public static string GetFirstSentence(this string text)
		{
			if (string.IsNullOrWhiteSpace(text))
				return string.Empty;
			int dotIndex = text.IndexOf('.');
			if (dotIndex == -1)
				return text.Trim();
			return text.Substring(0, dotIndex).Trim();
		}
		public static string GetSecondWord(this string text)
		{
			if (string.IsNullOrWhiteSpace(text))
				return string.Empty;
			string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			if (words.Length < 2)
				return string.Empty;
			return words[1];
		}
		public static int MatchCount(this string text,string word)
		{
			if (string.IsNullOrWhiteSpace(text) || string.IsNullOrWhiteSpace(word))
				return 0;
			int count = 0;
			int index = 0;
			while((index =text.IndexOf(word,index,StringComparison.OrdinalIgnoreCase))!= -1)
			{
				count++;
				index += word.Length;

			}
			return count;
		}


    }
}

