using System;
using System.Linq;

public interface IHomework12
{
    // char FirstDuplicateCharactor(string text);
    char FirstNotDuplicateCharactor(string text);
}

class HomeWork12 : IHomework12
{
    public char FirstDuplicateCharactor(string text)
    {

        string str = text;
        string output = null;
        char output1 = '-';
        int[] fiArray = new int[256];
        for (int i = 0; i < 256; i++)
            fiArray[i] = -1;

        for (int i = 0; i < text.Length; i++)
        {
            if (fiArray[text[i]] == -1)
            {
                fiArray[text[i]] = i;
            }
            else
            {
                fiArray[text[i]] = -2;
            }
        }

        int res = Int32.MaxValue;

        for (int i = 0; i < 256; i++)
        {
            // if (fiArray[i] >= 0)
            //     res = Math.Min(res, fiArray[i]);
            // Console.WriteLine("res : " + res);
            if (fiArray[i] >= 0)
                res = Math.Min(res, fiArray[i]);
            Console.WriteLine("res : " + res);

        }

        if (res != Int32.MaxValue)
        {
            output = string.Join(" ", str[res]);
            output1 = Convert.ToChar(output);
            // Console.WriteLine(output1);
        }
        return output1;

    }
    public char FirstNotDuplicateCharactor(string text)
    {

        string str = text;
        string output = null;
        char output1 = '-';
        int[] fiArray = new int[256];
        for (int i = 0; i < 256; i++)
            fiArray[i] = -1;

        for (int i = 0; i < text.Length; i++)
        {
            if (fiArray[text[i]] == -1)
            {
                fiArray[text[i]] = i;
            }
            else
            {
                fiArray[text[i]] = -2;
            }
        }

        int res = Int32.MaxValue;
        // Console.WriteLine("res : "+res);

        for (int i = 0; i < 256; i++)
        {
            if (fiArray[i] >= 0)
                res = Math.Min(res, fiArray[i]);
        }

        if (res != Int32.MaxValue)
        {
            output = string.Join(" ", str[res]);
            output1 = Convert.ToChar(output);
            // Console.WriteLine(output1);
        }
        return output1;

    }


}
