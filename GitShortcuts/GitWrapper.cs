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
            proc.OutputDataReceived += new DataReceivedEventHandler((sender, e) => { sOut += e.Data + "\r\n"; });
            proc.Start();
            proc.BeginOutputReadLine();
            proc.WaitForExit();

            string line1 = sOut.Split("\r\n")[0];
            return line1.Substring(10);
        }
        public void Checkout(string branch)
        {
            Process proc = new();
            string sOut = "";
            proc.StartInfo.FileName = "git";
            proc.StartInfo.Arguments = string.Format("checkout {0}", branch);
            proc.StartInfo.RedirectStandardOutput = true;
            proc.OutputDataReceived += new DataReceivedEventHandler((sender, e) => { sOut += e.Data + "\r\n"; });
            proc.Start();
            proc.BeginOutputReadLine();
            proc.WaitForExit();
        }
        public void Merge(string branch)
        {
            Process proc = new();
            string sOut = "";
            proc.StartInfo.FileName = "git";
            proc.StartInfo.Arguments = string.Format("merge {0} -X theirs", branch);
            proc.StartInfo.RedirectStandardOutput = true;
            proc.OutputDataReceived += new DataReceivedEventHandler((sender, e) => { sOut += e.Data + "\r\n"; });
            proc.Start();
            proc.BeginOutputReadLine();
            proc.WaitForExit();
        }
    }
}
