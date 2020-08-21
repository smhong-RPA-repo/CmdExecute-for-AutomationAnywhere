using CmdExecute_for_AutomationAnywhere;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace TestCmdExecute
{
    [TestClass]
    public class CmdExecuterTest
    {
        public CmdLineBuilder CmdLineBuilder;
        private string Dir;
        private string BatchDir;
        private string BatchFileName;
        private string Filename;
        private string Parameter;
        [TestInitialize]
        public void Precondition_init()
        {
            Dir = "C:\\buildbot\\referenceData";
            
            Filename = "InsertBatch.bat";
            BatchDir = "C:\\buildbot\\batch";
            BatchFileName = "ExportVehicleUsageReport.bat";
            Parameter = "1361.12, 1163.56,240";
            CmdLineBuilder = new CmdLineBuilder(Dir, Filename, Parameter);
        }



        [TestMethod]
        public void CmdLineBuilderGetCmdTest()
        {
            string Expected = "C:\\buildbot\\referenceData\\InsertBatch.bat 1361.12 1163.56 240";
            string Actual = CmdLineBuilder.getFilePath() + CmdLineBuilder.getParameter();
            Debug.WriteLine(Expected);
            Debug.WriteLine(Actual);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void CmdExecuteTest()
        {
            CmdExcuter cmdExcuter = new CmdExcuter();
            cmdExcuter.Execute(Dir, Filename, Parameter);
        }

        [TestMethod]
        public void CmdNonParamExecuteTest()
        {
            CmdExcuter cmdExcuter = new CmdExcuter();
            cmdExcuter.Execute(BatchDir, BatchFileName);
        }

        [TestCleanup]
        public void Postcondition()
        {

        }
    }
}
