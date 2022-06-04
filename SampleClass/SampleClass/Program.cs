using System;
using System.IO;

namespace SampleClass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // OutputMin();
            // OutputRounding();
            // FebruaryCount();
            OutputDayOfWeek();
        }

        private static void OutputMin()
        {
            Console.WriteLine("比較対象1の数値を入力してください");
            var int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("比較対象2の数値を入力してください");
            var int2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"小さい方の値は {Math.Min(int1, int2)} です。");
        }

        private static void OutputRounding()
        {
            while (true)
            {
                var input = Console.ReadLine();
                
                if (input == "")
                {
                    break;
                }
                var double1 = double.Parse(input);
                var floorValue = Math.Floor(double1);
                Console.WriteLine($"切り捨て後の値は {floorValue} です");
                var ceilingValue = Math.Ceiling(double1);
                Console.WriteLine($"切り上げ後の値は {ceilingValue} です");
            }
        }

        private static void FebruaryCount()
        {
            var countDays = DateTime.DaysInMonth(2020, 2);
            Console.WriteLine($"2020年2月の日数は {countDays} です。");
        }

        private static void OutputDayOfWeek()
        {
            var date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"{date} の曜日は {date.DayOfWeek} です");
        }
    }
}
