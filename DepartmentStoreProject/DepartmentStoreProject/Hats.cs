using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreProject
{
    enum HatsEnum
    {
        BaseballCaps = 1,
        Fedoras,
        Boaters,
        Beanies,
        Homburg,
        TopHats
    }
    class Hats : BaseClass
    {
        public void Somehat()
        {
            int inputNumb;
            string input;
            double addSubtotal = 0;
            Hats BaseballCaps = new Hats();

            BaseballCaps.Name = "Baseball Caps";
            BaseballCaps.ID = 001;
            BaseballCaps.Color = "Red";
            BaseballCaps.Size = 9;
            BaseballCaps.Price = 9.00;
            

            Hats Fedoras = new Hats();

            Fedoras.Name = "Fedoras";
            Fedoras.ID = 002;
            Fedoras.Color = "Black/Red";
            Fedoras.Size = 10;
            Fedoras.Price = 27.99 ;

            Hats Boaters = new Hats();

            Boaters.Name = "Boaters";
            Boaters.ID = 003;
            Boaters.Color = "Black/White";
            Boaters.Size = 12;
            Boaters.Price = 40.00;

            Hats Beanies = new Hats();

            Beanies.Name = "Beanies";
            Beanies.ID = 004;
            Beanies.Color = "Blue";
            Beanies.Size = 7;
            Beanies.Price = 9.99;

            Hats Homburg = new Hats();

            Homburg.Name = "Homburg";
            Homburg.ID = 005;
            Homburg.Color = "Grey";
            Homburg.Size = 11.5;
            Homburg.Price = 43.95;

            Hats TopHats = new Hats();

            TopHats.Name = "Top Hat";
            TopHats.ID = 006;
            TopHats.Color = "Black";
            TopHats.Size = 10.5;
            TopHats.Price = 89.95;

            Dictionary<int, Hats> HeadGear = new Dictionary<int, Hats>();
            HeadGear.Add(BaseballCaps.ID, BaseballCaps);
            HeadGear.Add(Fedoras.ID, Fedoras);
            HeadGear.Add(Boaters.ID, Boaters);
            HeadGear.Add(Beanies.ID, Beanies);
            HeadGear.Add(Homburg.ID, Homburg);
            HeadGear.Add(TopHats.ID, TopHats);


            do
            {
                Console.Clear();
                Console.WriteLine("Here is stuff we have:");
                foreach (KeyValuePair<int, Hats> item in HeadGear)
                {
                    Hats ListOfHats = item.Value;
                    ListOfHats.PrintMethod();

                }
                Console.WriteLine("Select an item");
                input = Console.ReadLine();
                int.TryParse(input, out inputNumb);
                while (!int.TryParse(input, out inputNumb))
                {
                    Console.WriteLine("Wrong input. Select a number");
                    foreach (KeyValuePair<int, Hats> item in HeadGear)
                    {
                        Hats ListOfHats = item.Value;
                        ListOfHats.PrintMethod();


                    }
                    input = Console.ReadLine();
                    int.TryParse(input, out inputNumb);

                }
                switch ((HatsEnum)inputNumb)
                {
                    case HatsEnum.BaseballCaps:
                        Subtotal += BaseballCaps.Price;
                        addSubtotal = BaseballCaps.Price;
                        Console.WriteLine($"We added {BaseballCaps.Name} to your cart");
                        break;
                    case HatsEnum.Fedoras:
                        Subtotal += BaseballCaps.Price;
                        addSubtotal = BaseballCaps.Price;
                        Console.WriteLine($"We added {BaseballCaps.Name} to your cart");
                        break;
                    case HatsEnum.Boaters:
                        Subtotal += Boaters.Price;
                        addSubtotal = Boaters.Price;
                        Console.WriteLine($"We added {Boaters.Name} to your cart");
                        break;
                    case HatsEnum.Beanies:
                        Subtotal += Beanies.Price;
                        addSubtotal = Beanies.Price;
                        Console.WriteLine($"We added {Beanies.Name} to your cart");
                        break;
                    case HatsEnum.Homburg:
                        Subtotal += Homburg.Price;
                        addSubtotal = Homburg.Price;
                        Console.WriteLine($"We added {Homburg.Name} to your cart");
                        break;
                    case HatsEnum.TopHats:
                        Subtotal += TopHats.Price;
                        addSubtotal = TopHats.Price;
                        Console.WriteLine($"We added {TopHats.Name} to your cart");
                        break;
                    default:
                        Console.WriteLine("WRONG INPUT!");
                        break;
                }

                Console.WriteLine($"Press ENTER to continue or type EXIT to go to Department selection");
                input = Console.ReadLine().ToLower();
            }
    }
}
