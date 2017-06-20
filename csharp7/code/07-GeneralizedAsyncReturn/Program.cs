using System.Threading.Tasks;
using static System.Console;

namespace _07_GeneralizedAsyncReturn
{
  class Program
  {
    static void Main()
    {
      ApiAsync api = new ApiAsync();

      var reult = api.Func();

      WriteLine(reult);
    }
  }

  public class ApiAsync
  {
    public async ValueTask<int> Func()
    {
      await Task.Delay(1);

      return 5;
    }
  }
}
