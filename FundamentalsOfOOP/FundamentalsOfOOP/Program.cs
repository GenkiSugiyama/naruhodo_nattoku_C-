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

            Console.WriteLine($"{book.Title}の情報");
            book.Print();

            Console.WriteLine($"{book2.Title}の情報");
            book2.Print();


        }
    }

    class Book
    {
        //プロパティの定義
        //アクセス修飾子を省略した場合はprivateが指定されたとみなされ外部からのアクセス不可となる
        public string Title { get; set; }

        public string Author { get; set; }

        public int Pages { get; set; }

        public int Rating { get; set; }

        //メソッドの定義
        //定義内のプロパティへのアクセス時のthisは省略可能
        public void Print()
        {
            Console.WriteLine($"■{this.Title}");
            Console.WriteLine($"  {this.Author}  {this.Pages}ページ  評価：{this.Rating}");
        }
    }
}
