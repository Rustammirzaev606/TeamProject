﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreProject
{
    class Hats : BaseClass
    {
        public void Somehat()
        {
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

            Hats TopHat = new Hats();

            TopHat.Name = "Top Hat";
            TopHat.ID = 006;
            TopHat.Color = "Black";
            TopHat.Size = 10.5;
            TopHat.Price = 89.95;
        }
    }
}