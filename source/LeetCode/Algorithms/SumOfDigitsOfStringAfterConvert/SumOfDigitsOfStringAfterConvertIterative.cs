namespace LeetCode.Algorithms.SumOfDigitsOfStringAfterConvert;

/// <inheritdoc />
public class SumOfDigitsOfStringAfterConvertIterative : ISumOfDigitsOfStringAfterConvert
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int GetLucky(string s, int k)
    {
        var sum = 0;

        foreach (var c in s)
        {
            var number = c - 'a' + 1;

            while (number > 0)
            {
                sum += number % 10;

                number /= 10;
            }
        }

        while (k > 1)
        {
            var currentSum = 0;

            while (sum > 0)
            {
                currentSum += sum % 10;

                sum /= 10;
            }

            sum = currentSum;

            k--;
        }

        return sum;
    }
}