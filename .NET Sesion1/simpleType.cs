// simpleType.cs
using System;

namespace MyCodeLibrary
{
  /// <summary>
  /// Simple utility type. 
  /// </summary>
  public class SimpleType
  {
    /// <summary>
    /// Print out select environment information
    /// </summary>
    public static void DisplayEnvironment()
    {
      Console.WriteLine("Location of this program: {0}",
        Environment.CurrentDirectory); 
      Console.WriteLine("Name of machine: {0}", 
        Environment.MachineName);
      Console.WriteLine("OS of machine: {0}", 
        Environment.OSVersion);
      Console.WriteLine("Version of .NET: {0}", 
        Environment.Version);
    }          
  }
}