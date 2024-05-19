using System;
using System.IO;
using System.Windows;

namespace passBreak.Services
{
    public class FileService
    {
        private readonly string _filePath = "ziad.txt";

        public void SaveToFile(string encryptedValue)
        {
            try
            {
                File.WriteAllText(_filePath, encryptedValue);
                MessageBox.Show("Password encrypted and saved to file successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the encrypted password: {ex.Message}");
            }
        }

        public string LoadFromFile()
        {
            try
            {
                string encryptedValue = File.ReadAllText(_filePath);
                return encryptedValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the encrypted password: {ex.Message}");
                return null;
            }
        }
    }
}