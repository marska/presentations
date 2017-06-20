using System;
using static System.Console;

namespace _02_PatternMatching
{
  class Program
  {
    static void Main()
    {
      // Is-expressions with patterns
      PrintStars(null);
      PrintStars("ta da");
      PrintStars(100);

      UsingPatternsWithTryMethods(5);
      UsingPatternsWithTryMethods("7");
      UsingPatternsWithTryMethods("hello");

      // switch statement
      PrintShape(null);
      PrintShape(new Rectangle { Height = 100, Width = 150 });
      PrintShape(new Rectangle { Height = 100, Width = 100 });
    }

    static void PrintStars(object o)
    {
      if (o is null) return; 

      if (!(o is int i)) return; 

      WriteLine(new string('*', i));
    }

    static void UsingPatternsWithTryMethods(object o)
    {
      if (o is int i || (o is string s && int.TryParse(s, out i)))
      {
        WriteLine(new string('*', i));
      }
    }

    static void PrintShape(Shape shape)
    {
      switch (shape)
      {
        case Circle s:
          WriteLine($"circle with radius {s.Radius}");
          break;
        case Rectangle s when s.Width == s.Height:
          WriteLine($"{s.Width} x {s.Height} square");
          break;
        case Rectangle r:
          WriteLine($"{r.Width} x {r.Height} rectangle");
          break;
        default:
          WriteLine("<unknown shape>");
          break;
        case null:
          throw new ArgumentNullException(nameof(shape));
      }
    }
  }

  public class Shape
  {
    public int Height { get; set; }

    public int Width { get; set; }
  }

  public class Circle : Shape
  {
    public int Radius { get; set; }
  }

  public class Rectangle : Shape
  {
  }
}