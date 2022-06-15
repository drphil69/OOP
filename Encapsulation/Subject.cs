using System;
using System.Linq;

namespace Encapsulation
{
    class Subject
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length <= 4)
                {
                    throw new ArgumentException("Fagets navn er for kort");
                }
                name = value;
            }
        }
        private string code;
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                if (value.Length != 7)
                {
                    throw new ArgumentException("Koden skal være 7 tegn");
                }
                else if
                    (
                    !(Char.IsDigit(value[4]) && 
                    Char.IsDigit(value[5]) &&
                    Char.IsDigit(value[6]) && 
                    value[4] != '0')
                    )
                {
                    throw new ArgumentException("De 3 sidste cifre skal være tal (ikke 0)");
                }
                else if (value[3] != '-')
                {
                    throw new ArgumentException("Kodens tegn nummer 4 skal være bindestreg");
                }
                else if
                    (
                    !(Char.IsUpper(value[0]) &&
                    Char.IsUpper(value[1]) &&
                    Char.IsUpper(value[2])
                    ))
                {
                    throw new ArgumentException("De første 3 tegb skal være store bogstaver");
                }
                code = value;
            }
        }
        private string teacher;
        public string Teacher
        {
            get
            {
                return teacher;
            }
            set
            {
                if (value.Length <= 1 && value.Length > 0)
                {
                    throw new ArgumentException("Skriv et navn, ikke et bogstav");
                }
                else if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Ugyldigt navn");
                }
                else if (value.Any(c => Char.IsDigit(c)))
                {
                    throw new ArgumentException("Et navn indeholder ikke tal");
                }
                teacher = value;
            }
        }
        private int ects;
        public int ECTS
        {
            get
            {
                return ects;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("ECTS point skal være i intervallet [0-10]");
                }
                ects = value;
            }
        }
        private DateTime startdate;
        private DateTime enddate;
        public DateTime EndDate
        {
            get => enddate;
            set
            {
                if (StartDate > value)
                {
                    throw new ArgumentException("Startdatoen skal være højere end slutdatoen");
                }
                enddate = value;
            }
        }
        public DateTime ExamsDate { get; set; }
        public string GetSubjectInfo()
        {
            return $"\nFag: {Name}\nKode: {Code}\nUnderviser: {Teacher}\nECTS point: {ECTS}\nStartdato: {StartDate}\nSlutdato: {EndDate}\nEksamensdato: {ExamsDate}";
        }
    }
}
