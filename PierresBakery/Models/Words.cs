using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace NumberOfWords.Models
{
  public class Words
  {
    Dictionary<int, string> letterText = new Dictionary<int, string>(){
{0, "zero"},
{1, "one"},
{2, "two"},
{3, "three"},
{4, "four"},
{5, "five"},
{6, "six"},
{7, "seven"},
{8, "eight"},
{9, "nine"},
{10, "ten"},
{11, "eleven"},
{12, "twelve"},
{13, "thirteen"},
{14, "fourteen"},
{15, "fifteen"},
{16, "sixteen"},
{17, "seventeen"},
{18, "eighteen"},
{19, "nineteen"},
{20, "twenty"},
{30, "thirty"},
{40, "fourty"},
{50, "fifty"},
{60, "sixty"},
{70, "seventy"},
{80, "eighty"},
{90, "ninety"}
            };

    public Words()
    {
    }

    public string[] SplitWords(string sentense)
    {
      string[] textSplit = sentense.Split(" ");

      for (int i = 0; i < textSplit.Length; i++)
      {
        string s = textSplit[i];
        // Console.WriteLine(s);
      }
      return textSplit;
    }

  }

}

