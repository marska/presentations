using System;

namespace _06_RefReturnsAndLocals
{
  class Program
  {
    static void Main()
    {
      int[] array = { 1, 3, 5, 7, 13, 17, 21 };

      ref int place = ref Find(7, array);
      place = 44;

      Console.WriteLine(array[3]);
    }

    public static ref int Find(int number, int[] numbers)
    {

      for (int i = 0; i < numbers.Length; i++)
      {
        if (numbers[i] == number)
        {
          return ref numbers[i];
        }
      }

      throw new IndexOutOfRangeException($"{nameof(number)} not found");
    }

  }
}