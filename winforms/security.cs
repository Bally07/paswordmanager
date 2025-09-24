USING system.security.cryptography
using Random
puplic class security
{
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
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        for (int i = 0; i < saltLength; i++)
        {
            Salt=+ chars(random.next());
        }
          saltedInput = Salt + ":" + input;
          return saltedInput;
    } 
}



