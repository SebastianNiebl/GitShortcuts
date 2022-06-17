using System;

namespace GitShortcuts
{
    class Program
    {
        static void Main(string[] args)
        {
            GitWrapper g = new();
            string b = g.GetCurrentBranch();
            g.Checkout("main");
            g.Merge(b);
            g.Checkout(b);
        }
    }
}
