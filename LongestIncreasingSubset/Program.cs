
using LongestIncreasingService;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter integers separated by single whitespace:");
        string? input = Console.ReadLine();

        ILongestIncreasingService lisService = new LongestIncreasingServiceClass();

        var result = lisService.GetLongestIncreasingSubsequence(input ?? string.Empty);

        Console.WriteLine("Longest Increasing Subsequence:");
        Console.WriteLine(string.Join(" ", result)); 
    }
}
