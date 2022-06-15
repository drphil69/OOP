using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation2
{
    public class Supplier
    {
        #region Fields
        private int id;
        private string name;
        private Product product;
        private ContactInfo contactinfo;
        private List<Product> products;
        #endregion

        #region Constructors
        public Supplier(int id, string name, ContactInfo contactinfo)
        {
            Id = id;
            Name = name;
            Product = product;
        }

        public Supplier(int id, string name, List<Product> products, ContactInfo contactinfo):this(id, name, contactinfo)
        {
            products = products;
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
        public Product Product
        {
            get => product; set
            {
                product = value;
            }
        }
        #endregion
    }
}
