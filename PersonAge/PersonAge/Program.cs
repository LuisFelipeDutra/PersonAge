using System;

namespace PersonAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Send the year: ");
            var year = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Send the month: ");
            var month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Send the day: ");
            var day = Convert.ToInt32(Console.ReadLine());

            PersonAge personAge = new PersonAge();
            var age = personAge.DateOfBirth = new DateTime(year, month, day);

            int result = personAge.Age(age);

            Console.WriteLine("You have " + result + " years old :)");
        }
    }
}
