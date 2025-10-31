namespace TodoList;

internal class Program
{
	static Profile profile;
	private static TodoList todos = new();

	public static void Main()
	{
		Console.WriteLine("Выполнили курсанты группы 3833 Кучеренко и Мурза");
		profile = AddUser();
		TodoList todoList = new();

		while (true)
		{
			Console.WriteLine("Введите команду: ");
			string input = Console.ReadLine();

			ICommand command = CommandParser.Parse(input, todoList, profile);
			command.Execute();
		}
	}

	private static Profile AddUser()
	{
		Console.Write("Введите ваше имя: ");
		var firstName = Console.ReadLine();
		Console.Write("Введите вашу фамилию: ");
		var lastName = Console.ReadLine();

		Console.Write("Введите ваш год рождения: ");
		var year = int.Parse(Console.ReadLine());

		var profile = new Profile(firstName, lastName, year);
		Console.WriteLine($"Добавлен пользователь {profile.GetInfo()}");
		return profile;
	}
}