﻿namespace SwissTransportGUI
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbConnections = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd.MM.yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(83, 135);
            this.datePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePicker.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(120, 22);
            this.datePicker.TabIndex = 11;
            this.datePicker.Value = new System.DateTime(2017, 5, 2, 0, 0, 0, 0);
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
            this.cbNach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNach.Name = "cbNach";
            this.cbNach.Size = new System.Drawing.Size(212, 24);
            this.cbNach.TabIndex = 7;
            // 
            // cbVon
            // 
            this.cbVon.FormattingEnabled = true;
            this.cbVon.Location = new System.Drawing.Point(83, 46);
            this.cbVon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVon.Name = "cbVon";
            this.cbVon.Size = new System.Drawing.Size(212, 24);
            this.cbVon.TabIndex = 6;
            this.cbVon.TextChanged += new System.EventHandler(this.CbVon_TextChanged);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(229, 135);
            this.timePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timePicker.MaxDate = new System.DateTime(2017, 5, 2, 23, 59, 0, 0);
            this.timePicker.MinDate = new System.DateTime(2017, 4, 27, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(65, 22);
            this.timePicker.TabIndex = 12;
            this.timePicker.Value = new System.DateTime(2017, 5, 2, 10, 10, 0, 0);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(25, 135);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(53, 17);
            this.lblDatum.TabIndex = 13;
            this.lblDatum.Text = "Datum:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(371, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbConnections
            // 
            this.lbConnections.FormattingEnabled = true;
            this.lbConnections.ItemHeight = 16;
            this.lbConnections.Location = new System.Drawing.Point(3, 189);
            this.lbConnections.Name = "lbConnections";
            this.lbConnections.Size = new System.Drawing.Size(494, 308);
            this.lbConnections.TabIndex = 17;
            // 
            // VerbindungenControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbConnections);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lblVon);
            this.Controls.Add(this.lblNach);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.cbNach);
            this.Controls.Add(this.cbVon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lbConnections;
    }
}
