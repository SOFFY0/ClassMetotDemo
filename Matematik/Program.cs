using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5,8);
            Console.WriteLine("--------------");
            dortIslem.Topla(5,2);
        }
    }
}
