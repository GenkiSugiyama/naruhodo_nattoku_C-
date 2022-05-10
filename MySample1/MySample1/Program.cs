using System;

namespace MySample1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //decimal型は数値の末尾にmをつける
            //decimalはfloatやdubleと異なり小数点以下の値を28桁まで正確に持てる
            //そのため金融や財務上の計算に適している
            var price = 1280m;
            var priceIncludingTax = price * 1.1m;
            Console.WriteLine(priceIncludingTax);
        }
    }
}
