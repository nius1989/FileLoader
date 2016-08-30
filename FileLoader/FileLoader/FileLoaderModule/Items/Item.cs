﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLoader.FileLoaderModule
{
    class Item
    {
        public Dictionary<Attribute, Cell> cellList;
        public String uuid { get; set; }

        public Item() {
            Init();
        }

        public void Init()
        {
            cellList = new Dictionary<Attribute, Cell>();
        }

    }
}
