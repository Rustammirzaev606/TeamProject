using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreProject
{
    
    class ShoesAndHeels : BaseClass
    {

        public void demshoes()
        {

            ShoesAndHeels Slippers = new ShoesAndHeels();

            Slippers.Name = "Slippers";
            Slippers.ID = 301;
            Slippers.Color = "Pink";
            Slippers.Size = 6;
            Slippers.Price = 4.99;

            ShoesAndHeels Sneakers = new ShoesAndHeels();

            Sneakers.Name = "Sneakers";
            Sneakers.ID = 302;
            Sneakers.Color = "White";
            Sneakers.Size = 10;
            Sneakers.Price = 39.99;

            ShoesAndHeels Boots = new ShoesAndHeels();

            Boots.Name = "Boots";
            Boots.ID = 303 ;
            Boots.Color = "Black";
            Boots.Size = 12;
            Boots.Price = 49.99;

            ShoesAndHeels Sandals = new ShoesAndHeels();

            Sandals.Name = "Sandals";
            Sandals.ID = 304;
            Sandals.Color = "Brown";
            Sandals.Size = 11.5;
            Sandals.Price = 9.99;

            ShoesAndHeels DressShoes = new ShoesAndHeels();

            DressShoes.Name = "Dress Shoes";
            DressShoes.ID =305 ;
            DressShoes.Color = "Black";
            DressShoes.Size = 10.5;
            DressShoes.Price = 59.99;

            ShoesAndHeels TapShoes = new ShoesAndHeels();

            TapShoes.Name = "Tap Shoes";
            TapShoes.ID = 306;
            TapShoes.Color = "Black/White";
            TapShoes.Size = 11.5;
            TapShoes.Price = 69.99;

            Dictionary<int, ShoesAndHeels> Footwear = new Dictionary<int, ShoesAndHeels>();
            Footwear.Add(Slippers.ID, Slippers);
            Footwear.Add(Sneakers.ID, Sneakers);
            Footwear.Add(Boots.ID, Boots);
            Footwear.Add(Sandals.ID, Sandals);
            Footwear.Add(DressShoes.ID, DressShoes);
            Footwear.Add(TapShoes.ID, TapShoes);

            Console.WriteLine("Here is our Shoe line:");

            foreach (KeyValuePair<int, ShoesAndHeels> item in Footwear)
            {
                ShoesAndHeels asd = item.Value;
                asd.Asd();

            }

            Console.ReadLine();



        }





    }
}
