using System;

namespace MySample1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //string型→int型への変換
            var total = 100;
            var line = Console.ReadLine();
            //string型→int型への変換はキャストではなくint.Parse(string)を使用する
            //doubleやdecimal、longへの変換も{変換後の型}.Parseで変換可能
            var count = int.Parse(line);
            var num = total / count;
            Console.WriteLine(num);
        }
    }
}
