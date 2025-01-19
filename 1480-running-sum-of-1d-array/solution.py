class Solution:
    def runningSum(self, nums: List[int]) -> List[int]:
        sums = []
        for i, num in enumerate(nums):
            sums.append(sum(nums[:i+1]))

        return sums

