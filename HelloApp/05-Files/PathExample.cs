partial class Program
{
    static void PathExample()
    {
        var filePath = "./05-Files/Example.txt";
        WriteLine($"filePath: {filePath}");
        var fileName = Path.GetFileName(filePath);
        WriteLine($"fileName: {fileName}");
        var fileExtention = Path.GetExtension(filePath);
        WriteLine($"fileExtention: {fileExtention}");
        var directoryName = Path.GetDirectoryName(filePath);
        WriteLine($"directoryName: {directoryName}");
        var combinedPath = Path.Combine("C:", "User", "Documents", "Example.txt");
        WriteLine($"combinedPath: {combinedPath}");
        var fullFilePath = Path.GetFullPath(filePath);
        WriteLine($"fullFilePath: {fullFilePath}");

    }
}   