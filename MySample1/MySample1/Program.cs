using System;

namespace MySample1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var name = "近藤さん";
            var age = 19;
            Console.WriteLine("{0}さんは、{1}歳です", name, age);

            var str = "改行を示すエスケープシーケンスは、\\nです。";
            Console.WriteLine(str);
        }
    }
}
