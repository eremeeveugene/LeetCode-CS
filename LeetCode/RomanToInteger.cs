namespace LeetCode;

public static class RomanToInteger
{
    public static int GetResult(string romanString)
    {
        var result = 0;

        var romanSymbols = RomanSymbolsParser.ParseRomanStringToSymbols(romanString);

        for (var i = 0; i < romanSymbols.Count; i++)
        {
            result += RomanSymbolsValidator.ValidateRules(romanSymbols.ElementAt(i), romanSymbols.ElementAtOrDefault(i + 1), ref i);
        }


        return result;
    }

    public static class RomanSymbolsValidator
    {
        public static int ValidateRules(RomanNumeral current, RomanNumeral? next, ref int i)
        {
            if (next != null)
            {
                if (current.Symbol.Equals(RomanSymbols.I) && next.Symbol.Equals(RomanSymbols.V))
                {
                    i++;
                    return 4;
                }

                if (current.Symbol.Equals(RomanSymbols.I) && next.Symbol.Equals(RomanSymbols.X))
                {
                    i++;
                    return 9;
                }

                if (current.Symbol.Equals(RomanSymbols.X) && next.Symbol.Equals(RomanSymbols.L))
                {
                    i++;
                    return 40;
                }

                if (current.Symbol.Equals(RomanSymbols.X) && next.Symbol.Equals(RomanSymbols.C))
                {
                    i++;
                    return 90;
                }

                if (current.Symbol.Equals(RomanSymbols.C) && next.Symbol.Equals(RomanSymbols.D))
                {
                    i++;
                    return 400;
                }

                if (current.Symbol.Equals(RomanSymbols.C) && next.Symbol.Equals(RomanSymbols.M))
                {
                    i++;
                    return 900;
                }
            }

            return current.Value;
        }
    }

    public static class RomanSymbolsParser
    {
        public static List<RomanNumeral> ParseRomanStringToSymbols(string romanString)
        {
            return romanString
                .Select(romanChar => RomanNumeralsHelper.RomanNumerals.First(s => s.Symbol.Char.Equals(romanChar)))
                .ToList();
        }
    }

    public class RomanNumeralsHelper
    {
        private static List<RomanNumeral>? _romanNumerals;

        public static List<RomanNumeral> RomanNumerals => _romanNumerals ??= GetRomanNumerals();

        private static List<RomanNumeral> GetRomanNumerals()
        {
            return new List<RomanNumeral>
            {
                new(RomanSymbols.I, 1),
                new(RomanSymbols.V, 5),
                new(RomanSymbols.X, 10),
                new(RomanSymbols.L, 50),
                new(RomanSymbols.C, 100),
                new(RomanSymbols.D, 500),
                new(RomanSymbols.M, 1000)
            };
        }
    }

    public class RomanNumeral
    {
        public RomanNumeral(RomanSymbol symbol, int value)
        {
            Symbol = symbol;
            Value = value;
        }

        public RomanSymbol Symbol { get; }
        public int Value { get; }
    }

    public static class RomanChars
    {
        public const char I = 'I';
        public const char V = 'V';
        public const char X = 'X';
        public const char L = 'L';
        public const char C = 'C';
        public const char D = 'D';
        public const char M = 'M';
    }

    public static class RomanSymbols
    {
        public static RomanSymbol I => new(RomanChars.I);
        public static RomanSymbol V => new(RomanChars.V);
        public static RomanSymbol X => new(RomanChars.X);
        public static RomanSymbol L => new(RomanChars.L);
        public static RomanSymbol C => new(RomanChars.C);
        public static RomanSymbol D => new(RomanChars.D);
        public static RomanSymbol M => new(RomanChars.M);

        //private static List<RomanSymbol> GetRomanSymbols()
        //{
        //    return new List<RomanSymbol>
        //    {
        //        new(I),
        //        new(V),
        //        new(X),
        //        new(L),
        //        new(C),
        //        new(D),
        //        new(M)
        //    };
        //}
    }

    public class RomanSymbol
    {
        public RomanSymbol(char @char)
        {
            Char = @char;
        }

        public char Char { get; }

        public override bool Equals(object? obj)
        {
            if (obj is RomanSymbol romanSymbol)
            {
                return Equals(romanSymbol);
            }

            return base.Equals(obj);
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
}