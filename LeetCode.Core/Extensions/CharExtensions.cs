namespace LeetCode.Core.Extensions;

public static class CharExtensions
{
    public static int ToInt(this char @char)
    {
        return 0b0000_1111 & (byte)@char;
    }
}