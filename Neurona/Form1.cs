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
    public partial class Form1 : Form
    {
        int inputs;
        string[] inputName;
        string[] outputName;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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

                MessageBox.Show($"There is {inputName.Length - 1} atributes and 1 class with {uniqueList.Count} diferent {inputName.Last()}\n{ string.Join(", ",uniqueList.ToArray())}");
                nudInput.Value = inputName.Length - 1;
                nudOutput.Value = uniqueList.Count();
                //MessageBox.Show(uniqueList.ToArray().ToString());
                //MessageBox.Show(txtDataset.Lines.FirstOrDefault().Split(',').Length.ToString().ToString()); 
            }
        }
    }
}
