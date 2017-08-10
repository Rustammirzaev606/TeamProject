using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreProject
{
    class Shirts:BaseClass
    {
        public void Someshirts()
        {
            
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
            Console.WriteLine("Here is stuff we have:");
            foreach (KeyValuePair<int, Shirts> item in shiet)
            {
                Shirts asd = item.Value;
                asd.Asd();

            }
            Console.ReadLine();





        }



    }
}
