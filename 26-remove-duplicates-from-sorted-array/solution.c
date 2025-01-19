int removeDuplicates(int* nums, int numsSize) {
    for (int i = numsSize-2; i >= 0; i--) {
        int num = nums[i];
        int prev = nums[i+1];

        if (num == prev) {
            for (int j = i + 1; j < numsSize; j++) {
                int tmp = nums[j];
                nums[j-1] = tmp;
            }
            nums[numsSize-1] = num;
            numsSize--;
        }
    }

    return numsSize;
}

