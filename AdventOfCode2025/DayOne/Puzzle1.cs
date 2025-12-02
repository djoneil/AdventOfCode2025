namespace AdventOfCode2025.DayOne;

public class Puzzle1
{
    public static void PartOne()
    {
        var filePath = Path.Combine("DayOne", "user_input");
        var commands = File.ReadAllLines(filePath)
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .ToList();

        var dial = new LinkedList<int>(Enumerable.Range(0, 100));
        var current = dial.Find(50);

        var countOfZeroes = 0;

        foreach (var cmd in commands)
        {
            char direction = cmd[0];
            int steps = int.Parse(cmd.Substring(1));

            for (int i = 0; i < steps; i++)
            {
                if (direction == 'R')
                {
                    current = current.Next ?? dial.First;
                }
                else if (direction == 'L')
                {
                    current = current.Previous ?? dial.Last;
                }
            }

            if (current.Value == 0)
            {
                countOfZeroes++;
            }
        }

        Console.WriteLine("Password is; " + countOfZeroes);
    }

    public static void PartTwo()
    {
        var filePath = Path.Combine("DayOne", "user_input");
        var commands = File.ReadAllLines(filePath)
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .ToList();

        var dial = new LinkedList<int>(Enumerable.Range(0, 100));
        var current = dial.Find(50);

        var countOfZeroes = 0;

        foreach (var cmd in commands)
        {
            char direction = cmd[0];
            int steps = int.Parse(cmd.Substring(1));

            for (int i = 0; i < steps; i++)
            {
                if (direction == 'R')
                {
                    current = current.Next ?? dial.First;
                }
                else if (direction == 'L')
                {
                    current = current.Previous ?? dial.Last;
                }

                if (current.Value == 0)
                {
                    countOfZeroes++;
                }
            }
        }

        Console.WriteLine("Password (method 0x434C49434B) is; " + countOfZeroes);
    }
}