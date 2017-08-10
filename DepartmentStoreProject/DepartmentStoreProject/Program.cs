
//GEnres:         ENUM
//1 Shoes/Heels  
//2 Pants 
//3 Shirts/Blouses 
//4 Hats

//items:          ENUM
//1. blah: price
//2. blah: price
//3. blah: price
//4. blah: price
//5. blah: price
//6. blah: price

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DepartmentStoreProject
{
    enum Genres
    {
        Shoes = 1,
        Pants,
        Shirts,
        Hats

    }
    class Program
    {        
        static void Main(string[] args)
        {
            ShoesAndHeels ShoesAndHeels = new ShoesAndHeels();
            Pants panties = new Pants();
            Shirts shierties = new Shirts();
            Hats haties = new Hats();

            
            string inputChoice;
            int inputNumb;
            double total;
            double savings;
            
            
            string exit;
            Console.WriteLine("Hello! Welcome to Rustam & Dorrell's Clothing Emporium!");
            do
            {
                
                Console.WriteLine("How may we assist you today? \n1 - Shoes:\n2 - Pants:\n3 - Shirts:\n4 - Hats:", 70);
                inputChoice = Console.ReadLine();
                int.TryParse(inputChoice, out inputNumb);
                while (!int.TryParse(inputChoice, out inputNumb))
                {

                    Console.WriteLine("I am sorry for the inconvenience, But I do not recognize your answer. Please select an appropriate department:\n1 - Shoes:\n2 - Pants:\n3 - Shirts:\n4 - Hats:");
                }
                switch ((Genres)inputNumb)
                {
                    case Genres.Shoes:
                        ShoesAndHeels.demshoes();


                        break;
                    case Genres.Pants:
                        panties.Somepants();
                        break;
                    case Genres.Shirts:
                        shierties.Someshirts();
                        break;
                    case Genres.Hats:
                        Console.WriteLine("123");
                        break;
                }
                Console.WriteLine("press enter to continue shopping or type CHECK OUT to finish"); //needs changes
                exit = Console.ReadLine().ToLower();
                total = ShoesAndHeels.Subtotal + panties.Subtotal + shierties.Subtotal + haties.Subtotal;
                savings = shierties.Savings + panties.Savings + ShoesAndHeels.Savings + haties.Savings;
            } while (exit == "checkout" ^ exit != "check out");
            
            Console.WriteLine($"Your grand total comes to {total.ToString("C")}. Your savings are {savings.ToString("C")}."); //needs changes. Math aint working yet.
            Console.ReadLine();
            
            //method1
            //ask what item they want. Get input. Case choice. Add mathing price to subtotal. 

        
            
        }
    }
}
