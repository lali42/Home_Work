using System;
using System.Collections.Generic;

public interface IHomework13
{
    int Homework13(IEnumerable<int> numbers);
}

class HomeWork13 : IHomework13
{
    public int Homework13(IEnumerable<int> numbers)
    {
        List<int> data = new List<int>();
        foreach (var item in numbers)
        {
            string cv = Convert.ToString(item);
            for (int i = 0; i < cv.Length; i++)
            {
                if (cv[i] == 9)
                {
                    if (data[i - 1] == cv[i])
                    {
                        data.Add(cv[i]);
                    }
                    else
                    {
                        data.Add(cv[i]);
                    }
                    // Console.WriteLine("data : " + data);
                }
            }
        }
        int[] dataNumber = data.ToArray();
        return dataNumber;
        // throw new NotImplementedException();
    }
}
