<Query Kind="Program" />

// https://www.codewars.com/kata/5ae64f28d2ee274164000118/train/csharp

void Main()
{
	Console.WriteLine($"{Test("String", 3) == "nrtgSi"}{Environment.NewLine}"); 	
	Console.WriteLine($"{Test("This is a string exemplification!", 0) == "This is a string exemplification!"}{Environment.NewLine}");
	Console.WriteLine($"{Test("Ohh Man God Damn", 7) == " nGOnmohaadhMD  "}{Environment.NewLine}");
	Console.WriteLine($"{Test("Ohh Man God Damnn", 19) == "haG mnad MhO noDn"}{Environment.NewLine}");
}

private string Test(string str, int times)
{
	Console.WriteLine($"Original : {str}");
	var chars = str.ToCharArray();
	int count = 1;
	long iterationsRequired =  times % calculateCycleLength(str.Length);
	while (count <= iterationsRequired)
	{
		chars = Reversal(chars);
		//Console.WriteLine($"{count} : {string.Join(null, chars)}");
		++count;
	}
	//str = string.Join(null, chars);
	StringBuilder sb = new();
	foreach (var item in chars)
	{
		sb.Append(item);
	}
	Console.WriteLine($"Result : {sb.ToString()}");
	return sb.ToString();
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


private static int calculateCycleLength(int n)
{
	// Cache these so we only calculate them once.
	int a = 2 * n + 1;
	int b = 2 * n;

	int cycleLength = 1;
	while (true)
	{
		double c = Math.Pow(2, cycleLength);
		if (c % a == 1 || c % a == b)
		{
			return cycleLength;
		}
		cycleLength++;
	}
}