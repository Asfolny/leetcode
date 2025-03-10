public class Solution {
    public int ClimbStairs(int n) {
        int a = 0;
        int b = 1;
        for(int i = 0; i < n; i++) {
            int tmp = a + b;
            a = b;
            b = tmp;
        }

        return b;
    }
}

