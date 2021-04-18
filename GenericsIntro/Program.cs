using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>(); // string kısmını t tanımladığımız için istediğimizi yazabiliriz
            isimler.Add("Engin");
        }
    }
}
