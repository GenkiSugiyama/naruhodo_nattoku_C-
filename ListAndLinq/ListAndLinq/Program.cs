using System;
using System.Collections.Generic;
using System.Linq;

namespace ListAndLinq
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //LINQの学習
            //LINQはListをはじめ、コレクションの操作を統一的に行える機能
            //オリジナルのコレクションには変更を行わないのでデータの安全性が保証される

            //var nums = new List<int> { 12, 56, 75, 8, 14, 98, 23, 94, 23, 45 };

            //Whereメソッドは条件に一致する要素を取り出す
            //var query = nums.Where(n => n >= 50);
            //foreach(var n in query)
            //{
            //    Console.WriteLine(n);
            //}

            //Selectメソッドは各要素を別の値に変換する
            //var nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var query = nums.Select(n => n * 2);
            //foreach(var n in query)
            //{
            //    Console.WriteLine(n);
            //}

            //もとのコレクションの要素はBookクラスだけど、Selectメソッドで文字列型のTitleを取り出して
            //stringクラスのコレクションを新しく作成している
            var books = new List<Book>();
            books.Add(new Book("人間失格", "太宰治", 212, 5));
            books.Add(new Book("女生徒", "太宰治", 279, 4));
            books.Add(new Book("吾輩は猫である", "夏目漱石", 610, 4));
            books.Add(new Book("こころ", "夏目漱石", 378, 5));
            books.Add(new Book("銀河鉄道の夜", "川端康成", 357, 3));
            books.Add(new Book("伊豆の踊り子", "川端康成", 201, 3));
            //var titles = books.Select(book => book.Title);
            //foreach(var title in titles)
            //{
            //    Console.WriteLine(title);
            //}

            //LINQは複数のメソッドを組み合わせることができる
            //レートが5以上の要素を取り出し、タイトルstringのみに変換する
            //var famousTitles = books.Where(b => b.Rate >= 5).Select(b => b.Title);
            //foreach(var t in famousTitles)
            //{
            //    Console.WriteLine(t);
            //}

            //3つ以上のメソッド連結も可能
            //var query = books.Where(b => b.Rate >= 4)
            //                 .Select(b => b.Author)
            //                 .Distinct(); // Distinctは重複を排除する
            //foreach(var author in query)
            //{
            //    Console.WriteLine(author);
            //}

            //Q1-1,3
            List<DateTime> times = new List<DateTime>();
            times.Add(new DateTime(1993, 3, 18));
            times.Add(new DateTime(1993, 6, 30));
            times.Add(new DateTime(1993, 8, 22));
            times.ForEach(t => Console.WriteLine(t.ToString("yyyy年MM月dd日 HH:mm")));
            //Q1-2
            Console.WriteLine(times.Count());

            //Q2-1
            void Linq1()
            {
                var famousBooks = books.Where(b => b.Rate >= 4);
                Console.WriteLine("Q2-1");
                foreach (Book book in famousBooks)
                {
                    Console.WriteLine($"書籍名：{book.Title}, 著者名：{book.Author}");
                }
            }
            
            //Q2-2
            void Linq2()
            {
                var newOrderBooks = books.OrderBy(b => b.Author);
                Console.WriteLine("Q2-2");
                foreach (Book book in newOrderBooks)
                {
                    Console.WriteLine($"書籍名：{book.Title}, 著者名：{book.Author}");
                }
            }

            //Q2-3
            void Linq3()
            {
                Book[] bookArray = books.Where(b => b.Page >= 300).ToArray();
                Console.WriteLine("Q2-3");
                foreach (Book book in bookArray)
                {
                    Console.WriteLine($"書籍名：{book.Title}, ページ数：{book.Page}");
                }
            }

            //Q2-4
            void Linq4()
            {
                Console.WriteLine("Q2-4");
                var book = books.OrderByDescending(b => b.Page).First();
                Console.WriteLine($"書籍名：{book.Title}, ページ数：{book.Page}");
            }

            Linq1();
            Linq2();
            Linq3();
            Linq4();
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Page { get; set; }
        public int Rate { get; set; }

        public Book(string title, string author,int page, int rate)
        {
            this.Title = title;
            this.Author = author;
            this.Page = page;
            this.Rate = rate;
        }
    }
}
