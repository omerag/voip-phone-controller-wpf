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
        public List<ContactModel> LoadData()
        {
            string path = "../../resources/data.csv";

            StreamReader reader = new StreamReader(path);
            List<ContactModel> contentItems = new List<ContactModel>();

            reader.ReadLine(); //skip first row
            Console.WriteLine("***starting read contacts***");
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');

                contentItems.Add(new ContactModel(values[0], values[2], values[6]));
            }

            reader.Close();
            Console.WriteLine("***" + contentItems.Count + " readed");

            return contentItems;
        }
    }
}
