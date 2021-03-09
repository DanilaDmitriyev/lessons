using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace Passwords
{
    [Serializable]
    public class PasswordsInfo
    {
        public string login { get; set; }
        public string password { get; set; }
    }
    
    class Program
    {
        
        static void Main(string[] args)
        {
            List<PasswordsInfo> passwords = new List<PasswordsInfo>();
            passwords.Add(new PasswordsInfo { login = "vasya", password = "123" });
            passwords.Add(new PasswordsInfo { login = "olya", password = "446" });
            BinaryFormatter BF = new BinaryFormatter();
            using (FileStream FS=new FileStream("psw.txt", FileMode.Create)) {
                BF.Serialize(FS, passwords);
            }
        }
    }
}
