using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dalek_V_Cybermen
{
    internal class XmlSerialize
    {
        public List<T> ConvertXmlToObjects<T>(string fileName)
        {
            List<T> list;

            //deserializes the file so it can be read and displayed
            using (StreamReader reader = new StreamReader(fileName))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                list = (List<T>)serializer.Deserialize(reader);
            }

            return list;
        }
    }
}
