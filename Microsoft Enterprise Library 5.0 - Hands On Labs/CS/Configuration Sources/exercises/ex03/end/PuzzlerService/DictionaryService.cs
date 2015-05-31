using System;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace PuzzlerService
{
	/// <summary>
	/// Summary description for DictionaryService.
	/// </summary>
	public class DictionaryService
	{
		private const string EXCEPTION_POLICY = "Service Policy";

		public static Boolean CheckSpelling(string wordToCheck)
		{
      var exceptionManager = EnterpriseLibraryContainer.Current.GetInstance<ExceptionManager>();
      return exceptionManager.Process(() => Dictionary.CheckSpelling(wordToCheck), false, EXCEPTION_POLICY);
		}

		public static void AddWord(string wordToAdd)
		{
      var exceptionManager = EnterpriseLibraryContainer.Current.GetInstance<ExceptionManager>();
      exceptionManager.Process(() => Dictionary.AddWord(wordToAdd), EXCEPTION_POLICY);
		}

		public static string GetDictionaryInfo()
		{
      var exceptionManager = EnterpriseLibraryContainer.Current.GetInstance<ExceptionManager>();
      return exceptionManager.Process(() => Dictionary.GetDictionaryInfo(), string.Empty, EXCEPTION_POLICY);
		}
	}
}
