using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            string path = (System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "save.xml"));
            XDocument doc = XDocument.Load(path);
            var tests = doc.Descendants("tests").First();
            var test = tests.Descendants("test");
            foreach (var t in test)
            {
                double Sumdelta1 = 0;
                double Sumdelta2 = 0;
                var delta1 = t.Descendants("Delta1").First();
                var delta2 = t.Descendants("Delta2").First();
                foreach (var sum in delta1.Attributes())
                {
                    var r = sum.Value;
                    Sumdelta1 += Convert.ToDouble(sum.Value, CultureInfo.InvariantCulture);
                   }
                foreach (var sum in delta2.Attributes())
                {
                    Sumdelta2 += Convert.ToDouble(sum.Value, CultureInfo.InvariantCulture);
                }
                delta1.SetAttributeValue("moyenne", Sumdelta1/10);
                delta2.SetAttributeValue("moyenne", Sumdelta2/10);
            }
            doc.Save(path);


        }
    }
}
