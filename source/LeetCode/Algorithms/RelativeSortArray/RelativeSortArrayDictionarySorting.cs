namespace LeetCode.Algorithms.RelativeSortArray;

/// <inheritdoc />
public class RelativeSortArrayDictionarySorting : IRelativeSortArray
{
    /// <summary>
    ///     Time complexity - O(m + n log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="arr1"></param>
    /// <param name="arr2"></param>
    /// <returns></returns>
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        var result = new List<int>();
        var remainingItems = new List<int>();

        var countDictionary = arr2.ToDictionary(arr2Item => arr2Item, _ => 0);

        foreach (var arr1Item in arr1)
        {
            if (countDictionary.TryGetValue(arr1Item, out var value))
            {
                countDictionary[arr1Item] = ++value;
            }
            else
            {
                remainingItems.Add(arr1Item);
            }
        }

        foreach (var arr2Item in arr2)
        {
            result.AddRange(Enumerable.Repeat(arr2Item, countDictionary[arr2Item]));
        }

        remainingItems.Sort();

        result.AddRange(remainingItems);

        return [.. result];
    }
}