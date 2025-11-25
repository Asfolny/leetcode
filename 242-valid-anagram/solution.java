class Solution {
    public boolean isAnagram(String s, String t) {
        var bucketS = new HashMap<Character, Integer>();
        s.chars().mapToObj(e->(char)e).forEach((c) -> {
            bucketS.putIfAbsent(c, 0);
            bucketS.put(c, bucketS.getOrDefault(c, 0) + 1);
        });

        var bucketT = new HashMap<Character, Integer>();
        t.chars().mapToObj(e->(char)e).forEach((c) -> {
            bucketT.put(c, bucketT.getOrDefault(c, 0) + 1);
        });

        if (bucketS.size() != bucketT.size()) {
            return false;
        }

        for (var keyS : bucketS.keySet()) {
            if (!bucketT.containsKey(keyS) ||
                !bucketS.get(keyS).equals(bucketT.get(keyS))) {
                return false;
            }
        }

        return true;
    }
}
