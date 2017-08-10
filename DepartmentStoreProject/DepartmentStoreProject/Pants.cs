using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreProject
{
    class Pants: BaseClass
    {
        public void Somepants()
        {

            Pants Jeans = new Pants();

            Jeans.Name= "Jeans";
            Jeans.ID = 101;
            Jeans.Color = "Blue";
            Jeans.Size = 42.30;
            Jeans.Price = 24.99;

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
            Khakis.Price = 29.99;

            Pants Shorts = new Pants();

            Shorts.Name = "Shorts";
            Shorts.ID = 103;
            Shorts.Color = "Beige";
            Shorts.Size = 36.33;
            Shorts.Price = 19.99;

            Pants CargoPants = new Pants();

            CargoPants.Name = "Cargo Pants";
            CargoPants.ID = 103;
            CargoPants.Color = "Camoflauge";
            CargoPants.Size = 36.33;
            CargoPants.Price = 21.99;









            Dictionary<int, Pants> Wj = new Dictionary<int, Pants>;
            Wj.Add(Jeans.ID, Jeans);

            Dictionary<int, \



        }
    }    
}
