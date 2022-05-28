using System;
using System.IO;

namespace SampleClass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var lines = new string[]
            {
                "祇園精舎の鐘の声、諸行無常の響きあり",
                "沙羅双樹の花の色、盛者必衰の理をあらはす",
                "おごれる人も久しからず、ただ春の夜の夢のごとし",
                "たけき者もついには滅びぬ、ひとへに風の前の塵に同じ"
            };

            File.WriteAllLines(@"/Users/sugiyamagenki/desktop", lines);
        }
    }
}
