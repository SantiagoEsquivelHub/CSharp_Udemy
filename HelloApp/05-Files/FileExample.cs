partial class Program
{
    static void FileExample()
    {
        string filePath = "./05-Files/Example.txt";
        var content = File.ReadAllText(filePath);
        // WriteLine(content);

        var lines = File.ReadAllLines(filePath);

        foreach (var line in lines)
        {
            WriteLine(line);
        }
        WriteLine(lines[1]);

        File.Copy(filePath, "./05-Files/CopyExample.txt", overwrite: true);
        File.Delete("./05-Files/CopyExample.txt");
    }
}