namespace Monopoly.API.Routes
{
    public static class DefaultRoutes
    {
        public const string Root = "api";

        public const string Version = "v0";

        public const string Base = Root + "/" + Version;

        public static class Identity
        {
            public const string Login = Base + "/identity/login";

            public const string Register = Base + "/identity/register";

            public const string Logout = Base + "/identity/logout";

            public const string RefreshToken = Base + "/identity/refreshToken";
        }

        public static class Lobby
        {
            public const string GameCreate = Base + "/lobby/game";

            public const string GameJoin = Base + "/lobby/game";

            public const string GameLeave = Base + "/lobby/game";

            public const string GetGames = Base + "/lobby";
        }

        public static class City
        {
            public const string GetCity = Base + "/city";

            public const string AddCity = Base + "/city";

            public const string DeleteCity = Base + "/city";

            public const string AddStreet = Base + "/city/street";

            public const string DeleteStreet = Base + "/city/street";

            public const string ConnectStreet = Base + "/city/street";

            public const string AddStreetMonopoly = Base + "/city/streetMonopoly";

            public const string DeleteStreetMonopoly = Base + "/city/streetMonopoly";
        }

        public static class LiqPay
        {
            public const string LiqPayRedirect = Base + "/liqPay";
            public const string LiqPayNotifications = Base + "/liqpay/notifications";
        }
    }
}