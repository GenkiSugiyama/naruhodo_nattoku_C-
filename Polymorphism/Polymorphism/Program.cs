using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //同じインターフェースを実装したクラスはすべて同一のインターフェースとみなして処理ができる
            var pets = new List<IVirtualPet>();
            var pet1 = new FoodiePet("エイミー");
            var pet2 = new CheerfulPet("くー");
            var pet3 = new SleepyPet("ライアン");
            pets.Add(pet1);
            pets.Add(pet2);
            pets.Add(pet3);

            foreach (var pet in pets)
            {
                pet.Eat();
                pet.Play();
                Console.WriteLine($"{pet.Name} 機嫌：{pet.Mood} エネルギー：{pet.Energy}");
            }
        }
    }

    //インターフェースを用いてポリモーフィズムを実現する場合はclassの代わりにinterfaceキーワードを使用する
    interface IVirtualPet
    {
        //インターフェース内のプロパティ、メソッドにはprivate、publicなどのアクセス修飾子を使わない
        //フィールドは実装の一部なのでインターフェースには定義できない
        string Name { get; }
        int Mood { get; }
        int Energy { get; }
        void Eat();
        void Play();
        void Sleep();
    }

    //インターフェースを実装するクラスではインターフェースに定義されているプロパティやメソッドを必ず実装しないといけない（エラーになる）
    //また、インターフェースで実装したプロパティやメソッドは必ずpublicにする必要あり
    //継承と異なりインターフェースの実装側は複数のインターフェースを実装することができる
    class SleepyPet : IVirtualPet
    {
        //インターフェースではgetしか定義していないのでsetの公開 / 非公開は実装側で定義できる
        //逆にgetはインターフェースでpublicで定義しているので、実装側で非公開にすることはできない
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        public SleepyPet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }

        public void Eat()
        {
            Mood -= 1;
            Energy += 5;
            Console.WriteLine("SleepyPet.Eatメソッドが実行されました");
        }

        public void Play()
        {
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine("SleepyPet.Playメソッドが実行されました");
        }

        public void Sleep()
        {
            Mood += 2;
            Energy += 2;
            Console.WriteLine("SleepyPet.Sleepメソッドが実行されました");
        }
    }

    class FoodiePet : IVirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        public FoodiePet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }

        public void Eat()
        {
            Mood += 3;
            Energy += 5;
            Console.WriteLine("FoodiePet.Eatメソッドが実行されました");
        }

        public void Play()
        {
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine("FoodiePet.Playメソッドが実行されました");
        }

        public void Sleep()
        {
            Mood -= 1;
            Energy += 2;
            Console.WriteLine("FoodiePet.Sleepメソッドが実行されました");
        }
    }

    class CheerfulPet : IVirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        public CheerfulPet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }

        public void Eat()
        {
            Mood += 0;
            Energy += 5;
            Console.WriteLine("CheerfulPet.Eatメソッドが実行されました");
        }

        public void Play()
        {
            Mood += 3;
            Energy -= 10;
            Console.WriteLine("CheerfulPet.Playメソッドが実行されました");
        }

        public void Sleep()
        {
            Mood -= 1;
            Energy += 2;
            Console.WriteLine("CheerfulPet.Sleepメソッドが実行されました");
        }
    }
}
