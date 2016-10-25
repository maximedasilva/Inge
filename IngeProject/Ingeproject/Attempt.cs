using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Attempt()
        {

        }
        public Attempt(string _name,int _age)
        {
            name = _name;
            age = _age;
        }

        internal void save()
        {
           
        }
    }
}
