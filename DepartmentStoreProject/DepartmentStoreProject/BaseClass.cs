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
        public bool Discount { get; set; } = false;
        public double DiscountRate { get; set; }
        public double Savings { get; set; }
        public double NewPrice { get; set; }


        public void PrintMethod()
        {
            //Console.WriteLine(String.Format($"{ID}  {Name, 3}, {Color.PadLeft(30)}, {Size}, {Price.ToString("C")}"), 51);
            Console.Write(String.Format($"{ID}  {Name.PadRight(20, '.')}"));
            Console.WriteLine($"{Color.PadRight(5, '.')}, {Size, 5}, {Price.ToString("C")}");
        }
        public void PrintDiscount()
        {
            Savings += Price * DiscountRate;
            NewPrice = Price - Price * DiscountRate;
            Console.Write(String.Format($"{ID}  {Name.PadRight(20, '.')}"));
            Console.WriteLine($"{Color.PadRight(5, '.')}, {Size,5}, {Price.ToString("C")}  **ATTENTION!!!** **SALES ITEM!!!** **{DiscountRate.ToString("P")} OFF!!!** **New Price!** {NewPrice.ToString("C")}!!!");
        }
    }
}    
