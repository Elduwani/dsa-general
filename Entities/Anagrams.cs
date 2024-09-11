// using System;
// using System.Linq;
namespace DotnetDSA.Entities;

public class Anagrams()
{
   //https://www.structy.net/problems/anagrams
   private bool Evaluate(string str1, string str2)
   {
      if (str1.Length != str2.Length)
      {
         return false;
      }

      var map = new Dictionary<string, Dictionary<char, int>>()
      {
         {"str1", new (){}},
         {"str2", new (){}},
      };

      for (int i = 0; i < str1.Length; i++)
      {
         char c = str1[i];
         char d = str2[i];

         if (map["str1"].ContainsKey(c))
         {
            map["str1"][c]++;
         }
         else { map["str1"][c] = 1; }

         if (map["str2"].ContainsKey(d))
         {
            map["str2"][d]++;
         }
         else { map["str2"][d] = 1; }
      }

      foreach (var pair in map["str1"])
      {
         if (!map["str2"].ContainsKey(pair.Key) || map["str2"][pair.Key] != pair.Value)
         {
            return false;
         }
      }

      return true;
   }

   public void Run()
   {
      var testCases = new Dictionary<string, string>()
      {
         {"restful", "fluster"},
         {"cats", "tocs"},
         {"monkeyswrite", "newyorktimes"},
         {"paper", "reapa"},
         {"elbow", "below"},
         {"tax", "taxi"},
         {"taxi", "tax"},
         {"night", "thing"},
         {"abbc", "aabc"},
         {"po", "popp"},
         {"pp", "oo"},
      };

      Console.WriteLine("\n>> Running Anagrams function <<");
      foreach (var testCase in testCases)
      {
         Console.WriteLine($"{testCase.Key} > {testCase.Value} | {Evaluate(testCase.Key, testCase.Value)}");
      }
   }
}