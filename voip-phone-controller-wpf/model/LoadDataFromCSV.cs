using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voip_phone_controller_wpf.model
{
    class LoadDataFromCSV : ILoadData
    {
        public List<ContentItem> LoadData()
        {
            string path = "../../resources/data.csv";

            StreamReader reader = new StreamReader(path);
            List<ContentItem> contentItems = new List<ContentItem>();

            reader.ReadLine(); //skip first row

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');

                contentItems.Add(new ContentItem(values[0], values[1], values[2], values[3]));
            }

            reader.Close();

            return contentItems;
        }
    }
}
