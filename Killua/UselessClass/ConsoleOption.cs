using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;

namespace Net.Christianto.UNPAR.FTIS.Killua.UselessClass {
    class ConsoleOption {
        [Option(HelpText = "Settings in, if you have another setting.xml file.", Default = "setting.xml")]
        public string setting {
            get; set;
        }
    }
}
