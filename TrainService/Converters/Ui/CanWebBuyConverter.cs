using System;
using System.Globalization;
using System.Windows.Data;

namespace TrainService.Converters.Ui {
    public class CanWebBuyConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if(value == null)
                return null;
            var CanWebBuy = (string)value;
            switch(CanWebBuy) {
                case "Y" :
                    return "有票";
                case "N":
                    return "无票";
                case "IS_TIME_NOT_BUY":
                    return "23:00-06:00系统维护时间";
            }
            return CanWebBuy;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            return value;
        }
    }
}