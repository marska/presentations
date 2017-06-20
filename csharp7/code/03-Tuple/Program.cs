using System;

namespace _03_Tuple
{
  class Program
  {
    static void Main(string[] args)
    {
      var customer = LookUpCustomer(5);
      Console.WriteLine($"Customer is {customer.Item1} {customer.Item2}, who is {customer.Item3} years old");

      var customer2 = LookUpCustomer2(5);
      Console.WriteLine($"Customer is {customer2.first} {customer2.last}, who is {customer2.age} years old");
    }

    public static (string, string, int) LookUpCustomer(int id)
    {
      var first = "Jan";
      var last = "Kowalsky";
      var age = 21;
      return (first, last, age);
    }

    public static (string first, string last, int age) LookUpCustomer2(int id)
    {
      var first = "Janse";
      var last = "Kowalsky";
      var age = 21;
      return (first, last, age);
    }
  }
}