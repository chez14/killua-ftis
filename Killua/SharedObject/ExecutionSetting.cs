using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Net.Christianto.UNPAR.FTIS.Killua.SharedObject {
    public class ExecutionSetting {
        [XmlArray("target", IsNullable = false)]
        public Target[] targets;

        [XmlArray("dont-remove", IsNullable = false)]
        public Target[] pattern;
    }

    [XmlRoot(ElementName = "addr")]
    public class Target {
        [XmlAttribute("active")]
        public bool isActive = true;

        [XmlText()]
        public string targetLocation;
    }

    [XmlRoot(ElementName = "regex")]
    public class Pattern {
        [XmlAttribute("active")]
        public bool isActive = true;

        [XmlText()]
        public string pattern;
    }
}
