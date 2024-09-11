using DotnetDSA.Entities;

namespace DotnetDSA;

class Program
{
   static void Main(string[] args)
   {
      new Compress().Run();
      new Uncompress().Run();
      new Anagrams().Run();
      new PairSum().Run();
   }
}
