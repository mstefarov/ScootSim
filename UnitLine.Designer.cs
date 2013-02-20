namespace ScootSim {
    partial class UnitLine {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && (components != null) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.xBox = new System.Windows.Forms.CheckBox();
            this.lShipType = new System.Windows.Forms.Label();
            this.nShipCount = new System.Windows.Forms.NumericUpDown();
            this.bChart = new System.Windows.Forms.Button();
            this.tText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nShipCount)).BeginInit();
            this.SuspendLayout();
            // 
            // xBox
            // 
            this.xBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xBox.AutoSize = true;
            this.xBox.Location = new System.Drawing.Point(294, 5);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(15, 14);
            this.xBox.TabIndex = 2;
            this.xBox.TabStop = false;
            this.xBox.UseVisualStyleBackColor = true;
            // 
            // lShipType
            // 
            this.lShipType.Enabled = false;
            this.lShipType.Location = new System.Drawing.Point(3, 4);
            this.lShipType.Name = "lShipType";
            this.lShipType.Size = new System.Drawing.Size(83, 15);
            this.lShipType.TabIndex = 1;
            this.lShipType.Text = "(UnitFactory Type)";
            this.lShipType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nShipCount
            // 
            this.nShipCount.Location = new System.Drawing.Point(89, 2);
            this.nShipCount.Margin = new System.Windows.Forms.Padding(0);
            this.nShipCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nShipCount.Name = "nShipCount";
            this.nShipCount.Size = new System.Drawing.Size(72, 20);
            this.nShipCount.TabIndex = 0;
            this.nShipCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bChart
            // 
            this.bChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bChart.FlatAppearance.BorderSize = 0;
            this.bChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bChart.Image = global::ScootSim.Properties.Resources.chart;
            this.bChart.Location = new System.Drawing.Point(264, -1);
            this.bChart.Margin = new System.Windows.Forms.Padding(0);
            this.bChart.Name = "bChart";
            this.bChart.Size = new System.Drawing.Size(27, 24);
            this.bChart.TabIndex = 1;
            this.bChart.TabStop = false;
            this.bChart.UseVisualStyleBackColor = true;
            this.bChart.Visible = false;
            // 
            // tText
            // 
            this.tText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tText.Location = new System.Drawing.Point(164, 5);
            this.tText.Name = "tText";
            this.tText.Size = new System.Drawing.Size(97, 13);
            this.tText.TabIndex = 3;
            this.tText.TabStop = false;
            // 
            // UnitLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tText);
            this.Controls.Add(this.bChart);
            this.Controls.Add(this.nShipCount);
            this.Controls.Add(this.lShipType);
            this.Controls.Add(this.xBox);
            this.Name = "UnitLine";
            this.Size = new System.Drawing.Size(312, 24);
            ((System.ComponentModel.ISupportInitialize)(this.nShipCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox xBox;
        private System.Windows.Forms.Label lShipType;
        private System.Windows.Forms.NumericUpDown nShipCount;
        private System.Windows.Forms.Button bChart;
        private System.Windows.Forms.TextBox tText;
    }
}
