public class Solution {
    public int NumberOfAlternatingGroups(int[] colors, int k) {
        var consecutives = new List<int>();
        for(int i = 1; i <= colors.Length; i++) {
            if (colors[i-1] == colors[i % colors.Length]) {
                consecutives.Add(i);
            }
        }

        if (consecutives.Count == 0) {
            return colors.Length;
        }

        var alternating = 0;
        var offset = 0;
        foreach(int consecutive in consecutives) {
            var left = consecutive - offset;
            if (left >= k)
                alternating += left+1 - k;
            offset = consecutive;
        }

        // No last to handle, return
        if (consecutives.Last() == colors.Length) {
            return alternating;
        }

        // We got all backwards, let's look forward
        var last = consecutives.Last();
        var first = consecutives.First();
        var potential = colors.Length - last;
        var withdraw = k - first - 1;
        if (potential - withdraw > 0) {
            alternating += withdraw < 0 ?
                potential : potential - withdraw;
        }
        
        return alternating;
    }
}
