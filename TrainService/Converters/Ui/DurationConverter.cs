using System;
using System.Globalization;
using System.Windows.Data;

namespace TrainService.Converters.Ui
{
    public class DurationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;
            var duration = (TimeSpan) value;
            return duration.ToString("hh':'mm");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;
            return TimeSpan.Parse((string)value);
        }
    }
}