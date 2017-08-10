using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreProject
{
    class Pants : BaseClass
    {
        public void Somepants()
        {

            Pants jeans = new Pants();

            jeans.Name= "Jeans";
            jeans.ID = 101;
            jeans.Color = "Blue";
            jeans.Size = 42.30;
            jeans.Price = 24.99;

            Pants DressPants = new Pants();

            DressPants.Name = "Dress Pants";
            DressPants.ID = 102;
            DressPants.Color = "Black";
            DressPants.Size = 32.32;
            DressPants.Price = 38.99;

            Pants Khakis = new Pants();

            Khakis.Name = "Khakis";
            Khakis.ID = 103;
            Khakis.Color = "Beige";
            Khakis.Size = 36.33;
            Khakis.Price = 21.99;

            Pants Shorts = new Pants();

            Shorts.Name = "Shorts";
            Shorts.ID = 104;
            Shorts.Color = "Brown";
            Shorts.Size = 35;
            Shorts.Price = 19.99;

            Pants CargoPants = new Pants();

            CargoPants.Name = "Cargo Pants";
            CargoPants.ID = 105;
            CargoPants.Color = "Camoflauge";
            CargoPants.Size = 36.33;
            CargoPants.Price = 21.99;

            Pants SweatPants = new Pants();

            CargoPants.Name = "Sweat Pants";
            CargoPants.ID = 106;
            CargoPants.Color = "Dark Grey";
            CargoPants.Size = 37.35;
            CargoPants.Price = 17.49;

            Dictionary<int, Pants> Pantalones = new Dictionary<int, Pants>();
            Pantalones.Add(jeans.ID, jeans);
            Pantalones.Add(DressPants.ID, DressPants);
            Pantalones.Add(Khakis.ID, Khakis);
            Pantalones.Add(Shorts.ID, Shorts);
            Pantalones.Add(CargoPants.ID, CargoPants);
            Pantalones.Add(SweatPants.ID, SweatPants);

            Console.WriteLine("Here is stuff we have:");
            foreach (KeyValuePair<int, Pants> item in Pantalones)
            {
                Pants asd = item.Value;
                asd.Asd();
                
            }

            Console.ReadLine();
        }
       
    }    
}
