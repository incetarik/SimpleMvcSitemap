using System;
using System.Xml;

namespace SimpleMvcSitemap.Serialization
{
    static class DateTimeExtensions
    {
        public static string ToIso8601Format(this DateTime? dateTime)
        {
            return dateTime.HasValue ? XmlConvert.ToString(dateTime.Value) : null;
        }
    }
}