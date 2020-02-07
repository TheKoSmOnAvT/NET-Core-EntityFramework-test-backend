using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace backend
{
    class DataBase
    {
        masterContext db = new masterContext();


        //Добавление в базу
        public void Add(string Name, string Surname, string Patronymic, string Mail, string Phone, string Position)
        {
            db.User.Add(new User(Name,  Surname,  Patronymic,  Mail,  Phone,  Position));
            db.SaveChanges();
        }

        public void Add(User user)
        {
            db.User.Add(user);
            db.SaveChanges();
        }

        // получение
        public List<User> ToList()
        {
            return db.User.ToList();
        }

        //Вывод в консоль 
        public void PrintConsole()
        {
            var data = db.User.ToList();
            foreach (var i in data)
            {
                Console.WriteLine($"{i.Uname} - {i.Surname} - {i.Patronymic} - {i.Mail} - {i.Phone} - {i.Position} ");
            }
        }

        //Удаление 
        public void Remove(string Name, string Surname, string Patronymic, string Mail, string Phone, string Position)
        {
            User user = db.User.FirstOrDefault(p => p.Uname == Name && p.Surname == Surname && p.Patronymic == Patronymic && p.Phone == Phone && p.Mail == Mail && p.Position == Position);
            if (user != null)
            {
                db.User.Remove(user);
                db.SaveChanges();
            }
        }
        public void Remove(User us)
        {
            User user = db.User.FirstOrDefault(p => p.Uname == us.Uname && p.Surname == us.Surname && p.Patronymic == us.Patronymic && p.Phone == us.Phone && p.Mail == us.Mail && p.Position == us.Position);
            if (user != null)
            {
                db.User.Remove(user);
                db.SaveChanges();
            }
        }
        //Редактикрование

        public void Change(User Old, User New)
        {
            var user = db.User.FirstOrDefault(p => p.Uname == Old.Uname && p.Surname == Old.Surname && p.Patronymic == Old.Patronymic && p.Phone == Old.Phone && p.Mail == Old.Mail && p.Position == Old.Position);
            if (user != null)
            {
                user.Uname = New.Uname;
                user.Surname = New.Surname;
                user.Patronymic = New.Patronymic;
                user.Mail = New.Mail;
                user.Phone = New.Phone;
                user.Position = New.Position;
                db.User.Update(user);
                db.SaveChanges();
            }
        }
    }
}
