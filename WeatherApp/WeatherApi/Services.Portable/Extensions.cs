﻿using System;
using System.Globalization;
using System.Linq;

namespace Services.Portable
{
    public static class Extensions
    {
        public static Uri Append(this Uri uri, params string[] paths)
        {
            return new Uri(paths.Aggregate(uri.AbsoluteUri, (current, path) => string.Format("{0}/{1}", current.TrimEnd('/'), path.TrimStart('/'))));
        }

        public static Uri AppendQuery(this Uri uri, params string[] query)
        {
            var uriBuilder = new UriBuilder(uri) { Query = string.Join("&", query) };
            return uriBuilder.Uri;
        }

        public static Uri AppendQuery(this Uri uri, string query)
        {
            var uriBuilder = new UriBuilder(uri) { Query = query };
            return uriBuilder.Uri;
        }

        public static decimal NormalizeTemperature(this decimal tempValue)
        {
            return Math.Round(tempValue - 273.15m, 1);
        }

        public static string DisplayTemperature(this decimal tempValue)
        {
            return $"{tempValue.NormalizeTemperature().ToString(CultureInfo.InvariantCulture)}º";
        }

        public static string DisplayHumidity(this decimal humidityValue)
        {
            return $"{humidityValue.ToString(CultureInfo.InvariantCulture)}%";
        }

        public static string DisplayWindy(this decimal windyValue)
        {
            var valueInKmPerH = windyValue*1000/3600;
            return $"{windyValue.ToString(CultureInfo.InvariantCulture)} km / h";
        }
    }
}