namespace Final_task_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, string surname, string login, int LoginCount, int age, bool pet, string[] colors) User;
            Console.WriteLine("Введите имя");
            User.name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            User.surname = Console.ReadLine();
            Console.WriteLine("Введите логин");
            User.login = Console.ReadLine();

        }
    }
}