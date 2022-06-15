using System;
using System.Linq;
using System.Collections.Generic;

namespace Aggregation
{
    public class Supplier
    {
        #region Fields
        private int id;
        private string name;
        private ContactInfo contactInfo;
        
        #endregion

        #region Constructors
        public Supplier(int id, string name, ContactInfo contactInfo)
        {
            Id = id;
            Name = name;
            ContactInfo = contactInfo;
        }
        #endregion

        #region Properties
        public int Id
        {
            get => id; set
            {
                id = value;
            }
        }
        public string Name
        {
            get => name; set
            {
                name = value;
            }
        }
        public ContactInfo ContactInfo
        {
            get => contactInfo; set
            {
                contactInfo = value;
            }
        }
        #endregion

        #region Methods
        public bool? IsDanish()
        {
            if (contactInfo != null)
            {
                string mailTld = contactInfo.Mail.Split('.').LastOrDefault();
                if (mailTld == "dk")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        } 
        #endregion
    }
}
