namespace LeetCode.Algorithms.FindTheStudentThatWillReplaceTheChalk;

/// <inheritdoc />
public class FindTheStudentThatWillReplaceTheChalkPrefixSum : IFindTheStudentThatWillReplaceTheChalk
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="chalk"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int ChalkReplacer(int[] chalk, int k)
    {
        var sum = 0;

        foreach (var value in chalk)
        {
            sum += value;

            if (sum > k)
            {
                break;
            }
        }

        var remainder = k % sum;

        var i = 0;

        while (remainder - chalk[i] >= 0)
        {
            remainder -= chalk[i];

            i++;
        }

        return i;
    }
}