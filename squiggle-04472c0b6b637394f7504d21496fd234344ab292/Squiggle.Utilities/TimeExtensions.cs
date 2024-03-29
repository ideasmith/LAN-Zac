﻿using System;

namespace Squiggle.Utilities
{
    public static class TimeExtensions
    {
        public static TimeSpan Seconds(this int number)
        {
            return TimeSpan.FromSeconds(number);
        }

        public static TimeSpan Minutes(this int number)
        {
            return TimeSpan.FromMinutes(number);
        }
    }
}
