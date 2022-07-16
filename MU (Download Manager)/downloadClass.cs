using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU__Download_Manager_
{
    public class downloadClass
    {
        public string FileName { get; set; }
        public double FileSize { get; set; }
        public string FileStatus { get; set; }
        public string FileLocation { get; set; }

        public downloadClass(string FileName = "",double FileSize = 0.0, string FileStatus="", string FileLocation="")
        {
            this.FileName = FileName;
            this.FileSize = FileSize;
            this.FileStatus = FileStatus;
            this.FileLocation = FileLocation;
        }
    }
}
