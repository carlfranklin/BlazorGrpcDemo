using System.Text.Json;
using BlazorGrpcDemo.Shared;

namespace BlazorGrpcDemo.Server.Data;

public class PersonsManager
{
	public List<Person> People { get; set; }

	public PersonsManager()
	{
		string filename = $"{Environment.CurrentDirectory}\\people.json";
		if (File.Exists(filename))
		{
			string json = File.ReadAllText(filename);
			People = JsonSerializer.Deserialize<List<Person>>(json);
		}
	}
}
