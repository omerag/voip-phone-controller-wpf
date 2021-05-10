using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voip_phone_controller_wpf.control
{
    class CallNumberProcessor
    {

        static public string ProcessPhoneNumber(string phoneNumber)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach(char c in phoneNumber)
            {
                if(Char.IsDigit(c))
                {
                    stringBuilder.Append(c);
                }
            }


            return stringBuilder.ToString();
        }
    }

}
