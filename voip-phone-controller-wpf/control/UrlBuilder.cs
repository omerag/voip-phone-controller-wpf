using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voip_phone_controller_wpf.control
{
    class UrlBuilder
    {

        public enum PhoneCommand
        {
            CALL,
            HANG_UP,
            MUTE,
            SPEAKER,
            VOLUME_UP,
            VOLUME_DOWN
        }
        public string BaseURL { get; set; }

        public string LineExtension { get; set; }

        public string CallNumber { get; set; }

        public UrlBuilder(string baseURL, string lineExtension, string callNumber)
        {
            BaseURL = baseURL ?? throw new ArgumentNullException(nameof(baseURL));
            LineExtension = lineExtension ?? throw new ArgumentNullException(nameof(lineExtension));
            CallNumber = callNumber ?? throw new ArgumentNullException(nameof(callNumber));
        }

        public string build(PhoneCommand command)
        {
            //https://10.8.21.55/servlet?key=number=0525673458&outgoing_uri=503

            switch (command)
            {
                case PhoneCommand.CALL:
                    return @"http://" + BaseURL + "/servlet?key=number=" + CallNumber + "&outgoing_uri=" + LineExtension;
                case PhoneCommand.HANG_UP:
                    return @"http://" + BaseURL + "/servlet?key=CALLEND";
                case PhoneCommand.MUTE:
                    return @"http://" + BaseURL + "/servlet?key=MUTE";
                case PhoneCommand.SPEAKER:
                    return @"http://" + BaseURL + "/servlet?key=SPEAKER";
                case PhoneCommand.VOLUME_UP:
                    return @"http://" + BaseURL + "/servlet?key=VOLUME_UP";
                case PhoneCommand.VOLUME_DOWN:
                    return @"http://" + BaseURL + "/servlet?key=VOLUME_UP";
                default:
                    return @"http://" + BaseURL + "/servlet?key=CALLEND";
            }

        }
    }
}
