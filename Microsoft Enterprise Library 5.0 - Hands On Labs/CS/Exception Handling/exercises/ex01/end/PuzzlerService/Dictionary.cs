using System;
using System.IO;
using System.Collections;
using System.Reflection;

namespace PuzzlerService
{
	/// <summary>
	/// Summary description for Dictionary.
	/// </summary>
	public class Dictionary
	{
		#region Private Implementation and Construction
		private const String DictionaryResourceName = "PuzzlerService.dict.txt";
		private static Hashtable _Dict = null;

		public static Hashtable Dict
		{
			get
			{
				if (_Dict == null)
				{
					StreamReader sr = null;
					try
					{
						_Dict = new Hashtable();
						Stream dictStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(DictionaryResourceName);
						sr = new StreamReader(dictStream);
						String line = sr.ReadLine();
						while (line != null)
						{
							_Dict.Add(line, line);
							line = sr.ReadLine();
						}
					}
					finally
					{
						if (sr != null) sr.Close();
					}
				}
				return _Dict;
			}
		}
		#endregion

		public static Boolean CheckSpelling(string wordToCheck)
		{
			//Console.WriteLine(wordToCheck);
			return Dict.Contains(wordToCheck);
		}

		private static Boolean IsWord(string candidate)
		{
			Boolean result = true;
			foreach( Char chr in candidate)
			{
				if (!Char.IsLetter(chr))
				{
					result = false;
					break;
				}
			}
			return result;
		}

		public static Boolean AddWord(string wordToAdd)
		{
			if (!IsWord(wordToAdd))
			{
				// It is not alphabetic! Throw an exception
				throw new ApplicationException("Word to add does not consist of alphabetic letters");
			}
			if (Dict[wordToAdd] == null)
			{
				Dict.Add(wordToAdd, wordToAdd);
			}
			return true;
		}

		public static long WordCount
		{
			get
			{
				return Dict.Count;
			}
		}

		public static string GetDictionaryInfo()
		{
			return String.Format("Dictionary Name: {0} \n Word Count: {1:n0}", DictionaryResourceName, WordCount);
		}

	}
}
