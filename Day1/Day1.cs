namespace AoCYear2022.Day1;

public static class Day1
{

    public static void FindCalories()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day1/input.txt");
        var text = File.ReadAllLines(filePath);

        List<int> elfFoodCalories = new();
        var totalCalories = 0;
        foreach (var line in text)
        {
            if (line == "")
            {
                elfFoodCalories.Add(totalCalories);
                totalCalories = 0;
            }
            else
            {
                totalCalories +=  Int32.Parse(line);
            }
        }
        Console.WriteLine("the most calories is: " + elfFoodCalories.Max());
        var first = elfFoodCalories.Max();
        elfFoodCalories.Remove(first);
        var second = elfFoodCalories.Max();
        elfFoodCalories.Remove(second);
        var third = elfFoodCalories.Max();
        
        Console.WriteLine("The top three most calories: " + (first+second+third));
    }

}
