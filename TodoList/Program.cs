using TodoList.Commands;

namespace TodoList;

internal class Program
{
	private static TodoList todos = new();

	public static void Main()
	{
		FileManager.EnsureDataDirectory(FileManager.DataDirPath);
		if (!File.Exists(FileManager.ProfilePath)) File.WriteAllText(FileManager.ProfilePath, "Default User 2000");
		Console.WriteLine("Выполнили курсанты группы 3833 Кучеренко и Мурза");
		TodoList todoList = new();

		while (true)
		{
			Console.WriteLine("Введите команду: ");
			string input = Console.ReadLine();

			ICommand command = CommandParser.Parse(input, todoList);
			command.Execute();
		}
	}

}