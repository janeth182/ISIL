using System;
using System.Collections;

namespace PuzzlerService
{
	public class WordGenerator
	{
		public static ArrayList GenerateWords(string charList, string requiredChar)
		{
			ArrayList result = new ArrayList();
			for (int wordLength = 1; wordLength <= charList.Length; wordLength++)
			{
				result = GenerateNCharWords(charList, "", requiredChar, null, wordLength, result);
			}
			return result;
		}

		public static ArrayList GenerateNCharWords(string charList, string rootWord, string requiredChar, int[] usedChars, int numChars, ArrayList result)
		{
			for (int ii = 0; ii < charList.Length; ii++)
			{
				string word = rootWord;
				if ((rootWord == "") || (usedChars == null)) usedChars = new int[charList.Length];
				if (usedChars[ii] != 1)
				{
					word += charList[ii].ToString();
					usedChars[ii] = 1;
					if (word.Length >= numChars)
					{
						if (Dictionary.CheckSpelling(word))
						{
							if (!result.Contains(word))
							{
								if ((requiredChar == null) || (requiredChar == "") || (word.IndexOf(requiredChar.Substring(0, 1)) > -1)) result.Add(word);
							}
						}
					}
					else
					{
						result = GenerateNCharWords(charList, word, requiredChar, usedChars, numChars, result);
					}
					usedChars[ii] = 0;
				}
			}
			return result;
		}
	}
}
