namespace TodoList
{
    class Program
    {
        static string firstName, lastName;
        static int age;

        static string[] todos = new string[2];
        static bool[] statuses = new bool[2];
        static DateTime[] dates = new DateTime[2];
        static int index = 0;
        public static void Main()
        {
            Console.WriteLine("Выполнили курсанты группы 3833 Кучеренко и Мурза");
            AddUser();

            while (true)
            {
                Console.Write("Введите команду: ");
                string command = Console.ReadLine();

                if (command == "help") HelpCommand();
                else if (command == "profile") ShowProfile();
                else if (command == "exit") break;
                else if (command.StartsWith("add ")) AddTodo(command);
                else if (command.StartsWith("done ")) DoneTodo(command);
                else if (command.StartsWith("delete ")) DeleteTodo(command);
                else if (command.StartsWith("update ")) UpdateTodo(command);
                else if (command == "view") ViewTodo();
                else Console.WriteLine("Неизвестная команда.");
            }
        }
        private static void AddTodo(string command)
        {
            throw new NotImplementedException();
        }
        private static void DoneTodo(string command)
        {
           throw new NotImplementedException();
        }
        private static void DeleteTodo(string command)
        {
            throw new NotImplementedException();
        }
        private static void UpdateTodo(string command)
        {
            throw new NotImplementedException();
        }
        private static void ViewTodo()
        {
            throw new NotImplementedException();
        }
    }
}
