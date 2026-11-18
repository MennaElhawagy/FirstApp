using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace FirstApp
{
    public static class Utils
    {
        public static string HashPassword(string password)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] data = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            //////
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }

            return sb.ToString();
        }


        public static string DefaultHashPassword()
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] data = sha256.ComputeHash(Encoding.UTF8.GetBytes("Password@123"));

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }

            return sb.ToString();
        }

        public static bool FormIsOpen(string name)
        {
            var openForms = Application.OpenForms.Cast<Form>();
            return openForms.Any(q => q.Name == name);
        }
    }
}
