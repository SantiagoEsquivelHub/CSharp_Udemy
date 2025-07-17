partial class Program
{
    static void WriteFileExample()
    {
        var filePath = "./05-Files/WriteFileExample.txt";
        var content = "Hello";
        var streamWriter = new StreamWriter(filePath, append: true);
        streamWriter.WriteLine(content);
        streamWriter.WriteLine("The current datetime is: " + DateTime.Now.ToString("HH:mm:ss"));
        streamWriter.Dispose();
        WriteLine("File successfully created!");
    }
}   