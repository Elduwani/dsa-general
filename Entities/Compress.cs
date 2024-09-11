// using System;
// using System.Linq;
namespace DotnetDSA.Entities;

public class Compress()
{
   //https://www.structy.net/problems/compress
   private string Evaluate(string str)
   {
      string result = "";

      for (int i = 0; i < str.Length; i++)
      {
         int counter = 1;
         while (i < str.Length - 1 && str[i] == str[i + 1])
         {
            counter++;
            i++;
         }
         result += $"{counter}{str[i]}";
      }

      return result;
   }

   public void Run()
   {
      var testCases = new List<string>(){
         "ccaaatsss",
         "ssssbbz",
         "ppoppppp",
         "nnneeeeeeeeeeeezz",
         "yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy"
      };

      Console.WriteLine("\n>> Running Compress function <<");
      foreach (var testCase in testCases)
      {
         Console.WriteLine($"{testCase} | {Evaluate(testCase)}");
      }
   }
}

public class Uncompress()
{
   //https://www.structy.net/problems/uncompress
   private string Evaluate(string str)
   {
      string result = "";

      for (int i = 0; i < str.Length; i++)
      {
         string count = str[i].ToString();

         if (int.TryParse(count, out int n))
         {
            while (int.TryParse(str[i + 1].ToString(), out n))
            {
               count += str[i + 1];
               i++;
            }

            result += string.Concat(Enumerable.Repeat(str[i + 1], Convert.ToInt32(count)));
         }
      }

      return result;
   }

   public void Run()
   {
      var testCases = new List<string>(){
         "2c3a1t",
         "4s2b",
         "2p1o5p",
         "3n12e2z",
         "12y"
      };

      Console.WriteLine("\n>> Running Uncompress function <<");

      foreach (var testCase in testCases)
      {
         Console.WriteLine($"{testCase} | {Evaluate(testCase)}");
      }
   }
}