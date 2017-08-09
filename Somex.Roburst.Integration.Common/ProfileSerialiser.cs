using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Somex.Roburst.Integration.Common
{
    public class ProfileSerialiser
    {

        /// <summary>
        /// Deserialises XML string into instance of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static T DeserialiseXML<T>(string xml)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            // Deserialize XML string into type T
            return (T)serializer.Deserialize(new StringReader(xml));
        }

        /// <summary>
        /// Serializes <paramref name="message" to XML string/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string Serialise(RoburstProfiles profiles)
        {
            var xmlSerializer = new XmlSerializer(profiles.GetType());

            using (var ms = new MemoryStream())
            {
                using (var xw = XmlWriter.Create(ms,
                    new XmlWriterSettings()
                    {
                        Encoding = new UTF8Encoding(false),
                        Indent = true,
                        NewLineOnAttributes = true,
                        OmitXmlDeclaration = false
                    }))
                {

                    // we want to remove xmlns put in by default
                    // http://stackoverflow.com/questions/760262/xmlserializer-remove-unnecessary-xsi-and-xsd-namespaces
                    XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                    ns.Add("", "");

                    xmlSerializer.Serialize(xw, profiles, ns);
                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }

        }
    }
}
