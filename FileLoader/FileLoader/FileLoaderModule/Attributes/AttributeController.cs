﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Windows.Storage;
using System.Text.RegularExpressions;

namespace FileLoader.FileLoaderModule
{
    class AttributeController
    {
        AttributeList attrList;
        ItemController itemController;
        ItemList itemList;

        public AttributeController(){
            init();
            String filePath = @"C:\Users\swoos\OneDrive\School\Fall 2016\UGResearch\Fall 2016 NEW\FileLoader\FileLoader\Assets\csv\titanic.xls";
            csvParser(filePath);
        }

        /*public static void Main( String[] args) {
            AttributeController attributeController = new AttributeController();
        }
        */
        public void init() {
            attrList = new AttributeList();
            itemController = new ItemController();
            itemList = new ItemList();
        }

        public async void csvParser( String filePath ) {
            string title = @"Assets\titanic.csv";
            StorageFolder folder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            StorageFile file = await folder.GetFileAsync(title);
            using (var inputStream = await file.OpenReadAsync())
            using (var classicStream = inputStream.AsStreamForRead())
            using (var sr = new StreamReader(classicStream))
            {
                var lines = new List<string[]>();
                String[] attributes;

                int Row = 0;
                int counter = 0;

                while (!sr.EndOfStream)
                {
                    string[] Line = Regex.Split(sr.ReadLine(), ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                    lines.Add(Line);
                    attributes = new String[Line.Length];
                    if (Row == 0)
                    {
                        foreach (String str in Line)
                        {
                            Attribute attr = new Attribute();
                            attr.name = str;
                            attrList.addAttribute(attr);
                            attributes[counter] = str;
                            counter++;
                        }
                    }
                    else if (Row == 1)
                    {
                        counter = 0;
                        Dictionary<Attribute, Cell> cellList = new Dictionary<Attribute, Cell>();

                        foreach (String str in Line)
                        {
                            String column = attributes[counter];
                            Attribute currentAttribute = attrList.attributeList[column];
                            if (isDigitsOnly(str))
                            {
                                currentAttribute.type = ATTRIBUTETYPE.Numerical;
                            }
                            else if (isDate(str))
                            {
                                currentAttribute.type = ATTRIBUTETYPE.Time;
                            }
                            else
                            {
                                currentAttribute.type = ATTRIBUTETYPE.Categorical;
                            }
                            currentAttribute.values.Add(str);
                            Cell cell = itemController.createCell(str, currentAttribute.type);
                            cellList.Add(currentAttribute, cell);
                            counter++;
                        }
                        Item item = itemController.createItem(cellList);
                        itemList.AddItem(item);
                    }
                    else
                    {
                        Dictionary<Attribute, Cell> cellList = new Dictionary<Attribute, Cell>();
                        counter = 0;
                        foreach (String str in Line)
                        {
                            String column = attributes[counter];
                            Attribute currentAttribute = attrList.attributeList[column];
                            currentAttribute.values.Add(str);
                            Cell cell = itemController.createCell(str, currentAttribute.type);
                            cellList.Add(currentAttribute, cell);
                            counter++;
                        }
                        Item item = itemController.createItem(cellList);
                        itemList.AddItem(item);
                    }
                    Row++;
                }
            }

        }

        /*private bool addAttribute(Attribute attr) {


            return true;
        }
        */

        //checks to see if the cells in the second row are digits or string values
        private bool isDigitsOnly( String str )
        {
            int i;
            return int.TryParse(str, out i);
        }

        private bool isDate(String str)
        {
            DateTime dateTime;
            return DateTime.TryParse(str, out dateTime);
        }
    }
}
