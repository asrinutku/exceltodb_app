using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nc_excel
{
    class ReadWriteXML
    {
        public class column
        {
            public string name { get; set; }
            public string type { get; set; }
        }

        public XmlDocument LoadDoc()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Settings.xml");

            return doc;
        }

        public void FolderPath(string klasor_adi)
        {
            var path = new XElement("config", new XElement("path", klasor_adi));

            var doc = new XDocument();

            if (File.Exists("Settings.xml"))
            {
                doc = XDocument.Load("Settings.xml");

                XElement invid = doc.XPathSelectElement("setting/config");

                if (invid != null)
                {
                    XElement child = doc.XPathSelectElement("setting/config");
                    child.Remove();
                }

                doc.Element("setting").Add(path);
                doc.Save("Settings.xml");
            }
        }

        public string GetFolderPath()
        {
            string path="";

            using (XmlReader reader = XmlReader.Create("Settings.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name.ToString())
                        {
                            case "path":
                                path = reader.ReadString();
                                break;
                        }
                    }
                }
            }

            return path;
        }

        public string GetDatabaseConnectionString()
        {
            string _connString="";

            using (XmlReader reader = XmlReader.Create("Settings.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name.ToString())
                        {
                            case "postgreSql":
                                _connString = reader.ReadString();
                                break;
                        }
                    }
                }
            }
            return _connString;
        }

        public List<column> ReadDbColumns()
        {
            XmlDocument doc = LoadDoc();

            List<column> tb = new List<column>();

            foreach (XmlNode item in doc.SelectNodes("setting/meta"))
            {
                foreach (XmlNode item2 in item.SelectSingleNode("columns"))
                {
                    column cl = new column();
                    foreach (var p in item2.InnerText.Split(';'))
                    {
                        if (p.IndexOf("=") > 0)
                        {
                            string pt = p.Trim();
                            if (pt.Split('=')[0].ToString().Trim() == "name") cl.name = pt.Split('=')[1].ToString().Trim();
                            if (pt.Split('=')[0].ToString().Trim() == "type") cl.type = pt.Split('=')[1].ToString().Trim();
                        }
                    }
                    tb.Add(cl);
                }
            }

            return tb;
        }
    }
}
