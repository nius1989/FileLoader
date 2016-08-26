using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLoader.FileLoaderModule
{
    class ItemController
    {
        private ItemList itemList;

        public ItemController()
        {
            Init();
        }

        public void Init()
        {
            itemList = new ItemList();
        }
    }
}
