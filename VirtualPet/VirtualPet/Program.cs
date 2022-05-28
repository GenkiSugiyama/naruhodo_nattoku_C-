using System;

namespace VirtualPet
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //string name = Console.ReadLine();
            //var mypet = new VirtualPet(name);
            //Console.WriteLine(mypet.Name);
            //Console.WriteLine(mypet.Mod);
            //Console.WriteLine(mypet.Energy);

            var person1 = new Person();
            var person2 = new Person("たろう", "たなか");
            //private setのプロパティに代入しようとするとエラーとなる
            //person2.FirstName = "げんき";
        }
    }

    class VirtualPet
    {
        public string Name { get; set; }

        //プロパティ定義のあとに「= 値;」でそのプロパティの初期値を設定できる
        public int Mod { get; set; } = 5;
        public int Energy { get; set; }

        public VirtualPet(string name)
        {
            Name = name;
            Mod = 5;
            Energy = 100;
        }
    }

    class Person
    {
        //setの前にprivateをつけることで外部からの代入を禁止する
        //外部からは呼び出しのみアクセス可能になる
        //private setではクラス内のメソッドなどで代入可能
        //setを省略した場合はコンストラクタ内でのみプロパティを設定できる
        public string FirstName { get; private set; }
        public string LastName { get; set; }

        public Person()
        {
            FirstName = "";
            LastName = "";
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        //Ratingには「1,2,3,4,5」までしか入力させたくないが現状だと100とかも入れられる
        //public int Rating { get; set; }

        //下記コードは上の1行でプロパティのゲッターとセッターを定義しているのと同義
        //_ratingはフィールド呼ばれ、インスタンス生成時に確保されるオブジェクトの中に存在する変数
        //クラスの外からはアクセスできない
        //クラスの外部に公開する値はプロパティ、隠蔽したい値はフィールドで使い分ける
        int _rating;

        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                //このsetterの中で1~5までの制限を加えることで想定内の値のみ代入される
                if (value <= 1)
                {
                    _rating = 1;
                }
                else if(value >= 6)
                {
                    _rating = 5;
                }
                else
                {
                    //valueはプロパティに代入されている値を表す
                    _rating = value;
                }
            }
        }
    }
}
