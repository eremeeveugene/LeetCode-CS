using System.Text;

namespace LeetCode.Algorithms.ExcelSheetColumnTitle;

/// <inheritdoc />
public class ExcelSheetColumnTitleIterative : IExcelSheetColumnTitle
{
    /// <summary>
    ///     Time complexity - O((log n) ^ 2)
    ///     Time complexity - O(log n)
    /// </summary>
    /// <param name="columnNumber"></param>
    /// <returns></returns>
    public string ConvertToTitle(int columnNumber)
    {
        var stringBuilder = new StringBuilder();

        while (columnNumber > 0)
        {
            stringBuilder.Insert(0, (char)(((columnNumber - 1) % 26) + 'A'));

            columnNumber = (columnNumber - 1) / 26;
        }

        return stringBuilder.ToString();
    }
}