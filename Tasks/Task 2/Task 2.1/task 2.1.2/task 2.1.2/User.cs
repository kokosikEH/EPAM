using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._1._2
{
    class User
    {
        private String name;

        public string Name { get => name; set => name = value; }
        public User() { name = null; }
        public string AddUser(User newUser) 
        {
           
            Console.WriteLine("Введите имя пользователя:");
            newUser.Name = Console.ReadLine();
            Console.WriteLine("Пользовательс ником " + newUser.Name + " успешно создан!");
            return newUser.Name;
        }

    }
}
