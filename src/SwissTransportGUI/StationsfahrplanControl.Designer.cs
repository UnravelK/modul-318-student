namespace SwissTransportGUI
{
    partial class StationsfahrplanControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.cbStation = new System.Windows.Forms.ComboBox();
            this.lbBoard = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStationName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(0, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(153, 25);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Stationsfahrplan";
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(25, 46);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(56, 17);
            this.lblStation.TabIndex = 1;
            this.lblStation.Text = "Station:";
            // 
            // cbStation
            // 
            this.cbStation.FormattingEnabled = true;
            this.cbStation.Location = new System.Drawing.Point(83, 46);
            this.cbStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStation.Name = "cbStation";
            this.cbStation.Size = new System.Drawing.Size(172, 24);
            this.cbStation.TabIndex = 2;
            this.cbStation.TextUpdate += new System.EventHandler(this.CbStation_TextUpdate);
            // 
            // lbBoard
            // 
            this.lbBoard.FormattingEnabled = true;
            this.lbBoard.ItemHeight = 16;
            this.lbBoard.Location = new System.Drawing.Point(19, 185);
            this.lbBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBoard.Name = "lbBoard";
            this.lbBoard.Size = new System.Drawing.Size(456, 292);
            this.lbBoard.TabIndex = 5;
            this.lbBoard.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(298, 47);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSuchen_Click);
            // 
            // lblStationName
            // 
            this.lblStationName.AutoSize = true;
            this.lblStationName.Location = new System.Drawing.Point(25, 164);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(87, 17);
            this.lblStationName.TabIndex = 7;
            this.lblStationName.Text = "Stationname";
            this.lblStationName.Visible = false;
            // 
            // StationsfahrplanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStationName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbBoard);
            this.Controls.Add(this.cbStation);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.lblTitel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StationsfahrplanControl";
            this.Size = new System.Drawing.Size(500, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.ComboBox cbStation;
        private System.Windows.Forms.ListBox lbBoard;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStationName;
    }
}
