using System.Globalization;

namespace ScootSim {
    static class FormatUtil {
        static readonly NumberFormatInfo ResFormatter;
        static FormatUtil() {
            ResFormatter = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
            ResFormatter.NumberGroupSeparator = ".";
        }

        public static string FormatRes( long number ) {
            return number.ToString( "#,#", ResFormatter );
        }
    }
}
