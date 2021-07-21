using GitLocalChangePullDemo;

using System;
using System.Diagnostics;

namespace GirCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string gitCommand = @"C:\Program Files\Git\cmd\git.exe";
            // string gitAddArgument = "add -A";
            //string commitMessage = "My 3rd commit message";
            Console.Write("Enter Remote Repository Branch path: ");
            string strAddArgument = Console.ReadLine();
            string gitAddArgument = String.Format("remote add origin \"{0}\"", strAddArgument);
            Console.Write("Enter Commit Comment: ");
            string strCommitComment = Console.ReadLine();
            string gitCommitArgument = String.Format("commit -a -m \"{0}\"", strCommitComment);
            string gitPushArgument = "push";
           
           


            Process.Start(gitCommand, gitAddArgument); // Runs: git add -A
            Process.Start(gitCommand, gitCommitArgument); // Runs: git commit -a -m "Your commit message"
            Process.Start(gitCommand, gitPushArgument); // Runs: git push
           
            // var git = new CommandRunner(@"C:\Program Files\Git\cmd\git.exe", @"C:\Users\ReshamP\Desktop\GitLocalChangePullDemo");
            //git.Run("git remote add origin https://github.com/reshampitale/reshampitale.git");
            // git.Run("git commit -m "+ commitMessage + "");
            // git.Run("git branch -M main");
            // git.Run("git push - u origin main");
            ////Console.WriteLine(status);
            Console.WriteLine("Exit the program by Enter... ");


            Console.ReadLine();
        }
    }
}
