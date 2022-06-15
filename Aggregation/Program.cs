using System;

namespace Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContactInfo c1 = new(69, "info@ølbutikken.dk", 304);
                ContactInfo c2 = new(420, "kontakt@sekretariatsministeriet.dk", 10203040);
                ContactInfo c3 = new(21, "dyrtalkohol@eskes.dk", 20304050);
                ContactInfo c4 = new(78, "living@ontheedge.dk", 40506070);
                ContactInfo c5 = new(87, "okay@fam.dk", 12345678);
                ContactInfo c6 = new(12, "fam@okay.dk", 87654321);
                ContactInfo c7 = new(14, "silence@ikillyou.dk", 56473819);

                Supplier s = new(1, "Ølbutikken", c1);

                Supplier s2 = new(2, "Sekretariatsministeriet", c2);
                Supplier s3 = new(3, "Eskes", c3);
                Supplier s4 = new(4, "Living on the edge", c4);

                Supplier s5 = new(2, "Sekretariatsministeriet", null);
                s5.ContactInfo = c5;
                Supplier s6 = new(3, "Eskes", null);
                s6.ContactInfo = c6;
                Supplier s7 = new(4, "Living on the edge", null);
                s7.ContactInfo = c7;

                Console.WriteLine(s.ContactInfo.ToString());
            }
            catch (ArgumentException e)
            {
                Console.Write($"Fejl: {e.Message}\n");
            }
        }
    }
}
