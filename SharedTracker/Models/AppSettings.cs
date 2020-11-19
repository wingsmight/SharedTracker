using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SharedTracker.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; } = "https://telegrambotapp.azurewebsites.net:433/{0}";
        public static string Name { get; set; } = "shared_tracker_bot";
        public static string Key { get; set; } = "1316366425:AAHj6oHBGTD8QcFtPUycJmxwBuuS3ST5nEc";
    }
}