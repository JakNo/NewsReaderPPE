using System.Net;

namespace NewsReaderPPE
{
    class WebsiteSourceCode
    {
        public static string GetSourceCode(string url)
        {
            using (WebClient client = new WebClient())
            {
                string htmlCode = client.DownloadString("http://ppe.pl");
                return htmlCode;
            }
        }
    }
}
