namespace ErrorOrExample.Keyhandler;

internal static class KeyHandler
{
    public static void WaitForKey()
    {
        Console.WriteLine("\n\nPress any key to exit...");

        Console.ReadKey();
    }
}
