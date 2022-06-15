using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new();
            p.FirstName = "Karl";
            p.LastName = "Hansen";
            p.Height = 175;
            p.Weight = 76;
            p.BirthDate = new DateTime(1946, 01, 02);

            string initials = p.GetInitials();
            Console.WriteLine(initials);

            int age = p.GetAgeToday();
            Console.WriteLine(age);

            Console.WriteLine("Skriv en alder for at se om Karl er ældre end det");
            int ageInput = Convert.ToInt32(Console.ReadLine());
            bool isOlder = p.IsOlderThan(ageInput);
            Console.WriteLine(isOlder);

            Console.WriteLine("Skriv et årstal for at se hvor gammel Karl var det år");
            int yearOfChoice = Convert.ToInt32(Console.ReadLine());
            if (yearOfChoice < p.BirthDate.Year)
            {
                Console.WriteLine("Der var Karl vidst ikke født");
            }
            else
            {
                int ageAt = p.GetAgeAt(yearOfChoice);
                Console.WriteLine(ageAt);
            }

            double bmiResult = p.GetBmi();
            Console.WriteLine($"Karls BMI er på {bmiResult}");

            string specificBmi = p.BmiDescription();
            Console.WriteLine(specificBmi);

            string narrativeDescription = p.NarrativeDescription();
            Console.WriteLine(narrativeDescription);
        }
    }
}