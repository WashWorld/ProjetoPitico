using System.Configuration;

namespace Pjt_Pitico
{
    public static class AppConfig
    {
        public static string RadioButtonState
        {
            get { return ConfigurationManager.AppSettings["RadioButtonState"]; }
            set { ConfigurationManager.AppSettings["RadioButtonState"] = value; }
        }

        public static bool RadioButtonDesligado { get; internal set; }
    }
}