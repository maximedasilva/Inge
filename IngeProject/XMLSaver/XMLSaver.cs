using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
namespace XMLSaver
{
    public class XMLSaver
    {
        public string file { get;private set; }
        public XDocument doc { get; private set; }
        public XMLSaver()
        {
            create();
        }
        public XMLSaver(string path)
        {
            file = path;
            
        }
        public void create()
        {
            string current = System.IO.Directory.GetCurrentDirectory();
            string fileName = System.IO.Path.GetRandomFileName();
            string pathTotal= System.IO.Path.Combine(current, fileName);
            doc = XDocument.Load(pathTotal);
        }
        public void create(string path)
        {
            try
            {
                System.IO.File.Create(path);
                doc = XDocument.Load(path);
            }
            catch (Exception e)
            {

                throw;
            }
        }

    }
}
