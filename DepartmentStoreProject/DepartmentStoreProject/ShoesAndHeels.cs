using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreProject
{
    enum ShoesEnum
    {
        Slippers = 1,
        Sneakers,
        Boots,
        Sandals,
        DressShoes,
        TapShoes

    }
    class ShoesAndHeels : BaseClass
    {

        public void demshoes()
        {
            int inputNumb;
            string input;
            

            ShoesAndHeels Slippers = new ShoesAndHeels();

            Slippers.Name = "Slippers";
            Slippers.ID = 1;
            Slippers.Color = "Pink ";
            Slippers.Size = 6;
            Slippers.Price = 4.99;

            ShoesAndHeels Sneakers = new ShoesAndHeels();

            Sneakers.Name = "Sneakers";
            Sneakers.ID = 2;
            Sneakers.Color = "White";
            Sneakers.Size = 10;
            Sneakers.Price = 39.99;

            ShoesAndHeels Boots = new ShoesAndHeels();

            Boots.Name = "Boots";
            Boots.ID = 3 ;
            Boots.Color = "Black";
            Boots.Size = 12;
            Boots.Price = 49.99;

            ShoesAndHeels Sandals = new ShoesAndHeels();

            Sandals.Name = "Sandals";
            Sandals.ID = 4;
            Sandals.Color = "Brown";
            Sandals.Size = 11.5;
            Sandals.Price = 9.99;

            ShoesAndHeels DressShoes = new ShoesAndHeels();

            DressShoes.Name = "Dress Shoes";
            DressShoes.ID = 5;
            DressShoes.Color = "Black";
            DressShoes.Size = 10.5;
            DressShoes.Price = 59.99;

            ShoesAndHeels TapShoes = new ShoesAndHeels();

            TapShoes.Name = "Tap Shoes";
            TapShoes.ID = 6;
            TapShoes.Color = "Black/White";
            TapShoes.Size = 11.5;
            TapShoes.Price = 69.99;
            TapShoes.Discount = true;
            TapShoes.DiscountRate = 0.25;

            Dictionary<int, ShoesAndHeels> Footwear = new Dictionary<int, ShoesAndHeels>();
            Footwear.Add(Slippers.ID, Slippers);
            Footwear.Add(Sneakers.ID, Sneakers);
            Footwear.Add(Boots.ID, Boots);
            Footwear.Add(Sandals.ID, Sandals);
            Footwear.Add(DressShoes.ID, DressShoes);
            Footwear.Add(TapShoes.ID, TapShoes);

            //Console.WriteLine("Here is our Shoe line:");

            //foreach (KeyValuePair<int, ShoesAndHeels> item in Footwear)
            //{
            //    ShoesAndHeels ListOfFootwear = item.Value;
            //    ListOfFootwear.PrintMethod();

            //}

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the shoe department! Here's whats in our catalog!");
                foreach (KeyValuePair<int, ShoesAndHeels> item in Footwear)
                {
                    ShoesAndHeels ListOfFootwear = item.Value;
                    if (ListOfFootwear.Discount == true)
                    {
                        ListOfFootwear.PrintDiscount();
                    }
                    else
                    {
                        ListOfFootwear.PrintMethod();
                    }

                }
                Console.WriteLine("Please select an item or type EXIT to return to main menu:");
                input = Console.ReadLine();
                int.TryParse(input, out inputNumb);
                while (!int.TryParse(input, out inputNumb) ^ input != "e" ^ input != "exut")
                {
                    Console.WriteLine("Im sorry I do not understand. Please select a number or type EXIT to return to main menu");
                    foreach (KeyValuePair<int, ShoesAndHeels> item in Footwear)
                    {
                        ShoesAndHeels ListOfFootwear = item.Value;
                        if (ListOfFootwear.Discount == true)
                        {
                            ListOfFootwear.PrintDiscount();
                        }
                        else
                        {
                            ListOfFootwear.PrintMethod();
                        }
                    }
                    input = Console.ReadLine().ToLower();
                    if (input == "exit" || input == "e")
                    {
                        break;
                    }
                    else
                    {
                        int.TryParse(input, out inputNumb);
                    }
                }
                if (input == "exit" || input == "e")
                {

                    break;
                }
                else
                {
                    switch ((ShoesEnum)inputNumb)
                    {
                        case ShoesEnum.Sneakers:
                            Subtotal += Sneakers.Price;
                            Console.WriteLine($"We have added {Sneakers.Name} to your cart.");
                            break;
                        case ShoesEnum.Boots:
                            Subtotal += Boots.Price;
                            Console.WriteLine($"We added {Boots.Name} to your cart.");
                            break;
                        case ShoesEnum.Sandals:
                            Subtotal += Sandals.Price;
                            Console.WriteLine($"We have added {Sandals.Name} to your cart.");
                            break;
                        case ShoesEnum.DressShoes:
                            Subtotal += DressShoes.Price;
                            Console.WriteLine($"We have added {DressShoes.Name} to your cart.");
                            break;
                        case ShoesEnum.TapShoes:
                            Subtotal += TapShoes.NewPrice;
                            Savings = TapShoes.Price - TapShoes.NewPrice;
                            Console.WriteLine($"We have added {TapShoes.Name} to your cart.");
                            break;
                        case ShoesEnum.Slippers:
                            Subtotal += Slippers.Price;
                            Console.WriteLine($"We have added {Slippers.Name} to your cart.");
                            break;
                        default:
                            Console.WriteLine("Im sorry I do not recognize your answer.");
                            break;

                    }

                    Console.WriteLine($"Press ENTER to continue or type EXIT to go back to the main store.");
                    input = Console.ReadLine().ToLower();
                }

            } while (input != "exit");





        }





    }
}
