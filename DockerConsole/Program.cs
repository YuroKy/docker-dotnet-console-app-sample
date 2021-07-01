using System;
using System.Linq;

namespace DockerConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      var name = args.Any() ? args[0] : "stranger";
      Console.WriteLine($"Hello, {name}");
    }
  }
}
