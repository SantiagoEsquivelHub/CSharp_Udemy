partial class Program
{
    static void LoopGame()
    {
        int counter = 0;

        WriteLine("Press any key to increase the counter");
        WriteLine("Press ESC to exit.\n");

        while (true)
        {
            var key = ReadKey(true).Key;

            if (key == ConsoleKey.Escape)
            {
                WriteLine($"You've been pressed {counter} the keys before leave");
                WriteLine("Program has finished");
                break;
            }
            counter++;
        }

    }
}