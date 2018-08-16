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
        static byte[] x;
        public CryptoUtil()
        {
            publicKeyFile = curr_dir + "/publickey.xml";
            privateKeyFile = curr_dir +  "/privatekey.xml";
            InitializeComponent();
            generateKeys();
            saveKeys(publicKeyFile, privateKeyFile);
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            byte[] e_message;
            byte[] de_message = Encoding.UTF8.GetBytes(decryptedTextBox.Text);
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                string publicKey = File.ReadAllText(publicKeyFile);
                rsa.FromXmlString(publicKey);
                e_message = rsa.Encrypt(de_message, true);
                x = e_message;
            }
            encryptedTextBox.Text = Convert.ToBase64String(e_message);
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            byte[] de_message;
            byte[] e_message = Convert.FromBase64String(encryptedTextBox.Text);
            using (var rsa = new RSACryptoServiceProvider(2038))
            {
                rsa.PersistKeyInCsp = false;
                string privateKey = File.ReadAllText(privateKeyFile);
                rsa.FromXmlString(privateKey);
                e_message = x;
                de_message = rsa.Decrypt(e_message, true);
            }
            decryptedTextBox.Text = Encoding.UTF8.GetString(de_message);
        }

        private static byte[] c(string str)
        {
            String[] arr = str.Split('-');
            byte[] array = new byte[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = Convert.ToByte(arr[i], 16);
            }
            return array;
        }

        

        private static void saveKeys(string publicKeyFile, string privateKeyFile)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
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

        static void generateKeys()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                publicKey = rsa.ExportParameters(false);
                privateKey = rsa.ExportParameters(true);
            }
        }

        private void genKeysButton_Click(object sender, EventArgs e)
        {
            generateKeys();
            saveKeys(publicKeyFile, privateKeyFile);
        }

        private void loadKeysButton_Click(object sender, EventArgs e)
        {
            if (!(File.Exists(keyTextBox.Text) ))
            {
                messageLabel1.Text = "Error!";
                messageLabel1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                publicKeyFile = keyTextBox.Text;
                //privateKeyFile = privateKeyTextBox.Text;
                messageLabel1.Text = "Loaded!";
                messageLabel1.ForeColor = System.Drawing.Color.Green;

            }
        }
    }
}
    /*

        static void Main(string[] args)
        {
            string message = "The quick brown fox jumps over the lazy dog";
            generateKeys();
            byte[] encrypted = Encrypt(Encoding.UTF8.GetBytes(message));
            byte[] decrypted = Decrypt(encrypted);
            DeleteKeyInCSP();
            Console.WriteLine("Original\n\t " + message + "\n");
            Console.WriteLine("Encrypted\n\t" + BitConverter.ToString(encrypted).Replace("-", "") + "\n");
            Console.WriteLine("Decrypted\n\t" + Encoding.UTF8.GetString(decrypted));

            Console.ReadLine();

        }


     
      */
