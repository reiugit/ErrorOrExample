using ErrorOr;

namespace ErrorOrExample;

internal class Divider
{
    private Divider(double dividend, double divisor)
    {
        Dividend = dividend;
        Divisor = divisor;
    }

    public double Dividend { get; }
    public double Divisor { get; }

    public static Divider Create(double dividend, double divisor)
        => new(dividend, divisor);

    public ErrorOr<double> Divide()
    {
        return Divisor != 0
            ? Dividend / Divisor
            : Error.Unexpected("DivisionByZero", "Cannot divide by zero.");
    }
}
