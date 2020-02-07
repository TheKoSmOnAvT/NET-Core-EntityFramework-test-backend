using System;
using System.Linq;
using System.Collections.Generic;

namespace backend
{
    class Program
    {


        static void Main(string[] args)
        {

            DataBase db = new DataBase();

            //Добавление 
            db.Add("1", "2", "3", "4", "5", "7");

            //получение 
            var data = db.ToList();
            foreach (var i in data)
            {
                Console.WriteLine($"{i.Uname} - {i.Surname} - {i.Patronymic} - {i.Mail} - {i.Phone} - {i.Position} ");
            }

            //удаление 
            db.Remove("1", "2", "3", "4", "5", "7");
            db.PrintConsole();


            //изменение 
            User us1 = new User("2", "2", "2", "2", "2", "2");
            User us2 = new User("0", "0", "0", "0", "0", "0");
            db.Add(us1);
            db.PrintConsole();

            db.Change(us1, us2);
            db.PrintConsole();



            Console.Read();
        }

    }
}

