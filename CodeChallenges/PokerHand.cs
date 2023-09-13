using System.Text;

namespace CodeChallenges;

// https://www.codewars.com/kata/5ae64f28d2ee274164000118/train/csharp

public class JomoPipi
{
    public string StringFunc(string str, long times)
    {
        Console.WriteLine($"Original : {str}");
        var chars = str.ToCharArray();
        var count = 1;
        while (count <= times)
        {
            chars = Reversal(chars);
            //Console.WriteLine($"{count} : {string.Join(null, chars)}");
            ++count;
        }
        //str = string.Join(null, chars);
        //Console.WriteLine($"Result : {str}");
        //return str;
        StringBuilder sb = new();
        foreach (var item in chars)
        {
            sb.Append(item);
        }
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
                (chars[start], chars[end]) = (chars[end], chars[start]);
                /*
                var temp = chars[start];
                chars[start] = chars[end];
                chars[end] = temp;
                 */
                ++start;
                --end;
            }

            //Console.WriteLine($"{round} : {string.Join(null, chars)}");
            round++;
        }
        return chars;
    }
}