namespace TodoList;

public class FileManager
{
	public const string DataDirPath = "data";
	public static readonly string ProfilePath = Path.Combine(DataDirPath, "profile.txt");

	public static void EnsureDataDirectory(string dirPath)
	{
		if (!Directory.Exists(dirPath)) Directory.CreateDirectory(dirPath);
	}

	public static void SaveProfile(Profile profile)
	{
		File.WriteAllText(ProfilePath, $"{profile.FirstName} {profile.LastName} {profile.BirthYear}");
	}

}