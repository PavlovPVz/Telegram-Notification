using System;
using System.Net;
using api;

namespace Telegram_notification
{
    class Program
    {
        static void Main(string[] args)
        {
            string tgtoken = "TOKEN";
            string tgchatid = "USERID";
            telegram.SendMessage("Telegram notification", tgtoken, tgchatid);
        }
    }
}
