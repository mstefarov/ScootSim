using System;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ScootSim {
    class SeparatedNumericUpDown : NumericUpDown {
        static readonly Regex FormatRegex = new Regex( @"\d{1,3}(\.\d\d\d)*" );


        bool userIsInteracting;

        protected override void OnEnter( EventArgs e ) {
            Debug.WriteLine( Environment.TickCount + "OnEnter" );
            base.OnEnter( e );
            userIsInteracting = true;
            UpdateEditText();
            Select( 0, Text.Length );
        }

        protected override void OnLeave( EventArgs e ) {
            base.OnLeave( e );
            userIsInteracting = false;
            UpdateEditText();
        }


        protected override void ValidateEditText() {
            Debug.WriteLine( Environment.TickCount + "ValidateEditText" );
            ParseEditText();
            UpdateEditText();
        }


        new void ParseEditText() {
            Debug.WriteLine( Environment.TickCount + "ParseEditText" );
            try {
                long intTry;
                if( Text.Length == 0 ) {
                    Value = 0;
                } else if( Int64.TryParse( Text, out intTry ) ) {
                    Value = Math.Max( Minimum, Math.Min( Maximum, intTry ) );
                } else if( FormatRegex.IsMatch( Text ) ) {
                    string prunedText = Text.Replace( ".", "" );
                    if( Int64.TryParse( prunedText, out intTry ) ) {
                        Value = Math.Max( Minimum, Math.Min( Maximum, intTry ) );
                    } else {
                        throw new FormatException();
                    }
                } else {
                    throw new FormatException();
                }
            } finally {
                UserEdit = false;
            }
        }


        protected override void UpdateEditText() {
            Debug.WriteLine( Environment.TickCount + "UpdateEditText" );
            if( userIsInteracting ) {
                if( Value == 0 ) {
                    Text = "";
                } else {
                    Text = Value.ToString( CultureInfo.InvariantCulture );
                }
            } else {
                Text = FormatUtil.FormatRes( (long)Value );
            }
        }
    }
}