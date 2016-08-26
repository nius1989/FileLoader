using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLoader.FileLoaderModule
{
    class AttributeList
    {
        protected Dictionary<String, Attribute> attributeList = new Dictionary<string, Attribute>();

        public AttributeList()
        {
        
        }

        public void addAttribute(Attribute attr)
        {
            if (attr.name != null) {
                attributeList.Add(attr.name, attr);
            }
        }
    }
}
