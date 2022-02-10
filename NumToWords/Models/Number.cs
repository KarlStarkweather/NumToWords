using System;
using System.Collections.Generic;

namespace NumToWords.Models
{

  public class Number
  {
    public int Value {get; set; }

    public string Name()
    {
      return Ones[Value];
    }

    private static Dictionary<int, string> Ones = new Dictionary<int, string>()
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
      {10, "ten"}
    };

    
    public Number(int number)
    {
      Value = number;
    }
  }
}