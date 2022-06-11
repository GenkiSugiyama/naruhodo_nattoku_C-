using System;

namespace Inheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var person = new Person
            {
                FristName = "太郎",
                LastName = "テスト",
                Email = "test@test.com"
            };
            person.Print();

            var employee = new Employee
            {
                FristName = "元基",
                LastName = "杉山",
                Email = "sgym0318@test.com",

                Number = 318,
                HireDate = new DateTime(2021, 11, 01)
            };
            //基底クラスのメソッドは派生クラスでも使用できる
            //派生クラスでオーバーライドしたメソッドが呼び出される
            employee.Print();

            //ObjectクラスのメソッドにToString()メソッドがある
            //Objectクラスのメソッドなのですべての型に対してこのメソッドが使用できる
            var empStr = employee.ToString();
            //ToStringはデフォルトだとクラス名を返す仕様になっている（Inheritance.Employee）
            Console.WriteLine(empStr);
        }
    }

    // C#はすべてのクラスの基底クラスとなるObjectクラスが存在している
    //Personクラスはどのクラスも継承していないようにみえるがObjectクラスの継承が省略されている
    class Person
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return LastName + FristName;
            }
        }
        public string Email { get; set; }

        //コンストラクタ
        //public Person(string firstName, string lastName, string email)
        //{
        //    FristName = firstName;
        //    LastName = lastName;
        //    Email = email;
        //}

        //基底クラスのメソッドにvirtualキーワードを指定して定義すると派生クラスでそのメソッドを上書き（オーバーライド）できる
        public virtual void Print()
        {
            Console.WriteLine($"名前：{FullName} （{Email}）");
        }
    }

    //「: クラス名」は継承のキーワード
    //コロンの後ろに書いたクラスを継承する
    //C#では継承できるクラスは1つだけ
    //継承したクラスのプロパティやメソッドを定義しなくても使用できる
    //共通するプロパティがあるだけで継承を使用してはいけない
    //継承が使用できるのは「派生クラスは基底クラスの一種である」という『is a』関係が成り立つときだけ
    class Employee : Person
    {
        public int Number { get; set; }
        public DateTime HireDate { get; set; }

        public override void Print()
        {
            Console.WriteLine($"{Number}：{FullName} （{Email}） {HireDate.Year}年入社");
        }

        //ToString()メソッドはvirtualで定義されているので各クラスでオーバーライドすることで任意の文字列を返すことができる
        public override string ToString()
        {
            var empStr = $"{Number}：{FullName} （{Email}） {HireDate.Year}年{HireDate.Month}月{HireDate.Day}日入社";
            return empStr;
        }
    }

    class Customer : Person
    {
        public string Id { get; set; }
        public int Rank { get; set; }
        public string CreditCardNumber { get; set; }
    }
}
