namespace BilliardPoints
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonOddSpillerA = new System.Windows.Forms.Button();
            this.buttonOddSpillerB = new System.Windows.Forms.Button();
            this.buttonVinnSpillerA = new System.Windows.Forms.Button();
            this.buttonVinnSpillerB = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.labelPoengSpillerA = new System.Windows.Forms.Label();
            this.labelPoengSpillerB = new System.Windows.Forms.Label();
            this.labelKlokke = new System.Windows.Forms.Label();
            this.labelDato = new System.Windows.Forms.Label();
            this.timerSekund = new System.Windows.Forms.Timer(this.components);
            this.comboBoxSpillerA = new System.Windows.Forms.ComboBox();
            this.comboBoxSpillerB = new System.Windows.Forms.ComboBox();
            this.labelCurrOmgTid = new System.Windows.Forms.Label();
            this.buttonSlettSisteHendelse = new System.Windows.Forms.Button();
            this.timer2Sekund = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.Spill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hendelse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OmgangsTid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonReStart = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelSpillerSomSprerHeading = new System.Windows.Forms.Label();
            this.labelSpillerSomSprer = new System.Windows.Forms.Label();
            this.labelSnittOmgTidHeading = new System.Windows.Forms.Label();
            this.labelSnittOmgTid = new System.Windows.Forms.Label();
            this.labelSpillNr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOddSpillerA
            // 
            this.buttonOddSpillerA.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonOddSpillerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOddSpillerA.Location = new System.Drawing.Point(403, 0);
            this.buttonOddSpillerA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOddSpillerA.Name = "buttonOddSpillerA";
            this.buttonOddSpillerA.Size = new System.Drawing.Size(173, 92);
            this.buttonOddSpillerA.TabIndex = 0;
            this.buttonOddSpillerA.Text = "ODD/EVEN";
            this.buttonOddSpillerA.UseVisualStyleBackColor = false;
            this.buttonOddSpillerA.Click += new System.EventHandler(this.buttonOddSpillerA_Click);
            // 
            // buttonOddSpillerB
            // 
            this.buttonOddSpillerB.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonOddSpillerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOddSpillerB.Location = new System.Drawing.Point(771, 0);
            this.buttonOddSpillerB.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOddSpillerB.Name = "buttonOddSpillerB";
            this.buttonOddSpillerB.Size = new System.Drawing.Size(173, 92);
            this.buttonOddSpillerB.TabIndex = 1;
            this.buttonOddSpillerB.Text = "ODD/EVEN";
            this.buttonOddSpillerB.UseVisualStyleBackColor = false;
            this.buttonOddSpillerB.Click += new System.EventHandler(this.buttonOddSpillerB_Click);
            // 
            // buttonVinnSpillerA
            // 
            this.buttonVinnSpillerA.Enabled = false;
            this.buttonVinnSpillerA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVinnSpillerA.Location = new System.Drawing.Point(16, 68);
            this.buttonVinnSpillerA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVinnSpillerA.Name = "buttonVinnSpillerA";
            this.buttonVinnSpillerA.Size = new System.Drawing.Size(380, 203);
            this.buttonVinnSpillerA.TabIndex = 2;
            this.buttonVinnSpillerA.Text = "Vinn";
            this.buttonVinnSpillerA.UseVisualStyleBackColor = true;
            this.buttonVinnSpillerA.Click += new System.EventHandler(this.buttonVinnSpillerA_Click);
            // 
            // buttonVinnSpillerB
            // 
            this.buttonVinnSpillerB.Enabled = false;
            this.buttonVinnSpillerB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVinnSpillerB.Location = new System.Drawing.Point(952, 67);
            this.buttonVinnSpillerB.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVinnSpillerB.Name = "buttonVinnSpillerB";
            this.buttonVinnSpillerB.Size = new System.Drawing.Size(369, 203);
            this.buttonVinnSpillerB.TabIndex = 3;
            this.buttonVinnSpillerB.Text = "Vinn";
            this.buttonVinnSpillerB.UseVisualStyleBackColor = true;
            this.buttonVinnSpillerB.Click += new System.EventHandler(this.buttonVinnSpillerB_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPause.Enabled = false;
            this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPause.Location = new System.Drawing.Point(771, 619);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(179, 137);
            this.buttonPause.TabIndex = 5;
            this.buttonPause.Text = "Pause spill";
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // labelPoengSpillerA
            // 
            this.labelPoengSpillerA.AutoSize = true;
            this.labelPoengSpillerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoengSpillerA.Location = new System.Drawing.Point(67, 274);
            this.labelPoengSpillerA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPoengSpillerA.Name = "labelPoengSpillerA";
            this.labelPoengSpillerA.Size = new System.Drawing.Size(258, 283);
            this.labelPoengSpillerA.TabIndex = 6;
            this.labelPoengSpillerA.Text = "0";
            // 
            // labelPoengSpillerB
            // 
            this.labelPoengSpillerB.AutoSize = true;
            this.labelPoengSpillerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoengSpillerB.Location = new System.Drawing.Point(1011, 274);
            this.labelPoengSpillerB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPoengSpillerB.Name = "labelPoengSpillerB";
            this.labelPoengSpillerB.Size = new System.Drawing.Size(258, 283);
            this.labelPoengSpillerB.TabIndex = 7;
            this.labelPoengSpillerB.Text = "0";
            // 
            // labelKlokke
            // 
            this.labelKlokke.AutoSize = true;
            this.labelKlokke.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKlokke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelKlokke.Location = new System.Drawing.Point(83, 638);
            this.labelKlokke.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKlokke.Name = "labelKlokke";
            this.labelKlokke.Size = new System.Drawing.Size(300, 113);
            this.labelKlokke.TabIndex = 8;
            this.labelKlokke.Text = "00.00";
            // 
            // labelDato
            // 
            this.labelDato.AutoSize = true;
            this.labelDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDato.Location = new System.Drawing.Point(10, 580);
            this.labelDato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDato.Name = "labelDato";
            this.labelDato.Size = new System.Drawing.Size(395, 36);
            this.labelDato.TabIndex = 9;
            this.labelDato.Text = "Mandag  01. desember 2016";
            // 
            // timerSekund
            // 
            this.timerSekund.Enabled = true;
            this.timerSekund.Tick += new System.EventHandler(this.timerSekund_Tick);
            // 
            // comboBoxSpillerA
            // 
            this.comboBoxSpillerA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSpillerA.FormattingEnabled = true;
            this.comboBoxSpillerA.Location = new System.Drawing.Point(16, 1);
            this.comboBoxSpillerA.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSpillerA.Name = "comboBoxSpillerA";
            this.comboBoxSpillerA.Size = new System.Drawing.Size(380, 59);
            this.comboBoxSpillerA.TabIndex = 10;
            this.comboBoxSpillerA.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpillerA_SelectedIndexChanged);
            // 
            // comboBoxSpillerB
            // 
            this.comboBoxSpillerB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSpillerB.FormattingEnabled = true;
            this.comboBoxSpillerB.Location = new System.Drawing.Point(952, 0);
            this.comboBoxSpillerB.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSpillerB.Name = "comboBoxSpillerB";
            this.comboBoxSpillerB.Size = new System.Drawing.Size(369, 59);
            this.comboBoxSpillerB.TabIndex = 11;
            this.comboBoxSpillerB.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpillerB_SelectedIndexChanged);
            // 
            // labelCurrOmgTid
            // 
            this.labelCurrOmgTid.AutoSize = true;
            this.labelCurrOmgTid.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrOmgTid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCurrOmgTid.Location = new System.Drawing.Point(477, 96);
            this.labelCurrOmgTid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrOmgTid.Name = "labelCurrOmgTid";
            this.labelCurrOmgTid.Size = new System.Drawing.Size(368, 69);
            this.labelCurrOmgTid.TabIndex = 13;
            this.labelCurrOmgTid.Text = "0 min. 0 sek.";
            // 
            // buttonSlettSisteHendelse
            // 
            this.buttonSlettSisteHendelse.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSlettSisteHendelse.Enabled = false;
            this.buttonSlettSisteHendelse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSlettSisteHendelse.Location = new System.Drawing.Point(455, 575);
            this.buttonSlettSisteHendelse.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSlettSisteHendelse.Name = "buttonSlettSisteHendelse";
            this.buttonSlettSisteHendelse.Size = new System.Drawing.Size(451, 39);
            this.buttonSlettSisteHendelse.TabIndex = 14;
            this.buttonSlettSisteHendelse.Text = "Slett siste hendelse";
            this.buttonSlettSisteHendelse.UseVisualStyleBackColor = false;
            this.buttonSlettSisteHendelse.Click += new System.EventHandler(this.buttonSlettSisteHendelse_Click);
            // 
            // timer2Sekund
            // 
            this.timer2Sekund.Interval = 1000;
            this.timer2Sekund.Tick += new System.EventHandler(this.timer2Sekund_Tick);
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.AllowUserToAddRows = false;
            this.dataGridViewInfo.AllowUserToDeleteRows = false;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Spill,
            this.Hendelse,
            this.StartTid,
            this.OmgangsTid});
            this.dataGridViewInfo.Location = new System.Drawing.Point(404, 168);
            this.dataGridViewInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.ReadOnly = true;
            this.dataGridViewInfo.RowHeadersVisible = false;
            this.dataGridViewInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewInfo.ShowEditingIcon = false;
            this.dataGridViewInfo.Size = new System.Drawing.Size(540, 400);
            this.dataGridViewInfo.TabIndex = 15;
            // 
            // Spill
            // 
            this.Spill.HeaderText = "Spill #";
            this.Spill.Name = "Spill";
            this.Spill.ReadOnly = true;
            this.Spill.Width = 50;
            // 
            // Hendelse
            // 
            this.Hendelse.HeaderText = "Hendelse";
            this.Hendelse.Name = "Hendelse";
            this.Hendelse.ReadOnly = true;
            this.Hendelse.Width = 120;
            // 
            // StartTid
            // 
            this.StartTid.HeaderText = "Tid";
            this.StartTid.Name = "StartTid";
            this.StartTid.ReadOnly = true;
            this.StartTid.Width = 160;
            // 
            // OmgangsTid
            // 
            this.OmgangsTid.HeaderText = "Omgangs tid";
            this.OmgangsTid.Name = "OmgangsTid";
            this.OmgangsTid.ReadOnly = true;
            this.OmgangsTid.Width = 75;
            // 
            // buttonReStart
            // 
            this.buttonReStart.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonReStart.Enabled = false;
            this.buttonReStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReStart.Location = new System.Drawing.Point(584, 619);
            this.buttonReStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReStart.Name = "buttonReStart";
            this.buttonReStart.Size = new System.Drawing.Size(179, 137);
            this.buttonReStart.TabIndex = 16;
            this.buttonReStart.Text = "Restart spill";
            this.buttonReStart.UseVisualStyleBackColor = false;
            this.buttonReStart.Click += new System.EventHandler(this.buttonReStart_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(397, 619);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(179, 137);
            this.buttonStart.TabIndex = 17;
            this.buttonStart.Text = "Start spill";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelSpillerSomSprerHeading
            // 
            this.labelSpillerSomSprerHeading.AutoSize = true;
            this.labelSpillerSomSprerHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpillerSomSprerHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSpillerSomSprerHeading.Location = new System.Drawing.Point(1005, 544);
            this.labelSpillerSomSprerHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSpillerSomSprerHeading.Name = "labelSpillerSomSprerHeading";
            this.labelSpillerSomSprerHeading.Size = new System.Drawing.Size(305, 36);
            this.labelSpillerSomSprerHeading.TabIndex = 18;
            this.labelSpillerSomSprerHeading.Text = "Spiller som skal spre :";
            // 
            // labelSpillerSomSprer
            // 
            this.labelSpillerSomSprer.AutoSize = true;
            this.labelSpillerSomSprer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpillerSomSprer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSpillerSomSprer.Location = new System.Drawing.Point(1016, 580);
            this.labelSpillerSomSprer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSpillerSomSprer.Name = "labelSpillerSomSprer";
            this.labelSpillerSomSprer.Size = new System.Drawing.Size(272, 36);
            this.labelSpillerSomSprer.TabIndex = 19;
            this.labelSpillerSomSprer.Text = "Sett odd/even først.";
            // 
            // labelSnittOmgTidHeading
            // 
            this.labelSnittOmgTidHeading.AutoSize = true;
            this.labelSnittOmgTidHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSnittOmgTidHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSnittOmgTidHeading.Location = new System.Drawing.Point(584, 10);
            this.labelSnittOmgTidHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSnittOmgTidHeading.Name = "labelSnittOmgTidHeading";
            this.labelSnittOmgTidHeading.Size = new System.Drawing.Size(173, 31);
            this.labelSnittOmgTidHeading.TabIndex = 20;
            this.labelSnittOmgTidHeading.Text = "Snitt omg.tid:";
            // 
            // labelSnittOmgTid
            // 
            this.labelSnittOmgTid.AutoSize = true;
            this.labelSnittOmgTid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSnittOmgTid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSnittOmgTid.Location = new System.Drawing.Point(585, 53);
            this.labelSnittOmgTid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSnittOmgTid.Name = "labelSnittOmgTid";
            this.labelSnittOmgTid.Size = new System.Drawing.Size(126, 25);
            this.labelSnittOmgTid.TabIndex = 21;
            this.labelSnittOmgTid.Text = "0 min. 0 sek. ";
            // 
            // labelSpillNr
            // 
            this.labelSpillNr.AutoSize = true;
            this.labelSpillNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpillNr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSpillNr.Location = new System.Drawing.Point(1138, 638);
            this.labelSpillNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSpillNr.Name = "labelSpillNr";
            this.labelSpillNr.Size = new System.Drawing.Size(104, 113);
            this.labelSpillNr.TabIndex = 22;
            this.labelSpillNr.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(1016, 668);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 36);
            this.label3.TabIndex = 23;
            this.label3.Text = "Spill # :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(10, 638);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tid:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1338, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSpillNr);
            this.Controls.Add(this.labelSnittOmgTid);
            this.Controls.Add(this.labelSnittOmgTidHeading);
            this.Controls.Add(this.labelSpillerSomSprer);
            this.Controls.Add(this.labelSpillerSomSprerHeading);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonReStart);
            this.Controls.Add(this.dataGridViewInfo);
            this.Controls.Add(this.buttonSlettSisteHendelse);
            this.Controls.Add(this.labelCurrOmgTid);
            this.Controls.Add(this.comboBoxSpillerB);
            this.Controls.Add(this.comboBoxSpillerA);
            this.Controls.Add(this.labelDato);
            this.Controls.Add(this.labelKlokke);
            this.Controls.Add(this.labelPoengSpillerB);
            this.Controls.Add(this.labelPoengSpillerA);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonVinnSpillerB);
            this.Controls.Add(this.buttonVinnSpillerA);
            this.Controls.Add(this.buttonOddSpillerB);
            this.Controls.Add(this.buttonOddSpillerA);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Biljard poeng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOddSpillerA;
        private System.Windows.Forms.Button buttonOddSpillerB;
        private System.Windows.Forms.Button buttonVinnSpillerA;
        private System.Windows.Forms.Button buttonVinnSpillerB;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Label labelPoengSpillerA;
        private System.Windows.Forms.Label labelPoengSpillerB;
        private System.Windows.Forms.Label labelKlokke;
        private System.Windows.Forms.Label labelDato;
        private System.Windows.Forms.Timer timerSekund;
        private System.Windows.Forms.ComboBox comboBoxSpillerA;
        private System.Windows.Forms.ComboBox comboBoxSpillerB;
        private System.Windows.Forms.Label labelCurrOmgTid;
        private System.Windows.Forms.Button buttonSlettSisteHendelse;
        private System.Windows.Forms.Timer timer2Sekund;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hendelse;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTid;
        private System.Windows.Forms.DataGridViewTextBoxColumn OmgangsTid;
        private System.Windows.Forms.Button buttonReStart;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelSpillerSomSprerHeading;
        private System.Windows.Forms.Label labelSpillerSomSprer;
        private System.Windows.Forms.Label labelSnittOmgTidHeading;
        private System.Windows.Forms.Label labelSnittOmgTid;
        private System.Windows.Forms.Label labelSpillNr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

