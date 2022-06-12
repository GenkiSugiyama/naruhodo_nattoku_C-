using System;
using System.IO;

namespace ErrorHandling
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //tryの中の処理で例外が発生した場合、例外が発生した箇所からcatch節内に処理が移動する
            //例外の種類を指定して例外をcatchすることで例外の種類ごとに任意の処理を行うことができる
            //tryの中でメソッドを呼び出し、そのメソッドが例外処理を実装しておらず例外が発生した場合は
            //上位層のtryで例外をキャッチすることができる
            //自分が指定した例外以外の例外が発生した場合はcatch節に移動しないので、最後にcatch (Syste.Exception)で指定した例外以外のすべての例外をキャッチできる
            //System.Exceptionはすべての例外の継承元なので、一番最初のcatchでキャッチしてしまうとそれ以外の例外クラスをキャッチできなくなるので最後にキャッチする
            //try
            //{
            //    var total = 100;
            //    var line = Console.ReadLine();
            //    //lineに入力された値が数値文字列でないとエラー
            //    var count = int.Parse(line);
            //    //countが0だとエラー
            //    var ans = total / count;
            //    Console.WriteLine(ans);
            //    Console.WriteLine("正常終了");
            //}
            //catch (System.DivideByZeroException devideByZeroEx)
            //{
            //    Console.WriteLine($"Type: {devideByZeroEx.GetType().Name}");
            //    Console.WriteLine("ゼロは入力できません");
            //}
            //catch (System.FormatException)
            //{
            //    Console.WriteLine("数値を入力してください");
            //}
            //catch (System.Exception)
            //{
            //    Console.WriteLine("予期せぬエラーが発生しました");
            //}

            // catch節で例外クラス用の変数を定義することで発生した例外の情報にアクセスできるようになる
            //try
            //{
            //    Book book = null;
            //    var title = book.Title;
            //}
            //catch (Exception ex)
            //{
            //    //例外名を取得
            //    Console.WriteLine($"Type: {ex.GetType().Name}");
            //    // 例外の内容を示すメッセージを取得
            //    Console.WriteLine($"Message: {ex.Message}");
            //    // 例外が発生したメソッド名を取得
            //    Console.WriteLine($"TargetSite: {ex.TargetSite}");
            //    // 例外が発生した箇所（行番号）を取得
            //    Console.WriteLine($"StackTrave: {ex.StackTrace}");
            //}

            // GetBmiの例外を処理する
            //try
            //{
            //    // heightをメートルで指定してしまったケース
            //    var bmi = BmiCalculator.GetBmi(1.57, 49.5);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            var price = GetPrice();
            var discount = (int)(price * 0.01);
            Console.WriteLine($"割引額: {discount}円");
        }

        private static int GetPrice()
        {
            while (true)
            {
                Console.WriteLine("金額を入力してください");
                var line = Console.ReadLine();
                // int.Parseメソッドは変換対象の値が数値文字列でない場合は例外を返す
                // int.TryParseメソッドは第一引数に変換対象の値をとり、対象が数値に変換できたかどうかのbool値を返す
                // 変換に失敗した場合はfalseを返し、成功した場合は第二引数に変換後の数値を格納する
                // 第二引数にはoutキーワード（戻り地ではなく引数で値を返すように指定するキーワード）を指定する必要あり
                // Parseする際に数値文字列以外の文字列が入る可能性がある場合はTryParseメソッドを使用したほうがよい
                if (int.TryParse(line, out var num))
                {
                    // 数値文字列が入力された場合はそのタイミングで変換された数値を返し、繰り返し処理を終了する
                    return num;
                }

                Console.WriteLine("入力に誤りがあります");
            }
        }

        private static void ReadSample()
        {
            // streamクラスなどIDisposableインターフェースを実装しているクラスを要する場合、後処理として必ずDisposeメソッドを実行する必要がある
            // ファイルを読み込む処理の途中などで例外が発生してしまうとDisposeメソッドが呼び出されない可能性がある
            // そのような不具合を避けるためにIDisposableを実装しているクラスを利用する場合はusing文を使用し確実にDiposeメソッドが呼び出されるようにするべし
            //usingの()で生成したインスタンスが後処理の対応となり、例外が発生しようがなかろうがusing文を抜けるときに自動的にDisposeメソッドが呼び出される
            using (var file = new StreamReader("sample.txt"))
            {
                while (file.EndOfStream == false)
                {
                    var line = file.ReadLine();
                    Console.WriteLine(line);
                }
            }

        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Page { get; set; }
        public int Rate { get; set; }

        public Book(string title, string author, int page, int rate)
        {
            this.Title = title;
            this.Author = author;
            this.Page = page;
            this.Rate = rate;
        }
    }

    // throwキーワードを使用して開発者が意図的に例外を発生させることができる
    static class BmiCalculator
    {
        // height（身長）はcm、weight（体重）はkgで指定する前提
        public static double GetBmi(double height, double weight)
        {
            // GetBmiメソッド内では例外をキャッチしていないが、GetBmiを使用している箇所でtry / catchを書けばGetBmiでスローした例外をキャッチできる
            if (height < 60.0 || 250.0 < height)
            {
                throw new ArgumentException("heightの指定に誤りがあります");
            }
            if (weight < 10.0 || 200.0 < weight)
            {
                throw new ArgumentException("weightの指定に誤りがあります");
            }
            var matersTall = height / 100.0;
            var bmi = weight / (matersTall * matersTall);
            return bmi;
        }
    }
}
