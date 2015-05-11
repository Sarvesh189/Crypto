using AssymetricCryptoApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoWindowApp
{
    public partial class frmCrypto : Form
    {
        public frmCrypto()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            var plaintext = txtPlainText.Text.Trim();
            if(!string.IsNullOrEmpty(plaintext))
            {

                var crypto = new Crypto(EncryptionKey.key);
                txtEncryptedText.Text = crypto.EncryptText(plaintext);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEncryptedText.Text = "";
            txtPlainText.Text = "";
            Clipboard.Clear();
        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtEncryptedText.Text);
        }


    }
}
