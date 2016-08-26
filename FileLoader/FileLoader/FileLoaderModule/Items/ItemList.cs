using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLoader.FileLoaderModule
{
    class ItemList
    {
        protected Dictionary<String, Item> attributeList;
        private int uuidCounter;

        public ItemList()
        {
            uuidCounter = 0;
            Init();
        }

        public void Init()
        {
            attributeList = new Dictionary<String, Item>();
        }

        public void DeInit()
        {
            attributeList = null;
        }

        public void ClearList()
        {
            attributeList.Clear();
        }

        public bool AddItem(Item item)
        {
            uuidCounter++;
            if (item != null)
            {
                attributeList.Add(uuidCounter.ToString(), item);
                return true;
            }
            return false;
        }

        public bool RemoveItem(String id)
        {
            if (attributeList.ContainsKey(id))
            {
                attributeList.Remove(id);
                return true;
            }
            return false;
        }
    }
}
