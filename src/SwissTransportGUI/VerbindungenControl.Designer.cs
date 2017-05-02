namespace SwissTransportGUI
{
    partial class VerbindungenControl
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lblVon = new System.Windows.Forms.Label();
            this.lblNach = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.cbNach = new System.Windows.Forms.ComboBox();
            this.cbVon = new System.Windows.Forms.ComboBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd.MM.yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(83, 136);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(108, 22);
            this.datePicker.TabIndex = 11;
            this.datePicker.Value = new System.DateTime(2017, 5, 2, 14, 36, 11, 0);
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Location = new System.Drawing.Point(25, 46);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(37, 17);
            this.lblVon.TabIndex = 10;
            this.lblVon.Text = "Von:";
            // 
            // lblNach
            // 
            this.lblNach.AutoSize = true;
            this.lblNach.Location = new System.Drawing.Point(25, 82);
            this.lblNach.Name = "lblNach";
            this.lblNach.Size = new System.Drawing.Size(45, 17);
            this.lblNach.TabIndex = 9;
            this.lblNach.Text = "Nach:";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(0, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(135, 25);
            this.lblTitel.TabIndex = 8;
            this.lblTitel.Text = "Verbindungen";
            // 
            // cbNach
            // 
            this.cbNach.FormattingEnabled = true;
            this.cbNach.Location = new System.Drawing.Point(83, 82);
            this.cbNach.Name = "cbNach";
            this.cbNach.Size = new System.Drawing.Size(172, 24);
            this.cbNach.TabIndex = 7;
            // 
            // cbVon
            // 
            this.cbVon.FormattingEnabled = true;
            this.cbVon.Location = new System.Drawing.Point(83, 46);
            this.cbVon.Name = "cbVon";
            this.cbVon.Size = new System.Drawing.Size(172, 24);
            this.cbVon.TabIndex = 6;
            this.cbVon.TextChanged += new System.EventHandler(this.cbVon_TextChanged);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "hh:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(197, 136);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(58, 22);
            this.timePicker.TabIndex = 12;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(25, 136);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(53, 17);
            this.lblDatum.TabIndex = 13;
            this.lblDatum.Text = "Datum:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VerbindungenControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lblVon);
            this.Controls.Add(this.lblNach);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.cbNach);
            this.Controls.Add(this.cbVon);
            this.Name = "VerbindungenControl";
            this.Size = new System.Drawing.Size(500, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.Label lblNach;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.ComboBox cbNach;
        private System.Windows.Forms.ComboBox cbVon;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button button1;
    }
}
