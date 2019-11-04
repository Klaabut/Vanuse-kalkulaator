using System;
using static System.Console;
using static System.DateTime;
namespace Kodutöö07._10._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta enda sünnikuupäev (päev/kuu/aasta) (/)-ga eraldades:");
            string userinfo = Console.ReadLine();
            
            DateOfBirth(userinfo);

            
            
        }

        public static void DateOfBirth(string userinfo)
        {
            string[] userDOB = userinfo.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            var CurrentDate = DateTime.UtcNow;
            
            System.DateTime DOB = new System.DateTime(int.Parse(userDOB[2]), int.Parse(userDOB[1]), int.Parse(userDOB[0]));
            
            WriteLine($"The current date is {CurrentDate}");
            System.TimeSpan Age = CurrentDate.Subtract(DOB);
            Console.WriteLine($"Te olete {Age.TotalSeconds} sekundit vana");
        }


        public static void AgeInSec()
        {
            

        }
    }
}
