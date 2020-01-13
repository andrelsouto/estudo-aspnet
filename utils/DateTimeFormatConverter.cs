using Newtonsoft.Json.Converters;
using System.Globalization;

namespace rest_consulta.utils
{
    public class DateTimeFormatConverter : IsoDateTimeConverter
    {
        
        public DateTimeFormatConverter(string format)
        {
            DateTimeFormat = format;
            DateTimeStyles = DateTimeStyles.AssumeLocal;
        }

        public DateTimeFormatConverter() { }

    }
}