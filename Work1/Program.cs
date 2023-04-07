using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var cats = new List<string>();

            //cats.Add("black");
            //cats.Add("gray");
            //cats.Add("white");

            //var readonlyListim = new ReadOnlyCollection<string>(cats);

            //foreach (var animals in readonlyListim)
            //{
            //    Console.WriteLine(animals + " ");
            //}

            // 5

            //Dictionary<int, string> studentsNames = new Dictionary<int, string>();
            //studentsNames.Add(1, "Faiq");
            //studentsNames.Add(2, "Shafa");
            //studentsNames.Add(3, "Emil");

            //foreach (KeyValuePair<int, string> stu in studentsNames)
            //    Console.WriteLine("Students " + stu.Key + " " + stu.Value);

            // 6 

            Dictionary<string, string> numbersPeople = new Dictionary<string, string>();
            numbersPeople.Add("Shafiqa", "0554682798");
            numbersPeople.Add("Turan", "05563925862");
            numbersPeople.Add("Faiq", "07054679564");

            foreach (var num in numbersPeople)
                Console.WriteLine("Name: {0}, Number: {1}", num.Key, num.Value);
            {
                if (numbersPeople.ContainsKey("Pit"))
                {
                    Console.WriteLine(numbersPeople["Pit"]);
                }
                string result;

                if (numbersPeople.TryGetValue("Pit", out result))
                {
                    Console.WriteLine(result);
                }
                for (int i = 0; i < numbersPeople.Count; i++)
                {
                    Console.WriteLine("Name: {0}, Number: {1}",
                    numbersPeople.ElementAt(i).Key,
                    numbersPeople.ElementAt(i).Value);
                }
                numbersPeople["AZ"] = "Tural, Tamerlan";
                if (numbersPeople.ContainsKey("three"))
                {
                    numbersPeople["three"] = "Faiq";
                }
                numbersPeople.Remove("Faiq");
                if (numbersPeople.ContainsKey("three"))
                {
                    numbersPeople.Remove("three");
                    numbersPeople.Clear();
                }
            }

            }
        }
    }

