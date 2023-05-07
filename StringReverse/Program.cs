Console.WriteLine("type your string");
string input = Console.ReadLine();
char[] strArray = input.ToCharArray();
Array.Reverse(strArray);
string reversedStrng = new string (strArray);
Console.WriteLine(reversedStrng);