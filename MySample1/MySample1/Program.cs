using System;

namespace MySample1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var priceText = Console.ReadLine();
            int purchasePrice = int.Parse(priceText);
            var rate = 0.01;
            var grantPoint = (int)(purchasePrice * rate);
            var specialGrantPoint = grantPoint * 5;
            Console.WriteLine($"付与ポイントは{specialGrantPoint}ポイントです！");
        }
    }

    //class PurchasePrice
    //{
    //    decimal Price;

    //    void PurchasePrise(string priceText)
    //    {
    //        this.Price = decimal.Parse(priceText);
    //    }

    //    int calucPoint(PurchasePrice price)
    //    {
    //        return 
    //    }
    //}
}
