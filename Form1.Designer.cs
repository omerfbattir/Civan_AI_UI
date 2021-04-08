
namespace Civan_AI_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cigsPerDayCheck = new System.Windows.Forms.CheckBox();
            this.hyp = new System.Windows.Forms.CheckBox();
            this.diabetes = new System.Windows.Forms.CheckBox();
            this.name = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.agePanel = new System.Windows.Forms.NumericUpDown();
            this.cigsPerDay = new System.Windows.Forms.NumericUpDown();
            this.BPMeds = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totChol = new System.Windows.Forms.NumericUpDown();
            this.send = new System.Windows.Forms.Button();
            this.diaBP = new System.Windows.Forms.NumericUpDown();
            this.sysBP = new System.Windows.Forms.NumericUpDown();
            this.glucose = new System.Windows.Forms.NumericUpDown();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.imagePathTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cigsPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totChol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaBP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysBP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glucose)).BeginInit();
            this.SuspendLayout();
            // 
            // cigsPerDayCheck
            // 
            this.cigsPerDayCheck.AutoSize = true;
            this.cigsPerDayCheck.Location = new System.Drawing.Point(12, 101);
            this.cigsPerDayCheck.Name = "cigsPerDayCheck";
            this.cigsPerDayCheck.Size = new System.Drawing.Size(122, 19);
            this.cigsPerDayCheck.TabIndex = 0;
            this.cigsPerDayCheck.Text = "Cigarattes Per Day";
            this.cigsPerDayCheck.UseVisualStyleBackColor = true;
            this.cigsPerDayCheck.CheckedChanged += new System.EventHandler(this.cigsPerDayCheck_CheckedChanged);
            // 
            // hyp
            // 
            this.hyp.AutoSize = true;
            this.hyp.Location = new System.Drawing.Point(12, 126);
            this.hyp.Name = "hyp";
            this.hyp.Size = new System.Drawing.Size(152, 19);
            this.hyp.TabIndex = 1;
            this.hyp.Text = "Prevalent Hypertension ";
            this.hyp.UseVisualStyleBackColor = true;
            // 
            // diabetes
            // 
            this.diabetes.AutoSize = true;
            this.diabetes.Location = new System.Drawing.Point(12, 151);
            this.diabetes.Name = "diabetes";
            this.diabetes.Size = new System.Drawing.Size(71, 19);
            this.diabetes.TabIndex = 2;
            this.diabetes.Text = "Diabetes";
            this.diabetes.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(80, 16);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 23);
            this.name.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // genderBox
            // 
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Location = new System.Drawing.Point(80, 42);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(121, 23);
            this.genderBox.TabIndex = 5;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(12, 45);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(45, 15);
            this.GenderLabel.TabIndex = 6;
            this.GenderLabel.Text = "Gender";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(12, 70);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(28, 15);
            this.AgeLabel.TabIndex = 7;
            this.AgeLabel.Text = "Age";
            // 
            // agePanel
            // 
            this.agePanel.Location = new System.Drawing.Point(80, 68);
            this.agePanel.Name = "agePanel";
            this.agePanel.Size = new System.Drawing.Size(43, 23);
            this.agePanel.TabIndex = 8;
            // 
            // cigsPerDay
            // 
            this.cigsPerDay.Enabled = false;
            this.cigsPerDay.Location = new System.Drawing.Point(136, 97);
            this.cigsPerDay.Name = "cigsPerDay";
            this.cigsPerDay.Size = new System.Drawing.Size(41, 23);
            this.cigsPerDay.TabIndex = 9;
            // 
            // BPMeds
            // 
            this.BPMeds.AutoSize = true;
            this.BPMeds.Location = new System.Drawing.Point(12, 177);
            this.BPMeds.Name = "BPMeds";
            this.BPMeds.Size = new System.Drawing.Size(167, 19);
            this.BPMeds.TabIndex = 10;
            this.BPMeds.Text = "Blood Pressure Medication";
            this.BPMeds.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total Cholestrol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Systolic BP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Diastolic BP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Glucose";
            // 
            // totChol
            // 
            this.totChol.DecimalPlaces = 2;
            this.totChol.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.totChol.Location = new System.Drawing.Point(107, 201);
            this.totChol.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.totChol.Name = "totChol";
            this.totChol.Size = new System.Drawing.Size(44, 23);
            this.totChol.TabIndex = 15;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(309, 365);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 28);
            this.send.TabIndex = 16;
            this.send.Text = "Send ";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.button1_Click);
            // 
            // diaBP
            // 
            this.diaBP.DecimalPlaces = 2;
            this.diaBP.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.diaBP.Location = new System.Drawing.Point(90, 258);
            this.diaBP.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.diaBP.Name = "diaBP";
            this.diaBP.Size = new System.Drawing.Size(44, 23);
            this.diaBP.TabIndex = 17;
            // 
            // sysBP
            // 
            this.sysBP.DecimalPlaces = 2;
            this.sysBP.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.sysBP.Location = new System.Drawing.Point(92, 229);
            this.sysBP.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.sysBP.Name = "sysBP";
            this.sysBP.Size = new System.Drawing.Size(44, 23);
            this.sysBP.TabIndex = 18;
            // 
            // glucose
            // 
            this.glucose.DecimalPlaces = 2;
            this.glucose.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.glucose.Location = new System.Drawing.Point(70, 287);
            this.glucose.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.glucose.Name = "glucose";
            this.glucose.Size = new System.Drawing.Size(44, 23);
            this.glucose.TabIndex = 19;
            // 
            // imagePathTB
            // 
            this.imagePathTB.Location = new System.Drawing.Point(60, 316);
            this.imagePathTB.Name = "imagePathTB";
            this.imagePathTB.Size = new System.Drawing.Size(275, 23);
            this.imagePathTB.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Bul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imagePathTB);
            this.Controls.Add(this.glucose);
            this.Controls.Add(this.sysBP);
            this.Controls.Add(this.diaBP);
            this.Controls.Add(this.send);
            this.Controls.Add(this.totChol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BPMeds);
            this.Controls.Add(this.cigsPerDay);
            this.Controls.Add(this.agePanel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.diabetes);
            this.Controls.Add(this.hyp);
            this.Controls.Add(this.cigsPerDayCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cigsPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totChol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaBP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysBP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glucose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cigsPerDayCheck;
        private System.Windows.Forms.CheckBox hyp;
        private System.Windows.Forms.CheckBox diabetes;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.NumericUpDown agePanel;
        private System.Windows.Forms.NumericUpDown cigsPerDay;
        private System.Windows.Forms.CheckBox BPMeds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown totChol;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.NumericUpDown diaBP;
        private System.Windows.Forms.NumericUpDown sysBP;
        private System.Windows.Forms.NumericUpDown glucose;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox imagePathTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

