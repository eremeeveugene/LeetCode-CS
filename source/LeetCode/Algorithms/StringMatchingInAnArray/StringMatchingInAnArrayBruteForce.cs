namespace LeetCode.Algorithms.StringMatchingInAnArray;

/// <inheritdoc />
public class StringMatchingInAnArrayBruteForce : IStringMatchingInAnArray
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="words"></param>
    /// <returns></returns>
    public IList<string> StringMatching(string[] words)
    {
        return words.Where((t1, i) => words.Where((t, j) => i != j && t.Contains(t1)).Any()).ToArray();
    }
}