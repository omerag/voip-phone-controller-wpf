using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace voip_phone_controller_wpf.control
{
    class PhoneData
    {
        public string ip { get; set; }
        public string number { get; set; }

        MainWindow mainWindow;

        public PhoneData(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public void setProperData()
        {
            if (mainWindow.RadioBtnNoc1.IsChecked.GetValueOrDefault())
            {
                ip = "192.0.0.1";
                number = "501";
            }
            else if (mainWindow.RadioBtnNoc2.IsChecked.GetValueOrDefault())
            {
                ip = "192.0.0.2";
                number = "502";
            }
            else if (mainWindow.RadioBtnNoc2.IsChecked.GetValueOrDefault())
            {
                ip = "192.0.0.3";
                number = "503";
            }
        }
    }
}
