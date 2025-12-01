namespace AdventOfCode2025.DayOne;

public class Puzzle1
{
    public static void PartOne()
    {
        var commands = File.ReadAllLines("C:\\Users\\danon\\RiderProjects\\AdventOfCode2025\\AdventOfCode2025\\AdventOfCode2025\\DayOne\\user_input")
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
        var commands = File.ReadAllLines("C:\\Users\\danon\\RiderProjects\\AdventOfCode2025\\AdventOfCode2025\\AdventOfCode2025\\DayOne\\user_input")
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