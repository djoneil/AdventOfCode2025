using System.Text;

namespace AdventOfCode2025.DayTwo;

public class Puzzle2
{
    public static void PartOne()
    {
        // Implementation for Day Two, Part One
        var filePath = Path.Combine("DayTwo", "user_input");
        var file = File.ReadAllLines(filePath)
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .ToList();

        var ranges = file.SelectMany(x => x.Split(','));

        long duplicateCount = 0;

        foreach (var range in ranges)
        {
            long firstId = long.Parse(range.Split("-")[0]);
            long lastId = long.Parse(range.Split("-")[1]);

            for (var i = firstId; i <= lastId; i++)
            {
                if (HasRepeatedDigits(i.ToString()))
                {
                    duplicateCount += i;
                }
            }
        }

        Console.WriteLine("Count of numbers with repeated digits: " + duplicateCount);
    }

    public static bool HasRepeatedDigits(string number)
    {
        // Split number in half to compare both halves to see if they're identical
        var len = number.Length;

        for (var blockLength = 1; blockLength <= len / 2; blockLength++)
        {
            if (len % blockLength != 0)
            {
                continue;
            }

            var block = number.Substring(0, blockLength);
            int repeats = len / blockLength;

            StringBuilder sb = new StringBuilder(len);
            for (var i = 0; i < repeats; i++)
            {
                sb.Append(block);
            }

            if (sb.ToString() == number)
            {
                return true;
            }
        }

        return false;
    }
}