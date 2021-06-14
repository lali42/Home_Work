using System;
using System.Collections.Generic;
using System.Linq;

public interface IHomework13
{
    int Homework13(IEnumerable<int> numbers);
}

class HomeWork13 : IHomework13
{
    public int Homework13(IEnumerable<int> numbers)
    {
        //result
        List<int> data = new List<int>();

        foreach (var item in numbers)
        {
            string cv = item.ToString();
            var x = cv.Contains("99");
            if (x)
            {
                data.Add(item);
                System.Console.WriteLine($"{item} has 99");
            }
            else
            {
                System.Console.WriteLine($"{item} not found");
            }
        }
        var countData = data.Distinct().ToList().Count;
        return countData;
    }
}
