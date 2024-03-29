﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voip_phone_controller_wpf.model;

namespace voip_phone_controller_wpf.test
{
    class Tests
    {
        ILoadData loadData;

        public Tests(ILoadData loadData)
        {
            this.loadData = loadData;
        }

        public void runTest()
        {
            ObservableCollection<ContactModel> contentItems = loadData.LoadData();

            foreach(ContactModel item in contentItems)
            {
                string itemPrint = "name: " + item.Name + "\ncall number: " + item.CallNumber + "\ncompany: " + item.Company;
                Console.WriteLine(itemPrint);
            }
        }
    }
}
