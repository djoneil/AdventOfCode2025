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
                if(HasRepeatedDigits(i))
                {
                    duplicateCount += i;
                }
            }
        }
        
        Console.WriteLine("Count of numbers with repeated digits: " + duplicateCount);
    }

    public static bool HasRepeatedDigits(long number)
    {
        var numberStr = number.ToString();
        // Split number in half to compare both halves to see if they're identical
        var firstHalf = numberStr.Substring(0, numberStr.Length / 2);
        var secondHalf = numberStr.Substring(numberStr.Length / 2);
        if (firstHalf == secondHalf)
        {
            return true;
        }
        
        return false;
    }
}