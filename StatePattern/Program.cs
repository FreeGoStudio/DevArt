using System;
using System.Threading;

namespace StatePattern
{
    internal class Program
    {
        private static Original original;
        public static void Main(string[] args)
        {
            original = new Original();
            var runThread = new Thread(new ThreadStart(Run));
            runThread.Start();

            var inputThread = new Thread(new ThreadStart(Input));
            inputThread.Start();
        }

        public static void Run()
        {
            while (true)
            {
                original.Execute();
                Thread.Sleep(100);
            }
        }

        public static void Input()
        {
            
        }
    }
}