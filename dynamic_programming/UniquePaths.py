class Solution:
    def uniquePaths(self, m: int, n: int) -> int:
        list = [1]*n
        for i in range (1, m):
            for j in range (1, n):
                list[j] = list[j-1] + list[j]
        return list[-1]