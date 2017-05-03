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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbBoard = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblStationName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(0, 0);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(126, 20);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Stationsfahrplan";
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(19, 37);
            this.lblStation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(43, 13);
            this.lblStation.TabIndex = 1;
            this.lblStation.Text = "Station:";
            // 
            // cbStation
            // 
            this.cbStation.FormattingEnabled = true;
            this.cbStation.Location = new System.Drawing.Point(62, 37);
            this.cbStation.Margin = new System.Windows.Forms.Padding(2);
            this.cbStation.Name = "cbStation";
            this.cbStation.Size = new System.Drawing.Size(130, 21);
            this.cbStation.TabIndex = 2;
            this.cbStation.TextUpdate += new System.EventHandler(this.CbStation_TextUpdate);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(206, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 98);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbBoard
            // 
            this.lbBoard.FormattingEnabled = true;
            this.lbBoard.Location = new System.Drawing.Point(14, 150);
            this.lbBoard.Margin = new System.Windows.Forms.Padding(2);
            this.lbBoard.Name = "lbBoard";
            this.lbBoard.Size = new System.Drawing.Size(343, 238);
            this.lbBoard.TabIndex = 5;
            this.lbBoard.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 80);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblStationName
            // 
            this.lblStationName.AutoSize = true;
            this.lblStationName.Location = new System.Drawing.Point(19, 133);
            this.lblStationName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(66, 13);
            this.lblStationName.TabIndex = 7;
            this.lblStationName.Text = "Stationname";
            this.lblStationName.Visible = false;
            // 
            // StationsfahrplanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStationName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbBoard);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbStation);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.lblTitel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StationsfahrplanControl";
            this.Size = new System.Drawing.Size(375, 406);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.ComboBox cbStation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lbBoard;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblStationName;
    }
}
