using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using EncrypterProgram;

namespace ManksEncrypter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                lblFileLocation.Text = open.FileName;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string key = "v8y/B?E(";
            string filePath = lblFileLocation.Text;
            if (chkboxEncrypt.Checked == true && chkboxDecrypt.Checked == true)
            {
                MessageBox.Show("You can only have 1 box checked!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                chkboxEncrypt.Checked = false;
                chkboxDecrypt.Checked = false;

            }
            else if (chkboxEncrypt.Checked == false && chkboxDecrypt.Checked == false)
            {
                MessageBox.Show("No Option Selected!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                chkboxEncrypt.Checked = false;
                chkboxDecrypt.Checked = false;

            }
            else if (lblFileLocation.Text == "")
            {
                MessageBox.Show("No File Location Selected", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (chkboxEncrypt.Checked == true)
            {
                Encrypt(filePath, key);
                lblFileLocation.Text = "";
                chkboxEncrypt.Checked = false;
            }
            else if (chkboxDecrypt.Checked == true)
            {
                Decrypt(filePath, key);
                lblFileLocation.Text = "";
                chkboxDecrypt.Checked = false;
            }
        }

        static void Encrypt(string filePath, string key)
        {
            byte[] plainContent = File.ReadAllBytes(filePath);
            using (var DES = new DESCryptoServiceProvider())
            {
                DES.IV = Encoding.UTF8.GetBytes(key);
                DES.Key = Encoding.UTF8.GetBytes(key);
                DES.Mode = CipherMode.CBC;
                DES.Padding = PaddingMode.PKCS7;

                using (var memStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memStream, DES.CreateEncryptor(), CryptoStreamMode.Write);
                    //write to buffer
                    cryptoStream.Write(plainContent, 0, plainContent.Length);
                    //update the buffer and than clear the buffer
                    cryptoStream.FlushFinalBlock();
                    File.WriteAllBytes(filePath, memStream.ToArray());
                    MessageBox.Show("File Encrypted", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        static void Decrypt(string filePath, string key)
        {
            byte[] encryptedFile = File.ReadAllBytes(filePath);
            using (var DES = new DESCryptoServiceProvider())
            {
                DES.IV = Encoding.UTF8.GetBytes(key);
                DES.Key = Encoding.UTF8.GetBytes(key);
                DES.Mode = CipherMode.CBC;
                DES.Padding = PaddingMode.PKCS7;

                using (var memStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memStream, DES.CreateDecryptor(), CryptoStreamMode.Write);
                    //write to buffer
                    try
                    {
                        cryptoStream.Write(encryptedFile, 0, encryptedFile.Length);
                        //update the buffer and than clear the buffer                      
                        cryptoStream.FlushFinalBlock();
                        File.WriteAllBytes(filePath, memStream.ToArray());
                        MessageBox.Show("File Decrypted", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("File Is Already Decrypted", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnPanelPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPanelEncrypter_Click(object sender, EventArgs e)
        {
            
        }
    }
}
