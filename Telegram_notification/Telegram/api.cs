using System;
using System.Net;

namespace api
{
    class telegram
    {
        public static bool SendMessage(string text, string tgtoken, string tgchatid)
        {
                using (WebClient c = new WebClient())
                {
                    string response = c.DownloadString(
                        "https://api.telegram.org/bot" + tgtoken + "/sendMessage" +
                        "?chat_id=" + tgchatid +
                        "&text=" + text +
                        "&parse_mode=Markdown" +
                        "&disable_web_page_preview=True"
                    );
                    return !response.StartsWith("{\"ok\":false");
                }
        }
    }
}
