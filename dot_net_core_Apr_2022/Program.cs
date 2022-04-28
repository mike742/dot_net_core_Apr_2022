using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Console;
// using Newtonsoft.Json;
using ProtectData;

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

            //string str = "hello method extension"; // "Hello
            //// var res = StringHelper.FlipFirsLetterCase(str);

            //var res = str.FlipFirsLetterCase();

            //Console.WriteLine(res);

            //BigInteger bi1 = new BigInteger(double.MaxValue);
            //BigInteger bi2 = new BigInteger(double.MaxValue);

            //BigInteger sum = BigInteger.Add( bi1, bi2);
            //// Console.WriteLine(sum);

            //BigInteger bi3 = BigInteger.Parse("925200000000000000000");
            //string str3 = bi3.ToString("N0");
            //string[] arr = str3.Split(',');

            //// 925,200,000,000,000,000,000
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    string number = PartToWords(arr[i]);
            //    number = number == "" ? "" : " " + LargeNumberToWord(arr.Length - i);

            //    Console.WriteLine(number);
            //}


            //string path = @"d:\tmp\file1.txt";

            //WriteLine( $"file exists = {File.Exists(path)}" );

            //WriteLine($" filename = { Path.GetFileName(path) } ");

            //string path2 = Path.Combine(@"d:\", "content", "webpage", "www", "folder 1", "index.html");
            //WriteLine(path2);

            //for (int i = 0; i < 5; ++i)
            //{
            //    var res = Path.GetRandomFileName();
            //    WriteLine(res);
            //}

            //path = "sample.txt";
            //string fileContent = String.Empty;
            //if (File.Exists(path))
            //{
            //    fileContent = File.ReadAllText(path);
            //    WriteLine(fileContent);
            //}

            ////var jss = new JsonSerializer();
            ////jss.Deserialize<Top>()
            //Top result = System.Text.Json.JsonSerializer.Deserialize<Top>(fileContent);

            //result.Print();

            //var xs = new XmlSerializer(typeof(Top));
            //string xmlFile = "data.xml";
            //using (FileStream fs = File.Create(xmlFile))
            //{
            //    xs.Serialize(fs, result);
            //}

            string pwd = "admin1234";

            string hidden = ProtectData.ProtectData.toMD5(pwd);

            WriteLine(hidden == ProtectData.ProtectData.toMD5("admin1234"));

            // WriteLine( ProtectData.ProtectData.GenerateSecretKey() );
            string sk = "3@hhp0P9:QNFedJ]?]gk8`UO0g@c]PE:";

            string increpted = ProtectData.ProtectData.EncryptString(sk, "1234-5678-9012-3456");

            WriteLine(increpted);

            WriteLine(ProtectData.ProtectData.DecryptString(sk, increpted));

            string pwd2 = "Pa$$w0rd";
            WriteLine( ProtectData.ProtectData.SaltAndHash(pwd2) );

        }
        static string LargeNumberToWord(int value)
        {
            string[] largeMap = new[] {
            "", "thousand", "million", "billion",
            "trillion", "quadrillion", "quintillion", "sextillion", "septillion", "octillion",
            "nonillion", "decillion", "undecillion", "duodecillion", "tredecillion",
            "Quattuordecillion", "Quindecillion", "Sexdecillion", "Septdecillion",
            "Octodecillion", "Novemdecillion", "Vigintillion"
            };

            return largeMap[value];
        }

        static string PartToWords(string part)
        {
            var unitsMap = new[] {
                "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
                "seventeen", "eighteen", "nineteen"
            };
            var tensMap = new[] {
                "", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty"
            };
            /*
             123,000
             */
            int index;
            string res = string.Empty;
            part = part.PadLeft(3, '0');
            Console.WriteLine(part);

            if (part[0] != '0')
            {
                index = Convert.ToInt32(part[0].ToString());
                res += unitsMap[index] + " hundred";
            }

            if (part[1] == '1')
            {
                index = Convert.ToInt32(part[1].ToString() + part[2].ToString());
                res += " " + unitsMap[index];
            }
            else if (part[1] != '0')
            {
                index = Convert.ToInt32(part[1].ToString());
                res += " " + tensMap[index];
            }

            if (part[2] != '0')
            {
                index = Convert.ToInt32(part[2].ToString());
                res += " " + unitsMap[index]; 
            }

            return res;
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
