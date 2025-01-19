/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* getConcatenation(int* nums, int numsSize, int* returnSize) {
    *returnSize = numsSize * 2;
    int *result = malloc(sizeof(int) * (*returnSize));
    
    for (int i = 0; i < numsSize; i++)
        result[i] = result[i + numsSize] = nums[i];

    return result;
}

