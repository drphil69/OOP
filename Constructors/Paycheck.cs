using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Paycheck
    {
        #region Fields
        private (DateTime start, DateTime end) interval;
        private double taxPercentage;
        private decimal hoursWorked;
        private decimal hourlyRate;
        #endregion

        #region Constants
        private readonly DateTime minimumIntervalDate = new DateTime(2000, 1, 1);
        private readonly DateTime maximumIntervalDate = new DateTime(2050, 1, 1); 
        #endregion

        #region Constructors
        public Paycheck((DateTime start, DateTime end) interval, double taxPercentage, decimal hoursWorked, decimal hourlyRate)
        {
            Interval = interval;
            TaxPercentage = taxPercentage;
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
        } 
        #endregion

        #region Properties
        public (DateTime start, DateTime end) Interval
        {
            get => interval; set
            {
                //Extract tuple elements:
                DateTime start = value.start;
                DateTime end = value.start;

                //Validate min and max:
                if (start < minimumIntervalDate)
                {
                    throw new ArgumentOutOfRangeException("Start date is too early");
                }
                else if (start > maximumIntervalDate)
                {
                    throw new ArgumentOutOfRangeException("End date is too late");
                }
                else if (end <= start)
                {
                    throw new ArgumentOutOfRangeException("End is earlier than start");
                }

                //Validate business rules:
                if(start.Date.AddDays(13) == end.Date)
                //weekly
                {
                    if (start.DayOfWeek == DayOfWeek.Monday)
                    {
                        interval = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("14 day interval does not start on a monday");
                    }
                }
                else //montly
                {
                    if (start.Day != 1)
                    {
                        throw new ArgumentOutOfRangeException("First day of provided monthly interval is not day one in that month");
                    }
                    int daysInMonth = DateTime.DaysInMonth(start.Year, start.Month);
                    if (start.AddDays(daysInMonth) != end.Date)
                    {
                        throw new ArgumentOutOfRangeException("End date must be the last date in the month of the start date");
                    }
                    else
                    {
                        interval = value;
                    }
                }
                interval = value;
            }
        }
        public double TaxPercentage
        {
            get => taxPercentage; set
            {
                if (taxPercentage > 100 || taxPercentage <= 0)
                {
                    throw new ArgumentOutOfRangeException("Procenten skal være i intervallet [0:100]");
                }
                taxPercentage = value;
            }
        }
        public decimal HoursWorked
        {
            get => hoursWorked; set
            {
                if (hoursWorked < 0)
                {
                    throw new ArgumentOutOfRangeException("Man kan ikke arbejde i minus timer");
                }
                hoursWorked = value;
            }
        }
        public decimal HourlyRate
        {
            get => hourlyRate; set
            {
                if (hourlyRate < 0)
                {
                    throw new ArgumentOutOfRangeException("Din timeløn kan ikke være i minus");
                }
                hourlyRate = value;
            }
        }
        #endregion

        #region Methods
        public decimal GetGrossSalary()
        {
            return hoursWorked * hourlyRate;
        }

        public decimal GetNetSalary()
        {
            return GetGrossSalary() - GetTaxAmount();
        }

        public decimal GetTaxAmount()
        {
            return GetGrossSalary() * (decimal)taxPercentage;
        }
        public override string ToString()
        {
            return $"Gross:\t{GetGrossSalary():c2}\nNet:\t{GetNetSalary():c2}\nTax:\t{GetTaxAmount():c2}";
        }
        #endregion
    }
}
