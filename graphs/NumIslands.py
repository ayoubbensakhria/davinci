class Solution:
    def numIslands(self, grid: List[List[str]]) -> int:
        count = 0
        for i in range(len(grid)):
            for j in range(len(grid[i])):
                count += self.sink(grid, i, j)
        return count
    
    def sink(self, grid: List[List[str]], i, j):
        if (i<0 or j<0 or i == len(grid) or j==len(grid[i]) or grid[i][j] == '0'):
            return 0
        grid[i][j] = '0'
        self.sink(grid, i+1, j)
        self.sink(grid, i-1, j)
        self.sink(grid, i, j+1)
        self.sink(grid, i, j-1)
        return 1