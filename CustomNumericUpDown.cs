using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ScootSim {
    class CustomNumericUpDown : NumericUpDown {
        readonly Regex formatRegex = new Regex( @"\d(1,3}(\.\d\d\d)+" );

        protected override void ValidateEditText() {
            ParseEditText();
            UpdateEditText();
        }

        protected override void UpdateEditText() {
            Text = FormatUtil.FormatRes( (int)Value );
        }

        new void ParseEditText() {
            int intTry;
            if( Text.Length == 0 ) {
                Value = 0;
                return;
            }else if( Int32.TryParse( Text, out intTry ) ) {
                Value = intTry;
                return;
            } else if( formatRegex.IsMatch( Text ) ) {
                string prunedText = Text.Replace( ".", "" );
                if( Int32.TryParse( prunedText, out intTry ) ) {
                    Value = intTry;
                    return;
                }
            }
            throw new FormatException();
        }
    }
}
