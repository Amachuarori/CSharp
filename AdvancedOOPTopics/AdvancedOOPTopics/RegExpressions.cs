using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdvancedOOPTopics
{
    internal class RegExpressions
    {
        public void Run()
        {
            string pattern1 = @"\d{5}";
            Regex regex = new Regex(pattern1);
            string text = "hi there my number is 12345 98765";
            MatchCollection matchCollection = regex.Matches(text);
            Console.WriteLine("{0} hits found: \n {1}" , matchCollection.Count, text);

            foreach(Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }

            Console.WriteLine();

            string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
            Regex reg = new Regex(@"\w*губ\w*");
            MatchCollection matches = reg.Matches(s);
            foreach(Match e in matches)
            {
                Console.WriteLine(e.Value);
            }

            string n = "222-435-2318 44-43-33";

            // @"[2]*-[0-9]{3}-\d{4}"   "[0-9]{3}-[0-9]{3}-[0-9]{4}"
            Regex rege = new Regex(@"[2]*-[0-9]{3}-\d{4}");
            MatchCollection match = rege.Matches(n);

            foreach(Match mat in match)
            {
                Console.WriteLine(mat.Value);
            }

            Console.WriteLine();

            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            var data = new string[]
            {
                "Tom@gmail.com",
                "+12345678999",
                "bob@yahoo.com",
                "+13435465566",
                "sam@yandex.ru",
                "+43743989393"
            };

            Console.WriteLine("Email list");
            foreach(var e in data)
            {
                if(Regex.IsMatch(e, pattern, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine(e);
                }
            }

            Console.WriteLine();
            string text1 = "Мама  мыла  раму. ";
            string pattern2 = @"\s+";
            string target = " ";
            Regex regex1 = new Regex(pattern2);
            string result = regex1.Replace(text1, target);
            Console.WriteLine(result);
            Console.WriteLine();

            string phoneNumber = "+1(876)-234-12-98";
            Console.WriteLine(phoneNumber);
            string pattern3 = @"\D";
            string target1 = "";
            Regex regex3 = new Regex(pattern3);
            string result2 = regex3.Replace(phoneNumber, target1);
            Console.WriteLine(result2);

        }
    }
}
