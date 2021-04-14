using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cursova
{
    public partial class Form2 : Form
    {
        public string ResultMessage { get; set; }
        public Form2(string resultMess)
        {
            ResultMessage = resultMess;
            InitializeComponent();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            resultTextBox.Text = ResultMessage;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files(*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, resultTextBox.Text);
                    MessageBox.Show("Message saved into file");
                }
            }
            resultTextBox.Text = "";
            Dispose();
        }
    }
}
