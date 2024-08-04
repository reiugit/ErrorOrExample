using ErrorOr;

namespace ErrorOrExample.Extensions;

internal static class GlobalPrintExtensions
{
    public static T Print<T>(this T value)
    {
        Console.WriteLine(value);

        return value;
    }

    public static void PrintValue<T>(this T value)
    {
        Console.WriteLine($"Result: {value}");
    }

    public static void PrintError(this Error error)
    {
        Console.WriteLine($"Error: {error.Description}");
    }

    public static ErrorOr<T> WithTitle<T>(this ErrorOr<T> errorOr, string title)
    {
        if (title != string.Empty)
        {
            Console.WriteLine($"Using '{title}' for handling result.");
        }

        return errorOr;
    }
}
