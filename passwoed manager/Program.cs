namespace password_manager
{
    using System;
    using Microsoft.Data.SqlClient;
    using System.Text;
    using System.Xml.Serialization;

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class Hasher
    { 
        private string _password;
        Hasher(string password) 
        { 
           
        }

        public string HashPassword(string password)
        {
            _password = password;
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Password cannot be null or empty", nameof(password));
            }
            else
            {

            }
            // Logic to hash the password
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
        }



    }
    public class PasswordManager
    {
        public bool login(string username, string password)
        {
            // sql Logic to check if user exists and password matches
            return true; 
        }
        public void Register(string username, string password)
        { char[] specialcharacters = new[ "!" ,"£" ,"$" ,"%" ,"^", "&", "*", "_", "-", "+", "=", "|", @"\", "<", ",", ">", ".", "?", "/", ";", ":", "'", "@", "#", "~" ;
            string numbers = "0123456789";
            if ((string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) || (password.Length < 8 || password.Contains(specialcharacters.Any) == false))
           {

            }
            {
                throw new ArgumentException("Username or password invalid");
            }
            // sql Logic to register user
        }
        public void AddPassword(string password)
        { if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Password cannot be null or empty", nameof(password));
            }
            // sql Logic to add password
        }

        public void RemovePassword(string password)
        {
            // sql Logic to remove password
        }

        public void ListPasswords()
        {
            // sql Logic to list passwords
        }
    }

    
}
