using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GameLoop.Controller
{
    abstract public class XML
    {
        public static XmlReader read(System.IO.Stream filename)
        {

            Console.WriteLine(typeof(XML).GetType().Assembly.GetManifestResourceNames());
            string result = string.Empty;

            using (Stream stream = filename)
            {
                using (StreamReader sr = new StreamReader(stream))
                    {
                        result = sr.ReadToEnd();
                    }
            }
            string XMLstring = result;
            StringBuilder output = new StringBuilder();
            return XmlReader.Create(new StringReader(XMLstring));        

        }
    }
}