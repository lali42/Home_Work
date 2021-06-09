using System;
namespace Home_work{
    class Program
    {
        static void Main(string[] args)
        {
            Homework04 num = new Homework04();
            Console.Write("Enter Your Number : ");
            string text = Console.ReadLine();
            var output = num.GetDivisibleBy5Text(text);
            Console.WriteLine(output);
        }
    }
}

