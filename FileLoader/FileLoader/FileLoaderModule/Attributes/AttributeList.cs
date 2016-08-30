using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLoader.FileLoaderModule
{
    class AttributeList
    {
        public Dictionary<String, Attribute> attributeList;

        public AttributeList()
        {
            Init();
        }

        /// <summary>
        /// initializes the attribute list
        /// </summary>
        public void Init() {
            attributeList = new Dictionary<string, Attribute>();
        }

        /// <summary>
        /// Clears and sets the attribute list to null
        /// </summary>
        public void DeInit()
        {
            attributeList.Clear();
            attributeList = null;
        }

        /// <summary>
        /// Clears the attribute list
        /// </summary>
        public void ClearList()
        {
            attributeList.Clear();
        }

        /// <summary>
        /// Adds an attribute to the dictionary list 
        /// </summary>
        /// <param name="attr"></param>
        public bool addAttribute(Attribute attr)
        {
            if (attr.name != null) {
                attributeList.Add(attr.name, attr);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Removes an attribute to the dictionary list
        /// </summary>
        /// <param name="attr"></param>
        /// <returns></returns>
        public bool removeAttribute(Attribute attr)
        {
            if (attributeList.ContainsKey(attr.name))
            {
                attributeList.Remove(attr.name);
                return true;
            }
            return false;
        }
    }
}
