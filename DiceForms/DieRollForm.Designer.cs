namespace DiceForms
{
    partial class DieRollForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupDieAsk = new System.Windows.Forms.GroupBox();
            this.lblTick = new System.Windows.Forms.Label();
            this.cmbBxTick = new System.Windows.Forms.ComboBox();
            this.cmbBxTimeIntervals = new System.Windows.Forms.ComboBox();
            this.cmbBxNOfRolls = new System.Windows.Forms.ComboBox();
            this.lblPS = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkBxTimeIntervals = new System.Windows.Forms.CheckBox();
            this.chkBxNOfRolls = new System.Windows.Forms.CheckBox();
            this.groupDieForm = new System.Windows.Forms.GroupBox();
            this.chrtFreqDist = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStop = new System.Windows.Forms.Button();
            this.roll2DieBtn = new System.Windows.Forms.Button();
            this.btnFreqDist = new System.Windows.Forms.Button();
            this.txtDieRolls = new System.Windows.Forms.TextBox();
            this.lblDieRolls = new System.Windows.Forms.Label();
            this.lblSeedNum = new System.Windows.Forms.Label();
            this.txtSeedNum = new System.Windows.Forms.TextBox();
            this.timerDie = new System.Windows.Forms.Timer(this.components);
            this.groupDieAsk.SuspendLayout();
            this.groupDieForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFreqDist)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDieAsk
            // 
            this.groupDieAsk.Controls.Add(this.lblTick);
            this.groupDieAsk.Controls.Add(this.cmbBxTick);
            this.groupDieAsk.Controls.Add(this.cmbBxTimeIntervals);
            this.groupDieAsk.Controls.Add(this.cmbBxNOfRolls);
            this.groupDieAsk.Controls.Add(this.lblPS);
            this.groupDieAsk.Controls.Add(this.lblTitle);
            this.groupDieAsk.Controls.Add(this.chkBxTimeIntervals);
            this.groupDieAsk.Controls.Add(this.chkBxNOfRolls);
            this.groupDieAsk.Location = new System.Drawing.Point(12, 12);
            this.groupDieAsk.Name = "groupDieAsk";
            this.groupDieAsk.Size = new System.Drawing.Size(883, 232);
            this.groupDieAsk.TabIndex = 10;
            this.groupDieAsk.TabStop = false;
            // 
            // lblTick
            // 
            this.lblTick.AutoSize = true;
            this.lblTick.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTick.Location = new System.Drawing.Point(151, 176);
            this.lblTick.Name = "lblTick";
            this.lblTick.Size = new System.Drawing.Size(347, 19);
            this.lblTick.TabIndex = 25;
            this.lblTick.Text = "When would you like each Tick to occur? (ms)\r\n";
            // 
            // cmbBxTick
            // 
            this.cmbBxTick.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBxTick.FormattingEnabled = true;
            this.cmbBxTick.Items.AddRange(new object[] {
            "1",
            "10",
            "100",
            "1000",
            "10000"});
            this.cmbBxTick.Location = new System.Drawing.Point(600, 173);
            this.cmbBxTick.Name = "cmbBxTick";
            this.cmbBxTick.Size = new System.Drawing.Size(121, 27);
            this.cmbBxTick.TabIndex = 24;
            // 
            // cmbBxTimeIntervals
            // 
            this.cmbBxTimeIntervals.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBxTimeIntervals.FormattingEnabled = true;
            this.cmbBxTimeIntervals.Items.AddRange(new object[] {
            "1",
            "10",
            "100",
            "1000",
            "10000",
            "100000"});
            this.cmbBxTimeIntervals.Location = new System.Drawing.Point(600, 131);
            this.cmbBxTimeIntervals.Name = "cmbBxTimeIntervals";
            this.cmbBxTimeIntervals.Size = new System.Drawing.Size(121, 27);
            this.cmbBxTimeIntervals.TabIndex = 23;
            this.cmbBxTimeIntervals.Visible = false;
            // 
            // cmbBxNOfRolls
            // 
            this.cmbBxNOfRolls.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBxNOfRolls.FormattingEnabled = true;
            this.cmbBxNOfRolls.Items.AddRange(new object[] {
            "1",
            "10",
            "100",
            "1000",
            "10000"});
            this.cmbBxNOfRolls.Location = new System.Drawing.Point(600, 102);
            this.cmbBxNOfRolls.Name = "cmbBxNOfRolls";
            this.cmbBxNOfRolls.Size = new System.Drawing.Size(121, 27);
            this.cmbBxNOfRolls.TabIndex = 22;
            this.cmbBxNOfRolls.Visible = false;
            // 
            // lblPS
            // 
            this.lblPS.AutoSize = true;
            this.lblPS.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPS.Location = new System.Drawing.Point(308, 59);
            this.lblPS.Name = "lblPS";
            this.lblPS.Size = new System.Drawing.Size(233, 19);
            this.lblPS.TabIndex = 21;
            this.lblPS.Text = "(You must choose one or both)\r\n";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(120, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(630, 33);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "How would you like to Update the Histogram?";
            // 
            // chkBxTimeIntervals
            // 
            this.chkBxTimeIntervals.AutoSize = true;
            this.chkBxTimeIntervals.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxTimeIntervals.Location = new System.Drawing.Point(129, 133);
            this.chkBxTimeIntervals.Name = "chkBxTimeIntervals";
            this.chkBxTimeIntervals.Size = new System.Drawing.Size(362, 23);
            this.chkBxTimeIntervals.TabIndex = 18;
            this.chkBxTimeIntervals.Text = "Update Histogram through Time Intervals (ms)";
            this.chkBxTimeIntervals.UseVisualStyleBackColor = true;
            this.chkBxTimeIntervals.CheckedChanged += new System.EventHandler(this.chkBxTimeIntervals_CheckedChanged);
            // 
            // chkBxNOfRolls
            // 
            this.chkBxNOfRolls.AutoSize = true;
            this.chkBxNOfRolls.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxNOfRolls.Location = new System.Drawing.Point(129, 104);
            this.chkBxNOfRolls.Name = "chkBxNOfRolls";
            this.chkBxNOfRolls.Size = new System.Drawing.Size(292, 23);
            this.chkBxNOfRolls.TabIndex = 17;
            this.chkBxNOfRolls.Text = "Update Histogram through # of Rolls";
            this.chkBxNOfRolls.UseVisualStyleBackColor = true;
            this.chkBxNOfRolls.CheckedChanged += new System.EventHandler(this.chkBxNOfRolls_CheckedChanged);
            // 
            // groupDieForm
            // 
            this.groupDieForm.Controls.Add(this.chrtFreqDist);
            this.groupDieForm.Controls.Add(this.btnStop);
            this.groupDieForm.Controls.Add(this.roll2DieBtn);
            this.groupDieForm.Controls.Add(this.btnFreqDist);
            this.groupDieForm.Controls.Add(this.txtDieRolls);
            this.groupDieForm.Controls.Add(this.lblDieRolls);
            this.groupDieForm.Controls.Add(this.lblSeedNum);
            this.groupDieForm.Controls.Add(this.txtSeedNum);
            this.groupDieForm.Location = new System.Drawing.Point(12, 250);
            this.groupDieForm.Name = "groupDieForm";
            this.groupDieForm.Size = new System.Drawing.Size(883, 315);
            this.groupDieForm.TabIndex = 9;
            this.groupDieForm.TabStop = false;
            // 
            // chrtFreqDist
            // 
            chartArea2.Name = "ChartArea1";
            this.chrtFreqDist.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtFreqDist.Legends.Add(legend2);
            this.chrtFreqDist.Location = new System.Drawing.Point(439, 21);
            this.chrtFreqDist.Name = "chrtFreqDist";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Die-Face Occurence";
            this.chrtFreqDist.Series.Add(series2);
            this.chrtFreqDist.Size = new System.Drawing.Size(422, 278);
            this.chrtFreqDist.TabIndex = 8;
            title2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "titleDieRoll";
            title2.Text = "Die-Roll Frequency Distribution";
            this.chrtFreqDist.Titles.Add(title2);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(155, 90);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(114, 33);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // roll2DieBtn
            // 
            this.roll2DieBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roll2DieBtn.Location = new System.Drawing.Point(129, 269);
            this.roll2DieBtn.Name = "roll2DieBtn";
            this.roll2DieBtn.Size = new System.Drawing.Size(163, 30);
            this.roll2DieBtn.TabIndex = 6;
            this.roll2DieBtn.Text = "Roll Dice Form";
            this.roll2DieBtn.UseVisualStyleBackColor = true;
            this.roll2DieBtn.Click += new System.EventHandler(this.roll2DieBtn_Click);
            // 
            // btnFreqDist
            // 
            this.btnFreqDist.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreqDist.Location = new System.Drawing.Point(55, 90);
            this.btnFreqDist.Name = "btnFreqDist";
            this.btnFreqDist.Size = new System.Drawing.Size(310, 33);
            this.btnFreqDist.TabIndex = 4;
            this.btnFreqDist.Text = "Generate Frequency Distribution";
            this.btnFreqDist.UseVisualStyleBackColor = true;
            this.btnFreqDist.Click += new System.EventHandler(this.btnFreqDist_Click);
            // 
            // txtDieRolls
            // 
            this.txtDieRolls.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDieRolls.Location = new System.Drawing.Point(264, 21);
            this.txtDieRolls.Name = "txtDieRolls";
            this.txtDieRolls.Size = new System.Drawing.Size(124, 27);
            this.txtDieRolls.TabIndex = 2;
            // 
            // lblDieRolls
            // 
            this.lblDieRolls.AutoSize = true;
            this.lblDieRolls.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDieRolls.Location = new System.Drawing.Point(29, 24);
            this.lblDieRolls.Name = "lblDieRolls";
            this.lblDieRolls.Size = new System.Drawing.Size(150, 19);
            this.lblDieRolls.TabIndex = 0;
            this.lblDieRolls.Text = "Enter # of Die Rolls";
            // 
            // lblSeedNum
            // 
            this.lblSeedNum.AutoSize = true;
            this.lblSeedNum.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeedNum.Location = new System.Drawing.Point(29, 56);
            this.lblSeedNum.Name = "lblSeedNum";
            this.lblSeedNum.Size = new System.Drawing.Size(195, 19);
            this.lblSeedNum.TabIndex = 1;
            this.lblSeedNum.Text = "Enter a Seed # (Optional)";
            // 
            // txtSeedNum
            // 
            this.txtSeedNum.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeedNum.Location = new System.Drawing.Point(264, 48);
            this.txtSeedNum.Name = "txtSeedNum";
            this.txtSeedNum.Size = new System.Drawing.Size(124, 27);
            this.txtSeedNum.TabIndex = 3;
            // 
            // timerDie
            // 
            this.timerDie.Interval = 1000;
            this.timerDie.Tick += new System.EventHandler(this.timerDie_Tick);
            // 
            // DieRollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 580);
            this.Controls.Add(this.groupDieAsk);
            this.Controls.Add(this.groupDieForm);
            this.Name = "DieRollForm";
            this.Text = "Die Roll Form";
            this.groupDieAsk.ResumeLayout(false);
            this.groupDieAsk.PerformLayout();
            this.groupDieForm.ResumeLayout(false);
            this.groupDieForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFreqDist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDieRolls;
        private System.Windows.Forms.Label lblSeedNum;
        private System.Windows.Forms.TextBox txtDieRolls;
        private System.Windows.Forms.TextBox txtSeedNum;
        private System.Windows.Forms.Button btnFreqDist;
        private System.Windows.Forms.Button roll2DieBtn;
        private System.Windows.Forms.GroupBox groupDieForm;
        private System.Windows.Forms.GroupBox groupDieAsk;
        private System.Windows.Forms.ComboBox cmbBxTimeIntervals;
        private System.Windows.Forms.ComboBox cmbBxNOfRolls;
        private System.Windows.Forms.Label lblPS;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkBxTimeIntervals;
        private System.Windows.Forms.CheckBox chkBxNOfRolls;
        private System.Windows.Forms.Label lblTick;
        private System.Windows.Forms.ComboBox cmbBxTick;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtFreqDist;
        private System.Windows.Forms.Timer timerDie;
    }
}