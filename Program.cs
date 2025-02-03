class DefenseOfConsolas
{
    static void Main()
    {
        System.Console.Title = "Defense of Consolas";

        //Ask for user input
        System.Console.Write("Target Row? ");
        int targetRow = Convert.ToInt32(System.Console.ReadLine());

        System.Console.Write("Target Column? ");
        int targetColumn = Convert.ToInt32(System.Console.ReadLine());

        // the computng of four locations
        int left = targetColumn - 1;
        int right = targetColumn + 1;
        int up = targetRow - 1;
        int down = targetRow + 1;

        
        //outputing deployment instructions
        System.Console.WriteLine("Deploy to:");
        System.Console.WriteLine($"({targetRow}, {left})");
        System.Console.WriteLine($"({up}, {targetColumn})");
        System.Console.WriteLine($"({targetRow}, {right})");
        System.Console.WriteLine($"({down}, {targetColumn})");

        
    }
}
