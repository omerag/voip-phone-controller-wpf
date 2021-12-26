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
            F_CONFRENCE,
            F_TRANSFER,
            F_HOLD,
            X,
            OK,
            SPEAKER,
            VOLUME_UP,
            VOLUME_DOWN,
            UP,
            DOWN,
            LEFT,
            RIGHT,
            RD,
            POUND,
            PRESS0,
            PRESS1,
            PRESS2,
            PRESS3,
            PRESS4,
            PRESS5,
            PRESS6,
            PRESS7,
            PRESS8,
            PRESS9
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
            String prefixString = @"http://" + BaseURL + "/servlet?key=";

            switch (command)
            {
                case PhoneCommand.CALL:
                    return prefixString + "number = " + CallNumber + "&outgoing_uri=" + LineExtension;
                case PhoneCommand.HANG_UP:
                    return prefixString + "CALLEND";
                case PhoneCommand.MUTE:
                    return prefixString + "MUTE";
                case PhoneCommand.SPEAKER:
                    return prefixString + "SPEAKER";
                case PhoneCommand.VOLUME_UP:
                    return prefixString + "VOLUME_UP";
                case PhoneCommand.VOLUME_DOWN:
                    return prefixString + "VOLUME_DOWN";
                case PhoneCommand.PRESS0:
                    return prefixString + "0";
                case PhoneCommand.PRESS1:
                    return prefixString + "1";
                case PhoneCommand.PRESS2:
                    return prefixString + "2";
                case PhoneCommand.PRESS3:
                    return prefixString + "3";
                case PhoneCommand.PRESS4:
                    return prefixString + "4";
                case PhoneCommand.PRESS5:
                    return prefixString + "5";
                case PhoneCommand.PRESS6:
                    return prefixString + "6";
                case PhoneCommand.PRESS7:
                    return prefixString + "7";
                case PhoneCommand.PRESS8:
                    return prefixString + "8";
                case PhoneCommand.PRESS9:
                    return prefixString + "9";
                case PhoneCommand.POUND:
                    return prefixString + "POUND";
                case PhoneCommand.F_CONFRENCE:
                    return prefixString + "F_CONRENCE";
                case PhoneCommand.F_TRANSFER:
                    return prefixString + "F_TRANSFER";
                case PhoneCommand.F_HOLD:
                    return prefixString + "F_HOLD";
                case PhoneCommand.X:
                    return prefixString + "X";
                case PhoneCommand.UP:
                    return prefixString + "UP";
                case PhoneCommand.DOWN:
                    return prefixString + "DOWN";
                case PhoneCommand.LEFT:
                    return prefixString + "LEFT";
                case PhoneCommand.RIGHT:
                    return prefixString + "RIGHT";
                case PhoneCommand.RD:
                    return prefixString + "RD";
                case PhoneCommand.OK:
                    return prefixString + "OK";
                default:
                    return prefixString + "CALLEND";
            }

        }
    }
}
