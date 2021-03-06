﻿using System;
using System.Globalization;

namespace ParkenDD.Api.Converters
{
    public static class IsoDateConverter
    {
        private const string IsoDateFormat = "yyyy-MM-ddTHH:mm:ss";
        public static string ToIsoString(DateTime dt)
        {
            return dt.ToUniversalTime().ToString(IsoDateFormat);
        }

        public static DateTime ToDateTime(string isoDateString)
        {
            DateTime result;
            if (DateTime.TryParseExact(isoDateString, IsoDateFormat, CultureInfo.InvariantCulture,
                DateTimeStyles.AssumeUniversal, out result))
            {
                return result;
            }
            return default(DateTime);
        }
    }
}
