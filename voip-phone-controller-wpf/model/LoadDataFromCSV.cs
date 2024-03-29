﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voip_phone_controller_wpf.model
{
    class LoadDataFromCSV : ILoadData
    {
        public ObservableCollection<ContactModel> LoadData()
        {
            string path = "../../resources/data.csv";
            Directory.CreateDirectory("../../resources/");
            ObservableCollection<ContactModel> contentItems = new ObservableCollection<ContactModel>();

            try
            {
                StreamReader reader = new StreamReader(path);

                reader.ReadLine(); //skip first row
                Console.WriteLine("***starting read contacts***");
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    contentItems.Add(new ContactModel(values[0], values[1], values[2], values[3], values[4], values[5]));
                }

                reader.Close();
                Console.WriteLine("***" + contentItems.Count + " readed");
                return contentItems;

            }
            catch (System.IO.FileNotFoundException e)
            {

                contentItems.Add(new ContactModel("Please", " add ", "contact ", "list ", "csv ", "file"));

                return contentItems;
            }
        }
    }
}
