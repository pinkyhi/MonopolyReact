namespace Monopoly.Core.Options
{
    using System;

    public class JwtOptions
    {
        public static string Secret { get; set; }

        public static TimeSpan TokenLifeTime { get; set; }
    }
}