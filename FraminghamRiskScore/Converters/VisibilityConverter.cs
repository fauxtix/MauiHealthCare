using System.Globalization;
using static FraminghamRiskScore.Enums;

namespace FraminghamRiskScore.Converters
{
    public class VisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return false;
            }

            var genderValue = (Gender)value;
            // Adjust this condition based on your logic to determine visibility
            if( genderValue == Gender.Male)
            {
                return Visibility.Visible;
            }
            return value.ToString() == "Category";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
