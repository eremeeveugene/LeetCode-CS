namespace LeetCode.Algorithms.ThreeConsecutiveOdds;

/// <inheritdoc />
public class ThreeConsecutiveOddsCounting : IThreeConsecutiveOdds
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        var count = 0;

        foreach (var item in arr)
        {
            if (item % 2 == 0)
            {
                count = 0;
            }
            else
            {
                count++;

                if (count == 3)
                {
                    return true;
                }
            }
        }

        return false;
    }
}