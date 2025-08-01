using System.Text.RegularExpressions;

namespace DimensionsTagUtility.Tools
{
    public class ByteArrayToStringConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, System.Globalization.CultureInfo culture)
        {
            switch (value)
            {
                case byte[] bytes:

                    return BitConverter.ToString(bytes).Replace("-", ":");

                case byte aByte:
                    var thisByte = $"{aByte}";
                    return thisByte;
            }
            return string.Empty;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, System.Globalization.CultureInfo culture)
        {
            //This is for numerical input, not text.
            var valueString = (value as string ?? string.Empty)
                    .Replace(":", string.Empty);

            byte[] byteArray = [];
            if (valueString.Length != 14 || !Regex.IsMatch(valueString, @"\A[0-9A-Fa-f]{14}\z")) return Binding.DoNothing;

            byteArray = new byte[7];

            for (int i = 0; i < byteArray.Length; i++)
            {
                string hexPair = valueString.Substring(i * 2, 2);
                byteArray[i] = System.Convert.ToByte(hexPair, 16);
            }

            return byteArray;
        }

    }

}
