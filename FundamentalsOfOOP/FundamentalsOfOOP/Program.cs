using System;

namespace FundamentalsOfOOP
{
    class Program
    {
        public static void Main(string[] args)
        {
            var book = new Book()
            {
                Title = "吾輩は猫である",
                Author = "夏目漱石",
                Pages = 610,
                Rating = 4
            };

            var book2 = new Book()
            {
                Title = "人間失格",
                Author = "太宰治",
                Pages = 212,
                Rating = 5,
            };

            //実態としては別物だが
            var isSameObject = book == book2;
            Console.WriteLine(isSameObject);

            //クラスは同じ
            var isSameClass = book.GetType() == book2.GetType();
            Console.WriteLine(isSameClass);
        }
    }

    class Book
    {
        //アクセス修飾子を省略した場合はprivateが指定されたとみなされ外部からのアクセス不可となる
        public string Title { get; set; }

        public string Author { get; set; }

        public int Pages { get; set; }

        public int Rating { get; set; }
    }
}
