namespace PathConverter;

internal class Program
{
    private static void Main(string[] args)
    {
        foreach (string path in args) {
            Console.WriteLine(ConvertPath(path));
        }
    }

    private static string ConvertPath(string path) {
        path = path.Replace(@"/mnt/c/", @"C:\\").Replace(@"/", @"\\");
        return path;
    }
}