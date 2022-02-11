class Solution:
    def uniquePathsWithObstacles(self, obstacleGrid: List[List[int]]) -> int:
        width = len(obstacleGrid[0])
        list = [0] * width
        list[0] = 1
        for row in obstacleGrid:
            for i in range (width):
                if row[i] == 1:
                    list[i] = 0
                elif i>0:
                    list[i] += list[i-1]
        return list[width-1]