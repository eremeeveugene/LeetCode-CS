namespace LeetCode.RomanToIntegerTask;

internal class RomanSymbol
{
    public RomanSymbol(char @char)
    {
        Char = @char;
    }

    public char Char { get; }

    public static RomanSymbol I => new(RomanChars.I);
    public static RomanSymbol V => new(RomanChars.V);
    public static RomanSymbol X => new(RomanChars.X);
    public static RomanSymbol L => new(RomanChars.L);
    public static RomanSymbol C => new(RomanChars.C);
    public static RomanSymbol D => new(RomanChars.D);
    public static RomanSymbol M => new(RomanChars.M);

    public override string ToString()
    {
        return Char.ToString();
    }

    public override bool Equals(object? @object)
    {
        if (@object is RomanSymbol romanSymbol) return Equals(romanSymbol);

        return Equals(this, @object);
    }

    protected bool Equals(RomanSymbol romanSymbol)
    {
        return Char == romanSymbol.Char;
    }

    public override int GetHashCode()
    {
        return Char.GetHashCode();
    }
}