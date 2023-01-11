using System.Text.RegularExpressions;

namespace LinesToArgs;

internal class Program
{
   private static void Main(string[] args)
   {
      string output = Regex.Replace(args[0], "1", "2");
      Console.WriteLine(output);
   }
}