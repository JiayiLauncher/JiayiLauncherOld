namespace JiayiLauncher;

internal static class Program
{
    public static CApp App = new();
    private static void Main(string[] args)
    {
        App.OnExecute();
    }
}