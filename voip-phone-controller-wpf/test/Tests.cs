using System;
using System.Collections.Generic;
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
            List<ContentItem> contentItems = loadData.LoadData();

            foreach(ContentItem item in contentItems)
            {
                string itemPrint = "name: " + item.Name + "\ncall number: " + item.CallNumber + "\ncompany: " + item.Company + "\nrole: " + item.Role;
                Console.WriteLine(itemPrint);
            }
        }
    }
}
