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
            TimeAttempt = new int[4];
            errorsAttempt = new int[4];
        }
        public Attempt(string _name,int _age)
        {
            name = _name;
            age = _age;
            TimeAttempt = new int[4];
            errorsAttempt = new int[4];

        }

        internal void save()
        {
           
        }
    }
}
