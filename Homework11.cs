using System;

namespace Home_Work
{

    class Homework11
    {
        public static string cv(int num)
        {

            string[][

            ] th_num = new string[3][];
            string[] th_digit = { "", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน" };

            th_num[0] = new string[10] { "", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า" };
            th_num[1] = new string[2] { "หนึ่ง", "เอ็ด" };
            th_num[2] = new string[2] { "สอง", "ยี่" };

            string tosrt = num.ToString();
            int ln = tosrt.Length;
            // Console.WriteLine(ln);
            if (tosrt == "0")
            {
                Console.WriteLine("ศูนย์");
            }
            string t = "";
            for (int i = ln; i > 0; i--)
            {
                var x = i - 1;
                var n = Convert.ToInt32(tosrt.Substring(ln - i, 1));
                var digit = x % 6;
                // Console.WriteLine("digit " + digit);
                // Console.WriteLine("n " + n);
                // Console.WriteLine("x " + x);

                if (n != 0)
                {
                    if (n == 1)
                    {
                        // Console.WriteLine(digit == 0 ? 1 : 0);
                        if (digit >= 2)
                        {
                            t += (digit == 1) ? "" : th_num[1][digit >= 2 ? 0 : 1];
                        }
                        else if(x == 6){
                            t += (digit == 1) ? "" : th_num[1][digit == 0 ? 0 : 1];
                        }
                        else
                        {
                            t += (digit == 1) ? "" : th_num[1][digit == 0 ? 1 : 0];
                        }
                    }
                    else if (n == 2)
                    {
                        t += th_num[2][digit == 1 ? 1 : 0];
                    }
                    else
                    {
                        t += th_num[0][n];
                    }
                    t += th_digit[(digit == 0 && x > 0 ? 6 : digit)];
                }
                else
                {
                    t += th_digit[digit == 0 && x > 0 ? 6 : 0];
                }
            }
            return t;
        }
        // static void Main(string[] args)
        // {

        //     Console.Write("Please input number: ");
        //     int num = Convert.ToInt32(Console.ReadLine());
        //     // var num = "1111";
        //     // var data = Convert.ToDecimal(num).ToString().Split('.');
        //     // string dic = "";
        //     // if (cv(data[1]) == "") { dic = ""; } else { dic = cv(data[1]) + "สตางค์"; };
        //     // string convert = cv(data[0]) + "บาท" + dic;
        //     string convert = cv(num);
        //     if (num >= 10000000)
        //     {
        //         Console.WriteLine("รองรับตัวเลขได้เพียหลักล้านเท่านั้น!");
        //     }
        //     else
        //     {
        //         Console.WriteLine(convert);
        //         System.Console.ReadKey();
        //     }

        // }
    }
}