﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        }
    }
}
