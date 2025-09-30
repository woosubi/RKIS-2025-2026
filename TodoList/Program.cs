namespace TodoList
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Выполнили курсанты группы 3833 Кучеренко и Мурза");
            Console.Write("Введите ваше имя: "); 
            string firstName = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            string lastName = Console.ReadLine();

            Console.Write("Введите ваш год рождения: ");
            int birthday = int.Parse(Console.ReadLine());
            int age = DateTime.Now.Year - birthday;

            string text = "Добавлен пользователь " + firstName + " " + lastName + ", возраст - " + age;
            Console.WriteLine(text);

            while (true)
            {
                Console.Write("Введите команду: ");
                string command = Console.ReadLine();

                if (command == "help")
                {
                    Console.WriteLine("Команды:");
                    Console.WriteLine("help — выводит список всех доступных команд с кратким описанием");
                    Console.WriteLine("profile — выводит данные пользователя");
                    Console.WriteLine("add \"текст задачи\" — добавляет новую задачу");
                    Console.WriteLine("view — выводит все задачи");
                    Console.WriteLine("exit — выход из программы");
                }
                else if (command == "profile")
                {
                    Console.WriteLine(firstName + " " + lastName + ", - " + age);
                }

                else if (command == "exit")
                {
                    Console.WriteLine("Выход из программы.");
                    break;
                }
                else
                {
                    Console.WriteLine("Неизвестная команда.");
                }
            }
        }
    }
}
