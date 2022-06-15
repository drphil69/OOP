using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject s = new();
            try
            {
                s.Name = "Software Construction";
                s.Code = "XLP-566";
                s.Teacher = "Mads";
                s.ECTS = 5;
                s.StartDate = new DateTime(2022, 1, 1);
                s.EndDate = new DateTime(2022, 2, 2);
                s.ExamsDate = new DateTime(2022, 6, 24);
            }
            catch(ArgumentException e)
            {
                Console.Write($"Fejl: {e.Message}\n");
            }

            string output = s.GetSubjectInfo();
            Console.WriteLine(output);
        }
    }
}
