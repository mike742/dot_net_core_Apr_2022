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
using System.Runtime.Serialization.Formatters.Binary;
using dot_net_core_Apr_2022.Models;
using System.Xml.Serialization;

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

            //string pwd = "admin1234";

            //string hidden = ProtectData.ProtectData.toMD5(pwd);

            //WriteLine(hidden == ProtectData.ProtectData.toMD5("admin1234"));

            //// WriteLine( ProtectData.ProtectData.GenerateSecretKey() );
            //string sk = "3@hhp0P9:QNFedJ]?]gk8`UO0g@c]PE:";

            //string increpted = ProtectData.ProtectData.EncryptString(sk, "1234-5678-9012-3456");

            //WriteLine(increpted);

            //WriteLine(ProtectData.ProtectData.DecryptString(sk, increpted));

            //string pwd2 = "Pa$$w0rd";
            //WriteLine( ProtectData.ProtectData.SaltAndHash(pwd2) );


            List<Employee> employees = new List<Employee>
            { 
                new Employee {Id = 1, FirstName = "Mark", LastName = "Smith", Salary = 2500},
                new Employee {Id = 2, FirstName = "Lucy", LastName = "Johnson", Salary = 2600},
                new Employee {Id = 3, FirstName = "Tracy", LastName = "Swanson", Salary = 2450},
                new Employee {Id = 4, FirstName = "Mike", LastName = "Doe", Salary = 2900},
            };

            // string file = "Employee.dat";
            //using (Stream st = File.Open(file, FileMode.Create))
            //{
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(st, employees);
            //}

            //using (Stream st = File.Open(file, FileMode.Open))
            //{
            //    BinaryFormatter bf = new BinaryFormatter();

            //    var employees2 = (List<Employee>)bf.Deserialize(st);

            //    foreach (var emp in employees2)
            //    {
            //        WriteLine(emp);
            //    }
            //}

            //customers customers = new customers
            //{
            //    Customers = new List<Customer> {
            //        new Customer
            //        {
            //            Name = "Mark",
            //            Creditcard = "1234-4567-7891",
            //            Password = "admin1234"
            //        }
            //    }
            //};

            // ToXml(customers, "XYZ.xml");

            //var file = "XYZ.xml";
            //var res = FromXml<customers>(file);

            //foreach (var c in res.Customers)
            //{
            //    WriteLine(c.Name + " " + c.Password);
            //}

            List<SerializeFile> files = new List<SerializeFile> {
                new SerializeFile { FileName = "data.xml", FileSize = 123456},
                new SerializeFile { FileName = "data.json", FileSize = 1324},
                new SerializeFile {FileName = "data.dat", FileSize = 12}
            };

            //var res = files.OrderByDescending(f => f.FileSize);

            //foreach (var r in res)
            //{
            //    WriteLine($"{r.FileName} : {r.FileSize}");
            //}


            //List<int> arr = new List<int> { 7, 3, 6, 8, 1, 9 };

            //arr.Sort();
            //arr.Reverse();

            //WriteLine( String.Join(" ", arr)  );

            files.Sort();
            files.Reverse();
            foreach (var file in files)
            {
                WriteLine($"{file.FileName} : {file.FileSize}");
            }

            var context = new AppDbContext();

            var customers = context.Customers.ToList();

            string city = "Boston";

            var result = customers.Where(cus => cus.City == city);

            result.Count();
            foreach (var cus in result)
            {
                WriteLine($"{cus.LastName} {cus.FirstName} : {cus.City}");
            }


            List<string> cities = new List<string>();

            foreach (var customer in customers)
            {
                cities.Add(customer.City);
            }

            WriteLine(String.Join(" ", cities.Distinct()));

            var cities2 = customers.Select(cus => cus.City).ToList().Distinct();

            WriteLine(String.Join(" ", cities2));


            var result3 = customers.Select(cus => new { Id = cus.Id, FullName = cus.FirstName + " " + cus.LastName });

            foreach (var item in result3)
            {
                WriteLine($"{item.Id} : {item.FullName}");
            }

        }


        public static void ToXml<T>(T obj, string xml)
        {
            using (StringWriter sw = new StringWriter(new StringBuilder()))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                xs.Serialize(sw, obj);
                File.WriteAllText(xml, sw.ToString());
            }
        }

        public static T FromXml<T>(string xml)
        {
            using (StringReader st = new StringReader(xml))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                // byte[] bytes = GetResponseByteArray(xml);
                return (T)xs.Deserialize(st);
            }
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
