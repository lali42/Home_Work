using System;

namespace HomeWork05e
{
    class new05
    {
        public static void Main(string[]  args){
            string[] status = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        string[] lamps = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
        foreach (var index in status)
        {
            Console.Write("[" + index + "] ");
        }
        Console.WriteLine("");
        foreach (var number in lamps)
        {
            Console.Write(" " + number + "  ");
        }
        Console.WriteLine("");



        while (true)
        {
            // string input = ledNo;
            int n = 0;
            Console.Write("Please choose LED to turn On/Off: ");
            string input = Console.ReadLine();

            foreach (var number in lamps)
            {

                if (input == number && status[n] == " ")
                {
                    status[n] = "!";
                    foreach (var i in status)
                    {
                        Console.Write("[" + i + "] ");
                    }
                    Console.WriteLine("");
                    foreach (var b in lamps)
                    {
                        Console.Write(" " + b + "  ");
                    }
                }
                else if (input == number && status[n] == "!")
                {
                    status[n] = " ";
                    foreach (var i in status)
                    {
                        Console.Write("[" + i + "] ");
                    }
                    Console.WriteLine("");
                    foreach (var b in lamps)
                    {
                        Console.Write(" " + b + "  ");
                    }
                }
                n++;
            }
            Console.WriteLine("");
        }
        }
    }
}
