using System;
using System.Linq;

public interface IHomework07
{
    string RemoveAndSortTextByAlphabetical(string text);
}

class Homework07 : IHomework07
{
    // static void Main(string[] args)
    // {
    //     // string text;
    //     // Console.WriteLine();
    //     string text = Console.ReadLine();
    //     var result = string.Join(" ", text.Split(' ').Distinct());
    //     string[] textArray = result.Split(" ");
    //     Array.Sort(textArray);
    //     foreach (var t in textArray)
    //     {
    //         Console.Write(t+" ");
    //     }
    // }
    public string RemoveAndSortTextByAlphabetical(string text)
    {
        var result = string.Join(" ", text.Split(' ').Distinct());
        string[] textArray = result.Split(" ");
        Array.Sort (textArray);
        string output = "";
        output = string.Join(" ", textArray);

        return output;
    }
}
