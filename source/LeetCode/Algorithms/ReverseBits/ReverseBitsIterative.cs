namespace LeetCode.Algorithms.ReverseBits;

/// <inheritdoc />
public class ReverseBitsIterative : IReverseBits
{
    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public uint reverseBits(uint n)
    {
        uint result = 0;

        for (var i = 0; i < 32; i++)
        {
            result = (result << 1) | (n & 1);

            n >>= 1;
        }

        return result;
    }
}