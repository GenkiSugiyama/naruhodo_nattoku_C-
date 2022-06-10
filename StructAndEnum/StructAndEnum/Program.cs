using System;

namespace StructAndEnum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //クラスは参照型（変数にはインスタンスが格納された参照（メモリの番地）が格納される）
            //参照型のデータ型はstring、array、classのみ
            var cardA = new Card(CardSuit.Spade, 4, "テスト");
            var cardB = cardA;

            //Numberはint型で値型なのでcardAのNumberを変更してもcardBのNumberにはえいきょうしない
            //cardA.Number = 12;

            //Strはstring型で参照型なのでプロパティには文字列が格納された参照がわたされている
            //文字列を変更したらそれを参照している別の箇所（cardB.Str）も影響を受ける
            //cardA.Str = "test";

            //Console.WriteLine($"cardA：Suit：{cardA.Suit}, Number：{cardA.Number}, Str：{cardA.Str}");
            //Console.WriteLine($"cardB：Suit：{cardB.Suit}, Number：{cardB.Number}, Str：{cardA.Str}");

            //構造体など値型のデータを引数に渡す場合はオブジェクト自身の参照ではなく、オブジェクトのコピーが作られてそれがメソッドに渡る
            //ChangeToAceメソッドにはcardAがそのまま渡されるのではなくコピーとして新しいcard構造体が渡されそのコピーのNumberが変わるだけ
            //classのインスタンスを渡す場合は引数に渡されたインスタンスがそのままメソッドに渡るので引数に渡したクラスの中身が変更される
            ChangeToAce(cardA);
            Console.WriteLine($"変更後のcardA：Suit：{cardA.Suit}, Number：{cardA.Number}, Str：{cardA.Str}");
            Console.WriteLine($"変更後のcardB：Suit：{cardB.Suit}, Number：{cardB.Number}, Str：{cardB.Str}");

            //int型など値型に対してはnullは指定できない
            //値型にnullを指定したい場合は型指定の最後に?をつけてnull許容型とする;
            //null許容型を本来の型に戻したい場合はキャストするかnull許容型独自のValueプロパティを使用する
            //int? num = null;
            //値がnullのデータに対してValueプロパティを使用すると実行時にエラーとなるので注意
            //そのためValueプロパティを使用する際はnullチェックが必要
            //nullチェック用にHasValueプロパティがある
            //この例はだめなやつ
            //int n = num.Value;

            //Q1
            var birthDay = new DateTime(1993, 3, 18);
            if (birthDay.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("誕生日は日曜日です");
            }
            else
            {
                Console.WriteLine("誕生日は日曜日ではありません");
            }
        }

        private static void ChangeToAce(Card card)
        {
            //card.Suit = CardSuit.Diamond;
            //card.Number = 1;
            card = new Card(CardSuit.Club, 1, "確認問題");
            Console.WriteLine($"新しいcard：Suit：{card.Suit}, Number：{card.Number}, Str：{card.Str}");
        }
    }

    //enumは値型
    enum CardSuit
    {
        Club,
        Spade,
        Heart,
        Diamond
    }

    //structは値型
    class Card
    {
        public CardSuit Suit {get; set;}
        public int Number { get; set; }
        public string Str { get; set; }

        public Card(CardSuit suit, int number, string str)
        {
            Suit = suit;
            Number = number;
            Str = str;
        }
    }

    //Q2-1
    enum Gender
    {
        Male,
        Female
    }

    class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; set; }

        //Q2-2
        public Gender Gender { get; set; }

        public Person()
        {
            FirstName = "";
            LastName = "";
        }

        //Q2-3
        public Person(string firstName, string lastName, Gender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }
    }
}
