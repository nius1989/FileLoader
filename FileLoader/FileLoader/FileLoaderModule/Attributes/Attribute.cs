using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLoader.FileLoaderModule
{
    class Attribute
    {
        public String name { get; private set; }
        public ATTRIBUTETYPE type { get; private set; }
        public double min { get; private set; }
        public double max { get; private set; }
        public String[] values { get; private set; }

        public Attribute() {

        }
    }
}
