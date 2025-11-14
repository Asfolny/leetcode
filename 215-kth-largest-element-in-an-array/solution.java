class Solution {
    public int findKthLargest(int[] nums, int k) {
        var heap = new PriorityQueue<Integer>(k+1);
        for (int num : nums) {
            heap.offer(num);
            if (heap.size() > k) {
                heap.poll();
            }
        }
        return heap.peek();
    }
}

