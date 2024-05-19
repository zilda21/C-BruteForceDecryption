using System;
using System.Diagnostics;
using System.Windows;
using passBreak.Services;

namespace passBreak
{
    public partial class MainWindow : Window
    {
        private readonly EncryptionService _encryptionService;
        private readonly FileService _fileService;

        public MainWindow()
        {
            InitializeComponent();
            _encryptionService = new EncryptionService();
            _fileService = new FileService();
        }

        private void EncryptionButton_Click(object sender, RoutedEventArgs e)
        {
            string value = txtValue.Text;
            string salt = txtSalt.Text;

            string encryptedValue = _encryptionService.Encrypt(value, salt);
            _fileService.SaveToFile(encryptedValue);
        }

        private void DecryptionButton_Click(object sender, RoutedEventArgs e)
        {
            string encryptedValue = _fileService.LoadFromFile();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string decryptedValue = _encryptionService.BruteForceDecrypt(encryptedValue, txtValue.Text);

            stopwatch.Stop();

            if (decryptedValue != null)
            {
                MessageBox.Show($"{decryptedValue}. Time taken: {stopwatch.Elapsed}");
            }
            else
            {
                MessageBox.Show("Brute force attack failed to find the password.");
            }
        }
    }
}