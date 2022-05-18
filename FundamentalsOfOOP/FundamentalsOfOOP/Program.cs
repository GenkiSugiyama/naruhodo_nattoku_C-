using System;

namespace FundamentalsOfOOP
{
    //メソッド定義のメリット
    //・処理に名前をつけることで「何をやるか」を明確にできる
    //・プログラムを分割でき、より理解しやすくなる
    //・処理の記述を1つにまとめることで、重複やムダを省き、間違いを起こしにくくする
    
    class Program
    {
        public static void Main(string[] args)
        {
            var bmicalc = new BmiCalculator();
            var bmi = bmicalc.GetBmi(176, 67);
            Console.WriteLine("{0:.00}", bmi);
            var type = bmicalc.GetBodyType(bmi);
            Console.WriteLine($"あなたは{type}です");
        }
    }

    class BmiCalculator
    {
        public double GetBmi(int height, int weight)
        {
            var matersTall = height / 100.0;
            var bmi = weight / (matersTall * matersTall);
            return bmi;
        }

        public string GetBodyType(double bmi)
        {
            var type = "";
            if (bmi < 18.5)
            {
                type = "痩せ型";
            }
            else if(bmi < 25)
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
}
