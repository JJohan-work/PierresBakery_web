using System;
using System.Collections.Generic;
using NumberOfWords.Models;
using System.Text.RegularExpressions;
using System.Linq;

namespace NumberOfWords
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a sentense:");
      string userEntereredSentence = Console.ReadLine();
      Words newWord = new Words();
      string [] temp = newWord.SplitWords(userEntereredSentence);

      
       for (int i = 0; i< temp.Length; i++)
        {
            // string currentWord = temp[i].match(/\d{1,3}/);
            string currentWord = temp[i];
            string stringResult = Regex.Match(currentWord, @"\d+").Value;
            stringResult = stringResult.Trim();
            // Console.WriteLine(typeof(stringResult));//typeof(T)
            int intResult;
            int.TryParse(stringResult, out intResult);
            // int intResult = int.Parse(stringResult);
            // if (temp[i] string s = temp[i];
            // Console.WriteLine(i);
            Console.WriteLine(intResult);
        }
    }
  }
}