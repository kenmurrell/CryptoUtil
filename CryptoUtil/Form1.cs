using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace CryptoUtil
{
    public partial class CryptoUtil : Form
    {

        private static string curr_dir = System.IO.Directory.GetCurrentDirectory();
        private static RSAParameters publicKey;
        private static RSAParameters privateKey;
        private static string publicKeyFile;
        private static string privateKeyFile;
        static string CONTAINER_NAME = "keyring";
        public CryptoUtil()
        {
            InitializeComponent();
            generateKeys();
        }

        private void initialize()
        {
            messageLabel1.Text = "";
            messageLabel2.Text = "";
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            initialize();
            byte[] e_message;
            byte[] de_message = Encoding.UTF8.GetBytes(decryptedTextBox.Text);
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                string publicKey = File.ReadAllText(publicKeyFile);
                rsa.FromXmlString(publicKey);
                try
                {
                    e_message = rsa.Encrypt(de_message, true);
                    encryptedTextBox.Text = Convert.ToBase64String(e_message);
                }
                catch(System.Security.Cryptography.CryptographicException e_error)
                {
                    messageLabel2.Text = "Encryption Error";
                    de_message = null;
                }
                
            } 
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            initialize();
            byte[] de_message;
            byte[] e_message = Convert.FromBase64String(encryptedTextBox.Text);
            using (var rsa = new RSACryptoServiceProvider(2038))
            {
                rsa.PersistKeyInCsp = false;
                string privateKey = File.ReadAllText(privateKeyFile);
                rsa.FromXmlString(privateKey);
                try
                {
                    de_message = rsa.Decrypt(e_message, true);
                    decryptedTextBox.Text = Encoding.UTF8.GetString(de_message);
                }
                catch (System.Security.Cryptography.CryptographicException d_error)
                {
                    messageLabel2.Text = "Decryption Error";
                    de_message = null;
                }
            }
        }

        private static void generateKeys()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                publicKeyFile = curr_dir + "/publickey.xml";
                privateKeyFile = curr_dir + "/privatekey.xml";
                if (File.Exists(privateKeyFile))
                    File.Delete(privateKeyFile);
                if (File.Exists(publicKeyFile))
                    File.Delete(publicKeyFile);
                string publicKey = rsa.ToXmlString(false);
                File.WriteAllText(publicKeyFile, publicKey);
                string privateKey = rsa.ToXmlString(true);
                File.WriteAllText(privateKeyFile, privateKey);
            }
        }

        private void genKeysButton_Click(object sender, EventArgs e)
        {
            generateKeys();
        }

        private void loadKeysButton_Click(object sender, EventArgs e)
        {
            if (!(File.Exists(publicKeyTextBox.Text) || !(File.Exists(privateKeyTextBox.Text))))
            {
                messageLabel1.Text = "Error!";
                messageLabel1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                publicKeyFile = publicKeyTextBox.Text;
                privateKeyFile = privateKeyTextBox.Text;
                messageLabel1.Text = "Loaded!";
                messageLabel1.ForeColor = System.Drawing.Color.Green;

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            initialize();
            encryptedTextBox.Text = "";
            decryptedTextBox.Text = "";
        }
    }
}

