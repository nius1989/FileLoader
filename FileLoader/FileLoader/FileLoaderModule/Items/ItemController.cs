using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLoader.FileLoaderModule
{
    class ItemController
    {
         ItemList itemList;

        public ItemController()
        {
            Init();
        }

        public void Init()
        {
            itemList = new ItemList();
        }

        public Cell createCell( String data, ATTRIBUTETYPE type )
        {
            Cell cell = new Cell();
            cell.data = data;
            cell.type = type;
            return cell;
        }

        public Item createItem( Dictionary<Attribute, Cell> cellList) {
            Item item = new Item();
            item.cellList = cellList;
            return item;
        }


    }
}
