namespace LeetCode.Core;

public class OrderInsensitiveIntArrayEqualityComparer : IEqualityComparer<int[]>
{
    private const int Seed = 13;
    private const int Multiplier = 17;

    public bool Equals(int[]? x, int[]? y)
    {
        if (x == null && y == null) return true;

        if (x == null || y == null) return false;

        return x.OrderBy(a => a).SequenceEqual(y.OrderBy(b => b));
    }

    public int GetHashCode(int[] array)
    {
        unchecked
        {
            return array.OrderBy(a => a).Aggregate(Seed, (accumulator, value) => accumulator * Multiplier + value);
        }
    }
}