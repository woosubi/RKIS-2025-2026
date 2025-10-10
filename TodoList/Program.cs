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
            string task = command.Split("add ", 2)[1];
            if (index == todos.Length)
            {
                string[] newTodos = new string[todos.Length*2];
                bool[] newStatuses = new bool[todos.Length*2];
                DateTime[] newDates = new DateTime[todos.Length*2];
                for (int i = 0; i < todos.Length; i++)
                {
                    newTodos[i] = todos[i];
                    newStatuses[i] = statuses[i];
                    newDates[i] = dates[i];
                }

                todos = newTodos;
                statuses = newStatuses;
                dates = newDates;
            }

            todos[index] = task;
            statuses[index] = false;
            dates[index] = DateTime.Now;

            Console.WriteLine("Добавлена задача: " + index + ") " + task);
            index++;
        }
        private static void DoneTodo(string command)
        {
            var parts = command.Split(' ', 2);
            int index = int.Parse(parts[1]);
            statuses[index] = true;

            Console.WriteLine("Задача " + todos[index] + " отмечена выполненной");
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
            Console.WriteLine("Задачи:");
            for (int i = 0; i < todos.Length; i++)
            {
                string todo = todos[i];
                bool status = statuses[i];
                DateTime date = dates[i];
                
                if (!string.IsNullOrEmpty(todo))
                {
                    Console.WriteLine(i + ") " + date + " - " +  todo + " выполнена: " + status);
                }
            }
        }
    }
}
