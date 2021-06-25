using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BossProxy bossProxy = new BossProxy();

            BossProxy bossProxy2 = new BossProxy();

            bossProxy.GiveImportantInformation();
            bossProxy2.GiveImportantInformation();


        }
    }
}
