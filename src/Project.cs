using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Potassium {
    [XmlRoot("project")]
    public struct Project {
        [XmlAttribute("version")]
        public int Version;

        [XmlArray("stages")]
        [XmlArrayItem("stage")]
        public List<ProjectStage> Stages;
    }

    public class ProjectStage {
        [XmlElement(ElementName = "name")]
        public string Name;
        [XmlElement(ElementName = "replaces")]
        public int Replaces;

        public override string ToString() {
            return "[" + Replaces + "] " + Name;
        }
    }

    public static class ProjectParser {
        public static Project Parse(string projectPath) {
            using (var reader = XmlReader.Create(projectPath)) {
                var serializer = new XmlSerializer(typeof(Project));
                return (Project)serializer.Deserialize(reader);
            }
        }
    }
}
