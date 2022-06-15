using System;

namespace Basics
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public DateTime BirthDate { get; set; }

        public string GetInitials()
        {
            string firstNameInitials = FirstName.Substring(0, 2);
            string lastNameInitials = LastName.Substring(0, 2);
            string upperFirstNameInitials = firstNameInitials.ToUpper();
            string upperLastNameInitials = lastNameInitials.ToUpper();
            return $"{upperFirstNameInitials}{upperLastNameInitials}";
        }

        public int GetAgeToday()
        {
            int thisYear = DateTime.Now.Year;
            return thisYear - BirthDate.Year;
        }

        public bool IsOlderThan(int input)
        {
            int age = GetAgeToday();
            if (age < input)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetAgeAt(int date)
        {
            return date - BirthDate.Year;
        }

        public double GetBmi()
        {
            double BMI;
            double h = Height / 100;
            BMI = Weight / (h * h);
            return BMI;
        }

        public string BmiDescription()
        {
            double bmi = GetBmi();
            if (bmi < 18.5)
            {
                return "Du er undervægtig";
            }
            else if (bmi < 25)
            {
                return "Du er normalvægtig";
            }
            else if (bmi < 30)
            {
                return "Du er næsten overvægtig";
            }
            else if (bmi < 35)
            {
                return "Du er overvægtig";
            }
            else if (bmi < 40)
            {
                return "Du er meget overvægtig";
            }
            else
            {
                return "Du er ekstremt overvægtig";
            }
        }

        public string NarrativeDescription()
        {
            return $"Der var engang en lille mand der hed {FirstName}, med efternavnet {LastName}. Hans fødselsdato er {BirthDate.Year}/{BirthDate.Month}/{BirthDate.Day}. Han er {Height} cm høj og vejer {Weight} kilo.";
        }
    }
}