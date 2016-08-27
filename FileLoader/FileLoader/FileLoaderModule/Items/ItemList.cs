using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLoader.FileLoaderModule
{
    class ItemList
    {
        public Dictionary<String, Item> itemList;
        int uuidCounter;

        public ItemList()
        {
            uuidCounter = 0;
            Init();
        }

        public void Init()
        {
            itemList = new Dictionary<String, Item>();
        }

        public void DeInit()
        {
            itemList = null;
        }

        public void ClearList()
        {
            itemList.Clear();
        }

        public bool AddItem(Item item)
        {
            uuidCounter++;
            if (item != null)
            {
                itemList.Add(uuidCounter.ToString(), item);
                return true;
            }
            return false;
        }

        public bool RemoveItem(String id)
        {
            if (itemList.ContainsKey(id))
            {
                itemList.Remove(id);
                return true;
            }
            return false;
        }
    }
}
