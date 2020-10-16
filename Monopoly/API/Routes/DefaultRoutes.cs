﻿namespace Monopoly.API.Routes
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
    }
}