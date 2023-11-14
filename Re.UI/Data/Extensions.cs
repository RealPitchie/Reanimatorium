using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Re.UI.Data
{
    public static class DateTimeExtends
    {
        public static DateOnly ToDateOnly(this DateTime date)
        {
            return new DateOnly(date.Year, date.Month, date.Day);
        }

        public static DateOnly? ToDateOnly(this DateTime? date)
        {
            return date != null ? date.Value.ToDateOnly() : null;
        }
        public static TimeOnly ToTimeOnly(this DateTime date)
        {
            return new TimeOnly(date.Hour, date.Minute, date.Second);
        }

        public static TimeOnly? ToTimeOnly(this DateTime? date)
        {
            return date != null ? date.Value.ToTimeOnly() : null;
        }
    }
    
}