using System.Diagnostics;

namespace CmdExecute_for_AutomationAnywhere
{
    public class CmdExcuter
    {
        private CmdLineBuilder Commands;
        private Process process;

        public void Execute(string Dir, string Filename) 
        {
            this.Commands = new CmdLineBuilder(Dir, Filename);
            process = new Process();

            process.StartInfo = new ProcessStartInfo 
            { 
                FileName = Commands.getFilePath()
            };
            process.Start();
            process.WaitForExit();
        }
        public void Execute(string Dir, string Filename, string Parameter)
        {
            this.Commands = new CmdLineBuilder(Dir, Filename, Parameter);
            process = new Process();

            process.StartInfo = new ProcessStartInfo
            {
                FileName = Commands.getFilePath(),
                Arguments = Commands.getParameter()
            };
            process.Start();
            process.WaitForExit();
        }
    }
}
