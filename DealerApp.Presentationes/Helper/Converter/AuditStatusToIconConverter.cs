﻿using DealerApp.Model;


namespace DealerApp.Presentationes.Helper.Converter
{
    public class AuditStatusToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is AudStatus status)
            {
                switch (status)
                {
                    case AudStatus.Sold:
                        return "sold.png";
                    case AudStatus.Inprocess:
                        return "inprocess.png";
                    case AudStatus.Failed:
                        return "failed.png";
                    default:
                        return string.Empty;
                }
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
