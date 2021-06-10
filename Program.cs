using System;
namespace Home_work{
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
            var text = new HomeWork12();
            Console.Write("Please input string: ");
            string input = Console.ReadLine();
            char dup = text.FirstDuplicateCharactor(input);
            char notDup = text.FirstNotDuplicateCharactor(input);
            Console.WriteLine("First duplicate charactor is:"+dup);
            Console.WriteLine("First not duplicate charactor is: "+notDup);

            // Homework11

            // Homework12

            // Homework13
        }
    }
}

