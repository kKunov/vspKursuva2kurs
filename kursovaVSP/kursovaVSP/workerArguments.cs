using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaVSP
{
    // this class is for passing the arguments to the worker
    public class workerArguments
    {
        public string sourceFolder;
        public string destFolder;
        public List<string> sourceFiles;
        public List<string> destFiles;
       
        public workerArguments(string sourceFolder, string destFolder, List<string> sourceFiles, List<string> destFiles)
        {
            this.sourceFolder = sourceFolder;
            this.destFolder = destFolder;
            this.sourceFiles = sourceFiles;
            this.destFiles = destFiles;
        }
    }
}
