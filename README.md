

# Brute Force Decryption Tool 🔓  

A .NET Core application designed to test brute force decryption techniques and analyze cryptographic security. The tool includes features for password encryption, decryption, and generation of all possible password combinations. It provides a user-friendly WPF interface for interaction and practical implementation of cryptographic concepts.  

## Features  
- **Password Encryption and Decryption:** Supports encrypting user-provided data and attempting decryption using brute force methods.  
- **Password Generation:** Implements a recursive algorithm to generate all possible password combinations for a given character set and length.  
- **File Management:** Securely saves and retrieves encrypted passwords to and from local files.  
- **User-Friendly Interface:** WPF-based GUI for seamless user interaction with encryption and decryption functionalities.  
- **Robust Error Handling:** Comprehensive exception management ensures smooth and error-free execution.  

## Technologies Used  
- **Frontend:** WPF (Windows Presentation Foundation)  
- **Backend:** C#, .NET Core  
- **File Handling:** System.IO for saving and loading encrypted data  

## Screenshots  
 <img width="934" alt="image" src="https://github.com/user-attachments/assets/bed402a7-eaed-4563-aabc-ac046518096a">



## Installation and Usage  

1. Clone the repository:  
   ```bash  
   git clone https://github.com/yourusername/brute-force-decryption.git  
   cd brute-force-decryption  
   ```  

2. Open the project in Visual Studio.  

3. Build and run the application.  

4. Features available in the app:  
   - Input a value and salt for encryption or decryption.  
   - Save the encrypted data to a local file.  
   - Load encrypted data for decryption attempts.  
   - Generate possible passwords based on the provided character set.  

## How It Works  
1. The **FileService** component manages the secure saving and retrieval of encrypted passwords.  
2. The **PasswordGenerator** generates all possible combinations of characters up to a specified length using a recursive algorithm.  
3. The WPF interface allows users to interact with the encryption, decryption, and password generation features.  

## Contributing  
Contributions are welcome! Fork the repository, create a feature branch, and submit a pull request.  

## License  
This project is licensed under the MIT License.  

## Acknowledgments  
- The project was inspired by the need to understand and test the robustness of cryptographic methods.  
- Thanks to the .NET and WPF communities for their support and resources.  

