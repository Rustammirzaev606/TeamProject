using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreProject
{
    class BaseClass
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Color { get; set; }
        public double Size { get; set; }
        public double Price { get; set; }
        public double Subtotal { get; set; }
        public double Discount { get; set; }
        public double DiscountRate { get; set; }
        

        public void PrintMethod()
        {

            Console.WriteLine(String.Format($"{ID}  {Name, 3}, {Color.PadLeft(30)}, {Size}, {Price.ToString("C")}"), 51);

        }
    }
}    
