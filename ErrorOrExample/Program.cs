using ErrorOr;
using ErrorOrExample;
using ErrorOrExample.Extensions;
using ErrorOrExample.Keyhandler;

Func<double, double, ErrorOr<double>> divisionUsingErrorOr = (dividend, divisor) =>
    Divider
        .Create(dividend, divisor)
        .PrintNumbers()
        .Divide()
        .ThenDo(x => Console.WriteLine("Division was successfull."))
        .ThenDo(x => Console.WriteLine("Now checking for negative number."))
        .FailIf(x => x < 0, Error.Validation("NegativeNumber", "Result was a negative number."))
        .ThenDo(x => Console.WriteLine("Number is positive."));

//1. MatchFirst example
divisionUsingErrorOr(6, 3)
    .WithTitle("MatchFirst")
    .MatchFirst(
           value => $"Result: {value}",
           error => $"Error: {error.Description}")
    .Print();

//2. SwitchFirst example with negative number
divisionUsingErrorOr(-6, 2)
    .WithTitle("SwitchFirst")
    .SwitchFirst(
        value => value.PrintValue(),
        error => error.PrintError());

//3. SwitchFirst example with error
divisionUsingErrorOr(4, 0)
    .WithTitle("SwitchFirst")
    .SwitchFirst(
        value => value.PrintValue(),
        error => error.PrintError());


KeyHandler.WaitForKey();
