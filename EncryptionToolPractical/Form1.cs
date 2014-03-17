using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncryptionToolPractical
{
    public partial class Form1 : Form
    {
        private IEncryptor encryptor;
        public Form1()
        {
            InitializeComponent();
        }

        private void setMainEncryptor()
        {
            if (plainTextEncryptRB.Checked)
            {
                encryptor = new PlainText();
            }
            else
            {
                encryptor = new Rot13();
            }
        }

        private void encryptTextBTN_Click(object sender, EventArgs e)
        {
            if (textToEncryptTB.Text.Length == 0 && (!plainTextEncryptRB.Checked && !rot13EncryptRB.Checked))
            {
                MessageBox.Show("You must enter some text to encrypt, and select an encryption option.");
            }
            else if (textToEncryptTB.Text.Length > 0 && (!plainTextEncryptRB.Checked && !rot13EncryptRB.Checked))
            {
                MessageBox.Show("You must select an encryption option.");
            }
            else if (textToEncryptTB.Text.Length == 0 && (plainTextEncryptRB.Checked || rot13EncryptRB.Checked))
            {
                MessageBox.Show("You must enter some text to encrypt.");
            }
            else
            {
                setMainEncryptor();

                encryptedTextResultsTB.Text = encryptor.encrypt(textToEncryptTB.Text);
            }
        }
    }
}
