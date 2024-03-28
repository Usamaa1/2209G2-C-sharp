// See https://aka.ms/new-console-template for more information
using System.Net;

Console.WriteLine("Hello, World!");



Console.WriteLine("Enter your URL: ");
string text = Console.ReadLine();


Console.WriteLine("Enter your file Name here: ");
string fileName = Console.ReadLine();



WebClient client = new WebClient();
string reply = client.DownloadString(text);


// Set a variable to the Documents path.
string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

string completePath = Path.Combine(docPath, "scrapper");

// Write the text to a new file named "WriteFile.txt".
File.WriteAllText(Path.Combine(completePath, fileName), reply);


