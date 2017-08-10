
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
            
            string inputChoice;
            int inputNumb;
            
            
            string exit = "exit";
            Console.WriteLine("Welcome to our store!");
            do
            {
                
                Console.WriteLine("Select the department to shop:\n1 - Shoes:\n2 - Pants:\n3 - Shirts:\n4 - Hats:");
                inputChoice = Console.ReadLine();
                int.TryParse(inputChoice, out inputNumb);
                while (!int.TryParse(inputChoice, out inputNumb))
                {

                    Console.WriteLine("INCORRECT INPUT! SELECT A NUMBER OF A DEPARTMENT:\n1 - Shoes:\n2 - Pants:\n3 - Shirts:\n4 - Hats:");
                }
                switch ((Genres)inputNumb)
                {
                    case Genres.Shoes:
                        //call method1
                        Console.WriteLine("123");
                        break;
                    case Genres.Pants:
                        Console.WriteLine("123");
                        break;
                    case Genres.Shirts:
                        Console.WriteLine("123");
                        break;
                    case Genres.Hats:
                        Console.WriteLine("123");
                        break;
                }

            } while (!(exit == "exit"));
            Console.WriteLine("Your total is");
            //method1
            //ask what item they want. Get input. Case choice. Add mathing price to subtotal. 

        
            
        }
    }
}
