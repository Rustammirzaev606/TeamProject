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
            LongSleeves.Size = 35.14; 
            LongSleeves.Price = 12.99;


           Shirts ShortSleeves = new Shirts();

            ShortSleeves.Name = "ShortSleeves";
            ShortSleeves.ID = 202;
            ShortSleeves.Color = "Orange";
            ShortSleeves.Size = 41.16;
            ShortSleeves.Price = 11.99;

            Shirts TShirts = new Shirts();

            TShirts.Name = "TShirts";
            TShirts.ID = 203;
            TShirts.Color = "White";
            TShirts.Size = 40.15;
            TShirts.Price = 9.99;

            Shirts ButtonUps = new Shirts();

            ButtonUps.Name = "ButtonUps";
            ButtonUps.ID = 204;
            ButtonUps.Color = "Green";
            ButtonUps.Size = 37.15;
            ButtonUps.Price = 19.99;

            Shirts Sweaters = new Shirts();

            Sweaters.Name = "Sweaters";
            Sweaters.ID = 205;
            Sweaters.Color = "Maroon";
            Sweaters.Size = 45.16;
            Sweaters.Price = 24.99;

            Shirts Hoodies = new Shirts();

            Hoodies.Name = "Hoodies";
            Hoodies.ID = 206;
            Hoodies.Color = "Charcoal";
            Hoodies.Size = 47.17;
            Hoodies.Price = 54.00;





        }



    }
}
