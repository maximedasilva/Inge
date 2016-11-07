using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Ingeproject
{
    public class Attempt
    {
        public string name { get; set; }
        public int age
        {
            get; set;
        }
        public int[] TimeAttempt
        {
            get; set;
        }
        public int[] errorsAttempt
        {
            get; set;
        }
        public double[,] distance; 
        public Attempt()
        {
            TimeAttempt = new int[4];
            errorsAttempt = new int[2];
            distance = new double[10, 2];
        }
        public Attempt(string _name,int _age)
        {
            name = _name;
            age = _age;
            TimeAttempt = new int[4];
            errorsAttempt = new int[4];
            distance = new double[10, 2];
        }
        public void save()
        {
            XDocument doc;
            try {
                string path = (System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "save.xml"));
                doc = XDocument.Load(path);
            }
            catch
            {
                string fileName = "save.xml";
                string current = System.IO.Directory.GetCurrentDirectory();
                string pathTotal = System.IO.Path.Combine(current, fileName);
                doc = XDocument.Load(pathTotal);
                
            }
            XElement test = new XElement("test");
            XElement tests = doc.Descendants("tests").First();
            test.SetAttributeValue("Nom", name);
            test.SetAttributeValue("Age", age);
            XElement times = new XElement("Times");
            times.SetAttributeValue("Test04", TimeAttempt[3].ToString());
            times.SetAttributeValue("Test03", TimeAttempt[2].ToString());
            times.SetAttributeValue("Test02", TimeAttempt[1].ToString());
            times.SetAttributeValue("Test01", TimeAttempt[0].ToString());
            test.Add(times);
            XElement errors = new XElement("Nberreurs");
            errors.SetAttributeValue("Test02", errorsAttempt[1].ToString());
            errors.SetAttributeValue("Test01", errorsAttempt[0].ToString());
            XElement delta1 = new XElement("Delta1");
            XElement delta2 = new XElement("Delta2");
            for(int i=9; i>=0;i--)
            {
                delta1.SetAttributeValue("clic" + (i + 1), distance[i, 0]);
                delta2.SetAttributeValue("clic" + (i + 1), distance[i, 1]);
            }
            test.Add(delta1);
            test.Add(delta2);
            test.Add(errors);
            tests.Add(test);
            doc.Save(path);
            
        }
    }
}
