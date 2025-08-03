using System.Text.RegularExpressions;
using System.Globalization;

namespace DimensionsTagUtility.Tools
{
    public partial class ByteArrayToStringConverter : IValueConverter
    {

        [GeneratedRegex(@"\A(?:[0-9A-Fa-f]{2})+\z")]
        private static partial Regex ValidHexRegex();

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
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

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var valueString = value as string ?? string.Empty;
            var byteArray = ConvertToByteArray(valueString);
            return byteArray.Length == 0 ? Binding.DoNothing : byteArray;
        }

        public static byte[] ConvertToByteArray(string hexString)
        {
            var updatedString = hexString.Replace(":", string.Empty);

            if (updatedString.Length % 2 != 0 ||
                !ValidHexRegex().IsMatch(updatedString)) return [];

            if (!TryParseHexString(updatedString.AsSpan(), out byte[] byteArray)) return [];
            return byteArray;
        }

        public static bool TryParseHexString(ReadOnlySpan<char> hexSpan, out byte[] result)
        {
            result = [];
            if (hexSpan.Length % 2 != 0) return false;

            byte[] buffer = new byte[hexSpan.Length / 2];

            for (int i = 0; i < buffer.Length; i++)
            {
                ReadOnlySpan<char> hexPair = hexSpan.Slice(i * 2, 2);
                if (!byte.TryParse(hexPair, NumberStyles.HexNumber, null, out buffer[i]))
                    return false;
            }

            result = buffer;
            return true;
        }

    }

}
