using DotnetDSA.Algo;

namespace DotnetDSA;

class Program
{
   static void Main(string[] args)
   {
      new Compress().Run();
      new Uncompress().Run();
   }
}
