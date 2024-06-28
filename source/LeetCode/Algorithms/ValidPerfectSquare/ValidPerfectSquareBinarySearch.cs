namespace LeetCode.Algorithms.ValidPerfectSquare;

/// <inheritdoc />
public class ValidPerfectSquareBinarySearch : IValidPerfectSquare
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public bool IsPerfectSquare(int num)
    {
        long left = 1;
        long right = num;

        while (left <= right)
        {
            var mid = left + ((right - left) / 2);

            var sqrt = mid * mid;

            if (sqrt == num)
            {
                return true;
            }

            if (sqrt < num)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
    }
}