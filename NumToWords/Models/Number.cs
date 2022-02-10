using System;
using System.Collections.Generic;

namespace NumToWords.Models
{

  public class Number
  {
    public int Value {get; set; }

    public Number(int number)
    {
      Value = number;
    }

    private string TwoDigits(int val)
    {
      if (val < 20)
      {
        return FirstNinteen[val];
      }
      else
      {
        int ones = val % 10;
        int tens = (val - ones) / 10;
        return TensPlace[tens] + " " + FirstNinteen[ones];  
      }
    }

    public string Name()
    {
      // string digits = Value.ToString();

      if (Value > 99)
      {
        int lessThanHundred = Value % 100;
        int hundreds = (Value - lessThanHundred) / 100;
        string numName = FirstNinteen[hundreds] + " hundred ";
        numName += TwoDigits(lessThanHundred);
        return numName;
      }
      else 
      {
        return TwoDigits(Value);
      }
    }

    private static Dictionary<int, string> FirstNinteen = new Dictionary<int, string>()
    {
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
      {19, "nineteen"}      
    };

    private static Dictionary<int, string> TensPlace = new Dictionary<int, string>()
    {
      {2, "twenty"},
      {3, "thirty"},
      {4, "forty"},
      {5, "fifty"},
      {6, "sixty"},
      {7, "seventy"},
      {8, "eighty"},
      {9, "ninety"},
    };

   }
}