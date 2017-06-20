using System;

namespace _01_OutVariables
{
  class Program
  {
    static void Main()
    {
      var input = "8291";

      TryParse(input);

      TryParse2(input);

      var output = Parse(input);
    }

    static void TryParse(string input)
    {
      int numericResult;

      if (int.TryParse(input, out numericResult))
        Console.WriteLine(numericResult);
      else
        Console.WriteLine("Could not parse input");
    }

    static void TryParse2(string input)
    {
      if (int.TryParse(input, out var numericResult))
        Console.WriteLine(numericResult);
      else
        Console.WriteLine("Could not parse input");
    }

    static int Parse(string input)
    {
      if (!int.TryParse(input, out int result))
      {
        return 0;
      }

      return result;
    }
  }
}