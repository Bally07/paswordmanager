namespace WinFormsApp1
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
    }
    public class security
    {
        private string _password;
        private string _username;
        public security(string password, string username)
        {
        }
        public bool Login(string password, string username)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(username))
            {
                return false;
            }else
            {
                searchAccountDatabase(password, username);
            }
           
            return true;
        }
        private bool searchAccountDatabase(string password, string username)
        {

            return true;
        }
    }
}
