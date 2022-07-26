using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_Library
{
    internal class Newspaper
    {
        static List<Newspaper> newsList = new List<Newspaper>();
        static Newspaper news = new Newspaper();
        public string Name;
        public DateTime PaperDate;


        public static void GetNewspaper()
        {
           
            Console.Write("Newspaper Name:");
            news.Name = Console.ReadLine();

            news.PaperDate = DateTime.Now;
            Console.WriteLine("Date-{0} and Time-{1}", news.PaperDate.ToShortDateString(), news.PaperDate.ToShortTimeString());
            
            newsList.Add(new Newspaper() { Name = "Lokmat" });
            newsList.Add(new Newspaper() { Name = "Indian Express" });

            newsList.Add(news);
        }

        public static void Return()
        {
            Newspaper news = new Newspaper();
            Console.WriteLine("Enter Following Details:");

            Console.Write("Newspaper name:");
            string name = Console.ReadLine();

            if (newsList.Exists(y => y.Name == name ))
            {
                Console.WriteLine("Newspaper Found",name);
            }
            else
            {
                Console.WriteLine("Newspaper not found:{0}",name);
            }
        }

       
    }
}
