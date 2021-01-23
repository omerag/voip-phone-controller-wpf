using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voip_phone_controller_wpf.control
{
    class UrlBuilder
    {
        public string BaseURL { get; set; }

        public string LineExtension { get; set; }

        public string CallNumber { get; set; }

        public UrlBuilder(string baseURL, string lineExtension, string callNumber)
        {
            BaseURL = baseURL ?? throw new ArgumentNullException(nameof(baseURL));
            LineExtension = lineExtension ?? throw new ArgumentNullException(nameof(lineExtension));
            CallNumber = callNumber ?? throw new ArgumentNullException(nameof(callNumber));
        }

        public string build()
        {
            //https://10.8.21.55/servlet?key=number=0525673458&outgoing_uri=503

            return @"http://" + BaseURL + "/servlet?key=number=" + CallNumber + "&outgoing_uri=" + LineExtension;
        }
    }
}
