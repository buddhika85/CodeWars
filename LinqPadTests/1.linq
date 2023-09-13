<Query Kind="Program" />

// https://www.codewars.com/kata/5ae64f28d2ee274164000118/train/csharp

void Main()
{
	Test("String", 3);	
}

private void Test(string str, int times)
{
	Console.WriteLine($"Original : {str}");
	var chars = str.ToCharArray();
	int count = 1;
	while (count <= times)
	{
		chars = Reversal(chars);
		Console.WriteLine($"{count} : {string.Join(null, chars)}");
		++count;
	}	
	Console.WriteLine($"Result : {string.Join(null, chars)}");
}

private char[] Reversal(char[] chars)
{	
	chars = chars.Reverse().ToArray();
	//Console.WriteLine($"Reverse : {string.Join(null, chars)}");

	var round = 1;

	while (round < chars.Length - 1)
	{
		var start = round;
		var end = chars.Length - 1;

		while (start < end)
		{
			var temp = chars[start];
			chars[start] = chars[end];
			chars[end] = temp;
			++start;
			--end;
		}

		//Console.WriteLine($"{round} : {string.Join(null, chars)}");
		round++;
	}	
	return chars;
}