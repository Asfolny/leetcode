public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        return Enumerable.Range(0, blocks.Length - k + 1)
            .Select(i => blocks.Substring(i, k).Count(c => c == 'W'))
            .Aggregate(k+1, (acc, m) => m < acc ? m : acc);
    }
}
