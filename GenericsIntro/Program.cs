using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("engin");
            Console.WriteLine(isimler.Lenght);
            isimler.Add("mustafa");
            Console.WriteLine(isimler.Lenght);
            isimler.Add(Console.ReadLine());
            Console.WriteLine(isimler.Lenght);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
