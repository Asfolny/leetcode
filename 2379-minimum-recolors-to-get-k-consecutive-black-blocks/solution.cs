public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        var moves = k+1;

        for(int i = 0; i <= blocks.Length-k; i++) {
            var part = blocks.Substring(i, k);
            var needed = part.Count((c) => c == 'W');

            if (moves > needed) {
                moves = needed;
            }
        }

        return moves;
    }
}
