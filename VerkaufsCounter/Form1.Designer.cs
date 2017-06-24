namespace VerkaufsCounter
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.usernametb = new System.Windows.Forms.TextBox();
            this.maxsitetb = new System.Windows.Forms.NumericUpDown();
            this.auswerten = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clear_bt = new System.Windows.Forms.Button();
            this.minsitestb = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.export = new System.Windows.Forms.Button();
            this.radioSearchSites = new System.Windows.Forms.RadioButton();
            this.radioSearchTime = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.help = new System.Windows.Forms.Button();
            this.anz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Währung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.maxsitetb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minsitestb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bitte den E-Bay-Usernamen eingeben:";
            // 
            // usernametb
            // 
            this.usernametb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernametb.Location = new System.Drawing.Point(270, 10);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(892, 22);
            this.usernametb.TabIndex = 1;
            // 
            // maxsitetb
            // 
            this.maxsitetb.Location = new System.Drawing.Point(293, 73);
            this.maxsitetb.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.maxsitetb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxsitetb.Name = "maxsitetb";
            this.maxsitetb.Size = new System.Drawing.Size(63, 22);
            this.maxsitetb.TabIndex = 5;
            this.maxsitetb.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.maxsitetb.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // auswerten
            // 
            this.auswerten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.auswerten.Location = new System.Drawing.Point(1062, 72);
            this.auswerten.Name = "auswerten";
            this.auswerten.Size = new System.Drawing.Size(127, 23);
            this.auswerten.TabIndex = 6;
            this.auswerten.Text = "Auswerten";
            this.auswerten.UseVisualStyleBackColor = true;
            this.auswerten.Click += new System.EventHandler(this.auswerten_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1168, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Max. Seiten ermitteln";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ermittelte max. Seiten des Users USER: XX";
            this.label4.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anz,
            this.Zeit,
            this.Währung,
            this.Preis,
            this.product});
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1327, 705);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clear_bt
            // 
            this.clear_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_bt.Location = new System.Drawing.Point(1195, 72);
            this.clear_bt.Name = "clear_bt";
            this.clear_bt.Size = new System.Drawing.Size(63, 23);
            this.clear_bt.TabIndex = 7;
            this.clear_bt.Text = "Clear";
            this.clear_bt.UseVisualStyleBackColor = true;
            this.clear_bt.Click += new System.EventHandler(this.clear_bt_Click);
            // 
            // minsitestb
            // 
            this.minsitestb.Location = new System.Drawing.Point(192, 73);
            this.minsitestb.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.minsitestb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minsitestb.Name = "minsitestb";
            this.minsitestb.Size = new System.Drawing.Size(63, 22);
            this.minsitestb.TabIndex = 4;
            this.minsitestb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Durchsuche von Seite";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "bis";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // export
            // 
            this.export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.export.Location = new System.Drawing.Point(1143, 41);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(196, 23);
            this.export.TabIndex = 8;
            this.export.Text = "Exportieren als .csv Datei";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // radioSearchSites
            // 
            this.radioSearchSites.AutoSize = true;
            this.radioSearchSites.Location = new System.Drawing.Point(16, 75);
            this.radioSearchSites.Name = "radioSearchSites";
            this.radioSearchSites.Size = new System.Drawing.Size(17, 16);
            this.radioSearchSites.TabIndex = 10;
            this.radioSearchSites.UseVisualStyleBackColor = true;
            // 
            // radioSearchTime
            // 
            this.radioSearchTime.AutoSize = true;
            this.radioSearchTime.Checked = true;
            this.radioSearchTime.Location = new System.Drawing.Point(16, 44);
            this.radioSearchTime.Name = "radioSearchTime";
            this.radioSearchTime.Size = new System.Drawing.Size(17, 16);
            this.radioSearchTime.TabIndex = 11;
            this.radioSearchTime.TabStop = true;
            this.radioSearchTime.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Verkäufe";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "(none)";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alle",
            "Im letzten Monat",
            "In den letzten 6 Monaten",
            "Im letzten Jahr"});
            this.comboBox1.Location = new System.Drawing.Point(110, 41);
            this.comboBox1.MaxDropDownItems = 4;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // help
            // 
            this.help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.help.Location = new System.Drawing.Point(1264, 72);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(75, 23);
            this.help.TabIndex = 9;
            this.help.Text = "Hilfe";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // anz
            // 
            this.anz.HeaderText = "Anz";
            this.anz.Name = "anz";
            this.anz.ReadOnly = true;
            this.anz.Width = 50;
            // 
            // Zeit
            // 
            this.Zeit.HeaderText = "Zeit";
            this.Zeit.Name = "Zeit";
            this.Zeit.ReadOnly = true;
            this.Zeit.Width = 150;
            // 
            // Währung
            // 
            this.Währung.HeaderText = "Währung";
            this.Währung.Name = "Währung";
            this.Währung.ReadOnly = true;
            this.Währung.Width = 70;
            // 
            // Preis
            // 
            this.Preis.HeaderText = "Stückpreis";
            this.Preis.Name = "Preis";
            this.Preis.ReadOnly = true;
            this.Preis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Preis.Width = 80;
            // 
            // product
            // 
            this.product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product.HeaderText = "Produkt";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 818);
            this.Controls.Add(this.help);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioSearchTime);
            this.Controls.Add(this.radioSearchSites);
            this.Controls.Add(this.export);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minsitestb);
            this.Controls.Add(this.clear_bt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.auswerten);
            this.Controls.Add(this.maxsitetb);
            this.Controls.Add(this.usernametb);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Produkt Zähler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxsitetb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minsitestb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.NumericUpDown maxsitetb;
        private System.Windows.Forms.Button auswerten;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button clear_bt;
        private System.Windows.Forms.NumericUpDown minsitestb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.RadioButton radioSearchSites;
        private System.Windows.Forms.RadioButton radioSearchTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.DataGridViewTextBoxColumn anz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Währung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
    }
}

