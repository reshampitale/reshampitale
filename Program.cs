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
            string gitAddArgument = "add -A";
            string commitMessage = "My 1sttt commit message";
            string gitCommitArgument = String.Format("commit -a -m \"{0}\"", commitMessage);
            string gitPushArgument = "push";

            Process.Start(gitCommand, gitAddArgument); // Runs: git add -A
            Process.Start(gitCommand, gitCommitArgument); // Runs: git commit -a -m "Your commit message"
            Process.Start(gitCommand, gitPushArgument); // Runs: git push
            //var git = new CommandRunner("https://github.com/reshampitale/reshampitale.git", @"https://github.com/reshampitale/reshampitale.git");
            //var status = git.Run("remote add");

            //Console.WriteLine(status);
            Console.WriteLine("Exit the program by Enter... ");


            Console.ReadLine();
        }
    }
}
