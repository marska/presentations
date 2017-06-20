using System;

namespace _05_LocalFunctions
{
  class Program
  {
    static void Main()
    {
      var runner = new Runner();
      runner.Run();
    }
  }

  public class Runner
  {
    public void Run()
    {
      Console.WriteLine(Fibonacci(6));
    }

    public int Fibonacci(int x)
    {
      if (x < 0) throw new ArgumentException();

      return Fib(x).current;

      (int current, int next) Fib(int i)
      {
        if (i == 0) return (1, 0);
        var (current, previous) = Fib(i - 1);
        x = 100;
        return (current + previous, current);
      }
    }
  }
}