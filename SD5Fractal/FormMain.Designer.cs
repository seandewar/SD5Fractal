namespace SD5Fractal
{
    partial class FormMain
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
            this.pictureBoxView = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxImY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxImX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCImE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCReE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCIm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCRe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownMaxIt = new System.Windows.Forms.NumericUpDown();
            this.labelMaxIt = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.checkBoxR = new System.Windows.Forms.CheckBox();
            this.checkBoxG = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.checkBoxColourSet = new System.Windows.Forms.CheckBox();
            this.radioButtonMandelbrotZSq = new System.Windows.Forms.RadioButton();
            this.radioButtonMandelbrotZCu = new System.Windows.Forms.RadioButton();
            this.labelStats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxIt)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxView
            // 
            this.pictureBoxView.BackColor = System.Drawing.Color.Black;
            this.pictureBoxView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxView.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxView.Name = "pictureBoxView";
            this.pictureBoxView.Size = new System.Drawing.Size(1024, 608);
            this.pictureBoxView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxView.TabIndex = 0;
            this.pictureBoxView.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelStats);
            this.panel1.Controls.Add(this.radioButtonMandelbrotZCu);
            this.panel1.Controls.Add(this.radioButtonMandelbrotZSq);
            this.panel1.Controls.Add(this.checkBoxColourSet);
            this.panel1.Controls.Add(this.checkBoxB);
            this.panel1.Controls.Add(this.checkBoxG);
            this.panel1.Controls.Add(this.checkBoxR);
            this.panel1.Controls.Add(this.buttonSaveAs);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxImY);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxImX);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxCImE);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxCReE);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxCIm);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxCRe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDownMaxIt);
            this.panel1.Controls.Add(this.labelMaxIt);
            this.panel1.Controls.Add(this.buttonGenerate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 608);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 112);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::SD5Fractal.Properties.Resources.sd5modern;
            this.pictureBox1.Location = new System.Drawing.Point(912, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxImY
            // 
            this.textBoxImY.Location = new System.Drawing.Point(318, 8);
            this.textBoxImY.Name = "textBoxImY";
            this.textBoxImY.Size = new System.Drawing.Size(100, 20);
            this.textBoxImY.TabIndex = 16;
            this.textBoxImY.Text = "720";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Render resolution: ";
            // 
            // textBoxImX
            // 
            this.textBoxImX.Location = new System.Drawing.Point(194, 8);
            this.textBoxImX.Name = "textBoxImX";
            this.textBoxImX.Size = new System.Drawing.Size(100, 20);
            this.textBoxImX.TabIndex = 13;
            this.textBoxImX.Text = "1024";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(9, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "i";
            // 
            // textBoxCImE
            // 
            this.textBoxCImE.Location = new System.Drawing.Point(194, 62);
            this.textBoxCImE.Name = "textBoxCImE";
            this.textBoxCImE.Size = new System.Drawing.Size(100, 20);
            this.textBoxCImE.TabIndex = 11;
            this.textBoxCImE.Text = "1.5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "+";
            // 
            // textBoxCReE
            // 
            this.textBoxCReE.Location = new System.Drawing.Point(68, 62);
            this.textBoxCReE.Name = "textBoxCReE";
            this.textBoxCReE.Size = new System.Drawing.Size(100, 20);
            this.textBoxCReE.TabIndex = 9;
            this.textBoxCReE.Text = "1.5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "End c = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "i";
            // 
            // textBoxCIm
            // 
            this.textBoxCIm.Location = new System.Drawing.Point(194, 36);
            this.textBoxCIm.Name = "textBoxCIm";
            this.textBoxCIm.Size = new System.Drawing.Size(100, 20);
            this.textBoxCIm.TabIndex = 6;
            this.textBoxCIm.Text = "-1.5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "+";
            // 
            // textBoxCRe
            // 
            this.textBoxCRe.Location = new System.Drawing.Point(68, 36);
            this.textBoxCRe.Name = "textBoxCRe";
            this.textBoxCRe.Size = new System.Drawing.Size(100, 20);
            this.textBoxCRe.TabIndex = 4;
            this.textBoxCRe.Text = "-2.5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start c = ";
            // 
            // numericUpDownMaxIt
            // 
            this.numericUpDownMaxIt.Location = new System.Drawing.Point(96, 86);
            this.numericUpDownMaxIt.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numericUpDownMaxIt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxIt.Name = "numericUpDownMaxIt";
            this.numericUpDownMaxIt.Size = new System.Drawing.Size(198, 20);
            this.numericUpDownMaxIt.TabIndex = 2;
            this.numericUpDownMaxIt.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // labelMaxIt
            // 
            this.labelMaxIt.AutoSize = true;
            this.labelMaxIt.Location = new System.Drawing.Point(12, 88);
            this.labelMaxIt.Name = "labelMaxIt";
            this.labelMaxIt.Size = new System.Drawing.Size(78, 13);
            this.labelMaxIt.TabIndex = 1;
            this.labelMaxIt.Text = "Max iterations: ";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 6);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Location = new System.Drawing.Point(424, 6);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveAs.TabIndex = 18;
            this.buttonSaveAs.Text = "Save As...";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // checkBoxR
            // 
            this.checkBoxR.AutoSize = true;
            this.checkBoxR.Checked = true;
            this.checkBoxR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxR.Location = new System.Drawing.Point(318, 39);
            this.checkBoxR.Name = "checkBoxR";
            this.checkBoxR.Size = new System.Drawing.Size(46, 17);
            this.checkBoxR.TabIndex = 19;
            this.checkBoxR.Text = "Red";
            this.checkBoxR.UseVisualStyleBackColor = true;
            // 
            // checkBoxG
            // 
            this.checkBoxG.AutoSize = true;
            this.checkBoxG.Checked = true;
            this.checkBoxG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxG.Location = new System.Drawing.Point(318, 60);
            this.checkBoxG.Name = "checkBoxG";
            this.checkBoxG.Size = new System.Drawing.Size(55, 17);
            this.checkBoxG.TabIndex = 20;
            this.checkBoxG.Text = "Green";
            this.checkBoxG.UseVisualStyleBackColor = true;
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Checked = true;
            this.checkBoxB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxB.Location = new System.Drawing.Point(318, 82);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(47, 17);
            this.checkBoxB.TabIndex = 21;
            this.checkBoxB.Text = "Blue";
            this.checkBoxB.UseVisualStyleBackColor = true;
            // 
            // checkBoxColourSet
            // 
            this.checkBoxColourSet.AutoSize = true;
            this.checkBoxColourSet.Checked = true;
            this.checkBoxColourSet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxColourSet.Location = new System.Drawing.Point(381, 82);
            this.checkBoxColourSet.Name = "checkBoxColourSet";
            this.checkBoxColourSet.Size = new System.Drawing.Size(208, 17);
            this.checkBoxColourSet.TabIndex = 22;
            this.checkBoxColourSet.Text = "Colour points within the Mandelbrot set";
            this.checkBoxColourSet.UseVisualStyleBackColor = true;
            // 
            // radioButtonMandelbrotZSq
            // 
            this.radioButtonMandelbrotZSq.AutoSize = true;
            this.radioButtonMandelbrotZSq.Checked = true;
            this.radioButtonMandelbrotZSq.Location = new System.Drawing.Point(381, 36);
            this.radioButtonMandelbrotZSq.Name = "radioButtonMandelbrotZSq";
            this.radioButtonMandelbrotZSq.Size = new System.Drawing.Size(98, 17);
            this.radioButtonMandelbrotZSq.TabIndex = 23;
            this.radioButtonMandelbrotZSq.TabStop = true;
            this.radioButtonMandelbrotZSq.Text = "Mandelbrot z^2";
            this.radioButtonMandelbrotZSq.UseVisualStyleBackColor = true;
            // 
            // radioButtonMandelbrotZCu
            // 
            this.radioButtonMandelbrotZCu.AutoSize = true;
            this.radioButtonMandelbrotZCu.Location = new System.Drawing.Point(381, 58);
            this.radioButtonMandelbrotZCu.Name = "radioButtonMandelbrotZCu";
            this.radioButtonMandelbrotZCu.Size = new System.Drawing.Size(98, 17);
            this.radioButtonMandelbrotZCu.TabIndex = 24;
            this.radioButtonMandelbrotZCu.Text = "Mandelbrot z^3";
            this.radioButtonMandelbrotZCu.UseVisualStyleBackColor = true;
            // 
            // labelStats
            // 
            this.labelStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStats.Location = new System.Drawing.Point(744, 6);
            this.labelStats.Name = "labelStats";
            this.labelStats.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStats.Size = new System.Drawing.Size(271, 61);
            this.labelStats.TabIndex = 25;
            this.labelStats.Text = "Generate to see statistics.";
            this.labelStats.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelStats.Click += new System.EventHandler(this.labelStats_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.pictureBoxView);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "SD5 Mandelbrot ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxIt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMaxIt;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCIm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCRe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxIt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCImE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCReE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxImY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxImX;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxG;
        private System.Windows.Forms.CheckBox checkBoxR;
        private System.Windows.Forms.CheckBox checkBoxColourSet;
        private System.Windows.Forms.RadioButton radioButtonMandelbrotZCu;
        private System.Windows.Forms.RadioButton radioButtonMandelbrotZSq;
        private System.Windows.Forms.Label labelStats;
    }
}

