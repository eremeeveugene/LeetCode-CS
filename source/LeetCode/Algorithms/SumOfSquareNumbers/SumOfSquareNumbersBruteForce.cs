namespace LeetCode.Algorithms.SumOfSquareNumbers;

/// <inheritdoc />
public class SumOfSquareNumbersBruteForce : ISumOfSquareNumbers
{
    /// <summary>
    ///     Time complexity - O(c)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="c"></param>
    /// <returns></returns>
    public bool JudgeSquareSum(int c)
    {
        for (long a = 0; a * a <= c; a++)
        {
            for (long b = 0; b * b <= c; b++)
            {
                if ((a * a) + (b * b) == c)
                {
                    return true;
                }
            }
        }

        return false;
    }
}