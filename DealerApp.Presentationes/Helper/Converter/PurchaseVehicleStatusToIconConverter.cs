using DealerApp.Model;


namespace DealerApp.Presentationes.Helper.Converter
{
    public class PurchaseVehicleStatusToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is PurchaseVehicleStatus status)
            {
                switch (status)
                {
                    case PurchaseVehicleStatus.True:
                        return "green.png";
                    case PurchaseVehicleStatus.False:
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
