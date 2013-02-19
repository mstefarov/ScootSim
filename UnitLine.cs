using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScootSim {
    public partial class UnitLine : UserControl {
        public UnitLine() {
            InitializeComponent();
            Text = "";
            xBox.Visible = false;
            nShipCount.Text = "";
            HighlightColor = SystemColors.ControlLight;

            // Toggles highlighting on mouse-over
            foreach( Control c in Controls ) {
                c.MouseEnter += OnMouseEnter;
                c.MouseLeave += OnMouseLeave;
            }
            MouseEnter += OnMouseEnter;
            MouseLeave += OnMouseLeave;

            // Toggles highlighting on focus
            nShipCount.Enter += nShipCount_Enter;
            nShipCount.Leave += nShipCount_Leave;

            // Replaces "0" with blank, for cosmetic purposes
            nShipCount.Validated += nShipCount_Validated;

            // Detects when value is 0 or blank
            nShipCount.TextChanged += nShipCount_ValueChanged;

            // handles toggling checkbox on Ctrl+Enter
            nShipCount.KeyDown += nShipCount_KeyDown;

            // Fires UnitLine.CountChanged
            nShipCount.ValueChanged += nShipCount_ValueChanged;

            // fires UnitLine.CheckedChanged event
            xBox.CheckedChanged += xBox_CheckedChanged;

            // fires UnitLine.GraphButtonClick event
            bChart.Click += bChart_Click;

            BackColorChanged += UnitLine_BackColorChanged;
        }

        
        void UnitLine_BackColorChanged( object sender, EventArgs e ) {
            // syncs our TextBox's BackColor (which cannot be made transparent)
            // to the control's general BackColor
            if( BackColor == Color.Transparent ) {
                tText.BackColor = SystemColors.Window;
            } else {
                tText.BackColor = BackColor;
            }
        }


        #region Properties

        [DefaultValue( true )]
        [EditorBrowsable]
        [Category( "Custom" )]
        public bool ShowCheckbox {
            get {
                return showCheckbox;
            }
            set {
                showCheckbox = value;
                SetCheckboxVisibility();
            }
        }

        bool showCheckbox = true;


        [DefaultValue( "(Ship Type)" )]
        [EditorBrowsable]
        [Category( "Custom" )]
        public string ShipType {
            get {
                return lShipType.Text;
            }
            set {
                lShipType.Text = value;
            }
        }


        [DefaultValue( false )]
        [EditorBrowsable]
        [Category( "Custom" )]
        public bool Checked {
            get {
                return xBox.Checked;
            }
            set {
                xBox.Checked = value;
            }
        }


        [DefaultValue( 0 )]
        [EditorBrowsable]
        [Category( "Custom" )]
        public int ShipCount {
            get {
                return (int)nShipCount.Value;
            }
            set {
                nShipCount.Value = value;
            }
        }


        [DefaultValue( "" )]
        [EditorBrowsable]
        [Browsable( true )]
        [Category( "Custom" )]
        public override string Text {
            get {
                return tText.Text;
            }
            set {
                tText.Text = value;
            }
        }


        [DefaultValue( false )]
        [EditorBrowsable]
        [Category( "Custom" )]
        public bool ChartVisible {
            get {
                return bChart.Visible;
            }
            set {
                bChart.Visible = value;
            }
        }


        [EditorBrowsable]
        [Category( "Custom" )]
        public Color HighlightColor { get; set; }


        [Category( "Custom" )]
        public bool IsHighlighted {
            get {
                return isHighlighted;
            }
            private set {
                if( isHighlighted != value ) {
                    isHighlighted = value;
                    if( isHighlighted ) {
                        BackColor = HighlightColor;
                    } else {
                        BackColor = SystemColors.Window;
                    }
                }
            }
        }

        bool isHighlighted;

        #endregion


        #region Events

        public event EventHandler CountChanged;

        void nShipCount_ValueChanged( object sender, EventArgs e ) {
            SetCheckboxVisibility();
            lShipType.Enabled = (nShipCount.Value > 0 && nShipCount.Text.Length > 0);
            var h = CountChanged;
            if( h != null ) h( this, e );
        }


        public event EventHandler CheckedChanged;

        void xBox_CheckedChanged( object sender, EventArgs e ) {
            var h = CheckedChanged;
            if( h != null ) h( this, e );
        }


        public event EventHandler GraphButtonClick;

        void bChart_Click( object sender, EventArgs e ) {
            var h = GraphButtonClick;
            if( h != null ) h( this, e );
        }

        #endregion


        #region Highlighting

        // highlight row when mouse enters
        void OnMouseEnter( object sender, EventArgs e ) {
            // make sure only one ShipLine in a control is highlighted at a time
            foreach( Control c in Parent.Controls ) {
                UnitLine sl = (c as UnitLine);
                if( sl != null && sl != this && !sl.nShipCount.Focused ) {
                    sl.IsHighlighted = false;
                }
            }
            // highlight this one
            IsHighlighted = true;
        }


        void OnMouseLeave( object sender, EventArgs e ) {
            // (this check is needed because child controls fire MouseLeave too)
            if( !ClientRectangle.Contains( PointToClient( MousePosition ) ) && !nShipCount.Focused ) {
                // remove highlight, if we left the boundaries
                IsHighlighted = false;
            }
        }


        void nShipCount_Enter( object sender, EventArgs e ) {
            // Select number when you tab to it
            nShipCount.Select( 0, nShipCount.Text.Length );
            // highlight this row
            OnMouseEnter( sender, e );
        }


        void nShipCount_Leave( object sender, EventArgs e ) {
            if( !ClientRectangle.Contains( PointToClient( MousePosition ) ) ) {
                // remove highlight, if we left the boundaries
                IsHighlighted = false;
            }
        }

        #endregion


        void nShipCount_Validated( object sender, EventArgs e ) {
            // Replace zeroes with blanks
            if( nShipCount.Value == 0 ) {
                nShipCount.Text = "";
            }
        }


        // handles toggling checkbox on Ctrl+Enter
        void nShipCount_KeyDown( object sender, KeyEventArgs e ) {
            if( e.KeyCode == Keys.Enter && e.Control && xBox.Visible ) {
                xBox.Checked = !xBox.Checked;
            }
        }


        void SetCheckboxVisibility() {
            xBox.Visible = showCheckbox &&
                           (nShipCount.Value > 0) &&
                           (nShipCount.Text.Length > 0);
        }


        public void Clear() {
            nShipCount.Value = 0;
            nShipCount.Text = "";
            xBox.Checked = false;
        }
    }
}