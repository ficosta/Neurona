namespace Neurona
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudHiddenLayers = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnLearn = new System.Windows.Forms.Button();
            this.nudMomentum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudLearningRate = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMaxEpochs = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.nudOutput = new System.Windows.Forms.NumericUpDown();
            this.nudInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbFirstLine = new System.Windows.Forms.CheckBox();
            this.txtDataset = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHiddenLayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMomentum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLearningRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxEpochs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudHiddenLayers);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Controls.Add(this.btnLearn);
            this.groupBox1.Controls.Add(this.nudMomentum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudLearningRate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudMaxEpochs);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.nudOutput);
            this.groupBox1.Controls.Add(this.nudInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGuess);
            this.groupBox1.Location = new System.Drawing.Point(12, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network Config";
            // 
            // nudHiddenLayers
            // 
            this.nudHiddenLayers.Location = new System.Drawing.Point(90, 105);
            this.nudHiddenLayers.Name = "nudHiddenLayers";
            this.nudHiddenLayers.Size = new System.Drawing.Size(57, 20);
            this.nudHiddenLayers.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hidden layers:";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(171, 137);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(153, 23);
            this.btnTest.TabIndex = 12;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnLearn
            // 
            this.btnLearn.Location = new System.Drawing.Point(6, 137);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(153, 23);
            this.btnLearn.TabIndex = 11;
            this.btnLearn.Text = "Learn";
            this.btnLearn.UseVisualStyleBackColor = true;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // nudMomentum
            // 
            this.nudMomentum.DecimalPlaces = 2;
            this.nudMomentum.Location = new System.Drawing.Point(252, 105);
            this.nudMomentum.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMomentum.Name = "nudMomentum";
            this.nudMomentum.Size = new System.Drawing.Size(57, 20);
            this.nudMomentum.TabIndex = 10;
            this.nudMomentum.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Momentum:";
            // 
            // nudLearningRate
            // 
            this.nudLearningRate.DecimalPlaces = 2;
            this.nudLearningRate.Location = new System.Drawing.Point(252, 79);
            this.nudLearningRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLearningRate.Name = "nudLearningRate";
            this.nudLearningRate.Size = new System.Drawing.Size(57, 20);
            this.nudLearningRate.TabIndex = 8;
            this.nudLearningRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Learning rate:";
            // 
            // nudMaxEpochs
            // 
            this.nudMaxEpochs.Location = new System.Drawing.Point(252, 53);
            this.nudMaxEpochs.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMaxEpochs.Name = "nudMaxEpochs";
            this.nudMaxEpochs.Size = new System.Drawing.Size(57, 20);
            this.nudMaxEpochs.TabIndex = 6;
            this.nudMaxEpochs.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(177, 60);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 13);
            this.label.TabIndex = 5;
            this.label.Text = "Max Epochs:";
            // 
            // nudOutput
            // 
            this.nudOutput.Location = new System.Drawing.Point(90, 79);
            this.nudOutput.Name = "nudOutput";
            this.nudOutput.Size = new System.Drawing.Size(57, 20);
            this.nudOutput.TabIndex = 4;
            // 
            // nudInput
            // 
            this.nudInput.Location = new System.Drawing.Point(90, 53);
            this.nudInput.Name = "nudInput";
            this.nudInput.Size = new System.Drawing.Size(57, 20);
            this.nudInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Outputs:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inputs:";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(6, 19);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(318, 23);
            this.btnGuess.TabIndex = 0;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(6, 19);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbFirstLine);
            this.groupBox2.Controls.Add(this.txtDataset);
            this.groupBox2.Controls.Add(this.btnLoadData);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 243);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Set";
            // 
            // cmbFirstLine
            // 
            this.cmbFirstLine.AutoSize = true;
            this.cmbFirstLine.Checked = true;
            this.cmbFirstLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cmbFirstLine.Location = new System.Drawing.Point(218, 25);
            this.cmbFirstLine.Name = "cmbFirstLine";
            this.cmbFirstLine.Size = new System.Drawing.Size(106, 17);
            this.cmbFirstLine.TabIndex = 3;
            this.cmbFirstLine.Text = "First Line Header";
            this.cmbFirstLine.UseVisualStyleBackColor = true;
            // 
            // txtDataset
            // 
            this.txtDataset.Location = new System.Drawing.Point(6, 48);
            this.txtDataset.Multiline = true;
            this.txtDataset.Name = "txtDataset";
            this.txtDataset.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataset.Size = new System.Drawing.Size(318, 189);
            this.txtDataset.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOutput);
            this.groupBox3.Location = new System.Drawing.Point(349, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 415);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(6, 25);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(340, 384);
            this.txtOutput.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 438);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Neurona";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHiddenLayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMomentum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLearningRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxEpochs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDataset;
        private System.Windows.Forms.CheckBox cmbFirstLine;
        private System.Windows.Forms.NumericUpDown nudOutput;
        private System.Windows.Forms.NumericUpDown nudInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudHiddenLayers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.NumericUpDown nudMomentum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudLearningRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMaxEpochs;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

