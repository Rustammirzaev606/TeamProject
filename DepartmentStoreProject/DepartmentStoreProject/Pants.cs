using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreProject
{
    enum PantsEnum
    {
        Jeans = 1,
        DressPants,
        Khakis,
        Shorts,
        Cargopants,
        Sweatpants
    }
    class Pants : BaseClass
    {
        public void Somepants()
        {
            int inputNumb;
            string input;
            

            Pants jeans = new Pants();

            jeans.Name= "Jeans";
            jeans.ID = 1;
            jeans.Color = "Blue";
            jeans.Size = 42.30;
            jeans.Price = 24.99;

            Pants DressPants = new Pants();

            DressPants.Name = "Dress Pants";
            DressPants.ID = 2;
            DressPants.Color = "Black";
            DressPants.Size = 32.32;
            DressPants.Price = 38.99;

            Pants Khakis = new Pants();

            Khakis.Name = "Khakis";
            Khakis.ID = 3;
            Khakis.Color = "Beige";
            Khakis.Size = 36.33;
            Khakis.Price = 21.99;

            Pants Shorts = new Pants();

            Shorts.Name = "Shorts";
            Shorts.ID = 4;
            Shorts.Color = "Brown";
            Shorts.Size = 35;
            Shorts.Price = 19.99;

            Pants CargoPants = new Pants();

            CargoPants.Name = "Cargo Pants";
            CargoPants.ID = 5;
            CargoPants.Color = "Camoflauge";
            CargoPants.Size = 36.33;
            CargoPants.Price = 21.99;
            CargoPants.Discount = true;
            CargoPants.DiscountRate = 0.1;

            Pants SweatPants = new Pants();

            SweatPants.Name = "Sweat Pants";
            SweatPants.ID = 6;
            SweatPants.Color = "Dark Grey";
            SweatPants.Size = 37.35;
            SweatPants.Price = 17.49;

            Dictionary<int, Pants> Pantalones = new Dictionary<int, Pants>();
            Pantalones.Add(jeans.ID, jeans);
            Pantalones.Add(DressPants.ID, DressPants);
            Pantalones.Add(Khakis.ID, Khakis);
            Pantalones.Add(Shorts.ID, Shorts);
            Pantalones.Add(CargoPants.ID, CargoPants);
            Pantalones.Add(SweatPants.ID, SweatPants);

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the pants department! Here's whats in our catalog!");
                foreach (KeyValuePair<int, Pants> item in Pantalones)
                {
                    Pants ListOfShirts = item.Value;
                    if (ListOfShirts.Discount == true)
                    {
                        ListOfShirts.PrintDiscount();
                    }
                    else
                    {
                        ListOfShirts.PrintMethod();
                    }
                }
                Console.WriteLine("Please select an item.");
                input = Console.ReadLine();
                int.TryParse(input, out inputNumb);
                while (!int.TryParse(input, out inputNumb))
                {
                    Console.WriteLine("Im sorry I do not understand. Please select a number.");
                    foreach (KeyValuePair<int, Pants> item in Pantalones)
                    {
                        Pants ListOfShirts = item.Value;
                        if (ListOfShirts.Discount == true)
                        {
                            ListOfShirts.PrintDiscount();
                        }
                        else
                        {
                            ListOfShirts.PrintMethod();
                        }

                    }
                    input = Console.ReadLine();
                    int.TryParse(input, out inputNumb);

                }
                switch ((PantsEnum)inputNumb)
                {
                    case PantsEnum.Jeans:
                        Subtotal += jeans.Price;
                        
                        Console.WriteLine($"We have added {jeans.Name} to your cart.");
                        break;
                    case PantsEnum.DressPants:
                        Subtotal += DressPants.Price;
                        
                        Console.WriteLine($"We have added {DressPants.Name} to your cart.");
                        break;
                    case PantsEnum.Khakis:
                        Subtotal += Khakis.Price;
                       
                        Console.WriteLine($"We have added {Khakis.Name} to your cart.");
                        break;
                    case PantsEnum.Shorts:
                        Subtotal += Shorts.Price;
                      
                        Console.WriteLine($"We have added {Shorts.Name} to your cart.");
                        break;
                    case PantsEnum.Cargopants:
                        Subtotal += CargoPants.NewPrice;
                        Savings = CargoPants.Price - CargoPants.NewPrice;
                        Console.WriteLine($"We have added {CargoPants.Name} to your cart.");
                        break;
                    case PantsEnum.Sweatpants:
                        Subtotal += SweatPants.Price;
                       
                        Console.WriteLine($"We have added {SweatPants.Name} to your cart.");
                        break;
                    default:
                        Console.WriteLine("Im sorry I do not recognize your answer.");
                        break;
                }

                Console.WriteLine($"Press ENTER to continue or type EXIT to go back to the main store.");
                input = Console.ReadLine().ToLower();

            } while (input != "exit");
        }
       
    }    
}
