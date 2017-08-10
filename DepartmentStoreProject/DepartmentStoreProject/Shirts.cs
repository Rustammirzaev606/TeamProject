using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreProject
{
    enum Shiert
    {
        LongSleeves = 1,
        ShortSleeves,
        TShirts,
        ButtonUps,
        Sweaters,
        Hoodies
    }
    class Shirts:BaseClass
    {
        public void Someshirts()
        {
            int inputNumb;
            string input;
            double addSubtotal = 0;
            Shirts LongSleeves = new Shirts();

            LongSleeves.Name = "LongSleeves";
            LongSleeves.ID = 1;
            LongSleeves.Color = "Red/White";
            LongSleeves.Size = 9;
            LongSleeves.Price = 9.00;


           Shirts ShortSleeves = new Shirts();

            ShortSleeves.Name = "ShortSleeves";
            ShortSleeves.ID = 2;
            ShortSleeves.Color = "Orange";
            ShortSleeves.Size = 10;
            ShortSleeves.Price = 27.99;

            Shirts TShirts = new Shirts();

            TShirts.Name = "TShirts";
            TShirts.ID = 3;
            TShirts.Color = "White";
            TShirts.Size = 12;
            TShirts.Price = 40.00;

            Shirts ButtonUps = new Shirts();

            ButtonUps.Name = "ButtonUps";
            ButtonUps.ID = 4;
            ButtonUps.Color = "Green";
            ButtonUps.Size = 7;
            ButtonUps.Price = 9.99;

            Shirts Sweaters = new Shirts();

            Sweaters.Name = "Sweaters";
            Sweaters.ID = 5;
            Sweaters.Color = "Maroon";
            Sweaters.Size = 11.5;
            Sweaters.Price = 43.95;

            Shirts Hoodies = new Shirts();

            Hoodies.Name = "Hoodies";
            Hoodies.ID = 6;
            Hoodies.Color = "Black";
            Hoodies.Size = 10.5;
            Hoodies.Price = 89.95;

            Dictionary<int, Shirts> shiet = new Dictionary<int, Shirts>();
            shiet.Add(LongSleeves.ID, LongSleeves);
            shiet.Add(ShortSleeves.ID, ShortSleeves);
            shiet.Add(TShirts.ID, TShirts);
            shiet.Add(ButtonUps.ID, ButtonUps);
            shiet.Add(Sweaters.ID, Sweaters);
            shiet.Add(Hoodies.ID, Hoodies);
            do
            {
                Console.Clear();
                Console.WriteLine("Here is stuff we have:");
                foreach (KeyValuePair<int, Shirts> item in shiet)
                {
                    Shirts asd = item.Value;
                    asd.Asd();

                }
                Console.WriteLine("Select an item");
                input = Console.ReadLine();
                int.TryParse(input, out inputNumb);
                while (!int.TryParse(input, out inputNumb))
                {
                    Console.WriteLine("Wrong input. Select a number");
                    foreach (KeyValuePair<int, Shirts> item in shiet)
                    {
                        Shirts asd = item.Value;
                        asd.Asd();


                    }
                    input = Console.ReadLine();
                    int.TryParse(input, out inputNumb);

                }
                switch((Shiert)inputNumb)
                {
                    case Shiert.ButtonUps:
                        Subtotal += ButtonUps.Price;
                        addSubtotal = ButtonUps.Price;
                        Console.WriteLine($"We added {ButtonUps.Name} to your cart");
                        break;
                    case Shiert.Hoodies:
                        Subtotal += Hoodies.Price;
                        addSubtotal = Hoodies.Price;
                        Console.WriteLine($"We added {Hoodies.Name} to your cart");
                        break;
                    case Shiert.LongSleeves:
                        Subtotal += LongSleeves.Price;
                        addSubtotal = LongSleeves.Price;
                        Console.WriteLine($"We added {LongSleeves.Name} to your cart");
                        break;
                    case Shiert.ShortSleeves:
                        Subtotal += ShortSleeves.Price;
                        addSubtotal = ShortSleeves.Price;
                        Console.WriteLine($"We added {ShortSleeves.Name} to your cart");
                        break;
                    case Shiert.Sweaters:
                        Subtotal += Sweaters.Price;
                        addSubtotal = Sweaters.Price;
                        Console.WriteLine($"We added {Sweaters.Name} to your cart");
                        break;
                    case Shiert.TShirts:
                        Subtotal += TShirts.Price;
                        addSubtotal = TShirts.Price;
                        Console.WriteLine($"We added {TShirts.Name} to your cart");
                        break;
                }
                
                Console.WriteLine($"Press ENTER to continue or type EXIT to go to Department selection");
                input = Console.ReadLine().ToLower();

            } while (input != "exit");
        }
    }
}
