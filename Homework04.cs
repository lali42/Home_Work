using System;

namespace Home_Work
{
    class Homework04
    {
        static void Main(string[] args)
        {
            string num;
            string delimiterChars = ",";
            Console.Write("Enter Your Number : ");
            num = Console.ReadLine();
            String[] numArray = num.Split(delimiterChars);

            foreach (var item in numArray)
            {
                int i = (item.Length - 1);
                double sum = 0, j = 0;
                while (i >= 0)
                {
                    sum += Convert.ToDouble(item.Substring(i, 1)) * Convert.ToDouble(Math.Pow(2.00, Convert.ToDouble(j)));
                    j++;
                    i--;
                }
                // Console.Write(sum + ",");
                if (sum % 5 == 0)
                {
                    Console.WriteLine(item + ",");
                }

            }

        }
    }
}