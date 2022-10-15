using System;

namespace PolymorphismDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PassingMessageUsingMobile child1 = new PassingMessageUsingMobile();
            child1.SendMessage();
            PassingMessageUsingEmail child2 = new PassingMessageUsingEmail();
            child2.SendMessage();
        }
    }
}
