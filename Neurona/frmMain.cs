using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Neurona
{
    public partial class frmMain : Form
    {
        int inputs;
        string[] inputName;
        string[] outputName;


        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void ShowMatrix(double[][] matrix, int numRows,
        int decimals, bool indices)
        {
            int len = matrix.Length.ToString().Length;
            for (int i = 0; i < numRows; ++i)
            {
                if (indices == true)
                    txtOutput.Text += "[" + i.ToString().PadLeft(len) + "]  ";
                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    double v = matrix[i][j];
                    if (v >= 0.0)
                        txtOutput.Text += (" "); // '+'
                    txtOutput.Text += (v.ToString("F" + decimals) + "  ");
                }
                txtOutput.Text += ("\r\n");
            }

            if (numRows < matrix.Length)
            {
                txtOutput.Text += (". . .");
                int lastRow = matrix.Length - 1;
                if (indices == true)
                    txtOutput.Text += ("[" + lastRow.ToString().PadLeft(len) + "]  ");
                for (int j = 0; j < matrix[lastRow].Length; ++j)
                {
                    double v = matrix[lastRow][j];
                    if (v >= 0.0)
                        txtOutput.Text += (" "); // '+'
                    txtOutput.Text += (v.ToString("F" + decimals) + "  ");
                }
            }
            txtOutput.Text += ("\r\n");
        }

        private void ShowVector(double[] vector, int decimals,
          int lineLen, bool newLine)
        {
            for (int i = 0; i < vector.Length; ++i)
            {
                if (i > 0 && i % lineLen == 0) txtOutput.Text += ("");
                if (vector[i] >= 0) txtOutput.Text += (" ");
                txtOutput.Text += (vector[i].ToString("F" + decimals) + " ");
            }
            if (newLine == true)
                txtOutput.Text += ("\r\n");
        }

        private double[][] MakeAllData(int numInput, int numHidden,
          int numOutput, int numRows, int seed)
        {
            Random rnd = new Random(seed);
            int numWeights = (numInput * numHidden) + numHidden +
              (numHidden * numOutput) + numOutput;
            double[] weights = new double[numWeights]; // actually weights & biases
            for (int i = 0; i < numWeights; ++i)
                weights[i] = 20.0 * rnd.NextDouble() - 10.0; // [-10.0 to 10.0]

            txtOutput.Text += ("\r\nGenerating weights and biases:");
            ShowVector(weights, 2, 10, true);

            double[][] result = new double[numRows][]; // allocate return-result
            for (int i = 0; i < numRows; ++i)
                result[i] = new double[numInput + numOutput]; // 1-of-N in last column

            NeuralNetwork gnn =
              new NeuralNetwork(numInput, numHidden, numOutput); // generating NN
            gnn.SetWeights(weights);

            for (int r = 0; r < numRows; ++r) // for each row
            {
                // generate random inputs
                double[] inputs = new double[numInput];
                for (int i = 0; i < numInput; ++i)
                    inputs[i] = 20.0 * rnd.NextDouble() - 10.0; // [-10.0 to -10.0]

                // compute outputs
                double[] outputs = gnn.ComputeOutputs(inputs);

                // translate outputs to 1-of-N
                double[] oneOfN = new double[numOutput]; // all 0.0

                int maxIndex = 0;
                double maxValue = outputs[0];
                for (int i = 0; i < numOutput; ++i)
                {
                    if (outputs[i] > maxValue)
                    {
                        maxIndex = i;
                        maxValue = outputs[i];
                    }
                }
                oneOfN[maxIndex] = 1.0;

                // place inputs and 1-of-N output values into curr row
                int c = 0; // column into result[][]
                for (int i = 0; i < numInput; ++i) // inputs
                    result[r][c++] = inputs[i];
                for (int i = 0; i < numOutput; ++i) // outputs
                    result[r][c++] = oneOfN[i];
            } // each row
            return result;
        } // MakeAllData

        private void SplitTrainTest(double[][] allData, double trainPct,
          int seed, out double[][] trainData, out double[][] testData)
        {
            Random rnd = new Random(seed);
            int totRows = allData.Length;
            int numTrainRows = (int)(totRows * trainPct); // usually 0.80
            int numTestRows = totRows - numTrainRows;
            trainData = new double[numTrainRows][];
            testData = new double[numTestRows][];

            double[][] copy = new double[allData.Length][]; // ref copy of data
            for (int i = 0; i < copy.Length; ++i)
                copy[i] = allData[i];

            for (int i = 0; i < copy.Length; ++i) // scramble order
            {
                int r = rnd.Next(i, copy.Length); // use Fisher-Yates
                double[] tmp = copy[r];
                copy[r] = copy[i];
                copy[i] = tmp;
            }
            for (int i = 0; i < numTrainRows; ++i)
                trainData[i] = copy[i];

            for (int i = 0; i < numTestRows; ++i)
                testData[i] = copy[i + numTrainRows];
        } // SplitTrainTest

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    String st = File.ReadAllText(openFileDialog1.FileName);
                    txtDataset.Text = st;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDataset.Text))
            {
                MessageBox.Show("Please load your data");
            }
            else
            {
                inputName = txtDataset.Lines.FirstOrDefault().Split(',');
                List<string> uniqueList = new List<string>();
                foreach (string line in txtDataset.Lines.Skip(1))
                {
                    if (!string.IsNullOrWhiteSpace(line) && !uniqueList.Contains(line.Split(',').Last().ToString()))
                        uniqueList.Add(line.Split(',').Last().ToString());           
                }

                MessageBox.Show($"There are {inputName.Length - 1} atributes and 1 class with {uniqueList.Count} diferent {inputName.Last()}\n{ string.Join(", ",uniqueList.ToArray())}");
                nudInput.Value = inputName.Length - 1;
                nudOutput.Value = uniqueList.Count();
                //MessageBox.Show(uniqueList.ToArray().ToString());
                //MessageBox.Show(txtDataset.Lines.FirstOrDefault().Split(',').Length.ToString().ToString()); 
            }
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            int numInput = 4; // number features
            int numHidden = 5;
            int numOutput = 3; // number of classes for Y
            int numRows = 1000;
            int seed = 1; // gives nice demo

            txtOutput.Text += ("\r\nGenerating " + numRows +
              " artificial data items with " + numInput + " features");
            double[][] allData = MakeAllData(numInput, numHidden, numOutput,
              numRows, seed);
            txtOutput.Text += ("Done");

            //ShowMatrix(allData, allData.Length, 2, true);

            txtOutput.Text += ("\r\nCreating train (80%) and test (20%) matrices");
            double[][] trainData;
            double[][] testData;
            SplitTrainTest(allData, 0.80, seed, out trainData, out testData);
            txtOutput.Text += ("Done\r\n");

            txtOutput.Text += ("\r\nTraining data:");
            ShowMatrix(trainData, 4, 2, true);
            txtOutput.Text += ("\r\nTest data:");
            ShowMatrix(testData, 4, 2, true);

            txtOutput.Text += ("\r\nCreating a " + numInput + "-" + numHidden +
              "-" + numOutput + " neural network");
            NeuralNetwork nn = new NeuralNetwork(numInput, numHidden, numOutput);

            int maxEpochs = 1000;
            double learnRate = 0.05;
            double momentum = 0.01;
            txtOutput.Text += ("\r\nSetting maxEpochs = " + maxEpochs);
            txtOutput.Text += ("\r\nSetting learnRate = " + learnRate.ToString("F2"));
            txtOutput.Text += ("\r\nSetting momentum  = " + momentum.ToString("F2"));

            txtOutput.Text += ("\r\n\r\nStarting training");
            double[] weights = nn.Train(trainData, maxEpochs, learnRate, momentum);
            txtOutput.Text += ("\r\n\r\nDone");
            txtOutput.Text += ("\r\n\r\nFinal neural network model weights and biases:\n");
            ShowVector(weights, 2, 10, true);

            //double[] y = nn.ComputeOutputs(new double[] { 1.0, 2.0, 3.0, 4.0 });
            //ShowVector(y, 3, 3, true);

            double trainAcc = nn.Accuracy(trainData);
            txtOutput.Text += ("\r\nFinal accuracy on training data = " +
              trainAcc.ToString("F4"));

            double testAcc = nn.Accuracy(testData);
            txtOutput.Text += ("\r\nFinal accuracy on test data     = " +
              testAcc.ToString("F4"));

            txtOutput.Text += ("\r\nEnd back-propagation demo\n");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }
    }
}
