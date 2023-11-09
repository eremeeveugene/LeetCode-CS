namespace LeetCode.Algorithms.RemoveElementTask;

public static class RemoveElement
{
    public static int GetResult(int[] nums, int val)
    {
        for (var k = 0; k < nums.Length; k++)
        for (var i = 0; i < nums.Length; i++)
            if (nums[i] == val)
                for (var j = i; j < nums.Length - 1; j++)
                    (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);

        return nums.Count(num => !num.Equals(val));
    }
}