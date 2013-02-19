using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ScootSim {
    class CoordTextBox : TextBox {
        static readonly Regex CoordRegex = new Regex( @"\d:\d{1,3}:\d{1,2}" );

        public Color ErrorBackColor { get; set; }
        public Color ValidBackColor { get; set; }

        public CoordTextBox() {
            ErrorBackColor = Color.LightPink;
            ValidBackColor = SystemColors.Window;
        }


        protected override void OnTextChanged( EventArgs e ) {
            base.OnTextChanged( e );
            if( IsValid ) {
                BackColor = ValidBackColor;
            } else {
                BackColor = ErrorBackColor;
            }
        }

        public bool IsValid {
            get {
                return CoordRegex.IsMatch( Text );
            }
        }
    }
}