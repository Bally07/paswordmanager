using system.security.cryptography;
using Random;
using System.Text;
using System;

public class security
{
    public static void Main()
    { 
    string key = "mysecretkey";
    string input = "mydata";
    input == salt(input);
    key == hasher(key);
    Console.Writeline(encrypt(input,key)); 
    }
    
    public string hasher(string input)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            string hash = GetHash(sha256Hash, input);
            return hash;
        }
    }  
    public string salt(string input)
    {
        string Salt = "";
        string saltedInput;
        var random = new Random();
        int saltLength = 2;
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789\x02";
        for (int i = 0; i < saltLength; i++)
        {
            Salt=+ chars(random.next());
        }
          saltedInput = Salt + ":" + input;
          return saltedInput;
    } 
    public string encrypt (string input ,string key) 
    {
        string encryptedString = "";
        encryptedstring = input ^ key;
        return encryptedString;
    }
}



