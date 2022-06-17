using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GitShortcuts
{
    class GitWrapper
    {

        public string GetCurrentBranch()
        {
            Process proc = new();
            string sOut = "";
            proc.StartInfo.FileName = "git";
            proc.StartInfo.Arguments = "status";
            proc.StartInfo.RedirectStandardOutput = true;
            proc.OutputDataReceived += new DataReceivedEventHandler((sender, e) => { sOut += e.Data; });
            proc.Start();
            proc.BeginOutputReadLine();
            proc.WaitForExit();// Waits here for the process to exit.
            string line1 = sOut.Split('\n')[0];
            return line1;
        }

    }
}
