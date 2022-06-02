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
            var nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var query = nums.Select(n => n * 2);
            foreach(var n in query)
            {
                Console.WriteLine(n);
            }

            //もとのコレクションの要素はBookクラスだけど、Selectメソッドで文字列型のTitleを取り出して
            //stringクラスのコレクションを新しく作成している
            var books = new List<Book>();
            books.Add(new Book("人間失格", "太宰治", 5));
            books.Add(new Book("女生徒", "太宰治", 4));
            books.Add(new Book("吾輩は猫である", "夏目漱石", 4));
            books.Add(new Book("こころ", "夏目漱石", 5));
            books.Add(new Book("銀河鉄道の夜", "川端康成", 3));
            books.Add(new Book("伊豆の踊り子", "川端康成", 3));
            var titles = books.Select(book => book.Title);
            foreach(var title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Rate { get; set; }

        public Book(string title, string author, int rate)
        {
            this.Title = title;
            this.Author = author;
            this.Rate = rate;
        }
    }
}
