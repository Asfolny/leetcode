int removeElement(int* nums, int numsSize, int val) {
    for (int i = numsSize-1; i >= 0; i--) {
        int num = nums[i];

        if (num == val) {
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

