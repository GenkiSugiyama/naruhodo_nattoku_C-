using System;

namespace StaticClass
{
    class MainClass
    {
        //通常クラスと静的クラスの実装の見極め
        //複数のインスタンスを作成し、それぞれに別の状態や値を持たせる必要がある場合は通常クラスで作成する
        //クラス1つで問題ない場合は静的クラスで作成する

        public static void Main(string[] args)
        {
            var str = "インスタンスを生成せずに利用できるメソッドをstaticメソッドと言います。";

            var str2 = str.Replace("staticメソッド", "静的メソッド");
            Console.WriteLine(str);
            Console.WriteLine(str2);

            //var bmi = BmiCalculator.GetBmi(176, 67);
            //Console.WriteLine("{0:.00}", bmi);
            //var type = BmiCalculator.GetBodyType(bmi);
            //Console.WriteLine($"あなたは{type}です");

            //int[] array = { 4, 6, 3, 5, 19, 34, 21 };
            //Console.WriteLine(ArrayUtil.Max(array));
            //Console.WriteLine(ArrayUtil.Min(array));
        }

        static class BmiCalculator
        {
            public static double GetBmi(int height, int weight)
            {
                var matersTall = height / 100.0;
                var bmi = weight / (matersTall * matersTall);
                return bmi;
            }

            public static string GetBodyType(double bmi)
            {
                var type = "";
                if (bmi < 18.5)
                {
                    type = "痩せ型";
                }
                else if (bmi < 25)
                {
                    type = "普通体重";
                }
                else
                {
                    type = "肥満";
                }
                return type;
            }
        }

        class ArrayUtil
        {
            public static int Total(int[] numbers)
            {
                var total = 0;
                foreach (int number in numbers)
                {
                    total += number;
                }
                return total;
            }

            public static double Average(int[] numbers)
            {
                var total = Total(numbers);
                return (double)total / numbers.Length;
            }

            public static int Max(int[] numbers)
            {
                Array.Sort(numbers);
                Array.Reverse(numbers);
                return numbers[0];
            }

            public static int Min(int[] numbers)
            {
                Array.Sort(numbers);
                return numbers[0];
            }
        }
    }
}
