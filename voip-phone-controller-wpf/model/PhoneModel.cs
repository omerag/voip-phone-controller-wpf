using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voip_phone_controller_wpf.model
{
    class PhoneModel
    {
        public string IP { get; set ; }
        public string LineExtension { get; set; }

        public PhoneModel(string ip, string lineExtension)
        {
            IP = ip;
            LineExtension = lineExtension;
        }
    }
}
