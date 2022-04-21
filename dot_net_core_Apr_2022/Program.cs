using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dot_net_core_Apr_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path1 = "c:\\temp\\temp1.txt";
            //string path2 = @"c:\temp\temp1.txt";


            ////Regex re = new Regex(@"^a{5}$");
            ////var res = Regex.IsMatch("aaaaa", @"^a{5}$");


            //// mike75 @company.com
            //PrintIsValid("aaaaa", @"^a{5,9}$");
            //PrintIsValid("mike_75", @"^[a-zA-Z0-9_]{3,}$");
            //PrintIsValid("75a", @"^\d{1,}$");
            //PrintIsValid("mike_75a", @"^\w{1,}$");


            //PrintIsValid("cccccccccccccccat", @"^c+at$");
            //PrintIsValid("at", @"^c?at$");

            //PrintIsValid("gogogogo", @"^(go){3}$");

            //PrintIsValid("sat", @"^s(e|i)t$");

            //// \w => [0-9a-zA-Z_]

            //// Console.WriteLine(res);

            //IsEmailValid("mike.zorin@123robertsoncollege.canada");


            //ConsoleKeyInfo cki = Console.ReadKey(true);

            //if (cki.Key == ConsoleKey.Escape)
            //{
            //    Console.WriteLine("You have pressed Esc");
            //}

            //if (cki.Key == ConsoleKey.Enter)
            //{
            //    Console.WriteLine("You have pressed Enter");
            //}

            //Console.ReadLine();

            string str = "hello method extension"; // "Hello
            // var res = StringHelper.FlipFirsLetterCase(str);
            
            var res = str.FlipFirsLetterCase();

            Console.WriteLine(res);

            BigInteger bi1 = new BigInteger(double.MaxValue);
            BigInteger bi2 = new BigInteger(double.MaxValue);

            BigInteger sum = BigInteger.Add( bi1, bi2);
            // Console.WriteLine(sum);

            BigInteger bi3 = BigInteger.Parse("18200000000000000000");
            string str3 = bi3.ToString("N0");
            string[] arr = str3.Split(',');

            foreach (var el in arr)
            {
                PartToWords(el);
            }

        }

        static void PartToWords(string number)
        { 
            /*
             123,000
             */
            number = number.PadLeft(3, '0');
            Console.WriteLine(number);
        }

        static void IsEmailValid(string value)
        {
            Regex re = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

            Console.WriteLine( $" { re.IsMatch(value) } " );
        }

        static void PrintIsValid(string value, string pattern)
        {
            Regex re = new Regex(pattern);
            Console.WriteLine($" {value} and {pattern} {re.IsMatch(value)}");
        }
    }
}
