namespace AoCYear2022.Day2;

public class Day2
{
    private static int totalPoints = 0;
    public static void ticTacToe()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day2/input.txt");
        var text = File.ReadAllLines(filePath);

        var theirMove = "0";
        var myMove = "0";
        
        foreach (var game in text)
        {

            theirMove = game.Split(" ")[0];
            myMove = game.Split(" ")[1];

            switch (theirMove)
            {
                case "A":
                    switch (myMove)
                    {
                        case"X": //draw
                            totalPoints += 1 + 3;
                            break;
                        case "Y": //win
                            totalPoints += 2 + 6;
                            break;
                        case "Z": //loose
                            totalPoints += 3 + 0;
                            break;
                    }
                    break;
                case "B":
                    switch (myMove)
                    {
                        case"X": //loose
                            totalPoints += 1 + 0;
                            break;
                        case "Y": //draw
                            totalPoints += 2 + 3;
                            break;
                        case "Z": //win
                            totalPoints += 3 + 6;
                            break;
                    }
                    break;
                case "C":
                    switch (myMove)
                    {
                        case"X": //win
                            totalPoints += 1 + 6;
                            break;
                        case "Y": //loose
                            totalPoints += 2 + 0;
                            break;
                        case "Z": //draw
                            totalPoints += 3 + 3;
                            break;
                    }
                    break;
            }

        }
        
        Console.WriteLine(totalPoints);
        
    }
    public static void ticTacToe2()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day2/input.txt");
        var text = File.ReadAllLines(filePath);

        var theirMove = "0";
        var myStrategy = "0";
        
        foreach (var game in text)
        {

            theirMove = game.Split(" ")[0];
            myStrategy = game.Split(" ")[1];
            var rock = 1;
            var paper = 2;
            var scissors = 3;

            switch (theirMove)
            {
                case "A": //rock
                    switch (myStrategy)
                    {
                        case"X": //loose
                            totalPoints += scissors + 0;
                            break;
                        case "Y": //draw
                            totalPoints += rock + 3;
                            break;
                        case "Z": //win
                            totalPoints += paper + 6;
                            break;
                    }
                    break;
                case "B": //paper
                    switch (myStrategy)
                    {
                        case"X": //loose
                            totalPoints += rock + 0;
                            break;
                        case "Y": //draw
                            totalPoints += paper + 3;
                            break;
                        case "Z": //win
                            totalPoints += scissors + 6;
                            break;
                    }
                    break;
                case "C": //scissors
                    switch (myStrategy)
                    {
                        case"X": //loose
                            totalPoints += paper + 0;
                            break;
                        case "Y": //draw
                            totalPoints += scissors + 3;
                            break;
                        case "Z": //win
                            totalPoints += rock + 6;
                            break;
                    }
                    break;
            }

        }
        
        Console.WriteLine(totalPoints);
        
    }
}