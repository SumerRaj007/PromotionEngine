using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CheckoutList> checkoutLists = new List<CheckoutList>();

            Console.WriteLine("total number of order");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                CheckoutList p = new CheckoutList(type);
                checkoutLists.Add(p);
            }

            int totalPrice = GetPrice(checkoutLists);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }

        private static int GetPrice(List<CheckoutList> checkLists)
        {
            int productofA = 0;
            int priceofA = 50;
            int productofB = 0;
            int priceofB = 30;
            int productofC = 0;
            int priceofC = 20;
            int productofD = 0;
            int priceofD = 15;
            foreach (CheckoutList pr in checkLists)
            {
                if (pr.Id == "A" )
                {
                    productofA = productofA + 1;
                }
                if (pr.Id == "B" )
                {
                    productofB = productofB + 1;
                }
                if (pr.Id == "C")
                {
                    productofC = productofC + 1;
                }
                if (pr.Id == "D" )
                {
                    productofD = productofD + 1;
                }
            }
            int totalPriceofA = (productofA / 3) * 130 + (productofA % 3 * priceofA);
            int totalPriceofB = (productofB / 2) * 45 + (productofB % 2 * priceofB);
            int totalPriceofC = (productofC * priceofC);
            int totalPriceofD = (productofD * priceofD);
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;

        }
    }
}
    
