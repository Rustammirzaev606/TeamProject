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
            LongSleeves.ID = 201;
            LongSleeves.Color = "Red/White";
            LongSleeves.Size = 9;
            LongSleeves.Price = 9.00;


           Shirts ShortSleeves = new Shirts();

            ShortSleeves.Name = "ShortSleeves";
            ShortSleeves.ID = 202;
            ShortSleeves.Color = "Orange";
            ShortSleeves.Size = 10;
            ShortSleeves.Price = 27.99;

            Shirts TShirts = new Shirts();

            TShirts.Name = "TShirts";
            TShirts.ID = 203;
            TShirts.Color = "White";
            TShirts.Size = 12;
            TShirts.Price = 40.00;

            Shirts ButtonUps = new Shirts();

            ButtonUps.Name = "ButtonUps";
            ButtonUps.ID = 204;
            ButtonUps.Color = "Green";
            ButtonUps.Size = 7;
            ButtonUps.Price = 9.99;

            Shirts Sweaters = new Shirts();

            Sweaters.Name = "Sweaters";
            Sweaters.ID = 205;
            Sweaters.Color = "Maroon";
            Sweaters.Size = 11.5;
            Sweaters.Price = 43.95;

            Shirts Hoodies = new Shirts();

            Hoodies.Name = "Hoodies";
            Hoodies.ID = 206;
            Hoodies.Color = "Black";
            Hoodies.Size = 10.5;
            Hoodies.Price = 89.95;





        }



    }
}
