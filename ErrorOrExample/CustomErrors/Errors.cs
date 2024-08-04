using ErrorOr;

namespace ErrorOrExample.CustomErrors;

internal static class Errors
{
    public static Error DivisionByZeroError = Error.Unexpected(
        code: "DivisionByZero",
        description: "Division by zero is not allowed.");
}
