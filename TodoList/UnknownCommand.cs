namespace TodoList;

public class UnknownCommand : ICommand
{
	public void Execute()
	{
		Console.WriteLine("Неизвестная команда.");
	}
}