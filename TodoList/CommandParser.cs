namespace TodoList;

public static class CommandParser
{
	public static ICommand Parse(string input, TodoList todoList, Profile profile)
	{
		string[] parts = input.Trim().Split(' ', 2);
		string commandName = parts[0].ToLower();
		string args = parts.Length > 1 ? parts[1] : "";

		switch (commandName)
		{
			case "add":
				var addCmd = new AddCommand
				{
					TodoList = todoList,
					IsMultiline = args.Contains("--multi") || args.Contains("-m"),
					TaskText = args.Replace("--multi", "").Replace("-m", "").Trim()
				};
				return addCmd;

			case "view":
				bool showAll = args.Contains("--all") || args.Contains("-a");
				var viewCmd = new ViewCommand
				{
					TodoList = todoList,
					ShowIndex = args.Contains("--index") || args.Contains("-i") || showAll,
					ShowStatus = args.Contains("--status") || args.Contains("-s") || showAll,
					ShowDate = args.Contains("--update-date") || args.Contains("-d") || showAll
				};
				return viewCmd;

			case "done":
				return new DoneCommand
				{
					TodoList = todoList,
					TaskIndex = int.Parse(args)
				};
			
			case "read":
				return new ReadCommand
				{
					TodoList = todoList,
					TaskIndex = int.Parse(args)
				};

			case "delete":
				return new DeleteCommand
				{
					TodoList = todoList,
					TaskIndex = int.Parse(args)
				};
			
			case "update":
				return new UpdateCommand
				{
					TodoList = todoList,
					TaskIndex = int.Parse(args.Split(" ", 2)[0]),
					NewText = args.Split(" ", 2)[1]
				};

			case "profile":
				return new ProfileCommand { Profile = profile };

			case "help":
				return new HelpCommand();

			case "exit":
				return new ExitCommand();

			default:
				return new UnknownCommand();
		}
	}
}