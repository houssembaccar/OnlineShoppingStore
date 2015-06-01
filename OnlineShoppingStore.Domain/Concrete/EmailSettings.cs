using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "houssembaccarenit@gmail.com";
        public string MailFromAddress = "houssembaccarenit@gmail.com";
        public bool UseSsl = true;
        public string Username = "houssembaccarenit@gmail.com";
        public string Password = "houssembaccarEnit123";  
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
    }
}
