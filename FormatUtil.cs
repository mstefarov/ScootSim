using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ScootSim {
    static class FormatUtil {
        static readonly NumberFormatInfo ResFormatter;
        static FormatUtil() {
            ResFormatter = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
            ResFormatter.NumberGroupSeparator = ".";
        }

        public static string FormatRes( int number ) {
            return number.ToString( "#,#", ResFormatter );
        }
    }
}
