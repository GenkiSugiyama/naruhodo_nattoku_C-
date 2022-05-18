using System;

namespace FundamentalsOfOOP
{
    class Program
    {
        public static void Main(string[] args)
        {
            var sale = new Sale
            {
                ProductName = "おにぎり",
                UnitPrice = 120,
                Quantity = 4
            };
            var amount = sale.GetAmount();
            Console.WriteLine($"合計金額{amount}円");
        }
    }

    class Sale
    {
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }

        public int GetAmount()
        {
            return UnitPrice * Quantity;
        }
    }
}
