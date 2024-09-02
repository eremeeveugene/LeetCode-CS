namespace LeetCode.Algorithms.FindTheStudentThatWillReplaceTheChalk;

/// <inheritdoc />
public class FindTheStudentThatWillReplaceTheChalkBinarySearch : IFindTheStudentThatWillReplaceTheChalk
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="chalk"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int ChalkReplacer(int[] chalk, int k)
    {
        var prefixSum = new long[chalk.Length];

        prefixSum[0] = chalk[0];

        for (var i = 1; i < prefixSum.Length; i++)
        {
            prefixSum[i] = prefixSum[i - 1] + chalk[i];
        }

        return GetStudentIndex(prefixSum, k % prefixSum[^1]);
    }

    private static int GetStudentIndex(long[] arr, long remainder)
    {
        var left = 0;
        var right = arr.Length - 1;

        while (left < right)
        {
            var mid = left + ((right - left) / 2);

            if (arr[mid] <= remainder)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return right;
    }
}