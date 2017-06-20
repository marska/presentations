using System;

namespace _04_Deconstruction
{
  class Program
  {
    static void Main()
    {
      var p = new Point(3.14, 2.71);
      (double x, double y) = p;

      Console.WriteLine($"X = {x}, Y = {y}");
    }
  }

  public class Point
  {
    public Point(double x, double y)
    {
      X = x;
      Y = y;
    }

    public double X { get; }

    public double Y { get; }

    public void Deconstruct(out double x, out double y)
    {
      x = X;
      y = Y;
    }
  }
}