﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Home_work
{
    class Program
    {
        static void Main(string[] args)
        {
            // Homework04
            // var num = new Homework04();
            // Console.Write("Enter Your Number : ");
            // string text = Console.ReadLine();
            // var output = num.GetDivisibleBy5Text(text);
            // Console.WriteLine(output);

            // Homework05
            // var index = new Homework05();
            // Console.Write("Please choose LED to turn On/Off: ");
            // string input = Console.ReadLine();
            // var led = index.DisplayLEDOnScreen(input);
            // Console.WriteLine(led);

            // Homework07

            // Homework11

            // Homework12
            // var text = new HomeWork12();
            // Console.Write("Please input string: ");
            // string input = Console.ReadLine();
            // char dup = text.FirstDuplicateCharactor(input);
            // char notDup = text.FirstNotDuplicateCharactor(input);
            // Console.WriteLine("First duplicate charactor is:"+dup);
            // Console.WriteLine("First not duplicate charactor is: "+notDup);

            // Homework13
            var number = new HomeWork13();
            // IEnumerable<int> data = Enumerable.Range(000000,999999).Select(x => x * x);
            IEnumerable<int> data = new List<int>() {   000000, 000099, 009900, 990000,
                                                        000999, 009990, 099900, 999000,
                                                        990999, 919909, 999799, 999999, };
            var numbers = number.Homework13(data);
            Console.WriteLine(numbers);

        }
    }
}
