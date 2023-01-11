using System.Text.RegularExpressions;

namespace LinesToArgs;

internal class Program
{
   private static void Main(string[] args)
   {
      string input = args[0];
      string pattern = "";
      string replacement = "";

      string output = Regex.Replace(input, pattern, replacement);

      Console.WriteLine(output);
   }
}