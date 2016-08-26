using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLoader.FileLoaderModule
{
    class Item
    {
        protected Dictionary<Attribute, Cell> attributeList = new Dictionary<Attribute, Cell>();
        public String uuid { get; private set; }

        public Item() {

        }
    }
}
