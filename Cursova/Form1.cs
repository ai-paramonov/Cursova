using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cursova.Presenters;
using Cursova.Views;
using System.IO;
using Cursova.Enums;

namespace Cursova
{
    public partial class Form1 : Form , IRequest
    {
        Form2 resultForm = new Form2();
        HelpForm helpForm = new HelpForm();
        Checker checker = new Checker();
        public string FileName { get; set; }
        public Operations Operation { get; set; }
        public Method Method { get; set; }
        public string KeyVigenere { get; set; }
        public int KeyCaesar { get; set;}
        public Form1()
        {
            InitializeComponent();
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            RequestPresenter presenter = new RequestPresenter(this);
            if(checker.ChoosedFileIsCurrentlyExist(FileName))
            {
                presenter.ReadMessageFromFile(FileName);
                presenter.GetOperationFromUI(Operation);
                presenter.GetMethodFromUI(Method);
                if (checker.IsOnlyUkrainianLetters(textBox1.Text) && radioVigenere.Checked)
                {
                    KeyVigenere = textBox1.Text;
                    presenter.GetVigenereKeyFromUI(KeyVigenere);
                    resultForm.ResultMessage = presenter.RunCipherMachine();
                }
                else if (checker.IsKeyCaesarValueIsValid(textBox1.Text) && radioCaesar.Checked)
                {
                    KeyCaesar = Convert.ToInt32(textBox1.Text);
                    presenter.GetCaesarKeyFromUI(KeyCaesar);
                    resultForm.ResultMessage = presenter.RunCipherMachine();
                }
                else if (radioAtbush.Checked)
                {
                    resultForm.ResultMessage = presenter.RunCipherMachine();
                }
                else
                {
                    MessageBox.Show(checker.ErrorText(textBox1.Text));
                    return;
                }
                if (resultForm.IsDisposed)
                {
                    resultForm = new Form2(resultForm.ResultMessage);
                }
                resultForm.Show();
                return;
            }
            MessageBox.Show("Choosen file doesn`t exist");
        }

        private void Choosebutton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "Text files(*.txt)|*.txt";
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = openDialog.FileName;
                }
            }
            if(FileName != null)
            {
                Startbutton.Enabled = true;
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            if (helpForm.IsDisposed)
            {
                helpForm = new HelpForm();
            }
            helpForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioCaesar_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            Method = Method.Caesar;
        }

        private void radioAtbush_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox1.Enabled = false;
            Method = Method.Atbush;
        }

        private void radioVigenere_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            Method = Method.Vigenere;
        }
        private void radioEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            Operation = Operations.Encrypt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            Operation = Operations.Decrypt;
        }

    }
}
