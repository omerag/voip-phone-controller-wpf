using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace voip_phone_controller_wpf.control
{
    class GetRequestDispatcher
    {

 
        public GetRequestDispatcher()
        {

        }

        public string SendCall(string PhoneIp,string LineExtension, string callNumber)
        {

            UrlBuilder urlBuilder = new UrlBuilder(PhoneIp, LineExtension, callNumber);

            string url = urlBuilder.build();
            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

            NetworkCredential myNetworkCredential = new NetworkCredential("admin", "admin");
            CredentialCache myCredentialCache = new CredentialCache();

            myCredentialCache.Add(uri, "Basic", myNetworkCredential);

            request.PreAuthenticate = true;
            request.Credentials = myCredentialCache;

            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                return response.ToString();
            }
            catch (WebException we)
            {
                return we.Message.ToString();
            }
        }

        public string SendHang(String BaseURL, string LineExtension)
        {
            UrlBuilder urlBuilder = new UrlBuilder(BaseURL, LineExtension, "");

            string url = urlBuilder.build();
            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

            NetworkCredential myNetworkCredential = new NetworkCredential("admin", "admin");
            CredentialCache myCredentialCache = new CredentialCache();

            myCredentialCache.Add(uri, "Basic", myNetworkCredential);

            request.PreAuthenticate = true;
            request.Credentials = myCredentialCache;

            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                return response.ToString();
            }
            catch (WebException we)
            {
                return we.Message.ToString();
            }

          
        }
    }
}
