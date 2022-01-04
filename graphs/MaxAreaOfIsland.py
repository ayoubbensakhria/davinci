class Solution:
    max_count = 0
    current_areas = 0
    
    def maxAreaOfIsland(self, grid: List[List[int]]) -> int:
        for i in range (len(grid)):
            for j in range (len(grid[i])):
                self.sink(grid, i, j)
                self.max_count = max(self.max_count, self.current_areas)
                self.current_areas = 0
        return self.max_count
    
    def sink(self, grid: List[List[int]], i, j):
        if(i<0 or j<0 or i==len(grid) or j==len(grid[i]) or grid[i][j]==0):
            return 
        self.current_areas = (self.current_areas+1) if grid[i][j] == 1 else self.current_areas
        grid[i][j] = 0
        self.sink(grid, i+1, j)
        self.sink(grid, i-1, j)
        self.sink(grid, i, j+1)
        self.sink(grid, i, j-1)
        return