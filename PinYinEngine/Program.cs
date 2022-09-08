using System;

namespace PinYinEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            string Chinese = "十年磨一剑。";
            string PinYin = PinYinEngine.GetPinYin(Chinese, "_");
            Console.WriteLine("{0} => {1}", Chinese, PinYin);
            Console.ReadLine();
        }
    }
}
