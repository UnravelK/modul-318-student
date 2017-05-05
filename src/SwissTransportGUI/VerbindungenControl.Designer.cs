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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvConnections = new System.Windows.Forms.ListView();
            this.btnSwap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd.MM.yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(112, 136);
            this.datePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePicker.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(120, 22);
            this.datePicker.TabIndex = 3;
            this.datePicker.Value = new System.DateTime(2017, 5, 2, 0, 0, 0, 0);
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Location = new System.Drawing.Point(54, 47);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(37, 17);
            this.lblVon.TabIndex = 0;
            this.lblVon.Text = "Von:";
            // 
            // lblNach
            // 
            this.lblNach.AutoSize = true;
            this.lblNach.Location = new System.Drawing.Point(54, 83);
            this.lblNach.Name = "lblNach";
            this.lblNach.Size = new System.Drawing.Size(45, 17);
            this.lblNach.TabIndex = 0;
            this.lblNach.Text = "Nach:";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(0, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(135, 25);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Verbindungen";
            // 
            // cbNach
            // 
            this.cbNach.FormattingEnabled = true;
            this.cbNach.Location = new System.Drawing.Point(112, 83);
            this.cbNach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNach.Name = "cbNach";
            this.cbNach.Size = new System.Drawing.Size(212, 24);
            this.cbNach.TabIndex = 2;
            this.cbNach.TextChanged += new System.EventHandler(this.CbNach_TextChanged);
            // 
            // cbVon
            // 
            this.cbVon.FormattingEnabled = true;
            this.cbVon.Location = new System.Drawing.Point(112, 47);
            this.cbVon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVon.Name = "cbVon";
            this.cbVon.Size = new System.Drawing.Size(212, 24);
            this.cbVon.TabIndex = 1;
            this.cbVon.TextChanged += new System.EventHandler(this.CbVon_TextChanged);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(258, 136);
            this.timePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timePicker.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.timePicker.MinDate = new System.DateTime(2017, 4, 27, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(65, 22);
            this.timePicker.TabIndex = 4;
            this.timePicker.Value = new System.DateTime(2017, 5, 2, 10, 10, 0, 0);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(54, 136);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(53, 17);
            this.lblDatum.TabIndex = 0;
            this.lblDatum.Text = "Datum:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(329, 114);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lvConnections
            // 
            this.lvConnections.FullRowSelect = true;
            this.lvConnections.Location = new System.Drawing.Point(15, 200);
            this.lvConnections.Name = "lvConnections";
            this.lvConnections.Size = new System.Drawing.Size(565, 280);
            this.lvConnections.TabIndex = 6;
            this.lvConnections.UseCompatibleStateImageBehavior = false;
            this.lvConnections.View = System.Windows.Forms.View.Details;
            this.lvConnections.Visible = false;
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(330, 66);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(80, 24);
            this.btnSwap.TabIndex = 0;
            this.btnSwap.TabStop = false;
            this.btnSwap.Text = "Tauschen";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.BtnSwap_Click);
            // 
            // VerbindungenControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.lvConnections);
            this.Controls.Add(this.btnSearch);
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
            this.Size = new System.Drawing.Size(600, 500);
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvConnections;
        private System.Windows.Forms.Button btnSwap;
    }
}
