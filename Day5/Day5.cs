namespace AoCYear2022.Day5;

public class Day5
{
    public static List<Stack<char>> myStacks = new();
    public static void cargoCrane()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day5/input.txt");
        var text = File.ReadAllLines(filePath);
        
        List<int> topCrates = new();
        
        
        char[] arr1 = new char[]{'F', 'C', 'F', 'P', 'H', 'T', 'W' };
        Stack<char> stack1 = new Stack<char>(arr1);
 
        char[] arr2 = new char[]{'G', 'R', 'V', 'F', 'Z', 'J', 'B', 'H' };
        Stack<char> stack2 = new Stack<char>(arr2);

        char[] arr3 = new char[]{'H', 'P', 'T', 'R' };
        Stack<char> stack3 = new Stack<char>(arr3);
        
        char[] arr4 = new char[]{'Z', 'S', 'N', 'P', 'H', 'T' };
        Stack<char> stack4 = new Stack<char>(arr4);
        
        char[] arr5 = new char[]{'N', 'V', 'F', 'Z', 'H', 'J', 'C', 'D' };
        Stack<char> stack5 = new Stack<char>(arr5);
        
        char[] arr6 = new char[]{'P', 'M', 'G', 'F', 'W', 'D', 'Z' };
        Stack<char> stack6 = new Stack<char>(arr6);
        
        char[] arr7 = new char[]{'M', 'V', 'Z', 'W', 'S', 'J', 'D', 'P' };
        Stack<char> stack7 = new Stack<char>(arr7);
        
        char[] arr8 = new char[]{'N', 'D', 'S' };
        Stack<char> stack8 = new Stack<char>(arr8);
        
        char[] arr9 = new char[]{'D', 'Z', 'S', 'F', 'M' };
        Stack<char> stack9 = new Stack<char>(arr9);

        myStacks.Add(stack1); //index 0 
        myStacks.Add(stack1);
        myStacks.Add(stack2);
        myStacks.Add(stack3);
        myStacks.Add(stack4);
        myStacks.Add(stack5);
        myStacks.Add(stack6);
        myStacks.Add(stack7);
        myStacks.Add(stack8);
        myStacks.Add(stack9);
        
        
        foreach (var line in text)
        {
            var instruction = line.Split(" ");

            moveCrates9001(Convert.ToInt16(instruction[1]), Convert.ToInt16(instruction[3]), Convert.ToInt16(instruction[5]));

        }
        
        Console.WriteLine(myStacks[1].Pop());
        Console.WriteLine(myStacks[2].Pop());
        Console.WriteLine(myStacks[3].Pop());
        Console.WriteLine(myStacks[4].Pop());
        Console.WriteLine(myStacks[5].Pop());
        Console.WriteLine(myStacks[6].Pop());
        Console.WriteLine(myStacks[7].Pop());
        Console.WriteLine(myStacks[8].Pop());
        Console.WriteLine(myStacks[9].Pop());
        
    }

    public static void moveCrates(int crates, int from, int to)
    {
        var crate = new char();
        for (int i = 0; i < crates; i++)
        {
            crate = myStacks[from].Pop();
            myStacks[to].Push(crate);
        }
    }
    
    public static void moveCrates9001(int crates, int from, int to)
    {
        List<char> cratesToMove = new();
        for (int i = 0; i < crates; i++)
        {
            cratesToMove.Add(myStacks[from].Pop());
        }

        for (int i = cratesToMove.Count - 1; i >= 0; i--)
        {
            myStacks[to].Push(cratesToMove[i]);
        }
    }
}