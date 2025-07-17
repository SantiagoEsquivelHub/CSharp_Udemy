partial class Program
{
    static void DirectoryExample()
    {
        var directoryPath = "./05-Files";
        Directory.CreateDirectory($"{directoryPath}/DirExample");

        if (Directory.Exists($"{directoryPath}/DirExample"))
        {
            WriteLine("Directory already exists");
        }

        Directory.Delete($"{directoryPath}/DirExample");
    }
}   