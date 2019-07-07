using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace oai_pmh_invalid_char_locator {
    public static class Validator {
        public static void Validate(string source) {
            string lastId = null;
            using(var sr = new StringReader(source))
            using(var reader = XmlReader.Create(sr)) {
                try {
                    while(reader.Read()) {
                        if(reader.NodeType != XmlNodeType.Element)
                            continue;

                        if(reader.Name == "identifier") {
                            lastId = reader.ReadElementContentAsString();
                        }
                    }
                } catch(XmlException) {
                    Console.WriteLine("Invalid XML encountered. The last ID seen was " + lastId);
                    return;
                }
            }

            Console.WriteLine("No problems encountered while reading the XML.");
        }
    }
}
