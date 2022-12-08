namespace AoCYear2022.Day4;

public class Day4
{

    public static void cleanUp()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day4/input.txt");
        var text = File.ReadAllLines(filePath);

        var fullyConsumedCount = 0;
        var count = 0;
        
        foreach (var line in text)
        {
            var pairs = line.Split(",");
            var firstPair = pairs[0].Split("-");
            var secondPair = pairs[1].Split("-");
            
            List<int> first = new();
            List<int> second = new();

            count = Convert.ToInt16(firstPair[0]);
            while (count <= Convert.ToInt16(firstPair[1]))
            {
                first.Add(count);
                count++;
            }
            
            count = Convert.ToInt16(secondPair[0]);
            while (count <= Convert.ToInt16(secondPair[1]))
            {
                second.Add(count);
                count++;
            }

            var containsFlag1 = true;
            var containsFlag2 = true;
            foreach (var number in first)
            {
                if (!second.Contains(number))
                {
                    containsFlag1 = false;
                }
            }
            foreach (var number in second)
            {
                if (!first.Contains(number))
                {
                    containsFlag2 = false;
                }
            }

            if (containsFlag1 || containsFlag2)
            {
                fullyConsumedCount += 1;
            }

        }

        Console.WriteLine(fullyConsumedCount);
    }
    
    
    public static void cleanUp2()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day4/input.txt");
        var text = File.ReadAllLines(filePath);

        var overlapCount = 0;
        var count = 0;
        
        foreach (var line in text)
        {
            var pairs = line.Split(",");
            var firstPair = pairs[0].Split("-");
            var secondPair = pairs[1].Split("-");
            
            List<int> first = new();
            List<int> second = new();

            count = Convert.ToInt16(firstPair[0]);
            while (count <= Convert.ToInt16(firstPair[1]))
            {
                first.Add(count);
                count++;
            }
            
            count = Convert.ToInt16(secondPair[0]);
            while (count <= Convert.ToInt16(secondPair[1]))
            {
                second.Add(count);
                count++;
            }

            var containsFlag1 = false;
            var containsFlag2 = false;
            foreach (var number in first)
            {
                if (second.Contains(number))
                {
                    containsFlag1 = true;
                }
            }
            foreach (var number in second)
            {
                if (first.Contains(number))
                {
                    containsFlag2 = true;
                }
            }

            if (containsFlag1 || containsFlag2)
            {
                overlapCount += 1;
            }

        }

        Console.WriteLine(overlapCount);
    }
}