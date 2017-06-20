using System.Collections.Concurrent;

namespace _08_ExpressionBodiedMembers
{
  class Program
  {
    static void Main(string[] args)
    {
    }
  }

  public class Person
  {
    private static ConcurrentDictionary<int, string> names = new ConcurrentDictionary<int, string>();

    private int id = GetId();

    // constructors
    public Person(string name) => names.TryAdd(id, name);

    // destructors
    ~Person() => names.TryRemove(id, out string value);

    // getters & setters
    public string Name
    {
      get => names[id];
      set => names[id] = value;
    }

    public static int GetId()
    {
      return 44;
    }
  }
}
