


//do
//{
//	string[] names = new string[] { "David", "John", "Karolina" };

//	Console.WriteLine("Select a number between 1 and 3");
//	string userSelectedNumberText = Console.ReadLine();


//	int.TryParse(userSelectedNumberText, out int userSelectedNumber);
//	if (userSelectedNumber > 3 || userSelectedNumber < 1)
//	{
//		Console.WriteLine("Out of bounds, try again");
//	}
//	else
//	{
//		Console.WriteLine($"{names[userSelectedNumber]} is the name associated to your chosen number");
//		Console.WriteLine("type exit to leave application or enter to try again");
//	}



//} while (Console.ReadLine().ToLower() != "exit");
List<string> students = new List<string>();
string studentName = string.Empty;
do
{

	Console.WriteLine("enter student name to add to class roster, \n" +
		"Or type 'done' when you are finished.");
	studentName = Console.ReadLine();
	students.Add(studentName);
	Console.WriteLine();

} while (studentName != "done");


Console.WriteLine($"There are currently {students.Count} students in the class");
