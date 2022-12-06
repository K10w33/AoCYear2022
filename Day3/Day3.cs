namespace AoCYear2022.Day3;

public class Day3
{
    private static Dictionary<string, int> priority = new Dictionary<string, int>()
    {
        {"a", 1},{"b", 2},{"c", 3},{"d", 4},{"e", 5},{"f", 6},{"g", 7},{"h", 8},{"i", 9}, {"j", 10},{"k", 11},{"l", 12},
        
    };
    public static void ruckSackSort()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day3/input.txt");
        var text = File.ReadAllLines(filePath);
        
        
        
        
        
        
        
    }
    
}