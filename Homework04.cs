using System;
using System.Collections.Generic;
using System.Linq;

public interface IHomework04
{
    string GetDivisibleBy5Text(string text);
}

class Homework04 : IHomework04
{
    public string GetDivisibleBy5Text(string text)
    {
        string num = text;
        string[] numArray = num.Split(",");
        List<string> getValue = new List<string>();
        // string output = "";

        foreach (var item in numArray)
        {
            int i = (item.Length - 1);
            double
                sum = 0,
                j = 0;
            while (i >= 0)
            {
                sum +=
                    Convert.ToDouble(item.Substring(i, 1)) *
                    Convert.ToDouble(Math.Pow(2.00, Convert.ToDouble(j)));
                j++;
                i--;
            }
            if (sum % 5 == 0)
            {
                getValue.Add(item);
            }
        }
        
        string output = string.Join(",",getValue);
        return output;
    }
}
