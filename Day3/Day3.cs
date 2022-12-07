namespace AoCYear2022.Day3;

public class Day3
{
    private static Dictionary<char, int> priority = new Dictionary<char, int>();
    public static void ruckSackSort()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day3/input.txt");
        var text = File.ReadAllLines(filePath);

        List<char> inBothCompartments = new();
        var priorityCount = 0;
        var count = 1;

        
        var priorityString = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        for(int i = 0; i < priorityString.Length; i++)
        {
            priority.Add(priorityString[i],count);
            count++;
        }

        
        foreach (var line in text)
        {
            List<char> alreadyFound = new();
         
            var firstCompartment = line.Substring(0, line.Length / 2);
            var secondCompartment = line.Substring(line.Length / 2, line.Length/2);

            
            foreach (var character in firstCompartment)
            {
                
                if (secondCompartment.Contains(character) && !alreadyFound.Contains(character))
                {
                    inBothCompartments.Add(character);
                    alreadyFound.Add(character);
                }
            }
            
        }

        foreach (var character in inBothCompartments)
        {
            priorityCount += priority[character];

        }

        Console.WriteLine(priorityCount);

    }


    public static void ruckSackSort2()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day3/input.txt");
        var text = File.ReadAllLines(filePath);

        List<char> inAllSacks = new();
        var priorityCount = 0;
        var count = 1;


        var priorityString = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        for (int i = 0; i < priorityString.Length; i++)
        {
            priority.Add(priorityString[i], count);
            count++;
        }

        var flag = false;
        count = 0;
        
        while (!flag)
        {
            foreach (var character in text[count])
            {
                
                if (text[count+1].Contains(character) && text[count+2].Contains(character))
                {
                    inAllSacks.Add(character);
                    break;
                }
            }

            count += 3;
            if (count + 3 > text.Length)
            {
                flag = true;
            }
        }

        foreach (var character in inAllSacks)
        {
            priorityCount += priority[character];
            Console.WriteLine(character);

        }

        Console.WriteLine(priorityCount);
    }
}