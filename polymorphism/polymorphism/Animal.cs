using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Animal
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public List<Checkup> vetChecks = new List<Checkup>();
        /* Instantiate new list instead of using auto properties.
        public List<Checkup> VetChecks { get; set; }
        */


        public virtual string Details()
        {
            return "";
        }
    }
}
