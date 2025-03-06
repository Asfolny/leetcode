class Solution:
    def findMissingAndRepeatedValues(self, grid: List[List[int]]) -> List[int]:
        all = set(range(1, len(grid) * len(grid[0])+1))
        uniq = set([col for row in grid for col in row])
        seen = set()
        dupes = [col for row in grid for col in row if col in seen or seen.add(col)]    
        return [dupes[0], list(all - uniq)[0]]

