using System;
using ExplicitDependenciesPrinciple.Original;

namespace ExplicitDependenciesPrinciple
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var user1 = new Original.User
            {
                Name = "A"
            };

            Original.Context.CurrentUser = user1;

            var client1 = new Original.Client();
            Console.WriteLine(client1.Login());
            Console.ReadLine();


            var user2 = new Improve.User()
            {
                Name = "B"
            };

            var client2 = new Improve.Client();
            Console.WriteLine(client2.Login(user2));
            Console.ReadLine();
        }
    }
}