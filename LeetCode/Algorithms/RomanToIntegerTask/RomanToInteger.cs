namespace LeetCode.Algorithms.RomanToIntegerTask;

public static class RomanToInteger
{
    public static int GetResult(string romanString)
    {
        var romanNumerals = new List<RomanNumeral>();

        for (var i = 0; i < romanString.Length; i++)
        {
            var currentChar = romanString.ElementAt(i);
            var nextChar = romanString.ElementAtOrDefault(i + 1);

            var subtractiveRomanNumeral = SubtractiveRomanNumeral.SubtractiveRomanNumerals.FirstOrDefault(
                s => s.Symbol.Char.Equals(currentChar) && s.SecondSymbol.Char.Equals(nextChar));

            if (subtractiveRomanNumeral != null)
            {
                romanNumerals.Add(subtractiveRomanNumeral);
                i++;
            }
            else
            {
                romanNumerals.Add(RomanNumeral.RomanNumerals.First(s => s.Symbol.Char.Equals(currentChar)));
            }
        }

        return romanNumerals.Sum(romanNumeral => romanNumeral.Value);
    }
}