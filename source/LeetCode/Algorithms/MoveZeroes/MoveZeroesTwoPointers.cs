namespace LeetCode.Algorithms.MoveZeroes;

/// <inheritdoc />
public class MoveZeroesTwoPointers : IMoveZeroes
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    public void MoveZeroes(int[] nums)
    {
        var left = 0;

        for (var right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
            {
                continue;
            }

            (nums[right], nums[left]) = (nums[left], nums[right]);

            left++;
        }
    }
}