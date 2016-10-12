using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureworksDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var database = new MyDbContext())
            {
                var currentData = database.Person_People;
                foreach (var item in currentData)
                {
                    Console.WriteLine(item.LastName + ", " + item.FirstName);
                }
            }
        }
    }
}
