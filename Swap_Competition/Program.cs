using System;
namespace Swap_Competition

{
    public class Program
    {
        static void Main(string[] args)
        {
            SwapString swapString = new SwapString();
            bool word = swapString.AreEqual("naon", "moon");
            Console.WriteLine(word+  ",  Two strings of characters are not same ");
        }
    }
}