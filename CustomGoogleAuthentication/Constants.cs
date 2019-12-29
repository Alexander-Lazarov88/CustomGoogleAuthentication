using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGoogleAuthentication
{
    public static class Constants
    {
        public const string AppName = "CUSTOM_GOOGLE_AUTHENTICATION_";

        public static class Context
        {
            public const string ConnectionString = AppName + "CONNECTION_STRING";
        }

        public static class Google
        {
            public const string ClientId = AppName + "GOOGLE_CLIENT_ID";
            public const string Secret = AppName + "GOOGLE_CLIENT_SECRET";
        }
    }
}
