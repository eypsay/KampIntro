using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            MyList<string> isimler = new MyList<string>();
            isimler.Add("eyyup");
            Console.WriteLine(isimler.Length);
            isimler.Add("semra");
            Console.WriteLine(isimler.Length);
            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
