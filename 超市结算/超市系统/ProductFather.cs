using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市系统
{ 
    class ProductFather
    {
        public string Name
        {
            get;
            set;
        }
        public double Price
        {
            get;
            set;
        }
        
        public string ID
        {
            get;
            set;
        }
        public ProductFather(string Name, double Price, string ID)
        {
            this.Name = Name;
            this.Price = Price;
            this.ID = ID;
        }
    }
}
