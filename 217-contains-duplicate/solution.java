class Solution {
    public boolean containsDuplicate(int[] nums) {
        var set = new HashSet<Integer>();
        for (var num : nums) {
            if (set.contains(num)) {
                return true;
            }

            set.add(num);
        }

        return false;
    }
}
