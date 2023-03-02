void repeat (string word , int count)
{
	string cavab = "";
	for (int i = 0; i < count; i++)
	{
		cavab += word;
	}
	Console.WriteLine (cavab);
}
repeat(" salam ", 5);