namespace DiceForms
{
    partial class DiceRollForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupDiceAsk = new System.Windows.Forms.GroupBox();
            this.lblTick = new System.Windows.Forms.Label();
            this.cmbBxTick = new System.Windows.Forms.ComboBox();
            this.cmbBxTimeIntervals = new System.Windows.Forms.ComboBox();
            this.cmbBxNOfRolls = new System.Windows.Forms.ComboBox();
            this.lblPS = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkBxTimeIntervals = new System.Windows.Forms.CheckBox();
            this.chkBxNOfRolls = new System.Windows.Forms.CheckBox();
            this.groupDiceForm = new System.Windows.Forms.GroupBox();
            this.chrtFreqDist = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnFreqDist = new System.Windows.Forms.Button();
            this.lblDiceThrows = new System.Windows.Forms.Label();
            this.txtDiceRolls = new System.Windows.Forms.TextBox();
            this.timerDice = new System.Windows.Forms.Timer(this.components);
            this.groupDiceAsk.SuspendLayout();
            this.groupDiceForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFreqDist)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDiceAsk
            // 
            this.groupDiceAsk.Controls.Add(this.lblTick);
            this.groupDiceAsk.Controls.Add(this.cmbBxTick);
            this.groupDiceAsk.Controls.Add(this.cmbBxTimeIntervals);
            this.groupDiceAsk.Controls.Add(this.cmbBxNOfRolls);
            this.groupDiceAsk.Controls.Add(this.lblPS);
            this.groupDiceAsk.Controls.Add(this.lblTitle);
            this.groupDiceAsk.Controls.Add(this.chkBxTimeIntervals);
            this.groupDiceAsk.Controls.Add(this.chkBxNOfRolls);
            this.groupDiceAsk.Location = new System.Drawing.Point(12, 11);
            this.groupDiceAsk.Name = "groupDiceAsk";
            this.groupDiceAsk.Size = new System.Drawing.Size(883, 232);
            this.groupDiceAsk.TabIndex = 11;
            this.groupDiceAsk.TabStop = false;
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
            // groupDiceForm
            // 
            this.groupDiceForm.Controls.Add(this.chrtFreqDist);
            this.groupDiceForm.Controls.Add(this.btnStop);
            this.groupDiceForm.Controls.Add(this.btnFreqDist);
            this.groupDiceForm.Controls.Add(this.lblDiceThrows);
            this.groupDiceForm.Controls.Add(this.txtDiceRolls);
            this.groupDiceForm.Location = new System.Drawing.Point(12, 275);
            this.groupDiceForm.Name = "groupDiceForm";
            this.groupDiceForm.Size = new System.Drawing.Size(883, 305);
            this.groupDiceForm.TabIndex = 10;
            this.groupDiceForm.TabStop = false;
            // 
            // chrtFreqDist
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtFreqDist.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtFreqDist.Legends.Add(legend1);
            this.chrtFreqDist.Location = new System.Drawing.Point(380, 22);
            this.chrtFreqDist.Name = "chrtFreqDist";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Dice-Sum Occurence";
            this.chrtFreqDist.Series.Add(series1);
            this.chrtFreqDist.Size = new System.Drawing.Size(483, 265);
            this.chrtFreqDist.TabIndex = 9;
            title1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "titleDiceRoll";
            title1.Text = "Dice-Roll Frequency Distribution";
            this.chrtFreqDist.Titles.Add(title1);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(138, 84);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(114, 35);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnFreqDist
            // 
            this.btnFreqDist.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreqDist.Location = new System.Drawing.Point(57, 84);
            this.btnFreqDist.Name = "btnFreqDist";
            this.btnFreqDist.Size = new System.Drawing.Size(275, 35);
            this.btnFreqDist.TabIndex = 3;
            this.btnFreqDist.Text = "Generate Frequency Distribution";
            this.btnFreqDist.UseVisualStyleBackColor = true;
            this.btnFreqDist.Click += new System.EventHandler(this.btnFreqDist_Click);
            // 
            // lblDiceThrows
            // 
            this.lblDiceThrows.AutoSize = true;
            this.lblDiceThrows.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiceThrows.Location = new System.Drawing.Point(34, 40);
            this.lblDiceThrows.Name = "lblDiceThrows";
            this.lblDiceThrows.Size = new System.Drawing.Size(177, 19);
            this.lblDiceThrows.TabIndex = 0;
            this.lblDiceThrows.Text = "Enter # of Dice Throws";
            // 
            // txtDiceRolls
            // 
            this.txtDiceRolls.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiceRolls.Location = new System.Drawing.Point(251, 37);
            this.txtDiceRolls.Name = "txtDiceRolls";
            this.txtDiceRolls.Size = new System.Drawing.Size(100, 27);
            this.txtDiceRolls.TabIndex = 1;
            // 
            // timerDice
            // 
            this.timerDice.Interval = 1000;
            this.timerDice.Tick += new System.EventHandler(this.timerDice_Tick);
            // 
            // DiceRollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 599);
            this.Controls.Add(this.groupDiceAsk);
            this.Controls.Add(this.groupDiceForm);
            this.Name = "DiceRollForm";
            this.Text = "Dice Roll Form";
            this.groupDiceAsk.ResumeLayout(false);
            this.groupDiceAsk.PerformLayout();
            this.groupDiceForm.ResumeLayout(false);
            this.groupDiceForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFreqDist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDiceThrows;
        private System.Windows.Forms.TextBox txtDiceRolls;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtFreqDist;
        private System.Windows.Forms.Button btnFreqDist;
        private System.Windows.Forms.GroupBox groupDiceForm;
        private System.Windows.Forms.GroupBox groupDiceAsk;
        private System.Windows.Forms.Label lblTick;
        private System.Windows.Forms.ComboBox cmbBxTick;
        private System.Windows.Forms.ComboBox cmbBxTimeIntervals;
        private System.Windows.Forms.ComboBox cmbBxNOfRolls;
        private System.Windows.Forms.Label lblPS;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkBxTimeIntervals;
        private System.Windows.Forms.CheckBox chkBxNOfRolls;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timerDice;
    }
}

