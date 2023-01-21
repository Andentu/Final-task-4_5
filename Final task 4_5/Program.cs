using System.Drawing;

namespace Final_task_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int k = 0; k < 3; k++)
            {
                (string name, string surname, string login, int LoginCount, double age, bool pet, string[] colors) User;
                Console.WriteLine("Введите имя");
                User.name = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                User.surname = Console.ReadLine();
                Console.WriteLine("Введите логин");
                User.login = Console.ReadLine();
                User.LoginCount = User.login.Length;
                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                string Hpet = Console.ReadLine();
                if (Hpet == "Да")
                {
                    User.pet = true;
                }
                else
                {
                    User.pet = false;
                }
                Console.WriteLine("Введите возраст пользователя: ");
                User.age = Convert.ToDouble(Console.ReadLine());

                User.colors = new string[3];

                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int i = 0; i < User.colors.Length; i++)
                {
                    User.colors[i] = Console.ReadLine();
                }
            }
        }
    }
    }
