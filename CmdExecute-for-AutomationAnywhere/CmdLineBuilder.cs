namespace CmdExecute_for_AutomationAnywhere
{
    public class CmdLineBuilder
    {
        private string FilePath;
        private string Parameter;

        public CmdLineBuilder(string Dir, string Filename)
        {
            if (!Dir.EndsWith("\\")) Dir += "\\";
            this.FilePath = Dir + Filename;
        }

        public CmdLineBuilder(string Dir, string Filename, string Parameter)
        {
            if (!Dir.EndsWith("\\")) Dir += "\\";
            this.FilePath = Dir + Filename;

            if (!Parameter.StartsWith(" "))
                Parameter = " " + Parameter;
            Parameter = Parameter.Replace(", ", " ");
            Parameter = Parameter.Replace(",", " ");
            this.Parameter = Parameter;
        }

        public CmdLineBuilder getCmd()
        {
            return this;
        }

        public string getFilePath() => FilePath;

        public string getParameter() => Parameter;
    }
}
