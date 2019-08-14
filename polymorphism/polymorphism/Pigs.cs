using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Pigs : Animal
    {
        static int counter = 0;
        public string MyBreed { get; set; }
        public static List<string> Breeds = new List<string>() { "Domestic", "Wild (Kuni Kuni)" };
        public Pigs()
        {
            counter++;
        }
    }
}
