using System;

namespace MySample1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //文字列型（string）と文字型（char）

            //string型は連続した文字をダブルクォーテーションで囲う
            var message = "こんにちは";
            Console.WriteLine("変数messageの型：{0}", message.GetType());
            //1文字をダブルクォーテーションで囲ってもstring型になる
            var message2 = "あ";
            Console.WriteLine("変数message2の型：{0}", message2.GetType());

            //char型はシングルクォーテーションで囲う
            //2文字以上をシングルクォーテーションで囲うとエラーになる
            var symbol = 'あ';
            Console.WriteLine("変数symbolの型：{0}", symbol.GetType());
        }
    }
}
