namespace TodoList
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите ваше имя: "); 
            string firstName = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            string lastName = Console.ReadLine();

            Console.Write("Введите ваш год рождения: ");
            int birthday = int.Parse(Console.ReadLine());

            string text = "Добавлен пользователь " + firstName + " " + lastName + ", возраст - " + (DateTime.Now.Year - birthday);
            Console.WriteLine(text);
        }
    }
}