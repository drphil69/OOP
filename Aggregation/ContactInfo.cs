using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    public class ContactInfo
    {
        #region Fields
        private int id;
        private string mail;
        private int phoneNumber;
        #endregion

        #region Constructors
        public ContactInfo(int id, string mail, int phoneNumber)
        {
            Id = id;
            Mail = mail;
            PhoneNumber = phoneNumber;
        } 
        #endregion

        #region Properties
        public int Id
        {
            get => id;
            private set
            {
                if (id < 0)
                {
                    throw new ArgumentException("Kan ikke være mindre end 0");
                }
                id = value;
            }
        }
        public string Mail
        {
            get => mail; set
            {
                mail = value;
            }
        }
        public int PhoneNumber
        {
            get => phoneNumber; set
            {
                if (phoneNumber.ToString().Count() <= 4)
                {
                    throw new ArgumentException("Et telefonnummer skal mindst have 4 cifre");
                }
                phoneNumber = value;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id: {id}, Mail: {mail}, Phone Number: {phoneNumber}";
        } 
        #endregion
    }
}
