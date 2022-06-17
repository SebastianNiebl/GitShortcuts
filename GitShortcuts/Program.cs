using System;

namespace GitShortcuts
{
    class Program
    {
        static void Main(string[] args)
        {
            GitWrapper g = new();
            Console.WriteLine(g.GetCurrentBranch());
        }
    }
}
