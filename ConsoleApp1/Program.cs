using ConsoleApp1.Models;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new testContext())
            {
                //var andrew = new Person
                //{
                //    Dob = new DateTime(1973, 7, 3),
                //    EyeColor = "Brown",
                //    FirstName = "Andrew",
                //    LastName = "Richardson"
                //};

                //context.People.Add(andrew);

                //var amy = new Person
                //{
                //    Dob = new DateTime(1972, 7, 26),
                //    EyeColor = "Blue",
                //    FirstName = "Amy",
                //    LastName = "Helton"
                //};

                //context.People.Add(amy);

                var andrew = context.People.Where(x => x.FirstName.ToLower() == "andrew").FirstOrDefault();

                var amy = context.People.Where(x => x.FirstName.ToLower() == "amy").FirstOrDefault();


                Console.WriteLine($"{andrew.FirstName.Trim()} {andrew.LastName.Trim()}");
                Console.WriteLine($"{amy.FirstName.Trim()} {amy.LastName.Trim()}");




                context.SaveChanges();
            }

         }
    }
}
