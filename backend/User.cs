using System;
using System.Collections.Generic;
using System.Text;

namespace backend
{
    public partial class User
    {
        public int Id { get; set; }
        public string Uname { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }
   
    public User(string Uname, string Surname, string Patronymic, string Mail, string Phone, string Position)
        {
            this.Uname = Uname;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
            this.Mail = Mail;
            this.Phone = Phone;
            this.Position = Position;
        }
    }
}
