using GitLocalChangePullDemo;

using System;

namespace GirCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("walterlv's automatic git command");

            var git = new CommandRunner("git", @"C:\Users\ReshamP\Desktop\GitLocalChangePullDemo");
            var status = git.Run("add .");

            Console.WriteLine(status);
            Console.WriteLine("Exit the program by Enter... ");


            Console.ReadLine();
        }
    }
}
