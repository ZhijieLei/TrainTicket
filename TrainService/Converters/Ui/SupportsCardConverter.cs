using System;
using System.Globalization;
using System.Windows.Data;

namespace TrainService.Converters.Ui {
    public class SupportsCardConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if(value == null)
                return null;
            var SupportsCard = (string)value;
            return SupportsCard == "0" ? "不支持" : "支持";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            if(value == null)
                return null;
            var SupportsCardString = (string)value;
            return SupportsCardString == "不支持" ? 0 : 1;
        }
    }
}
