namespace AoCYear2022.Day6;

public class Day6
{

    public static void findMarker()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day6/input.txt");
        var text = File.ReadAllText(filePath);

        var marker = 0;
        var markerFound = false;

        var first = '0';
        var second = '0';
        var third = '0';
        var potentialMarker = '0';
        
        var index = 0;

        while (!markerFound)
        {
            first = text[index];
            second = text[index + 1];
            third = text[index + 2];
            potentialMarker = text[index + 3];
            if (potentialMarker != first && potentialMarker != second && potentialMarker != third && first != second && second != third && first != third)
            {
                markerFound = true;
                marker = index + 4;
            }
            index++;
        }

        Console.WriteLine(marker);

    }

    public static void findMarker2()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day6/input.txt");
        var text = File.ReadAllText(filePath);

        var marker = 0;
        var markerFound = false;
        
        List<char> characters = new();
        
        var index = 0;
        
        while (!markerFound)
        {
            for (int i = 0; i < 14; i++)
            {
                characters.Add(text[index+i]);
                
            }
            
            int uniqueCharacters = characters.Distinct().Count();
            
            
            if (uniqueCharacters == characters.Count())
            {
                markerFound = true;
                marker = index + 14;
            }
            
            for (int i = 0; i < 14; i++)
            {
                characters.Remove(text[index+i]);
                
            }
            
            index++;

        }

        
        
        Console.WriteLine(marker);
    }
}