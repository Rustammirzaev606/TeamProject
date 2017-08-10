
////GEnres:         ENUM
////1 Shoes/Heels  
////2 Pants 
////3 Shirts/Blouses 
////4 Hats

////items:          ENUM
////1. blah: price
////2. blah: price
////3. blah: price
////4. blah: price
////5. blah: price
////6. blah: price discount







//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DepartmentStoreProject
//{

//    enum shoes
//    {
//        Sneakers,
//        Slippers,
//        Boots,
//        Sandals,

//    }
//    enum pants
//    {
//        Jeans,
//        DressPants,
//        Khakis,
//        Shorts,


//    }
//    enum shirts
//    {
//        LongSleeves,
//        ShortSleeves,
//        TShirts,
//        ButtonUps,



//    }
//    enum hats
//    {
//        BaseballCaps,
//        Fedoras,
//        Boaters,
//        Beanies


//    }


//    class Program
//    {
       
//        //enum


//        static void Main(string[] args)
//        {

//            int footWear;
//            Console.WriteLine("Hello and what type of shoes are you looking for?\n 1.Sneakers.\n2.Slippers.\n3Boots.\nSandals.\n");
//            string subject = Console.ReadLine();
//            int.TryParse(subject, out footWear);

//            switch ((shoes)footWear)
//            {
//                case shoes.Sneakers:



//                break;


//                case shoes.Slippers:



//                break;

//                case shoes.Boots:



//                break;

//                case shoes.Sandals:



//                break;
//            }

//            int pantaloons;
//            Console.WriteLine("Hello and welcome to the pantaloons department what can I help you with?\n 1.Jeans.\n2.Dresspants.\n3Khakis.\nShorts.\n");
//            string slacks = Console.ReadLine();
//            int.TryParse(slacks, out pantaloons);

//            switch ((pants)pantaloons)
//            {
//                case pants.Jeans:






//                break;

//                case pants.DressPants:



//                break;

//                case pants.Khakis:




//                break;

//                case pants.Shorts:




//                break;
//            }

//            int tops;
//            Console.WriteLine("Hello and what type of shoes are you looking for?\n 1.LongSleeves.\n2.ShortSleeves.\n3.Tshirts.\nButtonUps.\n");
//            string upperbod = Console.ReadLine();
//            int.TryParse(upperbod, out tops);

//            switch ((shirts)tops)
//            {
//                case shirts.LongSleeves:



//                break;

//                case shirts.ShortSleeves:



//                break;

//                case shirts.TShirts:



//                break;

//                case shirts.ButtonUps:


//                break;

                    
//            }

//            int headWear;
//            Console.WriteLine("Hello and what type of shoes are you looking for?\n 1.BaseBallCaps.\n2.Fedoras.\n3.Floaters.\nBeanies.\n");
//            string topwear = Console.ReadLine();
//            int.TryParse(topwear, out headWear);

//            switch ((hats)headWear)
//            {
//                case hats.BaseballCaps:





//                break;

//                case hats.Fedoras:



//                break;
//                case hats.Boaters:


//                break;


//                case hats.Beanies:



//                break;

            }
        }
    }
}
