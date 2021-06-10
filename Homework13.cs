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
        IEnumerable<int> number = numbers;
        foreach (int n in numbers)
        {
            return n;
        }
            // return number;
        throw new NotImplementedException();
    }
}
