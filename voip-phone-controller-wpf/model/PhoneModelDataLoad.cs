using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voip_phone_controller_wpf.model;

namespace voip_phone_controller_wpf.control
{
    class PhoneModelDataLoad
    {

        string path = "../../resources/phone_model.csv";

        public List<PhoneModel> GetPhoneModels()
        {
            List<PhoneModel> phoneModels = new List<PhoneModel>();
            int phones = 3;
            StreamReader reader = new StreamReader(path);

            reader.ReadLine(); //skip first row

            while (!reader.EndOfStream && phones > 0)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');

                phoneModels.Add(new PhoneModel(values[0], values[1]));
                phones--;
            }


            reader.Close();
            return phoneModels;
        }

    }
}
