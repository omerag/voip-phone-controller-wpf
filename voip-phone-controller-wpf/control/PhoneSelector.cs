using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using voip_phone_controller_wpf.model;

namespace voip_phone_controller_wpf.control
{
    class PhoneSelector
    {
        public string ip { get; set; }
        public string number { get; set; }

        MainWindow mainWindow;

        List<PhoneModel> phoneModels;

        public PhoneSelector(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            PhoneModelDataLoad dataLoad = new PhoneModelDataLoad();
            phoneModels = dataLoad.GetPhoneModels();
        }

        public void setProperData()
        {
            if (mainWindow.RadioBtnNoc1.IsChecked.GetValueOrDefault())
            {
                ip = phoneModels[0].IP; //"10.8.21.50";
                number = phoneModels[0].IP; //"501";
            }
            else if (mainWindow.RadioBtnNoc2.IsChecked.GetValueOrDefault())
            {
                ip = phoneModels[1].IP; // "10.8.21.55";
                number = phoneModels[1].IP; // "504";
            }
            else if (mainWindow.RadioBtnNoc3.IsChecked.GetValueOrDefault())
            {
                ip = phoneModels[2].IP; //"10.8.21.94";
                number = phoneModels[2].IP; // "505";
            }
        }
    }
}
